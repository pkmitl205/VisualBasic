Option Explicit On
Option Strict On
Imports System.Runtime.InteropServices

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As String = ""

        Dim sb As SByte = 0
        result = "ค่า Min : " & SByte.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & SByte.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(SByte.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & sb.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "SByte")

        Dim sh As Short = 0
        result = "ค่า Min : " & Short.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & Short.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(Short.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & sh.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Short")

        Dim i As Integer = 0
        result = "ค่า Min : " & Integer.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & Integer.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(Integer.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & i.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Integer")

        Dim l As Long = 0
        result = "ค่า Min : " & Long.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & Long.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(Long.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & l.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Long")

        Dim b As Byte = 0
        result = "ค่า Min : " & Byte.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & Byte.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(Byte.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & b.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Byte")

        Dim us As UShort = 0
        result = "ค่า Min : " & UShort.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & UShort.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(UShort.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & us.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "UShort")

        Dim ui As UInteger = 0
        result = "ค่า Min : " & UInteger.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & UInteger.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(UInteger.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & ui.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "UInteger")

        Dim ul As ULong = 0
        result = "ค่า Min : " & ULong.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & ULong.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(ULong.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & ul.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "ULong")

        Dim sng As Single = 0
        result = "ค่า Min : " & Single.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & Single.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(Single.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & sng.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Single")

        Dim dbl As Double = 0
        result = "ค่า Min : " & Double.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & Double.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(Double.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & dbl.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Double")

        Dim dc As Decimal = Nothing
        result = "ค่า Min : " & Decimal.MinValue.ToString() & Environment.NewLine
        result &= "ค่า Max : " & Decimal.MaxValue.ToString() & Environment.NewLine
        result &= "ขนาด (ไบต์) : " & Marshal.SizeOf(Decimal.MaxValue.[GetType]()) & Environment.NewLine
        result &= "Type : " & dc.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Decimal")

        Dim ch As Char = ControlChars.NullChar
        result = "Type : " & ch.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Char")

        Dim bl As Boolean = False
        result = "Type : " & bl.[GetType]().ToString()
        MessageBox.Show(result.ToString(), "Boolean")
    End Sub
End Class
