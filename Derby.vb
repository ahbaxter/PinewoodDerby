' File:    Derby.vb
' Author:  Andrew Baxter
' Date:    March 7, 2016
' Purpose: Operate a Pinewood Derby tournament, scheduling races and interpreting results from an Arduino unit

Imports System.IO.Ports
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Derby



    Private Const buffsize As UInteger = 8

    Private WithEvents serial As System.IO.Ports.SerialPort = Nothing ' As New System.IO.Ports.SerialPort("COM1", 9600)
    Private thread As New System.Threading.Thread(AddressOf KickoffRead)
    Private readbuff(buffsize) As Byte ' Four bytes for car ID, four bytes for time taken

    Private carsFinished As New List(Of CarFinishedPacket)
    Private listMutex As Object

    Private Sub HandleData(data As Byte(), size As Integer)
        If (size < buffsize) Then ' Wait for a complete packet. Not sure if the port holds on to the old data though...
            Return
        End If

        SyncLock listMutex
            carsFinished.Add(New CarFinishedPacket(data))
        End SyncLock
    End Sub

    Private Sub HandleReadError(ex As Exception)
        If dudRacesPort.SelectedItem Is serial.PortName And serial.IsOpen Then ' Don't report an error if they're in the middle of switching ports
            MessageBox.Show("Error reading data:" + vbNewLine + ex.ToString())
        Else
            Debug.WriteLine(ex.ToString())
        End If
    End Sub

    Private Sub KickoffRead() ' Begins an asynchronous read operation on the serial port
        serial.BaseStream.BeginRead(readbuff, 0, buffsize,
                                    Sub(ar As IAsyncResult)
                                        Try
                                            Dim actualLength As Integer = serial.BaseStream.EndRead(ar)
                                            Dim received(actualLength) As Byte
                                            Buffer.BlockCopy(readbuff, 0, received, 0, actualLength)
                                            HandleData(received, actualLength)
                                        Catch ex As Exception
                                            HandleReadError(ex)
                                        End Try
                                    End Sub,
                                    Nothing)
    End Sub

    Private Sub Derby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports As New Collection
        dudRacesPort.Items.Add("None")
        dudRacesPort.Items.Add("COM1")
        dudRacesPort.Items.Add("COM2")
        dudRacesPort.Items.Add("COM3")
        dudRacesPort.Items.Add("COM4")

        If Not IO.File.Exists("./data/racers.json") Then
            If Not IO.Directory.Exists("./data") Then
                IO.Directory.CreateDirectory("./data")
            End If
            Dim temp As IO.FileStream = IO.File.Create("./data/racers.json")
            temp.Close()
        End If
        racer_file = New IO.StreamWriter(IO.File.Open("./data/racers.json", IO.FileMode.Open And IO.FileMode.Append))

    End Sub

    Private Sub Derby_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        racer_file.Close()
    End Sub

    Private Sub dudRacesPort_SelectedItemChanged(sender As Object, e As EventArgs) Handles dudRacesPort.SelectedItemChanged

        If Not serial Is Nothing AndAlso serial.IsOpen Then
            serial.Close()
        End If

        If Not (dudRacesPort.SelectedItem Is Nothing OrElse dudRacesPort.SelectedItem Is "None") Then
            Try
                serial = New SerialPort(dudRacesPort.SelectedItem, 9600)
                serial.Open()
                KickoffRead()
            Catch ex As Exception
                MessageBox.Show("Failed to open communications on " + dudRacesPort.SelectedItem)
                Return
            End Try
        End If

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


    Private racer_file As IO.StreamWriter
    Private serializer As New JsonSerializer
    Private Sub btnRegisterAdd_Click(sender As Object, e As EventArgs) Handles btnRegisterAdd.Click
        If Not (String.IsNullOrEmpty(txtRegisterNumber.Text) Or String.IsNullOrEmpty(txtRegisterName.Text)) Then
            Dim entry As New RacerEntry
            entry.id = Integer.Parse(txtRegisterNumber.Text)
            entry.name = txtRegisterName.Text
            serializer.Serialize(racer_file, entry)

            txtReg_lastNum += 1
            txtRegisterNumber.Text = txtReg_lastNum.ToString()
        Else
            MessageBox.Show("Insufficient registration data")
        End If
    End Sub
End Class

Public Class RacerEntry
    Public id As String
    Public name As String
End Class

Public Class CarFinishedPacket
    Public Sub New(data As Byte())
        id = BitConverter.ToInt32(data, 0)
        time_ms = BitConverter.ToInt32(data, 4)
    End Sub

    ' These may need to be Integers instead of Int32s
    Public id As Int32
    Public time_ms As Int32
End Class