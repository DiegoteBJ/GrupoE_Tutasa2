using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Estado_de_Encomienda
{
    public partial class EstadoDeEncomiendaForm : Form
    {
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
            string guia = TextBox_NroGuia.Text.Trim();

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

            if (guia.Length != 9)
            {
                MessageBox.Show("El número de guía debe tener 9 dígitos.");
                return;
            }

            // Simulación (dato ficticio)
            if (guia != "123456789")
            {
                MessageBox.Show("Número de guía no encontrado.");
                return;
            }

            ListView_Resultado.Items.Clear();

            ListViewItem fila1 = new ListViewItem("03/05/2026");
            fila1.SubItems.Add("En tránsito");
            fila1.SubItems.Add("CD Central");

            ListViewItem fila2 = new ListViewItem("04/05/2026");
            fila2.SubItems.Add("Pendiente de entrega");
            fila2.SubItems.Add("Agencia Belgrano");

            ListView_Resultado.Items.Add(fila1);
            ListView_Resultado.Items.Add(fila2);

            MessageBox.Show("Consulta realizada correctamente.");
        }

        private void Button_Borrar_Click(object sender, EventArgs e)
        {
            TextBox_NroGuia.Clear();
            ListView_Resultado.Items.Clear();
        }

        private void Button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}