using GrupoE_Tutasa.EmitirFactura;
using GrupoE_Tutasa.EstadoCCClientes;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Admision
{
    public partial class AdmisionForm : Form
    {
        private AdmisionModelo modelo = new();
        bool encuentro = false;
        GuiasAAdmitir guiaActual = null;

        public AdmisionForm()
        {
            InitializeComponent();
        }

        private void AdmisionForm_Load(object sender, EventArgs e)
        {
            var guiasAAdmitir = modelo.LGuiasAAdmitir;
            var cajas = modelo.LCajas;

            NumeroGuiaTextBox.Clear();
            FechaGuiaLabel.Text = string.Empty;
            CDOrigenGuiaLabel.Text = string.Empty;
            CDDestinoGuiaLabel.Text = string.Empty;
            EstadoGuiaLabel.Text = string.Empty;
            ObservacionesTextBox.Text = string.Empty;
            TamañoDeclaradoLabel.Text = string.Empty;

            TamañoReclasificacionComboBox.Items.Clear();
            TamañoReclasificacionComboBox.DisplayMember = "nombre";
            foreach (var caja in cajas)
            {
                TamañoReclasificacionComboBox.Items.Add(caja);
            }
        }

        private void BuscarGuiaBoton_Click(object sender, EventArgs e)
        {
            encuentro = false;
            int numeroGuia = 0;
            if (string.IsNullOrWhiteSpace(NumeroGuiaTextBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de guía válido.");
                return;
            }
            if (!int.TryParse(NumeroGuiaTextBox.Text, out numeroGuia))
            {
                MessageBox.Show("El número de guía debe ser un valor numérico.");
                return;
            }

            var guias = modelo.LGuiasAAdmitir;
            guiaActual = guias.FirstOrDefault(g => g.numeroGuia == numeroGuia);

            if (guiaActual != null)
            {
                CDOrigenGuiaLabel.Text = guiaActual.CDOrigenId.ToString();
                CDDestinoGuiaLabel.Text = guiaActual.CDDestinoId.ToString();
                EstadoGuiaLabel.Text = guiaActual.estadoGuia.ToString();
                ObservacionesTextBox.Text = guiaActual.observaciones;
                TamañoDeclaradoLabel.Text = guiaActual.tamaño;
                encuentro = true;

                TamañoCorrectoBoton.Checked = true;
                TamañoReclasificacionComboBox.SelectedIndex = -1;
                return;
            }
            MessageBox.Show("No se encontró la guía con el número proporcionado.");
        }

        private void TamañoCorrectoBoton_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitarReclasificacion = !TamañoCorrectoBoton.Checked && encuentro;
            TamañoReclasificacionComboBox.Enabled = habilitarReclasificacion;
            CambiarTamañoBoton.Enabled = habilitarReclasificacion;
        }

        private void ObservacionesTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AdmitirBoton_Click(object sender, EventArgs e)
        {
            decimal importeImposicion = 0;
            decimal importeEntrega = 0;
            decimal importeTransporte = 0;
            decimal importe = 0;
            
            if (guiaActual== null)
            {
                MessageBox.Show("No hay una guía seleccionada para admitir.");
                return;
            }

            string estadoGuia = guiaActual.estadoGuia;

            if (encuentro == false)
            {
                MessageBox.Show("No se ha encontrado la guía. Por favor, busque una guía válida antes de admitir.");
                return;
            }
            if (estadoGuia != "RENDIDA")
            {
                MessageBox.Show("La guía no se encuentra en un estado válido para ser admitida. Por favor, revise el estado de la guía antes de admitir.");
                return;
            }

            if (!TamañoCorrectoBoton.Checked)
            {
                if (TamañoReclasificacionComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un nuevo tamaño para la guía.");
                    return;
                }
                string nuevoTamañoNombre = ((Cajas)TamañoReclasificacionComboBox.SelectedItem).nombre;
                guiaActual.tamaño = nuevoTamañoNombre;
                modelo.CambiarTamañoGuia(guiaActual.numeroGuia, nuevoTamañoNombre);
            }

            importeTransporte = modelo.ObtenerCoeficiente(guiaActual.CDOrigenId, guiaActual.CDDestinoId, guiaActual.tamaño);

            if (guiaActual.tipoImposicion == "D")
                importeImposicion = modelo.ObtenerTarifaRetiroDomicilio(guiaActual.tarifarioId);
            else if (guiaActual.tipoImposicion == "C")
                importeImposicion = 0;

            if (guiaActual.tipoEntrega == "A")
                importeEntrega = modelo.ObtenerTarifaEntregaAgencia(guiaActual.tarifarioId);
            else if (guiaActual.tipoEntrega == "D")
                importeEntrega = modelo.ObtenerTarifaDistribucionDomicilio(guiaActual.tarifarioId);
            else if (guiaActual.tipoEntrega == "C")
                importeEntrega = 0;

            importe = importeTransporte + importeImposicion + importeEntrega;

            // Asignar importes a guiaActual antes de crear el registro en CC
            guiaActual.importeImposicion = importeImposicion;
            guiaActual.importeEntrega = importeEntrega;
            guiaActual.importeTransporte = importeTransporte;
            guiaActual.importe = importe;

            modelo.AdmitirGuia(guiaActual.numeroGuia);
            modelo.CrearCCCliente(guiaActual);

            MessageBox.Show($"Guía admitida. El importe calculado para la guía es: {importe:C}.");
            LimpiaNoCierra(sender, e);
        }

        private void RechazarBoton_Click(object sender, EventArgs e)
        {
            if (encuentro == false)
            {
                MessageBox.Show("No se ha encontrado la guía. Por favor, busque una guía válida antes de rechazar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(ObservacionesTextBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una razón para el rechazo en las observaciones.");
                return;
            }

            modelo.RechazarGuia(guiaActual.numeroGuia, ObservacionesTextBox.Text);

            MessageBox.Show("La guía ha sido rechazada.");
            LimpiaYCierra(sender, e);
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            LimpiaYCierra(sender, e);
        }

        private void CambiarTamañoBoton_Click(object sender, EventArgs e)
        {
            if (TamañoReclasificacionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un nuevo tamaño para la guía.");
                return;
            }
            if (!encuentro)
            {
                MessageBox.Show("No se ha encontrado la guía. Por favor, busque una guía válida antes de cambiar el tamaño.");
                return;
            }

            string nuevoTamañoNombre = ((Cajas)TamañoReclasificacionComboBox.SelectedItem).nombre;

            if (nuevoTamañoNombre == TamañoDeclaradoLabel.Text)
            {
                MessageBox.Show("El nuevo tamaño seleccionado es el mismo que el tamaño declarado. Por favor, seleccione un tamaño diferente.");
                return;
            }

            TamañoDeclaradoLabel.Text = nuevoTamañoNombre;
            modelo.CambiarTamañoGuia(guiaActual.numeroGuia, nuevoTamañoNombre);
            guiaActual.tamaño = nuevoTamañoNombre;
            MessageBox.Show($"El tamaño de la guía ha sido cambiado a: {nuevoTamañoNombre}.");
            TamañoCorrectoBoton.Checked = true;
        }

        private void LimpiaYCierra(object sender, EventArgs e)
        {
            encuentro = false;
            guiaActual = null;

            NumeroGuiaTextBox.Clear();
            FechaGuiaLabel.Text = string.Empty;
            CDOrigenGuiaLabel.Text = string.Empty;
            CDDestinoGuiaLabel.Text = string.Empty;
            EstadoGuiaLabel.Text = string.Empty;
            ObservacionesTextBox.Clear();
            TamañoDeclaradoLabel.Text = string.Empty;

            TamañoReclasificacionComboBox.SelectedIndex = -1;
            TamañoReclasificacionComboBox.Enabled = false;
            CambiarTamañoBoton.Enabled = false;

            TamañoCorrectoBoton.Checked = true;

            this.Close();
        }

        private void LimpiaNoCierra(object sender, EventArgs e)
        {
            encuentro = false;
            guiaActual = null;

            NumeroGuiaTextBox.Clear();
            FechaGuiaLabel.Text = string.Empty;
            CDOrigenGuiaLabel.Text = string.Empty;
            CDDestinoGuiaLabel.Text = string.Empty;
            EstadoGuiaLabel.Text = string.Empty;
            ObservacionesTextBox.Clear();
            TamañoDeclaradoLabel.Text = string.Empty;

            TamañoReclasificacionComboBox.SelectedIndex = -1;
            TamañoReclasificacionComboBox.Enabled = false;
            CambiarTamañoBoton.Enabled = false;

            TamañoCorrectoBoton.Checked = true;
        }
    }
}
