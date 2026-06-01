using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GrupoE_Tutasa.EntregaEnAgencia
{
    public partial class EntregaEnAgenciaForm : Form
    {
        private EntregaEnAgenciaModelo modelo = new EntregaEnAgenciaModelo();
        public EntregaEnAgenciaForm()
        {
            InitializeComponent();
            ListView_GuiasPendientes.FullRowSelect = true;
            ListView_GuiasPendientes.HideSelection = false;
            ListView_GuiasPendientes.MultiSelect = true;
            ListView_GuiasPendientes.View = View.Details;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            string dni = TextBox_DniDestinatario.Text;

            if (dni == "")
            {
                MessageBox.Show("Debe ingresar un DNI.");
                return;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe contener solo números.");
                return;
            }

            if (dni.Length < 7 || dni.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.");
                return;
            }

            long dniNumero = Convert.ToInt64(dni);

            Guia guiaReferencia = modelo.BuscarGuiaPorDni(dniNumero);

            if (guiaReferencia == null)
            {
                MessageBox.Show("Destinatario no encontrado.");
                return;
            }

            Label_NombreResultado.Text = guiaReferencia.NombreDestinatario;
            Label_ApellidoResultado.Text = guiaReferencia.ApellidoDestinatario;

            List<Guia> guias = modelo.BuscarGuiasPendientesEnAgencia(dniNumero);

            ListView_GuiasPendientes.Items.Clear();

            if (guias.Count == 0)
            {
                MessageBox.Show("No hay guías pendientes en agencia para este destinatario.");
                return;
            }

            foreach (Guia guia in guias)
            {
                ListViewItem fila = new ListViewItem(guia.GuiaId.ToString());

                fila.SubItems.Add(guia.Tamanio);
                fila.SubItems.Add(guia.Estado);

                ListView_GuiasPendientes.Items.Add(fila);
            }
        }
        private void Button_ConfirmarEntrega_Click(object sender, EventArgs e)
        {
            if (ListView_GuiasPendientes.Items.Count == 0)
            {
                MessageBox.Show("Debe buscar un DNI primero.");
                return;
            }

            if (ListView_GuiasPendientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía.");
                return;
            }

            foreach (ListViewItem filaSeleccionada in ListView_GuiasPendientes.SelectedItems)
            {
                int guiaId = Convert.ToInt32(filaSeleccionada.Text);

                modelo.ConfirmarEntrega(guiaId);
            }

            MessageBox.Show("Entrega realizada correctamente.");

            TextBox_DniDestinatario.Clear();
            Label_NombreResultado.Text = "";
            Label_ApellidoResultado.Text = "";
            ListView_GuiasPendientes.Items.Clear();

            TextBox_DniDestinatario.Focus();
        }
        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            TextBox_DniDestinatario.Clear();
            Label_NombreResultado.Text = "";
            Label_ApellidoResultado.Text = "";
            ListView_GuiasPendientes.Items.Clear();

            TextBox_DniDestinatario.Focus();
        }

        private void TextBox_DniDestinatario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
