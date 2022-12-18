Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace DateTimeChartRangeControlClient

    Public Class DateTimeItem

        Public Property Argument As Object

        Public Property Value As Object
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Const dataCount As Integer = 100

        Private data As List(Of DateTimeItem) = New List(Of DateTimeItem)()

        Private Function GenerateDateTimeData() As List(Of DateTimeItem)
            Dim now As Date = Date.Now.Date
            Dim rand As Random = New Random()
            Dim value As Double = 0
            For i As Integer = 0 To dataCount - 1
                now = now.AddDays(1)
                value +=(rand.NextDouble() - 0.5)
                data.Add(New DateTimeItem() With {.Argument = now, .Value = value + Math.Sin(i * 0.6)})
            Next

            Return data
        End Function

        Public Sub New()
            Me.InitializeComponent()
            DataContext = GenerateDateTimeData()
        End Sub
    End Class
End Namespace
