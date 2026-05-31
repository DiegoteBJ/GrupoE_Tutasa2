using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace GrupoE_Tutasa.EstadoDeEncomienda
{
    public partial class EstadoDeEncomiendaForm : Form
    {
        private EstadoDeEncomiendaModelo modelo = new EstadoDeEncomiendaModelo();
        public EstadoDeEncomiendaForm()
        {
            InitializeComponent();
            this.Text = "Consultar Estado de Encomienda";

            // Configurar ListView
            ListView_Resultado.View = View.Details;
            ListView_Resultado.Columns.Clear();

            ListView_Resultado.Columns.Add("Fecha", 120);
            ListView_Resultado.Columns.Add("Estado", 150);
            ListView_Resultado.Columns.Add("Ubicación", 180);
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            string guia = TextBox_numerodeguia.Text.Trim();

            if (guia == "")
            {
                MessageBox.Show("Debe ingresar un número de guía.");
                return;
            }

            if (!guia.All(char.IsDigit))
            {
                MessageBox.Show("Debe ingresar solo números.");
                return;
            }

            int guiaId = Convert.ToInt32(guia);

            Guia guiaEncontrada = modelo.BuscarGuia(guiaId);

            if (guiaEncontrada == null)
            {
                MessageBox.Show("Número de guía no encontrado.");
                return;
            }

            ListView_Resultado.Items.Clear();

            foreach (MovimientoEstadoGuia movimiento in guiaEncontrada.MovimientosEstado)
            {
                ListViewItem fila = new ListViewItem(movimiento.Fecha.ToString("dd/MM/yyyy"));
                fila.SubItems.Add(movimiento.Estado);
                fila.SubItems.Add(movimiento.Ubicacion);

                ListView_Resultado.Items.Add(fila);
            }

            MessageBox.Show("Consulta realizada correctamente.");
        }
        private void Button_Borrar_Click(object sender, EventArgs e)
        {
            TextBox_numerodeguia.Clear();
            ListView_Resultado.Items.Clear();
        }

        private void Button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Instruccion_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox_BusquedaGuia_Enter(object sender, EventArgs e)
        {

        }
    }
}