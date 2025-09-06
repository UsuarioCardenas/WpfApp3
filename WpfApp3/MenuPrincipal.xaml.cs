using System.Windows;

namespace WpfApp3
{
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnOperaciones_Click(object sender, RoutedEventArgs e)
        {
            MenuOperaciones ventana = new MenuOperaciones();
            ventana.ShowDialog();
        }

        private void BtnMantenimientos_Click(object sender, RoutedEventArgs e)
        {
            MenuMantenimientos ventana = new MenuMantenimientos();
            ventana.ShowDialog();
        }

        private void BtnReportes_Click(object sender, RoutedEventArgs e)
        {
            MenuReportes ventana = new MenuReportes();
            ventana.ShowDialog();
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MainWindow loginWindow = new MainWindow();
                loginWindow.Show();
                this.Close();
            }
        }
    }
}