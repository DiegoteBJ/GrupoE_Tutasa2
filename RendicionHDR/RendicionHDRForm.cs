using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            // Validar vacío
            if (string.IsNullOrWhiteSpace(nroHDR))
            {
                MessageBox.Show(
                    "Debe ingresar un número de Hoja de Ruta.");

                HDRtextBox.Focus();
                return;
            }

            // Validar numérico
            if (!int.TryParse(nroHDR, out _))
            {
                MessageBox.Show(
                    "Debe ingresar solo números.");

                HDRtextBox.Clear();
                return;
            }

            // Verificar que haya seleccionado un tipo
            if (!HDRRetiroRadioBoton.Checked &&
                !HDRDistribucionRadioBoton.Checked)
            {
                MessageBox.Show(
                    "Debe seleccionar un tipo de HDR.");

                return;
            }
            if (HDRRetiroRadioBoton.Checked)
            {
                foreach (var hdr in modelo.LHDRRetiro)
                {
                    if (hdr.numeroHDR == nroHDR && hdr.estadoHDR == "PENDIENTE")
                    {
                        CargarHDRRetiro(hdr);
                        return;
                    }
                    {
                        CargarHDRRetiro(hdr);
                        return;
                    }
                }
            }

            if (HDRDistribucionRadioBoton.Checked)
            {
                foreach (var hdr in modelo.LHDRDistribucion)
                {
                    if (hdr.numeroHDR == nroHDR && hdr.estadoHDR == "PENDIENTE")
                    {
                        CargarHDRDistribucion(hdr);
                        return;
                    }
                    {
                        CargarHDRDistribucion(hdr);
                        return;
                    }
                }
            }
            MessageBox.Show("El número de Hoja de Ruta no existe en el tipo de viaje seleccionado o ya ha sido rendida.");

            HDRtextBox.Clear();

            HDRRetiroRadioBoton.Checked = false;
            HDRDistribucionRadioBoton.Checked = false;
        }

        private void CargarHDRRetiro(HDRRetiro hdr)
        {
            var fletero =
                modelo.LFleteros.FirstOrDefault(
                    f => f.Dni == hdr.fleteroDNI);

            if (fletero == null)
                return;

            // Datos del viaje
            RespuestaFleteroLabel.Text =
                fletero.Apellido + ", " +
                fletero.Nombre;

            RespuestaFechaLabel.Text =
                hdr.fechaHDR.ToShortDateString();

            RespuestaTipoHDRLabel.Text = "Retiro";

            // Limpiar detalle anterior
            DetalleHDRListView.Items.Clear();

            int totalGuias = 0;

            // Cargar detalle de guías
            foreach (var guia in modelo.LGuias)
            {
                if (hdr.GuiaIds.Contains(guia.guiaId))
                {
                    ListViewItem item = new ListViewItem(guia.guiaId.ToString());

                    item.SubItems.Add(guia.remitente);
                    item.SubItems.Add(guia.destinatario);
                    item.SubItems.Add(guia.domicilio);
                    item.SubItems.Add(guia.tamanio);
                    item.SubItems.Add("-"); // En Retiro no aplica intento
                    item.SubItems.Add(guia.resultado);

                    DetalleHDRListView.Items.Add(item);

                    totalGuias++;
                }
            }

            // Total de guías
            RespuestaTotalGuiasLabel.Text = totalGuias.ToString();

            // Inicializar contadores
            RespCantGuiasCumplidasLabel.Text = "0/" + totalGuias;

            RespCantidadGuiasNoCumplidasLabel.Text = "0/" + totalGuias;
        }

        private void CargarHDRDistribucion(HDRDistribucion hdr)
        {
            var fletero =
                modelo.LFleteros.FirstOrDefault(
                    f => f.Dni == hdr.fleteroDNI);

            if (fletero == null)
                return;

            // Datos del viaje
            RespuestaFleteroLabel.Text =
                fletero.Apellido + ", " +
                fletero.Nombre;

            RespuestaFechaLabel.Text =
                hdr.fechaHDR.ToShortDateString();

            RespuestaTipoHDRLabel.Text = "Distribución";

            // Limpiar detalle anterior
            DetalleHDRListView.Items.Clear();

            int totalGuias = 0;

            // Cargar detalle de guías
            foreach (var guia in modelo.LGuias)
            {
                if (guia.numeroHDR == hdr.numeroHDR)
                {
                    ListViewItem item = new ListViewItem(guia.guiaId.ToString());

                    item.SubItems.Add(guia.remitente);
                    item.SubItems.Add(guia.destinatario);
                    item.SubItems.Add(guia.domicilio);
                    item.SubItems.Add(guia.tamanio);
                    item.SubItems.Add(guia.intentosEntrega.ToString());
                    item.SubItems.Add(guia.resultado);

                    DetalleHDRListView.Items.Add(item);

                    totalGuias++;
                }
            }

            // Total de guías
            RespuestaTotalGuiasLabel.Text = totalGuias.ToString();

            // Inicializar contadores
            RespCantGuiasCumplidasLabel.Text = "0/" + totalGuias;

            RespCantidadGuiasNoCumplidasLabel.Text = "0/" + totalGuias;
        }

        private void CambiarCumplidasBoton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DetalleHDRListView.SelectedItems)
            {
                item.SubItems[6].Text = "Cumplida";
            }

            ActualizarContadores();
        }

        private void CambiarNoCumplidasBoton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DetalleHDRListView.SelectedItems)
            {
                item.SubItems[6].Text = "No Cumplida";
            }

            ActualizarContadores();
        }

        private void ActualizarContadores()
        {
            int cumplidas = 0;
            int noCumplidas = 0;

            foreach (ListViewItem item in DetalleHDRListView.Items)
            {
                string estado =
                    item.SubItems[6].Text;

                if (estado == "Cumplida")
                    cumplidas++;

                if (estado == "No Cumplida")
                    noCumplidas++;
            }

            int total = DetalleHDRListView.Items.Count;

            RespCantGuiasCumplidasLabel.Text =
                $"{cumplidas}/{total}";

            RespCantidadGuiasNoCumplidasLabel.Text =
                $"{noCumplidas}/{total}";
        }

        private void ConfirmarRendicionBoton_Click(object sender, EventArgs e)
        {
            bool hayPendientes = false;

            foreach (ListViewItem item in DetalleHDRListView.Items)
            {
                if (item.SubItems[6].Text == "Pendiente")
                {
                    hayPendientes = true;
                    break;
                }
            }

            if (hayPendientes)
            {
                MessageBox.Show(
                    "Operación incompleta. Debe asignar un resultado a todas las encomiendas de la grilla");

                return;
            }
            DialogResult respuesta =
            MessageBox.Show("¿Está seguro de confirmar la rendición de la Hoja de Ruta?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            // Procesar rendición
            MessageBox.Show(
                "Rendición registrada correctamente.");
        }
    }
}

