using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.EntregaEnCD
{
    public partial class EntregaEnCDForm : Form
    {
        private EntregaEnCDModelo modelo = new EntregaEnCDModelo();
        public EntregaEnCDForm()
        {
            InitializeComponent();

            ListView_GuiasPendientes.FullRowSelect = true;
            ListView_GuiasPendientes.HideSelection = false;
            ListView_GuiasPendientes.MultiSelect = true;
            ListView_GuiasPendientes.View = View.Details;
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

            List<Guia> guias = modelo.BuscarGuiasPendientesEnCD(dniNumero);

            ListView_GuiasPendientes.Items.Clear();
            ListView_GuiasPendientes.View = View.Details;

            if (guias.Count == 0)
            {
                MessageBox.Show("No hay guías pendientes en CD para este destinatario.");
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

            MessageBox.Show("Entrega registrada correctamente para las guías seleccionadas.");

            TextBox_DniDestinatario.Clear();
            Label_NombreResultado.Text = "";
            Label_ApellidoResultado.Text = "";
            ListView_GuiasPendientes.Items.Clear();

            TextBox_DniDestinatario.Focus();
        }
        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir? No se grabarán los cambios.",
                "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void EntregaEnCDFormNuevo_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_DniDestinatario_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView_GuiasPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
