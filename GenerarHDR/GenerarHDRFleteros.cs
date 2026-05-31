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
            // Cada vez que cambian los ítems o la selección, refrescar el contador
          
        }



        private void GenerarHDRFleteros_Load(object sender, EventArgs e)
        {
            // Form_Load: estado inicial
            ingresardnitextBox.Enabled = true;
            buscardnifleterobutton.Enabled = true;
            nombrefleterolabel.Text = string.Empty;
            apellidofleterolabel.Text = string.Empty;
            retiroradioButton.Enabled = false;
            distribucionradioButton.Enabled = false;
            buscarcodigopostalbutton.Enabled = false;

            // Predictivo vacío al inicio
            ingresarcodigopostaltextBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
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

            // Limitar a 8 dígitos
            if (digits.Length > 8)
                digits = digits.Substring(0, 8);

            if (ingresardnitextBox.Text != digits)
            {
                ingresardnitextBox.Text = digits;
                ingresardnitextBox.SelectionStart = Math.Min(selStart, digits.Length);
            }
        
        }

        private void buscardnifleterobutton_Click(object sender, EventArgs e)
        {
            string dni = ingresardnitextBox.Text?.Trim() ?? string.Empty;

            if (!AsignarGuiasModelo.ValidarDniString(dni))
            {
                MessageBox.Show("Ingrese un DNI válido (7 u 8 dígitos numéricos).", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetearFormularioFletero();
                ingresardnitextBox.Focus();
                ingresardnitextBox.SelectAll();
                return;
            }

            var modelo = new AsignarGuiasModelo();
            var fletero = modelo.LFleteros.FirstOrDefault(f => f.FleteroDNI == dni);

            if (fletero != null)
            {
                //Muestra nombre y apellido de fletero en labels correspondientes, habilita los radio buttons de retiro y distribución
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
                MessageBox.Show($"No se encontró un fletero con DNI {dni}.",
                                 "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetearFormularioFletero();
            }


        }

        private void ResetearFormularioFletero()
        {
            nombrefleterolabel.Text = string.Empty;
            apellidofleterolabel.Text = string.Empty;
            retiroradioButton.Checked = false;
            retiroradioButton.Enabled = false;
            distribucionradioButton.Checked = false;
            distribucionradioButton.Enabled = false;
            seleccionguiaslistView.Items.Clear();
            detallehdrlistView.Items.Clear();
            buscarcodigopostalbutton.Enabled = false;
            ingresarcodigopostaltextBox.Text = string.Empty;
            this.Tag = null; // borra el contexto del fletero anterior
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
            if (retiroradioButton.Checked)
                CargarGuiasPorEstado("A retirar");
                ActualizarAutoCompleteCP("A retirar");
                buscarcodigopostalbutton.Enabled = true;
                
        }

        private void distribucionradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (distribucionradioButton.Checked)
                CargarGuiasPorEstado("Admitida");
                ActualizarAutoCompleteCP("Admitida");
                buscarcodigopostalbutton.Enabled = true;
        }

        private HashSet<int> guiasAsignadas = new HashSet<int>();

        private void CargarGuiasPorEstado(string estado)
        {
            seleccionguiaslistView.Items.Clear();
            var modelo = new AsignarGuiasModelo();

            var guias = modelo.LGuiasAAsignar.Where(g => g.EstadoGuia == estado && !guiasAsignadas.Contains(g.GuiaId));

            foreach (var g in guias)
            {
                var item = new ListViewItem(g.GuiaId.ToString());
                item.SubItems.Add(g.CodigoPostalGuia);
                item.SubItems.Add(g.DomicilioGuia);
                item.SubItems.Add(g.tamañoGuia);
                item.SubItems.Add(g.EstadoGuia);
                item.Tag = g;
                seleccionguiaslistView.Items.Add(item);
            }

            ActualizarBultosSeleccion();
        }
        private void ActualizarBultosSeleccion()
        {
            bultoslabel.Text = seleccionguiaslistView.Items.Count.ToString();
        }

        private void codigopostallabel_Click(object sender, EventArgs e)
        {

        }

        private void ingresarcodigopostaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarcodigopostalbutton_Click(object sender, EventArgs e)
        {
            string cp = ingresarcodigopostaltextBox.Text.Trim();
            if (!ValidarCodigoPostalArg(cp))
            {
                MessageBox.Show("Código Postal inválido. Use 4 dígitos o CPA (ej: C1424ABC).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingresarcodigopostaltextBox.Clear();   // borra el contenido
                ingresarcodigopostaltextBox.Focus(); // vuelve el foco al TextBox
                return;
            }

            // Filtrar lo que ya está cargado en seleccionguiaslistView
            foreach (ListViewItem item in seleccionguiaslistView.Items)
            {
                var guia = item.Tag as GuiasAAsignar;
                item.BackColor = (guia != null && guia.CodigoPostalGuia == cp) ? Color.LightGreen : Color.LightGray;
                ingresarcodigopostaltextBox.Clear();
                ingresarcodigopostaltextBox.Focus();
            }
        }
        private bool ValidarCodigoPostalArg(string cp)
        {
            if (string.IsNullOrWhiteSpace(cp)) return false;
            cp = cp.Trim().ToUpper();
            var regex = new System.Text.RegularExpressions.Regex(@"^([A-Z]\d{4}[A-Z]{3}|\d{4})$");
            return regex.IsMatch(cp);
        }
        private void ActualizarAutoCompleteCP(string estado)
        {
            var modelo = new AsignarGuiasModelo();
            var codigosPostales = modelo.LGuiasAAsignar
                                        .Where(g => g.EstadoGuia == estado && !guiasAsignadas.Contains(g.GuiaId))
                                        .Select(g => g.CodigoPostalGuia)
                                        .Distinct()
                                        .ToArray();

            var source = new AutoCompleteStringCollection();
            source.AddRange(codigosPostales);

            ingresarcodigopostaltextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ingresarcodigopostaltextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ingresarcodigopostaltextBox.AutoCompleteCustomSource = source;
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
            foreach (ListViewItem item in seleccionguiaslistView.SelectedItems)
            {
                var guia = item.Tag as GuiasAAsignar;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());
                newItem.SubItems.Add(guia.DomicilioGuia);
                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;
                

                detallehdrlistView.Items.Add(newItem);
                seleccionguiaslistView.Items.Remove(item);

                guiasAsignadas.Add(guia.GuiaId);
            }

            // Actualizar ambos contadores
            ActualizarBultosSeleccion();
            ActualizarTotalesDetalle();
        }

        private void agregartodoguiasbutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in seleccionguiaslistView.Items)
            {
                var guia = item.Tag as GuiasAAsignar;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());
                newItem.SubItems.Add(guia.DomicilioGuia);
                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;
                

                detallehdrlistView.Items.Add(newItem);

                guiasAsignadas.Add(guia.GuiaId);
            }

            seleccionguiaslistView.Items.Clear();

            // Actualizar ambos contadores
            ActualizarBultosSeleccion();
            ActualizarTotalesDetalle();
        }
        private void ActualizarTotalesDetalle()
        {
            bultostotalasignadoslabel.Text = detallehdrlistView.Items.Count.ToString();
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
            foreach (ListViewItem item in detallehdrlistView.SelectedItems)
            {
                var guia = item.Tag as GuiasAAsignar;
                if (guia == null) continue;

                // Crear item nuevo para seleccionguiasListView
                var newItem = new ListViewItem(guia.GuiaId.ToString());
                newItem.SubItems.Add(guia.CodigoPostalGuia);
                newItem.SubItems.Add(guia.DomicilioGuia);
                newItem.SubItems.Add(guia.tamañoGuia);
                newItem.SubItems.Add(guia.EstadoGuia);
                newItem.Tag = guia;
                

                // Validar estado y radio button
                if (guia.EstadoGuia == "A retirar" && retiroradioButton.Checked)
                    seleccionguiaslistView.Items.Add(newItem);
                else if (guia.EstadoGuia == "Admitida" && distribucionradioButton.Checked)
                    seleccionguiaslistView.Items.Add(newItem);

                detallehdrlistView.Items.Remove(item);

                guiasAsignadas.Remove(guia.GuiaId);
            }

            ActualizarBultosSeleccion();
            ActualizarTotalesDetalle();
        }

        private void eliminartodoguiasbutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in detallehdrlistView.Items)
            {
                var guia = item.Tag as GuiasAAsignar;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());
                newItem.SubItems.Add(guia.CodigoPostalGuia);
                newItem.SubItems.Add(guia.DomicilioGuia);
                newItem.SubItems.Add(guia.tamañoGuia);
                newItem.SubItems.Add(guia.EstadoGuia);
                newItem.Tag = guia;
               
                if (guia.EstadoGuia == "A retirar" && retiroradioButton.Checked)
                    seleccionguiaslistView.Items.Add(newItem);
                else if (guia.EstadoGuia == "Admitida" && distribucionradioButton.Checked)
                    seleccionguiaslistView.Items.Add(newItem);

                guiasAsignadas.Remove(guia.GuiaId);
            }

            detallehdrlistView.Items.Clear();

            ActualizarBultosSeleccion();
            ActualizarTotalesDetalle();
        }

        private void cancelargenerarhdrbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                     "No se guardará ningún cambio. ¿Está seguro de salir?",
                     "Cancelar HDR",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
                this.Close();
        }

        private void generarhdrbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
