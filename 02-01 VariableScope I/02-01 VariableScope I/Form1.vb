Option Explicit On
Option Strict On

Public Class Form1
    Dim str As String = "ตัวแปรระดับฟอร์ม"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "ตัวแปรระดับ Local"
        Label1.Text = str
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = str
    End Sub
End Class
