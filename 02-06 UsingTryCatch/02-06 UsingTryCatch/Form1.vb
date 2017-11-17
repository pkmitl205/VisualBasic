Option Explicit On
Option Strict On

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            Dim x As Integer = 5
            Dim y As Integer = 0
            Dim z As Integer = CInt((x / y))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ข้อผิดพลาด")
        End Try
    End Sub
End Class
