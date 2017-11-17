Option Explicit On
Option Strict On

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x = "1"
        Dim y = 2
        Dim z = 3.5
        MessageBox.Show("x: " & x.GetType.ToString() & Environment.NewLine &
                        "y: " & y.GetType.ToString() & Environment.NewLine &
                        "z: " & z.GetType.ToString() & Environment.NewLine, "ชนิดข้อมูล")
    End Sub
End Class
