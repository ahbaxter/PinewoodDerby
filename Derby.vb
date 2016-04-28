' File:    Derby.vb
' Author:  Andrew Baxter
' Date:    March 7, 2016
' Purpose: Operate a Pinewood Derby tournament, scheduling races and interpreting results from an Arduino unit

' TODO:
' Add up-next and in-the-hole displays
' Printable schedules
' Results viewer (sort by best time per person)

Imports System.IO.Ports
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Threading

Public Class Derby

    Private racers_list As List(Of RacerEntry)
    Private races_list As List(Of RaceDesc)

#Region "Serial Communication Setup"
    Private Const buffsize As UInteger = 6 ' Three bytes for lane (and newline), three bytes for time taken

    Private readbuff(buffsize) As Byte

    Private Sub EnumPorts() Handles MyBase.Load
        Dim ports As New Collection
        cmbSelectedPort.Items.Add("None")
        cmbSelectedPort.Items.Add("COM1")
        cmbSelectedPort.Items.Add("COM2")
        cmbSelectedPort.Items.Add("COM3")
        cmbSelectedPort.Items.Add("COM4")
        cmbSelectedPort.Items.Add("COM5")
        cmbSelectedPort.Items.Add("COM6")
        cmbSelectedPort.Items.Add("COM7")
        cmbSelectedPort.Items.Add("COM8")
        cmbSelectedPort.Items.Add("COM9")
        cmbSelectedPort.SelectedIndex = 0

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        com = Nothing
    End Sub

    Private Sub SeverConnections() Handles Me.Closing
        If Not com Is Nothing AndAlso com.IsOpen Then
            com.Close()
        End If
        Environment.Exit(0) ' Disregard all other running threads
    End Sub

    Private Sub cmbSelectedPort_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSelectedPort.SelectedValueChanged

        If Not com Is Nothing AndAlso com.IsOpen Then
            com.Close()
        End If

        If Not (cmbSelectedPort.SelectedItem Is Nothing OrElse cmbSelectedPort.SelectedItem Is "None") Then
            Try
                com = New SerialPort(cmbSelectedPort.SelectedItem, 9600)
                com.Open()
                MessageBox.Show("Opened communications on port " & cmbSelectedPort.SelectedItem)
            Catch ex As Exception
                MessageBox.Show("Failed to open communications on port " & cmbSelectedPort.SelectedItem)
                Return
            End Try
        End If

    End Sub

    Private buffer(0) As Char
    Private Sub OnDataReceived() Handles com.DataReceived
        Dim oldlen = buffer.Length
        ReDim Preserve buffer(buffer.Length + com.BytesToRead - 1)
        com.Read(buffer, oldlen, com.BytesToRead)

        Dim lines() As String = New String(buffer).Split(vbCr)

        ' Remove dangling vbLf's and vbNullChar's because VB is a little stupid sometimes
        Dim i As Integer
        For i = 0 To lines.Length - 1
            lines(i) = lines(i).Replace(Chr(0), "").Replace(vbLf, "")
            Debug.WriteLine(lines(i))
        Next

        ' Sends packets to HandleData()
        For i = 0 To lines.Length - 2 Step 2
            Dim packet(1) As String
            packet(0) = lines(i)
            packet(1) = lines(i + 1)
            'Debug.WriteLine(packet(0) & vbCrLf & packet(1))
            HandleData(packet)
        Next
        ' Clear the buffer, moving up any data we haven't used yet
        If i >= lines.Length - 1 Then ' We got all the lines
            ReDim buffer(0)
            buffer(0) = "0"c
        Else ' We missed a line
            ReDim buffer(lines(i).Length - 1)
            buffer = lines(i)
        End If
    End Sub

    Private Sub HandleReadError(ex As Exception)
        SyncLock cmbSelectedPort
            SyncLock com
                If com.IsOpen Then ' Don't report an error if they're in the middle of switching ports
                    MessageBox.Show("Error reading data:" & vbNewLine & ex.ToString())
                    'Else
                    'Debug.WriteLine(ex.ToString())
                End If
            End SyncLock
        End SyncLock


    End Sub


#End Region

