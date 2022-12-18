Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Charts

Namespace ShowCrosshairExample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

#Region "#MouseUp"
        Private Sub OnChartControlMouseUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            Dim xyDiagram As XYDiagram2D = TryCast(Me.chartControl.Diagram, XYDiagram2D)
            If xyDiagram Is Nothing Then Return
            xyDiagram.ShowCrosshair(e.GetPosition(Me.chartControl))
        End Sub
#End Region  ' #MouseUp
    End Class
End Namespace
