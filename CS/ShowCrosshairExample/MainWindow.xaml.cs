using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Charts;

namespace ShowCrosshairExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        #region #MouseUp
        private void OnChartControlMouseUp(object sender, MouseButtonEventArgs e) {
            XYDiagram2D xyDiagram = chartControl.Diagram as XYDiagram2D;
            if (xyDiagram == null) return;

            xyDiagram.ShowCrosshair(e.GetPosition(chartControl));
        }
        #endregion #MouseUp
    }
}
