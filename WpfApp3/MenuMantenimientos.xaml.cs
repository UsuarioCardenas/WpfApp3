
using System.Windows;

namespace WpfApp3
{
    public partial class MenuMantenimientos : Window
    {
        public MenuMantenimientos()
        {
            InitializeComponent();
        }

        private void BtnConductores_Click(object sender, RoutedEventArgs e)
        {
            ListaConductores ventana = new ListaConductores();
            ventana.Title = "Lista de Conductores";
            ventana.ShowDialog();
        }

        private void BtnTransportistas_Click(object sender, RoutedEventArgs e)
        {
            ListaConductores ventana = new ListaConductores();
            ventana.Title = "Lista de Transportistas";
            ventana.ShowDialog();
        }

        private void BtnCamiones_Click(object sender, RoutedEventArgs e)
        {
            RegistroCamiones ventana = new RegistroCamiones();
            ventana.Title = "Registro de Camiones";
            ventana.ShowDialog();
        }

        private void BtnProductos_Click(object sender, RoutedEventArgs e)
        {
            RegistroCamiones ventana = new RegistroCamiones();
            ventana.Title = "Registro de Productos";
            ventana.ShowDialog();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}