#Region "JSON Databases"
    Private serializer As New JsonSerializer

    Private racers_read As JsonReader
    Private racers_write As JsonWriter

    Private races_read As JsonReader
    Private races_write As JsonWriter

    Private Sub LoadRegistrationData() Handles MyBase.Load
        If Not IO.File.Exists("./data/racers.json") Then
            If Not IO.Directory.Exists("./data") Then
                IO.Directory.CreateDirectory("./data")
            End If
            Dim temp As IO.FileStream = IO.File.Create("./data/racers.json")
            temp.Close()
        End If
        racers_read = New JsonTextReader(New IO.StreamReader(IO.File.Open("./data/racers.json", IO.FileMode.Open)))

        Dim names As List(Of String) = serializer.Deserialize(Of List(Of String))(racers_read)
        racers_list = New List(Of RacerEntry)
        If names IsNot Nothing Then
            For i As Integer = 0 To names.Count - 1
                Dim r As New RacerEntry
                r.id = i + 1
                r.name = names(i)
                racers_list.Add(r)
            Next
        End If
        racers_read.Close()

        UpdateRegHistory()

        txtReg_lastNum = racers_list.Count + 1
        txtRegisterNumber.Text = txtReg_lastNum.ToString()
    End Sub

    Private Sub LoadRaceData() Handles MyBase.Load
        If Not IO.File.Exists("./data/races.json") Then
            If Not IO.Directory.Exists("./data") Then
                IO.Directory.CreateDirectory("./data")
            End If
            Dim temp As IO.FileStream = IO.File.Create("./data/races.json")
            temp.Close()
        End If
        races_read = New JsonTextReader(New IO.StreamReader(IO.File.Open("./data/races.json", IO.FileMode.Open)))
        races_list = serializer.Deserialize(Of List(Of RaceDesc))(races_read)
        If (races_list Is Nothing) Then races_list = New List(Of RaceDesc)
        races_read.Close()

        ' Figure out where to start the races from
        Do ' Dummy outer block
            For i As Integer = 0 To races_list.Count - 1
                For j As Integer = 0 To 3
                    If races_list(i).times_ms(j) = -1 Then
                        currentRaceIndex = i
                        Exit Do
                    End If
                Next
            Next
        Loop While False

    End Sub

    Private Sub SaveRegistrationData()
        racers_write = New JsonTextWriter(New IO.StreamWriter(IO.File.Open("./data/racers.json", IO.FileMode.Open)))
        Dim names As New List(Of String)
        For Each r In racers_list
            names.Add(r.name)
        Next
        serializer.Serialize(racers_write, names)
        racers_write.Close()
    End Sub

    Private Sub SaveRaceData()
        races_write = New JsonTextWriter(New IO.StreamWriter(IO.File.Open("./data/races.json", IO.FileMode.Open)))
        serializer.Serialize(races_write, races_list)
        races_write.Close()
    End Sub
#End Region

#Region "Registration"
    Private Sub UpdateRegHistory()
        Dim lines(racers_list.Count + 1) As String
        lines(0) = "ID:" & vbTab & vbTab & vbTab & "Name: "
        lines(1) = "-----------------------------------------------------------------------------------"
        For i As Integer = 0 To racers_list.Count - 1
            lines(i + 2) = racers_list(racers_list.Count - i - 1).id & vbTab & vbTab & vbTab & racers_list(racers_list.Count - i - 1).name
        Next
        txtRegisterHistory.Lines = lines
    End Sub

    Private txtReg_lastNum As Integer
    Private Sub txtRegisterNumber_TextChanged(sender As Object, e As EventArgs) Handles txtRegisterNumber.TextChanged
        Dim test_result As Integer
        If Integer.TryParse(txtRegisterNumber.Text, test_result) Then
            txtReg_lastNum = test_result
        Else
            ' txtRegisterNumber.Text is not an integer, and is invalid
            ' Set it to whatever was in in the last time it passed this test
            txtRegisterNumber.Text = txtReg_lastNum.ToString()
        End If
    End Sub

    Private Sub txtRegister_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRegisterNumber.KeyDown, txtRegisterName.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnRegisterAdd_Click(sender, e)
        End If
    End Sub

    Private Sub btnRegisterAdd_Click(sender As Object, e As EventArgs) Handles btnRegisterAdd.Click
        If Not (String.IsNullOrEmpty(txtRegisterNumber.Text) Or String.IsNullOrEmpty(txtRegisterName.Text)) Then
            Dim entry As New RacerEntry
            entry.id = Integer.Parse(txtRegisterNumber.Text)
            entry.name = txtRegisterName.Text
            racers_list.Add(entry)

            txtReg_lastNum += 1
            txtRegisterNumber.Text = txtReg_lastNum.ToString()
            UpdateRegHistory()
            txtRegisterName.Text = ""
            SaveRegistrationData()
        Else
            MessageBox.Show("Insufficient registration data")
        End If
    End Sub
#End Region

