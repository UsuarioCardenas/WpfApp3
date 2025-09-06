using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Password.Trim();

            // Validar credenciales (usuario: admin, password: 123)
            if (usuario == "admin" && password == "123")
            {
                // Credenciales correctas - ir al menú
                MenuPrincipal menuWindow = new MenuPrincipal();
                menuWindow.Show();
                this.Close();
            }
            else
            {
                // Credenciales incorrectas - mostrar mensaje de validación
                lblMensaje.Text = "Usuario o contraseña incorrectos. Por favor, verifique sus credenciales.";
                txtPassword.Clear();
            }
        }
    }
}