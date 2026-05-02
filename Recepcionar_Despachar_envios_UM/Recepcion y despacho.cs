using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    public partial class Recepcion_y_despacho : Form
    {
        public Recepcion_y_despacho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonbuscardnifletero_Click(object sender, EventArgs e)
        {

        }

        private void nombretxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recepcion_y_despacho_Load(object sender, EventArgs e)
        {

        }

        private void textBox2DNIFletero(object sender, EventArgs e)
        {
            string dni;
            dni = textBoxDNIFletero.Text;

            MessageBox.Show("El DNI ingresado es: " + dni);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