#Region "Race Generation"

    Private Sub ScrambleRaces()
        Dim r As New Random
        For i As Integer = 0 To races_permutations.Count - 1
            Dim target As Integer = r.Next(races_permutations(0).Count)
            Dim swap As RacerEntry
            For j As Integer = 0 To 3
                swap = races_permutations(j)(target)
                races_permutations(j)(target) = races_permutations(j)(i)
                races_permutations(j)(i) = swap
            Next
        Next
    End Sub

    Private Sub UpdateGenListings()
        Dim lines(races_permutations(0).Count) As String

        For i As Integer = 0 To races_permutations(0).Count - 1
            lines(i) = races_permutations(0)(i).name
        Next
        txtGenLane1.Lines = lines

        For i As Integer = 0 To races_permutations(1).Count - 1
            lines(i) = races_permutations(1)(i).name
        Next
        txtGenLane2.Lines = lines

        For i As Integer = 0 To races_permutations(2).Count - 1
            lines(i) = races_permutations(2)(i).name
        Next
        txtGenLane3.Lines = lines

        For i As Integer = 0 To races_permutations(3).Count - 1
            lines(i) = races_permutations(3)(i).name
        Next
        txtGenLane4.Lines = lines
    End Sub

    Private races_permutations(3) As List(Of RacerEntry)
    Private Sub EnumRacesDumb() Handles tabBehavior.SelectedIndexChanged
        If (tabBehavior.SelectedTab Is pageGenerate) Then
            Dim remainder_by_two As Integer = racers_list.Count Mod 2
            Dim races_count As Integer = racers_list.Count + remainder_by_two
            For i As Integer = 0 To 3
                races_permutations(i) = New List(Of RacerEntry)
                For j As Integer = 0 To racers_list.Count - 1
                    races_permutations(i).Add(racers_list(j))
                Next
                For j As Integer = racers_list.Count To races_count - 1
                    Dim dummy As New RacerEntry()
                    dummy.id = 0
                    dummy.name = "Dummy"
                    races_permutations(i).Add(dummy)
                Next
            Next
            UpdateGenListings()
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        prgGenerate.Value = 0
        Dim offset As Integer = 0
        Dim offsets() As Integer = {0, 0}
        Dim r As New Random

        ' Leave lane 1 untouched

        ' Lane 2 is just lane 1 with a looped offset
        races_permutations(1).Clear()
        While (offset = 0)
            offset = r.Next(0, races_permutations(0).Count)
        End While
        For i As Integer = 0 To races_permutations(0).Count - 1
            races_permutations(1).Add(races_permutations(0)((i + offset) Mod (races_permutations(0).Count)))
        Next
        offsets(0) = offset

        ' Another offset for lane 3
        races_permutations(2).Clear()
        While (offset = offsets(0) Or offset = 0)
            offset = r.Next(0, races_permutations(0).Count)
        End While
        For i As Integer = 0 To races_permutations(0).Count - 1
            races_permutations(2).Add(races_permutations(0)((i + offset) Mod (races_permutations(0).Count)))
        Next
        offsets(1) = offset

        ' Another unique offset for lane 4
        races_permutations(3).Clear()
        While (offset = offsets(1) Or offset = offsets(0) Or offset = 0)
            offset = r.Next(0, races_permutations(0).Count)
        End While
        For i As Integer = 0 To races_permutations(0).Count - 1
            races_permutations(3).Add(races_permutations(0)((i + offset) Mod (races_permutations(0).Count)))
        Next

        While prgGenerate.Value < 100
            ScrambleRaces()
            UpdateGenListings()
            txtGenLane1.Refresh()
            txtGenLane2.Refresh()
            txtGenLane3.Refresh()
            txtGenLane4.Refresh()
            prgGenerate.Refresh()
            prgGenerate.Value += 5
            Thread.Sleep(20)
        End While

        races_list.Clear()
        For i As Integer = 0 To races_permutations(0).Count - 1
            Dim race As New RaceDesc
            For j As Integer = 0 To 3
                race.ids(j) = races_permutations(j)(i).id
                race.times_ms(j) = -1
            Next
            races_list.Add(race)
        Next

        SaveRaceData()
        MessageBox.Show("Saved to ./data/races.json")
    End Sub

#End Region

