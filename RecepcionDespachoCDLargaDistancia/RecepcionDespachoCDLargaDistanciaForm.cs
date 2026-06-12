using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GrupoE_Tutasa.FormularioPrincipal;

namespace GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia
{
    public partial class RecepcionDespachoCDLargaDistanciaForm : Form
    {
        private RecepcionDespachoCDLargaDistanciaModelo _modelo = new();

        private List<HDRTransporte> hdrARecibir = new List<HDRTransporte>();
        private List<HDRTransporte> hdrADespachar = new List<HDRTransporte>();

        public RecepcionDespachoCDLargaDistanciaForm()
        {
            InitializeComponent();
            //labelRespuestaUsuario.Text = Program.CDTrabajoId.ToString();
            labelResultadoCD.Text = _modelo.GetNombreCDOperario();
        }
           
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string nroServicio = textBoxNrodeservicioTransporte.Text.Trim();

            if (_modelo.EsNroVacio(nroServicio))
            {
                MessageBox.Show("Debe ingresar el Nro. de servicio de transporte.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_modelo.TieneFormatoInvalido(nroServicio))
            {
                MessageBox.Show("El formato ingresado no es válido. Debe ingresar solo caracteres numéricos.",
                                "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_modelo.ExisteServicio(nroServicio))
            {
                MessageBox.Show("No se encontró ningún servicio con el número ingresado. Vuelva a intentarlo.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                return;
            }

            ServicioTransporte servicio = _modelo.BuscarServicio(nroServicio);

            labelResultadoNombreTransporte.Text = servicio.NombreEmpresa;
            labelResultadoFecha.Text = servicio.FechaSalida.ToString("dd/MM/yyyy");

            hdrARecibir = servicio.HDRsARecibir;
            hdrADespachar = servicio.HDRsADespachar;

            CargarListViewRecibir();
            CargarListViewDespachar();
        }

        private void CargarListViewRecibir()
        {
            listViewHDRaRecibir.Items.Clear();

            foreach (HDRTransporte hdr in hdrARecibir)
            {
                ListViewItem item = new ListViewItem(hdr.NroGuia);
                item.SubItems.Add(hdr.Destino);
                item.SubItems.Add(hdr.Tamaño);
                item.Tag = hdr;
                listViewHDRaRecibir.Items.Add(item);
            }
        }

        private void CargarListViewDespachar()
        {
            listViewHDRaDespachar.Items.Clear();

            foreach (HDRTransporte hdr in hdrADespachar)
            {
                ListViewItem item = new ListViewItem(hdr.NroGuia);
                item.SubItems.Add(hdr.Destino);
                item.SubItems.Add(hdr.Tamaño);
                item.Tag = hdr;
                listViewHDRaDespachar.Items.Add(item);
            }
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            if (hdrARecibir.Count == 0 && hdrADespachar.Count == 0)
            {
                MessageBox.Show("No hay hojas de ruta para procesar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _modelo.MarcarComoRecibidas(hdrARecibir);
            _modelo.MarcarComoEnTransito(hdrADespachar);

            MessageBox.Show("Operación confirmada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            textBoxNrodeservicioTransporte.Clear();
            labelResultadoNombreTransporte.Text = string.Empty;
            labelResultadoFecha.Text = string.Empty;
            listViewHDRaRecibir.Items.Clear();
            listViewHDRaDespachar.Items.Clear();
            hdrARecibir.Clear();
            hdrADespachar.Clear();
        }

        private void labelRespuestaUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
