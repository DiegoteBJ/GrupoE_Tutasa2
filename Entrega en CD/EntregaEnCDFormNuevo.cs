using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Entrega_en_CD
{
    public partial class EntregaEnCDFormNuevo : Form
    {
        public EntregaEnCDFormNuevo()
        {
            InitializeComponent();
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

            Label_NombreResultado.Text = "Carlos";
            Label_ApellidoResultado.Text = "Pérez";

            ListView_GuiasPendientes.Items.Clear();
            ListView_GuiasPendientes.View = View.Details;

            if (ListView_GuiasPendientes.Columns.Count == 0)
            {
                ListView_GuiasPendientes.Columns.Add("Nro de guía", 120);
                ListView_GuiasPendientes.Columns.Add("Tamaño", 100);
                ListView_GuiasPendientes.Columns.Add("Estado", 150);
            }

            ListViewItem fila1 = new ListViewItem("CD000321");
            fila1.SubItems.Add("Chica");
            fila1.SubItems.Add("Pendiente de entrega");

            ListViewItem fila2 = new ListViewItem("CD000322");
            fila2.SubItems.Add("Mediana");
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

            MessageBox.Show("Entrega registrada correctamente en CD.");

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
