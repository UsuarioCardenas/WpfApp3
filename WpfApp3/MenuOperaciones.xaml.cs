using System.Windows;

namespace WpfApp3
{
    public partial class MenuOperaciones : Window
    {
        public MenuOperaciones()
        {
            InitializeComponent();
        }

        private void BtnIngresos_Click(object sender, RoutedEventArgs e)
        {
            RegistroSalidas ventana = new RegistroSalidas();
            ventana.Title = "Registro de Ingresos";
            ventana.ShowDialog();
        }

        private void BtnSalidas_Click(object sender, RoutedEventArgs e)
        {
            RegistroSalidas ventana = new RegistroSalidas();
            ventana.Title = "Registro de Salidas";
            ventana.ShowDialog();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}