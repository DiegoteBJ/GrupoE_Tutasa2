using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace GrupoE_Tutasa.Entrega_en_Agencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            Label_NombreResultado.Text = "María";
            Label_ApellidoResultado.Text = "Gómez";

            ListView_GuiasPendientes.Items.Clear();

            ListView_GuiasPendientes.View = View.Details;

            if (ListView_GuiasPendientes.Columns.Count == 0)
            {
                ListView_GuiasPendientes.Columns.Add("Nro de guía", 120);
                ListView_GuiasPendientes.Columns.Add("Tamaño", 100);
                ListView_GuiasPendientes.Columns.Add("Estado", 150);
            }

            ListViewItem fila1 = new ListViewItem("G001245");
            fila1.SubItems.Add("Mediana");
            fila1.SubItems.Add("Pendiente de entrega");

            ListViewItem fila2 = new ListViewItem("G001246");
            fila2.SubItems.Add("Grande");
            fila2.SubItems.Add("Pendiente de entrega");

            ListView_GuiasPendientes.Items.Add(fila1);
            ListView_GuiasPendientes.Items.Add(fila2);
        }
        private void Button_ConfirmarEntrega_Click(object sender, EventArgs e)
        {
            if (ListView_GuiasPendientes.Items.Count == 0)
            {
                MessageBox.Show("Debe buscar un DNI primero.");
                return;
            }

            MessageBox.Show("Entrega realizada correctamente.");

            TextBox_DniDestinatario.Clear();
            Label_NombreResultado.Text = "";
            Label_ApellidoResultado.Text = "";
            ListView_GuiasPendientes.Items.Clear();
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            TextBox_DniDestinatario.Clear();
            Label_NombreResultado.Text = "";
            Label_ApellidoResultado.Text = "";
            ListView_GuiasPendientes.Items.Clear();
        }
    }
}
