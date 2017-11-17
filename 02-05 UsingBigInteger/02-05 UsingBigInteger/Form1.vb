Option Explicit On
Option Strict On

Imports System.Numerics

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Num1 As BigInteger = CType(Double.MaxValue, BigInteger)
        Dim Num2 As BigInteger = CType(Double.MaxValue, BigInteger)
        Dim Num3 As BigInteger = CType(Double.MaxValue, BigInteger)
        Dim Num4 As BigInteger = CType(Double.MaxValue, BigInteger)
        Dim Num5 As BigInteger = CType(Double.MaxValue, BigInteger)
        Dim b As BigInteger
        b = Num1 * Num2 * Num3 * Num4 * Num5 * Num1 * Num2 * Num3 * Num4 * Num5 * 999999999999999999
        MessageBox.Show(b.ToString(), "ผลการคูณ")
    End Sub
End Class
