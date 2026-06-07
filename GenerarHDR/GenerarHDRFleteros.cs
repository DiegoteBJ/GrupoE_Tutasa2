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
        private AsignarGuiasModelo modelo = new AsignarGuiasModelo();
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
            bultoslabel.Text = "0";
            bultostotalasignadoslabel.Text = "0";
            centrodistribucionlabel.Text = "Buenos Aires";
            generarhdrbutton.Enabled = false;
            generarhdrbutton.Enabled = false;
            agregarguiasbutton.Enabled = false;
            agregartodoguiasbutton.Enabled = false;
            eliminarguiasbutton.Enabled = false;
            eliminartodoguiasbutton.Enabled = false;

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
            int selStart = ingresardnitextBox.SelectionStart;
            string raw = ingresardnitextBox.Text ?? string.Empty;
            string digits = new string(raw.Where(char.IsDigit).ToArray());

            if (digits.Length > 8)
                digits = digits.Substring(0, 8);

            if (ingresardnitextBox.Text != digits)
            {
                ingresardnitextBox.Text = digits;
                ingresardnitextBox.SelectionStart = Math.Min(selStart, digits.Length);
            }

            buscardnifleterobutton.Enabled = true;
        }

        private void buscardnifleterobutton_Click(object sender, EventArgs e)
        {
            string dni = ingresardnitextBox.Text?.Trim() ?? string.Empty;

            if (!AsignarGuiasModelo.ValidarDniString(dni))
            {
                MessageBox.Show("Ingrese un DNI válido (7 u 8 dígitos numéricos).", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetearFormularioFletero();
                return;
            }

            var fletero = modelo.BuscarFleteroPorDni(dni);
            if (fletero != null)
            {
                nombrefleterolabel.Text = fletero.FleteroNombre;
                apellidofleterolabel.Text = fletero.FleteroApellido;
                this.Tag = fletero;
                ingresardnitextBox.Clear();
                retiroradioButton.Enabled = true;
                distribucionradioButton.Enabled = true;
                generarhdrbutton.Enabled = true;
            }
            else
            {
                MessageBox.Show($"No se encontró un fletero con DNI {dni}.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ingresarcodigopostaltextBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            bultoslabel.Text = "0";
            bultostotalasignadoslabel.Text = "0";
            ingresardnitextBox.Clear();
            ingresardnitextBox.Focus();
            generarhdrbutton.Enabled = false;
            agregarguiasbutton.Enabled = false;
            agregartodoguiasbutton.Enabled = false;
            eliminarguiasbutton.Enabled = false;
            eliminartodoguiasbutton.Enabled = false;

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
                generarhdrbutton.Enabled = true;
                agregarguiasbutton.Enabled = true;
                agregartodoguiasbutton.Enabled = true;
                eliminarguiasbutton.Enabled = true;
                eliminartodoguiasbutton.Enabled = true;



        }

        private void distribucionradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (distribucionradioButton.Checked)
                CargarGuiasPorEstado("Distribución"); // parámetro especial
                ActualizarAutoCompleteCP("Distribución");
                buscarcodigopostalbutton.Enabled = true;
                generarhdrbutton.Enabled = true;
                agregarguiasbutton.Enabled = true;
                agregartodoguiasbutton.Enabled = true;
                eliminarguiasbutton.Enabled = true;
                eliminartodoguiasbutton.Enabled = true;
        }

        

        private void CargarGuiasPorEstado(string estado)
        {
            seleccionguiaslistView.Items.Clear();

            var guiasEnDetalle = detallehdrlistView.Items
                .Cast<ListViewItem>()
                .Select(i => (i.Tag as Guias)?.GuiaId)
                .Where(id => id.HasValue)
                .Select(id => id.Value)
                .ToHashSet();

            var fletero = this.Tag as Fleteros;
            if (fletero == null) return;

            var guias = modelo.ObtenerGuiasPorEstado(estado, fletero, guiasEnDetalle);

            foreach (var g in guias)
            {
                var item = new ListViewItem(g.GuiaId.ToString()); // Columna Guía

                if (estado == "A retirar")
                {
                    item.SubItems.Add(g.DomicilioRetiro.CodigoPostal); // Código Postal
                    item.SubItems.Add($"{g.DomicilioRetiro.Calle} {g.DomicilioRetiro.Numero} - Piso: {g.DomicilioRetiro.Piso} - Depto: {g.DomicilioRetiro.Depto}"); // Domicilio
                }
                else // Distribución
                {
                    item.SubItems.Add(g.DomicilioEntrega.CodigoPostal);
                    item.SubItems.Add($"{g.DomicilioEntrega.Calle} {g.DomicilioEntrega.Numero} - Piso: {g.DomicilioEntrega.Piso} - Depto: {g.DomicilioEntrega.Depto}");
                }

                item.SubItems.Add(g.tamañoGuia);                // Tamaño
                item.SubItems.Add(g.EstadoGuia);                // Estado
                item.SubItems.Add(g.IntentosDeEntrega.ToString()); // Intentos
                item.SubItems.Add(g.NombreDestinatarioGuia);    // Destinatario

                item.Tag = g;
                seleccionguiaslistView.Items.Add(item);
            }

            bultoslabel.Text = seleccionguiaslistView.Items.Count.ToString();
        }


        

        private void codigopostallabel_Click(object sender, EventArgs e)
        {

        }

        private void ingresarcodigopostaltextBox_TextChanged(object sender, EventArgs e)
        {
            int selStart = ingresarcodigopostaltextBox.SelectionStart;
            string raw = ingresarcodigopostaltextBox.Text ?? string.Empty;

            // ✅ Filtrar solo letras y dígitos
            string filtered = new string(raw.Where(char.IsLetterOrDigit).ToArray());

            // ✅ Limitar a 5 caracteres
            if (filtered.Length > 5)
                filtered = filtered.Substring(0, 5);

            // ✅ Normalizar a mayúsculas
            filtered = filtered.ToUpper();

            // Reemplazar si hubo cambios
            if (ingresarcodigopostaltextBox.Text != filtered)
            {
                ingresarcodigopostaltextBox.Text = filtered;
                ingresarcodigopostaltextBox.SelectionStart = Math.Min(selStart, filtered.Length);
            }

            // ✅ Reset y reordenar si queda vacío
            if (string.IsNullOrWhiteSpace(filtered))
            {
                var itemsOrdenados = modelo.ResetearYOrdenar(seleccionguiaslistView);

                seleccionguiaslistView.BeginUpdate();
                seleccionguiaslistView.Items.Clear();
                seleccionguiaslistView.Items.AddRange(itemsOrdenados.ToArray());
                seleccionguiaslistView.EndUpdate();
            }
        }
        

        private void buscarcodigopostalbutton_Click(object sender, EventArgs e)
        {
            string cp = ingresarcodigopostaltextBox.Text.Trim().ToUpper();

            // ✅ Si está vacío → error
            if (string.IsNullOrEmpty(cp))
            {
                MessageBox.Show("Debe ingresar un código postal para buscar.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validar formato
            if (!modelo.ValidarCodigoPostalArg(cp))
            {
                MessageBox.Show("Código Postal inválido. Debe ser Letra + 4 dígitos (ej: C1401).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingresarcodigopostaltextBox.Clear();
                ingresarcodigopostaltextBox.Focus();
                return;
            }

            // ✅ Filtrar y reordenar
            var (coincidencias, noCoincidencias) = modelo.FiltrarPorCodigoPostal(
                cp, seleccionguiaslistView, retiroradioButton.Checked);

            if (coincidencias.Count == 0)
            {
                MessageBox.Show($"No se encontraron guías con el código postal {cp}.",
                                "Sin coincidencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            seleccionguiaslistView.BeginUpdate();
            seleccionguiaslistView.Items.Clear();
            seleccionguiaslistView.Items.AddRange(coincidencias.ToArray());
            seleccionguiaslistView.Items.AddRange(noCoincidencias.ToArray());
            seleccionguiaslistView.EndUpdate();

        }
        
        private void ActualizarAutoCompleteCP(string estado)
        {
            var fletero = this.Tag as Fleteros;
            if (fletero == null)
            {
                ingresarcodigopostaltextBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                return;
            }

            string[] codigosPostales;
            if (estado == "A retirar")
            {
                codigosPostales = modelo.LGuiasAAsignar
                    .Where(g => g.EstadoGuia == "A retirar" &&
                                fletero.CPCobertura.Contains(g.DomicilioRetiro.CodigoPostal.ToUpper()))
                    .Select(g => g.DomicilioRetiro.CodigoPostal.ToUpper())
                    .Distinct()
                    .ToArray();
            }
            else
            {
                codigosPostales = modelo.LGuiasAAsignar
                    .Where(g => (g.EstadoGuia == "Admitida" ||
                                 (g.EstadoGuia == "En distribución" && g.IntentosDeEntrega < 2)) &&
                                fletero.CPCobertura.Contains(g.DomicilioEntrega.CodigoPostal.ToUpper()))
                    .Select(g => g.DomicilioEntrega.CodigoPostal.ToUpper())
                    .Distinct()
                    .ToArray();
            }

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
            if (seleccionguiaslistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in seleccionguiaslistView.SelectedItems)
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());

                // ✅ Mostrar domicilio según radio activo
                if (retiroradioButton.Checked || guia.EstadoGuia == "A retirar")
                {
                    newItem.SubItems.Add($"{guia.DomicilioRetiro.Calle} {guia.DomicilioRetiro.Numero} - Piso: {guia.DomicilioRetiro.Piso} - Depto: {guia.DomicilioRetiro.Depto}".Trim());
                }
                else
                {
                    newItem.SubItems.Add($"{guia.DomicilioEntrega.Calle} {guia.DomicilioEntrega.Numero} - Piso: {guia.DomicilioEntrega.Piso} - Depto: {guia.DomicilioEntrega.Depto}".Trim());
                }

                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;

                detallehdrlistView.Items.Add(newItem);
                seleccionguiaslistView.Items.Remove(item);
                modelo.AsignarGuia(guia.GuiaId);
            }

            bultoslabel.Text = seleccionguiaslistView.Items.Count.ToString();
            bultostotalasignadoslabel.Text = detallehdrlistView.Items.Count.ToString();
        }

        private void agregartodoguiasbutton_Click(object sender, EventArgs e)
        {
            if (seleccionguiaslistView.Items.Count == 0)
            {
                MessageBox.Show("No hay guías para asignar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in seleccionguiaslistView.Items.Cast<ListViewItem>().ToList())
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());

                // ✅ Mostrar domicilio según radio activo
                if (retiroradioButton.Checked || guia.EstadoGuia == "A retirar")
                {
                    newItem.SubItems.Add($"{guia.DomicilioRetiro.Calle} {guia.DomicilioRetiro.Numero} - Piso: {guia.DomicilioRetiro.Piso} - Depto: {guia.DomicilioRetiro.Depto}".Trim());
                }
                else
                {
                    newItem.SubItems.Add($"{guia.DomicilioEntrega.Calle} {guia.DomicilioEntrega.Numero} - Piso: {guia.DomicilioEntrega.Piso} - Depto: {guia.DomicilioEntrega.Depto}".Trim());
                }

                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;

                detallehdrlistView.Items.Add(newItem);
                seleccionguiaslistView.Items.Remove(item);
                modelo.AsignarGuia(guia.GuiaId);
            }

            bultoslabel.Text = seleccionguiaslistView.Items.Count.ToString();
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
            if (detallehdrlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in detallehdrlistView.SelectedItems)
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = (ListViewItem)item.Clone();
                seleccionguiaslistView.Items.Add(newItem);
                detallehdrlistView.Items.Remove(item);
                modelo.DesasignarGuia(guia.GuiaId);
            }

            bultoslabel.Text = seleccionguiaslistView.Items.Count.ToString();
            bultostotalasignadoslabel.Text = detallehdrlistView.Items.Count.ToString();

            var itemsOrdenados = seleccionguiaslistView.Items
                .Cast<ListViewItem>()
                    .OrderBy(i =>
                    {
                        int guiaId;
                        return int.TryParse(i.Text, out guiaId) ? guiaId : int.MaxValue;
                    })
                .ToList();

            // Refrescar vista según radio activo
            if (retiroradioButton.Checked)
                CargarGuiasPorEstado("A retirar");
            else if (distribucionradioButton.Checked)
                CargarGuiasPorEstado("Distribución");




        }

        private void eliminartodoguiasbutton_Click(object sender, EventArgs e)
        {
            if (detallehdrlistView.Items.Count == 0)
            {
                MessageBox.Show("No hay guías para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in detallehdrlistView.Items.Cast<ListViewItem>().ToList())
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = (ListViewItem)item.Clone();
                seleccionguiaslistView.Items.Add(newItem);
                detallehdrlistView.Items.Remove(item);
                modelo.DesasignarGuia(guia.GuiaId);
            }

            bultoslabel.Text = seleccionguiaslistView.Items.Count.ToString();
            bultostotalasignadoslabel.Text = detallehdrlistView.Items.Count.ToString();

            var itemsOrdenados = seleccionguiaslistView.Items
                .Cast<ListViewItem>()
                    .OrderBy(i =>
                    {
                        int guiaId;
                        return int.TryParse(i.Text, out guiaId) ? guiaId : int.MaxValue;
                    })
                .ToList();

            // Refrescar vista según radio activo
            if (retiroradioButton.Checked)
                CargarGuiasPorEstado("A retirar");
            else if (distribucionradioButton.Checked)
                CargarGuiasPorEstado("Distribución");


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
            if (detallehdrlistView.Items.Count == 0)
            {
                MessageBox.Show("No hay guías asignadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fletero = this.Tag as Fleteros;
            if (fletero == null)
            {
                MessageBox.Show("Debe seleccionar un fletero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var guiasSeleccionadas = detallehdrlistView.Items
                .Cast<ListViewItem>()
                .Select(i => i.Tag as Guias)
                .Where(g => g != null)
                .ToList();

            var resumenOrdenado = modelo.GenerarHDR(guiasSeleccionadas);
            MostrarResumenPopup(resumenOrdenado, fletero);


        }

        private void MostrarResumenPopup(List<HDRResumen> resumen, Fleteros fletero)
        {
            Form popup = new Form();
            popup.Text = "Resumen HDR";
            popup.Size = new Size(950, 500);
            popup.StartPosition = FormStartPosition.CenterParent;

            var listView = new ListView();
            listView.Dock = DockStyle.Top;
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Height = 380;

            listView.Columns.Add("HDR Id", 80);
            listView.Columns.Add("Tipo HDR", 100);
            listView.Columns.Add("Guías incluidas", 200);
            listView.Columns.Add("Destinatarios", 200);
            listView.Columns.Add("Domicilio", 200);
            listView.Columns.Add("Código Postal", 100);
            listView.Columns.Add("Intentos", 80);
            listView.Columns.Add("Fecha impresión", 120);

            foreach (var r in resumen.OrderBy(x => x.Domicilio))
            {
                var item = new ListViewItem(r.HDRId.ToString());
                item.SubItems.Add(r.TipoHDR);
                item.SubItems.Add(string.Join(", ", r.GuiasIds));
                item.SubItems.Add(r.Destinatario);
                item.SubItems.Add(r.Domicilio);
                item.SubItems.Add(r.CodigoPostal);
                item.SubItems.Add(r.IntentosDeEntrega.ToString());
                item.SubItems.Add(r.FechaImpresion.ToString("dd/MM/yyyy"));
                listView.Items.Add(item);
            }

            var imprimirButton = new Button();
            imprimirButton.Text = "🖨️ Imprimir HDR y Resumen";
            imprimirButton.Dock = DockStyle.Bottom;
            imprimirButton.Height = 45;
            imprimirButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            imprimirButton.BackColor = Color.Green;
            imprimirButton.ForeColor = Color.White;
            imprimirButton.FlatStyle = FlatStyle.Flat;
            imprimirButton.FlatAppearance.BorderSize = 0;

            imprimirButton.Click += (s, e) =>
            {
                modelo.ImprimirResumen(resumen, fletero, listView.Items.Count);
                popup.Close();
                ResetearFormularioFletero();
            };

            popup.Controls.Add(listView);
            popup.Controls.Add(imprimirButton);
            popup.ShowDialog();
        }



    }
}
