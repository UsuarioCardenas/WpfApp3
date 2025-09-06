
using System.Windows;

namespace WpfApp3
{
    public partial class MenuReportes : Window
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void BtnReporteCargas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de Reporte de Cargas implementada",
                "Reporte de Cargas", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnReporteIngresos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de Reporte de Ingresos implementada",
                "Reporte de Ingresos", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnReporteSalidas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de Reporte de Salidas implementada",
                "Reporte de Salidas", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}