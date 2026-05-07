using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    public partial class RecepcionDespachoAgenciaForm : Form
    {
        private bool fleteroValido = false;

        private Dictionary<string, string[]> fleteros = new Dictionary<string, string[]>()
    {
        { "28456789", new string[] { "Carlos", "Gómez" } },
        { "35123456", new string[] { "Laura", "Martínez" } }
    };
        public RecepcionDespachoAgenciaForm()
        {
            InitializeComponent();

            UsuarioRespuestaLabel.Text = "Usuario01";
            AgenciaRespuestaLabel.Text = "Agencia Moron Centro";

            LimpiarFormulario();
        }
        private void BuscarFleteroBoton_Click_1(object sender, EventArgs e)
        {
            string dni = DNIFleteroBox.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Debe ingresar un numero de DNI");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(dni, @"^\d+$"))
            {
                MessageBox.Show("Debe ingresar un numero entero positivo");
                DNIFleteroBox.Clear();
                return;
            }

            if (dni.Length < 7 || dni.Length > 8)
            {
                MessageBox.Show("Debe ingresar un numero que contenga entre 7 y 8 caracteres");
                DNIFleteroBox.Clear();
                return;
            }

            if (!fleteros.ContainsKey(dni))
            {
                MessageBox.Show("No se encontró el fletero. Vuelva a intentarlo.");
                DNIFleteroBox.Clear();
                return;
            }

            NombreFleteroRespuestaLabel.Text = fleteros[dni][0];
            ApellidoRespuestaLabel.Text = fleteros[dni][1];

            CargarGuias(dni);

            if (GuiasRecibirListView.Items.Count == 0 &&
                GuiasEntregarAFleteroListView.Items.Count == 0)
            {
                MessageBox.Show("El fletero seleccionado no tiene guias a recibir ni entregar");
                LimpiarFormulario();
                return;
            }

            fleteroValido = true;
        }

        private void CargarGuias(string dni)
        {
            GuiasRecibirListView.Items.Clear();
            GuiasEntregarAFleteroListView.Items.Clear();

            if (dni == "28456789")
            {
                ListViewItem fila1 = new ListViewItem("G-004821");
                fila1.SubItems.Add("Tipo M");
                GuiasRecibirListView.Items.Add(fila1);

                ListViewItem fila2 = new ListViewItem("G-004839");
                fila2.SubItems.Add("Tipo L");
                GuiasRecibirListView.Items.Add(fila2);

                ListViewItem fila3 = new ListViewItem("G-003711");
                fila3.SubItems.Add("Tipo XL");
                fila3.SubItems.Add("CD Buenos Aires");
                GuiasEntregarAFleteroListView.Items.Add(fila3);
            }
            else if (dni == "35123456")
            {
                ListViewItem fila1 = new ListViewItem("G-005001");
                fila1.SubItems.Add("Tipo S");
                GuiasRecibirListView.Items.Add(fila1);

                ListViewItem fila2 = new ListViewItem("G-004100");
                fila2.SubItems.Add("Tipo M");
                fila2.SubItems.Add("CD Córdoba");
                GuiasEntregarAFleteroListView.Items.Add(fila2);
            }
        }

        private void ConfirmarBoton_Click_1(object sender, EventArgs e)
        {
            if (!fleteroValido)
            {
                MessageBox.Show("Seleccione un transportista para continuar");
                return;
            }

            MessageBox.Show("Operación confirmada. Se actualizaron los estados de las guías.");
            LimpiarFormulario();
        }

        private void CancelarBoton_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            DNIFleteroBox.Clear();
            NombreFleteroRespuestaLabel.Text = "Nombre Fletero";
            ApellidoRespuestaLabel.Text = "Apellido Fletero";
            GuiasRecibirListView.Items.Clear();
            GuiasEntregarAFleteroListView.Items.Clear();
            fleteroValido = false;
        }

    }
}

