using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.GenerarHDR
{
    public partial class GenerarHDRFleteros : Form
    {
        
        public GenerarHDRFleteros()
        {
            InitializeComponent();
        }



        private void GenerarHDRFleteros_Load(object sender, EventArgs e)
        {
            // Form_Load: estado inicial
            ingresardnitextBox.Enabled = true;
            buscardnifleterobutton.Enabled = false;
            nombrefleterolabel.Text = string.Empty;
            apellidofleterolabel.Text = string.Empty;
            retiroradioButton.Enabled = false;
            distribucionradioButton.Enabled = false;
        }

        private void usuariolabel_Click(object sender, EventArgs e)
        {

        }

        private void numusuariolabel_Click(object sender, EventArgs e)
        {

        }

        private void cdlabel_Click(object sender, EventArgs e)
        {

        }

        private void centrodistribucionlabel_Click(object sender, EventArgs e)
        {

        }

        private void dnifleterolabel_Click(object sender, EventArgs e)
        {

        }

        private void ingresardnitextBox_TextChanged(object sender, EventArgs e)
        {
            // TextChanged: normaliza y habilita botón sólo si tiene 7 u 8 dígitos
            int selStart = ingresardnitextBox.SelectionStart;
            string raw = ingresardnitextBox.Text ?? string.Empty;
            string digits = new string(raw.Where(char.IsDigit).ToArray());

            if (ingresardnitextBox.Text != digits)
            {
                ingresardnitextBox.Text = digits;
                ingresardnitextBox.SelectionStart = Math.Min(selStart, digits.Length);
            }

            // Habilitar sólo si longitud 7 u 8 y es número no negativo
            buscardnifleterobutton.Enabled = (digits.Length == 7 || digits.Length == 8) && int.TryParse(digits, out int n) && n >= 0;
        
        
        }

        private void buscardnifleterobutton_Click(object sender, EventArgs e)
        {
            string dni = ingresardnitextBox.Text?.Trim() ?? string.Empty;

            if (!AsignarGuiasModelo.ValidarDniString(dni))
            {
                MessageBox.Show("Ingrese un DNI válido (7 u 8 dígitos numéricos).", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var modelo = new AsignarGuiasModelo();
            var fletero = modelo.LFleteros.FirstOrDefault(f => f.FleteroDNI == dni);

            if (fletero != null)
            {
                nombrefleterolabel.Text = fletero.FleteroNombre;
                apellidofleterolabel.Text = fletero.FleteroApellido;
                this.Tag = fletero; // guardar contexto simple
                retiroradioButton.Enabled = true;
                distribucionradioButton.Enabled = true;
            }
            else
            {
                nombrefleterolabel.Text = string.Empty;
                apellidofleterolabel.Text = string.Empty;
                MessageBox.Show($"No se encontró un fletero con DNI {dni}.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

      

        private void ingresardnitextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Atajo Enter
            if (e.KeyCode == Keys.Enter && buscardnifleterobutton.Enabled)
            {
                buscardnifleterobutton.PerformClick();
                e.Handled = true;
            }
        }

        private void nombrelabel_Click(object sender, EventArgs e)
        {

        }

        private void nombrefleterolabel_Click(object sender, EventArgs e)
        {

        }

        private void apellidolabel_Click(object sender, EventArgs e)
        {

        }

        private void apellidofleterolabel_Click(object sender, EventArgs e)
        {

        }

        private void retiroradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void distribucionradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void codigopostallabel_Click(object sender, EventArgs e)
        {

        }

        private void ingresarcodigopostaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarcodigopostalbutton_Click(object sender, EventArgs e)
        {

        }

        private void seleccionguiasgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void seleccionguiaslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cantidaddebultoslabel_Click(object sender, EventArgs e)
        {

        }

        private void bultoslabel_Click(object sender, EventArgs e)
        {

        }

        private void agregarguiasbutton_Click(object sender, EventArgs e)
        {

        }

        private void agregartodoguiasbutton_Click(object sender, EventArgs e)
        {

        }

        private void detallehdrgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void detallehdrlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalbultosasignadoslabel_Click(object sender, EventArgs e)
        {

        }

        private void bultostotalasignadoslabel_Click(object sender, EventArgs e)
        {

        }

        private void eliminarguiasbutton_Click(object sender, EventArgs e)
        {

        }

        private void eliminartodoguiasbutton_Click(object sender, EventArgs e)
        {

        }

        private void cancelargenerarhdrbutton_Click(object sender, EventArgs e)
        {

        }

        private void generarhdrbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
