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
            bultoslabel.Text = "0";
            bultostotalasignadoslabel.Text = "0";
            centrodistribucionlabel.Text = "Buenos Aires";
            generarhdrbutton.Enabled = false;

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
            ingresarcodigopostaltextBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            bultoslabel.Text = "0";
            bultostotalasignadoslabel.Text = "0";
            ingresardnitextBox.Clear();
            ingresardnitextBox.Focus();
            generarhdrbutton.Enabled = false;

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


        }

        private void distribucionradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (distribucionradioButton.Checked)
                CargarGuiasPorEstado("Distribución"); // parámetro especial
                ActualizarAutoCompleteCP("Distribución");
                buscarcodigopostalbutton.Enabled = true;
                generarhdrbutton.Enabled = true;
        }

        private HashSet<int> guiasAsignadas = new HashSet<int>();

        private void CargarGuiasPorEstado(string estado)
        {
            seleccionguiaslistView.Items.Clear();

            IEnumerable<Guias> guias;

            if (estado == "A retirar")
            {
                guias = modelo.LGuiasAAsignar
                    .Where(g => 
                        g.EstadoGuia == "A retirar" || 
                        g.EstadoGuia == "Impuesta Telefónicamente" 
                        && !guiasAsignadas.Contains(g.GuiaId)
                        && !modelo.HDRsRetiro.Any(h => h.GuiasIds.Contains(g.GuiaId) && h.Estado == "Pendiente"));
            }
            else if (estado == "Distribución")
            {
                guias = modelo.LGuiasAAsignar
                    .Where(g =>
                        (g.EstadoGuia == "Admitida" ||
                        (g.EstadoGuia == "En distribución" && g.IntentosDeEntrega <= 2))
                        && !guiasAsignadas.Contains(g.GuiaId)
                        && !modelo.HDRsRetiro.Any(h => h.GuiasIds.Contains(g.GuiaId) && h.Estado == "Pendiente"));
            }
            else
            {
                guias = Enumerable.Empty<Guias>();
            }

            foreach (var g in guias)
            {
                var item = new ListViewItem(g.GuiaId.ToString());

                if (estado == "A retirar")
                {
                    item.SubItems.Add(g.DomicilioRetiro.CodigoPostal);
                    item.SubItems.Add($"{g.DomicilioRetiro.Calle} {g.DomicilioRetiro.Numero}");

                }
                else // Distribución
                {
                    item.SubItems.Add(g.DomicilioEntrega.CodigoPostal);
                    item.SubItems.Add($"{g.DomicilioEntrega.Calle} {g.DomicilioEntrega.Numero}");
                }

                item.SubItems.Add(g.tamañoGuia);
                item.SubItems.Add(g.EstadoGuia);

                if (g.EstadoGuia == "En distribución")
                    item.SubItems.Add( g.IntentosDeEntrega.ToString());
                else
                    item.SubItems.Add("0");

                item.SubItems.Add(g.NombreDestinatarioGuia);

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
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                string cpComparar = retiroradioButton.Checked
                    ? guia.DomicilioRetiro.CodigoPostal
                    : guia.DomicilioEntrega.CodigoPostal;

                item.BackColor = (cpComparar == cp) ? Color.LightGreen : Color.LightGray;
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
            string[] codigosPostales;

            if (estado == "A retirar")
            {
                codigosPostales = modelo.LGuiasAAsignar
                    .Where(g => 
                        g.EstadoGuia == "A retirar" ||
                        g.EstadoGuia == "Impuesta Telefónicamente" 
                        && !guiasAsignadas.Contains(g.GuiaId))
                    .Select(g => g.DomicilioRetiro.CodigoPostal)
                    .Distinct()
                    .ToArray();
            }
            else if (estado == "Distribución")
            {
                codigosPostales = modelo.LGuiasAAsignar
                    .Where(g =>
                        (g.EstadoGuia == "Admitida" ||
                         (g.EstadoGuia == "En distribución" && g.IntentosDeEntrega <= 2))
                        && !guiasAsignadas.Contains(g.GuiaId))
                    .Select(g => g.DomicilioEntrega.CodigoPostal)
                    .Distinct()
                    .ToArray();
            }
            else
            {
                codigosPostales = Array.Empty<string>();
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
            foreach (ListViewItem item in seleccionguiaslistView.SelectedItems)
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());

                if (guia.EstadoGuia == "A retirar")
                    newItem.SubItems.Add($"{guia.DomicilioRetiro.Calle} {guia.DomicilioRetiro.Numero}");
                else
                    newItem.SubItems.Add($"{guia.DomicilioEntrega.Calle} {guia.DomicilioEntrega.Numero}");

                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;

                detallehdrlistView.Items.Add(newItem);
                seleccionguiaslistView.Items.Remove(item);

                guiasAsignadas.Add(guia.GuiaId);
            }

            ActualizarBultosSeleccion();
            ActualizarTotalesDetalle();
        }

        private void agregartodoguiasbutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in seleccionguiaslistView.Items)
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());

                if (guia.EstadoGuia == "A retirar")
                    newItem.SubItems.Add($"{guia.DomicilioRetiro.Calle} {guia.DomicilioRetiro.Numero}");
                else
                    newItem.SubItems.Add($"{guia.DomicilioEntrega.Calle} {guia.DomicilioEntrega.Numero}");

                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;

                detallehdrlistView.Items.Add(newItem);

                guiasAsignadas.Add(guia.GuiaId);
            }

            seleccionguiaslistView.Items.Clear();

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
            if (detallehdrlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía para eliminar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in detallehdrlistView.SelectedItems)
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());

                if ((guia.EstadoGuia == "A retirar" || guia.EstadoGuia == "Impuesta Telefónicamente") && retiroradioButton.Checked)
                {
                    newItem.SubItems.Add(guia.DomicilioRetiro.CodigoPostal);
                    newItem.SubItems.Add($"{guia.DomicilioRetiro.Calle} {guia.DomicilioRetiro.Numero}");
                }
                else if ((guia.EstadoGuia == "Admitida" || guia.EstadoGuia == "En distribución") && distribucionradioButton.Checked)
                {
                    newItem.SubItems.Add(guia.DomicilioEntrega.CodigoPostal);
                    newItem.SubItems.Add($"{guia.DomicilioEntrega.Calle} {guia.DomicilioEntrega.Numero}");
                }


                newItem.SubItems.Add(guia.tamañoGuia);
                newItem.SubItems.Add(guia.EstadoGuia);
                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;

                seleccionguiaslistView.Items.Add(newItem);
                detallehdrlistView.Items.Remove(item);
                guiasAsignadas.Remove(guia.GuiaId);
            }

            ActualizarBultosSeleccion();
            ActualizarTotalesDetalle();

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
                CargarGuiasPorEstado("Distribucion");


        }

        private void eliminartodoguiasbutton_Click(object sender, EventArgs e)
        {
            if (bultostotalasignadoslabel.Text == "0")
            {
                MessageBox.Show("Debe haber al menos una guía para eliminar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (ListViewItem item in detallehdrlistView.Items)
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                var newItem = new ListViewItem(guia.GuiaId.ToString());

                if ((guia.EstadoGuia == "A retirar" || guia.EstadoGuia == "Impuesta Telefónicamente") && retiroradioButton.Checked)
                {
                    newItem.SubItems.Add(guia.DomicilioRetiro.CodigoPostal);
                    newItem.SubItems.Add($"{guia.DomicilioRetiro.Calle} {guia.DomicilioRetiro.Numero}");
                }
                else if ((guia.EstadoGuia == "Admitida" || guia.EstadoGuia == "En distribución") && distribucionradioButton.Checked)
                {
                    newItem.SubItems.Add(guia.DomicilioEntrega.CodigoPostal);
                    newItem.SubItems.Add($"{guia.DomicilioEntrega.Calle} {guia.DomicilioEntrega.Numero}");
                }
               

                newItem.SubItems.Add(guia.tamañoGuia);
                newItem.SubItems.Add(guia.EstadoGuia);
                newItem.SubItems.Add(guia.NombreDestinatarioGuia);
                newItem.Tag = guia;

                seleccionguiaslistView.Items.Add(newItem);
                guiasAsignadas.Remove(guia.GuiaId);
            }

            detallehdrlistView.Items.Clear();

            ActualizarBultosSeleccion();
            ActualizarTotalesDetalle();
            
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

        private AsignarGuiasModelo modelo = new AsignarGuiasModelo();
        private int ultimoHDRRetiroId = 0;
        private int ultimoHDRDistribucionId = 0;


        private List<HDRResumen> hdrsProvisorios = new List<HDRResumen>();

        private void generarhdrbutton_Click(object sender, EventArgs e)
        {
            if (detallehdrlistView.Items.Count == 0)
            {
                MessageBox.Show("No hay guías asignadas en el detalle.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ingresardnitextBox.Focus();
                return;
            }

            var fletero = this.Tag as Fleteros;
            if (fletero == null)
            {
                MessageBox.Show("Debe seleccionar un fletero antes de generar HDR.",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hdrsProvisorios.Clear();

            // ✅ Numeración continua según HDRs ya guardados
            int idRetiroTemp = modelo.HDRsRetiro.Any() ? modelo.HDRsRetiro.Max(h => h.HDRRetiroId) + 1 : 1;
            int idDistribTemp = modelo.HDRsDistribucion.Any() ? modelo.HDRsDistribucion.Max(h => h.HDRDistribucionId) + 1 : 1;

            // Agrupar guías por domicilio
            var grupos = detallehdrlistView.Items
                .Cast<ListViewItem>()
                .Select(i => i.Tag as Guias)
                .GroupBy(g => (g.EstadoGuia == "A retirar" || g.EstadoGuia == "Impuesta Telefónicamente")
                    ? $"{g.DomicilioRetiro.Calle}-{g.DomicilioRetiro.Numero}-{g.DomicilioRetiro.CodigoPostal}"
                    : $"{g.DomicilioEntrega.Calle}-{g.DomicilioEntrega.Numero}-{g.DomicilioEntrega.CodigoPostal}");

            foreach (var grupo in grupos)
            {
                var guiasGrupo = grupo.ToList();

                if (guiasGrupo.All(g => g.EstadoGuia == "A retirar" || g.EstadoGuia == "Impuesta Telefónicamente"))
                {
                    hdrsProvisorios.Add(new HDRResumen(idRetiroTemp++, guiasGrupo, "Retiro"));
                }
                else
                {
                    hdrsProvisorios.Add(new HDRResumen(idDistribTemp++, guiasGrupo, "Distribución"));
                }
            }

            var resumenOrdenado = hdrsProvisorios.OrderBy(r => r.Domicilio).ToList();
            MostrarResumenPopup(resumenOrdenado, fletero);


        }

        private void MostrarResumenPopup(List<HDRResumen> resumen, Fleteros fletero)
        {
            Form popup = new Form();
            popup.Text = "Resumen HDR";
            popup.Size = new Size(850, 500);
            popup.StartPosition = FormStartPosition.CenterParent;

            var listView = new ListView();
            listView.Dock = DockStyle.Top;
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Height = 380;

            listView.Columns.Add("HDR Id", 80);
            listView.Columns.Add("Guías incluidas", 200);
            listView.Columns.Add("Tipo HDR", 100);
            listView.Columns.Add("Guías a imprimir", 200);
            listView.Columns.Add("Fecha/Hora impresión", 150);

            foreach (var r in resumen)
            {
                var item = new ListViewItem(r.HDRId.ToString());
                item.SubItems.Add(string.Join(", ", r.GuiasIds));
                item.SubItems.Add(r.TipoHDR);

                // ✅ Mostrar directamente las guías a imprimir desde la propiedad
                item.SubItems.Add(r.GuiasAImprimir.Any() ? string.Join(", ", r.GuiasAImprimir) : "-");

                // ✅ Mostrar la fecha/hora de impresión desde la propiedad
                item.SubItems.Add(r.FechaImpresion.ToString("dd/MM/yyyy HH:mm"));

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
                ImprimirResumen(resumen, fletero);
                popup.Close();
            };

            popup.Controls.Add(listView);
            popup.Controls.Add(imprimirButton);

            popup.ShowDialog();
        }


        private void ImprimirResumen(List<HDRResumen> resumen, Fleteros fletero)
        {
            MessageBox.Show("Se están imprimiendo las HDR y el resumen...",
                    "Impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            // Asegurar numeración continua
            ultimoHDRRetiroId = modelo.HDRsRetiro.Any() ? modelo.HDRsRetiro.Max(h => h.HDRRetiroId) : ultimoHDRRetiroId;
            ultimoHDRDistribucionId = modelo.HDRsDistribucion.Any() ? modelo.HDRsDistribucion.Max(h => h.HDRDistribucionId) : ultimoHDRDistribucionId;

            foreach (var r in resumen)
            {
                var guiasGrupo = modelo.LGuiasAAsignar.Where(g => r.GuiasIds.Contains(g.GuiaId)).ToList();
                if (!guiasGrupo.Any()) continue;

                if (r.TipoHDR == "Retiro")
                {
                    ultimoHDRRetiroId++;
                    var hdr = new HDRRetiro
                    {
                        HDRRetiroId = ultimoHDRRetiroId,
                        fleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Now,
                        Estado = "Pendiente",
                        GuiasIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    };
                    modelo.HDRsRetiro.Add(hdr);
                }
                else if (r.TipoHDR == "Distribución")
                {
                    ultimoHDRDistribucionId++;
                    var hdr = new HDRDistribucion
                    {
                        HDRDistribucionId = ultimoHDRDistribucionId,
                        fleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Now,
                        Estado = "Pendiente",
                        GuiasIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    };
                    modelo.HDRsDistribucion.Add(hdr);

                    foreach (var g in guiasGrupo.Where(g => g.EstadoGuia == "Admitida"))
                        g.EstadoGuia = "En distribución";
                }
            }

            ResetearFormularioFletero();
            ingresardnitextBox.Clear();
            ingresardnitextBox.Focus();
        }
    }
}
