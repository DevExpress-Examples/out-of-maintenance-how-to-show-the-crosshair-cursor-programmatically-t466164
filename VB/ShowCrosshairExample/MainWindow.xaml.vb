Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Charts

Namespace ShowCrosshairExample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#MouseUp"
        Private Sub OnChartControlMouseUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            Dim xyDiagram As XYDiagram2D = TryCast(chartControl.Diagram, XYDiagram2D)
            If xyDiagram Is Nothing Then
                Return
            End If

            xyDiagram.ShowCrosshair(e.GetPosition(chartControl))
        End Sub
        #End Region ' #MouseUp
    End Class
End Namespace
