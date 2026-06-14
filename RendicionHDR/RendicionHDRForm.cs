using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrupoE_Tutasa.RendicionHDR
{
    public partial class RendicionHDRForm : Form
    {
        private RendicionHDRModelo modelo = new();

        public RendicionHDRForm()
        {
            InitializeComponent();
        }

        private void RendicionHDRForm_Load(object sender, EventArgs e)
        {
            RespuestaFleteroLabel.Text = "";
            RespuestaFechaLabel.Text = "";
            RespuestaTipoHDRLabel.Text = "";
            RespuestaTotalGuiasLabel.Text = "";

            RespCantGuiasCumplidasLabel.Text = "0/0";
            RespCantidadGuiasNoCumplidasLabel.Text = "0/0";

            DetalleHDRListView.Items.Clear();

            DetalleHDRListView.View = View.Details;
            DetalleHDRListView.MultiSelect = true;
            DetalleHDRListView.FullRowSelect = true;
        }

        private void BuscarHDRboton_Click(object sender, EventArgs e)
        {
            string nroHDR = HDRtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(nroHDR))
            {
                MessageBox.Show("Debe ingresar un número de Hoja de Ruta.");
                HDRtextBox.Focus();
                return;
            }

            if (!int.TryParse(nroHDR, out _))
            {
                MessageBox.Show("Debe ingresar solo números.");
                HDRtextBox.Clear();
                return;
            }

            if (!HDRRetiroRadioBoton.Checked && !HDRDistribucionRadioBoton.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de HDR.");
                return;
            }

            if (HDRRetiroRadioBoton.Checked)
            {
                var hdr = modelo.LHDRRetiro
                    .FirstOrDefault(h => h.numeroHDR == nroHDR && h.estadoHDR == "PENDIENTE");
                if (hdr != null)
                {
                    CargarHDR(hdr.numeroHDR, hdr.fleteroDNI, hdr.fechaHDR, hdr.GuiaIds, "Retiro");
                    return;
                }
            }

            if (HDRDistribucionRadioBoton.Checked)
            {
                var hdr = modelo.LHDRDistribucion
                    .FirstOrDefault(h => h.numeroHDR == nroHDR && h.estadoHDR == "PENDIENTE");
                if (hdr != null)
                {
                    CargarHDR(hdr.numeroHDR, hdr.fleteroDNI, hdr.fechaHDR, hdr.GuiaIds, "Distribución");
                    return;
                }
            }

            MessageBox.Show("El número de Hoja de Ruta no existe en el tipo seleccionado o ya ha sido rendida.");
            HDRtextBox.Clear();
            HDRRetiroRadioBoton.Checked = false;
            HDRDistribucionRadioBoton.Checked = false;
        }

        private void CargarHDR(string numeroHDR, long fleteroDNI, DateTime fechaHDR, List<int> guiaIds, string tipoHDR)
        {
            var fletero = modelo.LFleteros.FirstOrDefault(f => f.fleteroDNI == fleteroDNI);
            if (fletero == null) return;

            RespuestaFleteroLabel.Text = $"{fletero.fleteroApellido}, {fletero.fleteroNombre}";
            RespuestaFechaLabel.Text = fechaHDR.ToShortDateString();
            RespuestaTipoHDRLabel.Text = tipoHDR;

            DetalleHDRListView.Items.Clear();

            foreach (var guia in modelo.ObtenerGuiasPorIds(guiaIds))
            {
                ListViewItem item = new ListViewItem(guia.guiaId.ToString());
                item.SubItems.Add(guia.remitente);
                item.SubItems.Add(guia.destinatario);
                item.SubItems.Add(guia.domicilio);
                item.SubItems.Add(guia.tamanio);
                item.SubItems.Add(tipoHDR == "Retiro" ? "-" : guia.intentosEntrega.ToString());
                item.SubItems.Add(guia.resultado);
                DetalleHDRListView.Items.Add(item);
            }

            int total = DetalleHDRListView.Items.Count;
            RespuestaTotalGuiasLabel.Text = total.ToString();
            RespCantGuiasCumplidasLabel.Text = $"0/{total}";
            RespCantidadGuiasNoCumplidasLabel.Text = $"0/{total}";
        }

        private void CambiarCumplidasBoton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DetalleHDRListView.SelectedItems)
                item.SubItems[5].Text = "Cumplida";

            ActualizarContadores();
        }

        private void CambiarNoCumplidasBoton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DetalleHDRListView.SelectedItems)
                item.SubItems[5].Text = "No Cumplida";

            ActualizarContadores();
        }

        private void ActualizarContadores()
        {
            int cumplidas = 0;
            int noCumplidas = 0;

            foreach (ListViewItem item in DetalleHDRListView.Items)
            {
                string estado = item.SubItems[5].Text;
                if (estado == "Cumplida") cumplidas++;
                if (estado == "No Cumplida") noCumplidas++;
            }

            int total = DetalleHDRListView.Items.Count;
            RespCantGuiasCumplidasLabel.Text = $"{cumplidas}/{total}";
            RespCantidadGuiasNoCumplidasLabel.Text = $"{noCumplidas}/{total}";
        }

        private void ConfirmarRendicionBoton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DetalleHDRListView.Items)
            {
                if (item.SubItems[5].Text == "Pendiente")
                {
                    MessageBox.Show("Operación incompleta. Debe asignar un resultado a todas las encomiendas de la grilla");
                    return;
                }
            }

            var respuesta = MessageBox.Show(
                "¿Está seguro de confirmar la rendición de la Hoja de Ruta?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No) return;

            var resultados = DetalleHDRListView.Items
                .Cast<ListViewItem>()
                .Select(item => new ResultadoGuia
                {
                    guiaId = int.Parse(item.SubItems[0].Text),
                    resultado = item.SubItems[5].Text
                })
                .ToList();

            if (HDRRetiroRadioBoton.Checked)
                modelo.ConfirmarRendicionRetiro(HDRtextBox.Text.Trim(), resultados);
            else
                modelo.ConfirmarRendicionDistribucion(HDRtextBox.Text.Trim(), resultados);

            MessageBox.Show("Rendición registrada correctamente.");
        }

        private void CancelarRendicionBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
