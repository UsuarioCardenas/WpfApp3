using System;
using System.Windows;

namespace WpfApp3
{
    public partial class RegistroSalidas : Window
    {
        public RegistroSalidas()
        {
            InitializeComponent();
            // Inicializar fecha actual
            dpFechaHora.SelectedDate = DateTime.Now;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtNombreTransportista.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.",
                    "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Registro guardado exitosamente.", "Éxito",
                MessageBoxButton.OK, MessageBoxImage.Information);

            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}