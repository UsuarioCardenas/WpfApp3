using System.Windows;

namespace WpfApp3
{
    public partial class ListaConductores : Window
    {
        public ListaConductores()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtPesoMaximo.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtPesoVacio.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.",
                    "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string mensaje = this.Title.Contains("Conductores") ?
                "Conductor registrado exitosamente." : "Transportista registrado exitosamente.";

            MessageBox.Show(mensaje, "Éxito",
                MessageBoxButton.OK, MessageBoxImage.Information);

            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}