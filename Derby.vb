'File:    Derby.vb
'Author:  Andrew Baxter
'Date:    March 7, 2016
'Purpose: Operate a Pinewood Derby tournament, scheduling races and interpreting results from an Arduino unit

Imports System.IO.Ports

Public Class Derby
    Private Const buffsize As UInteger = 8

    Private WithEvents serial As New System.IO.Ports.SerialPort("COM1", 9600)
    Private thread As New System.Threading.Thread(AddressOf KickoffRead)
    Private readbuff(buffsize) As Byte 'Four bytes for car ID, four bytes for time taken

    Private carsFinished As New List(Of CarFinished)
    Private listMutex As Object

    Private Sub HandleData(data As Byte(), size As Integer)
        If (size < 8) Then
            Return
        End If

        SyncLock listMutex
            carsFinished.Add(New CarFinished(data))
        End SyncLock
    End Sub

    Private Sub HandleReadError(ex As Exception)
        MessageBox.Show(ex.ToString())
    End Sub

    Private Sub KickoffRead()
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

    Private Sub Derby_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Move to a "Start Listening" button click from pageRace
        serial.Open()
        KickoffRead()
    End Sub

    Private Sub Derby_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing 'Move to a "Stop Listening" button clink from pageRace
        serial.Close()
    End Sub
End Class


Public Class CarFinished
    Public Sub New(data As Byte())
        id = BitConverter.ToInt32(data, 0)
        time_ms = BitConverter.ToInt32(data, 4)
    End Sub

    Public Property id As UInt32
    Public Property time_ms As UInt32
End Class