Option Explicit On
Option Strict On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To 2
            Dim strVal As String = "ตัวแปรระดับ Block"
            Label1.Text = strVal
        Next
        'Label1.Text = strVal

    End Sub
End Class
