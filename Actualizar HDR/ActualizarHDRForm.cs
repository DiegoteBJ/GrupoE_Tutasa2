using System;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Actualizar_HDR
{
    public partial class ActualizarHDRForm : Form
    {
        public ActualizarHDRForm()
        {
            InitializeComponent();
            this.Text = "Actualizar HDR";

            ComboBox_NuevoEstado.Items.Clear();
            ComboBox_NuevoEstado.Items.Add("Generada");
            ComboBox_NuevoEstado.Items.Add("En tránsito");
            ComboBox_NuevoEstado.Items.Add("En reparto");
            ComboBox_NuevoEstado.Items.Add("Finalizada");
            ComboBox_NuevoEstado.Items.Add("Cancelada");

            ComboBox_NuevoEstado.SelectedIndex = -1;
            LimpiarFormulario();
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            string idHDR = TextBox_HojaRuta.Text.Trim().ToUpper();

            if (idHDR == "")
            {
                MessageBox.Show("Debe ingresar un identificador de Hoja de Ruta.");
                return;
            }

            if (idHDR != "HDR001")
            {
                MessageBox.Show("No se encontró una Hoja de Ruta con el identificador ingresado.");
                return;
            }

            Label_IDHojaRutaResultado.Text = "HDR001";
            Label_TipoHDRResultado.Text = "Entrega en CD";
            Label_OrigenResultado.Text = "CD Central";
            Label_DestinoResultado.Text = "Agencia Norte";
            Label_EstadoActualResultado.Text = "En tránsito";

            MessageBox.Show("Hoja de Ruta encontrada.");
        }

        private void Button_ConfirmarActualizacion_Click(object sender, EventArgs e)
        {
            if (Label_IDHojaRutaResultado.Text == "-")
            {
                MessageBox.Show("Debe buscar una Hoja de Ruta antes de confirmar.");
                return;
            }

            if (ComboBox_NuevoEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un nuevo estado.");
                return;
            }

            string nuevoEstado = ComboBox_NuevoEstado.SelectedItem.ToString();

            Label_EstadoActualResultado.Text = nuevoEstado;

            MessageBox.Show("Hoja de Ruta " + Label_IDHojaRutaResultado.Text +
                            " actualizada correctamente. Estado actual: " + nuevoEstado);

            LimpiarFormulario();
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            TextBox_HojaRuta.Clear();

            Label_IDHojaRutaResultado.Text = "-";
            Label_TipoHDRResultado.Text = "-";
            Label_OrigenResultado.Text = "-";
            Label_DestinoResultado.Text = "-";
            Label_EstadoActualResultado.Text = "-";

            ComboBox_NuevoEstado.SelectedIndex = -1;
        }
    }
}