#Region "Race Running"
    Private currentRaceIndex As Integer = 0
    Private carsFinished As Integer = 0
    Private raceMutex As New Object

    Private Sub HandleData(data() As String)
        If data(0)(0) = "0" And data(1)(0) = "0" Then
            ' Signifies the beginning of the race
            btnRacesNext.Text = "Running..."
            btnLoadRace.Text = "Running..."
            btnRacesNext.Enabled = False
            btnLoadRace.Enabled = False
            carsFinished = 0
            prgRace.Style = ProgressBarStyle.Marquee
        Else
            ' A car has finished
            Dim packet As New CarFinishedPacket(data)
            SyncLock raceMutex
                races_list(currentRaceIndex).times_ms(packet.lane - 1) = packet.time_ms
                'Debug.WriteLine("Lane " & packet.lane & " finished with a time of " & packet.time_ms & "ms")
                carsFinished += 1
                If (carsFinished = 4) Then
                    btnLoadRace.Text = "Load Race"
                    btnLoadRace.Enabled = True
                    prgRace.Style = ProgressBarStyle.Blocks
                    prgRace.Value = 100
                    SaveRaceData()
                    UpdateRaceListings()
                End If
            End SyncLock
        End If
    End Sub

    Private Sub btnRacesNext_Click(sender As Object, e As EventArgs) Handles btnRacesNext.Click
        prgRace.Value = 0
        currentRaceIndex += 1
        UpdateRaceListings() ' Disables the button if it's too close to 
    End Sub

    Private Sub btnLoadRace_Click(sender As Object, e As EventArgs) Handles btnLoadRace.Click
        Dim strRace As String = Nothing
        Dim intRace As Integer = Nothing
        Do
            strRace = InputBox("Enter race number to run:", "Load Race", (currentRaceIndex + 1).ToString())
        Loop Until strRace Is Nothing Or Integer.TryParse(strRace, intRace)

        If strRace IsNot Nothing Then 'User did not cancel
            'Check if the race id exists
            If intRace <= races_list.Count AndAlso intRace > 0 Then
                'Check if the race has already been run
                For i As Integer = 0 To 3
                    If Not races_list(intRace - 1).times_ms(i) = -1 Then
                        If MessageBox.Show("This race has already been run." & vbNewLine & "Do you want to run it again?", "Confirm Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                            Exit For
                        End If
                    End If
                    Exit For
                Next
                currentRaceIndex = intRace - 1
                UpdateRaceListings()
            Else
                MessageBox.Show("Invalid race ID")
            End If

        End If
    End Sub

    Private Sub UpdateRaceListings() Handles tabBehavior.SelectedIndexChanged
        If (tabBehavior.SelectedTab Is pageRace) Then
            'Update labels
            grpRacesNow.Text = "Current Race: " & currentRaceIndex + 1
            If currentRaceIndex < races_list.Count - 1 Then
                grpRacesUpNext.Text = "Up Next: " & (currentRaceIndex + 2)
            Else
                grpRacesUpNext.Text = "Out of Races"
            End If
            If currentRaceIndex < races_list.Count - 2 Then
                grpRacesHole.Text = "In the Hole: " & (currentRaceIndex + 3)
            Else
                grpRacesHole.Text = "Out of Races"
            End If

            'Update buttons
            If currentRaceIndex < races_list.Count - 1 Then
                btnRacesNext.Text = "Next Race"
                btnRacesNext.Enabled = True
            Else
                btnRacesNext.Text = "Out of Races"
                btnRacesNext.Enabled = False
            End If

            'Update the "current race" grid
            If gridRacesCurrent.Rows.Count < 4 Then gridRacesCurrent.Rows.Add(4 - gridRacesCurrent.Rows.Count)
            For lane As Integer = 0 To 3
                'Show lane
                gridRacesCurrent.Rows(lane).Cells(0).Value = (lane + 1).ToString()

                'Show name
                If races_list(currentRaceIndex).ids(lane) > 0 Then
                    gridRacesCurrent.Rows(lane).Cells(1).Value = racers_list(races_list(currentRaceIndex).ids(lane) - 1).name
                Else
                    gridRacesCurrent.Rows(lane).Cells(1).Value = "Dummy"
                End If

                'Show time to finish
                If Not races_list(currentRaceIndex).times_ms(lane) = -1 Then
                    gridRacesCurrent.Rows(lane).Cells(2).Value = races_list(currentRaceIndex).times_ms(lane).ToString()
                Else
                    gridRacesCurrent.Rows(lane).Cells(2).Value = ""
                End If
            Next

        End If
    End Sub
#End Region

#Region "Results Display"

#End Region

End Class

Public Class RacerEntry
    Public id As Int32
    Public name As String
End Class

Public Class RaceDesc
    Public ids(3) As Int32
    Public times_ms(3) As Int32
End Class

Public Class CarFinishedPacket
    Public Sub New(data() As String)
        If data.Length = 2 Then
            lane = Integer.Parse(data(0))
            time_ms = Integer.Parse(data(1))
        Else
            Throw New ArgumentException("CarFinishedPacket::data must be 1D array of 2 elements")
        End If
    End Sub

    ' These may need to be Integers instead of Int32s
    Public lane As Int32
    Public time_ms As Int32
End Class