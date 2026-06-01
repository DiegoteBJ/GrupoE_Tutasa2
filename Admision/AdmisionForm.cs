using GrupoE_Tutasa.EmitirFactura;
using GrupoE_Tutasa.EstadoCCClientes;
using System;
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
            /*Todavia el formulario no esta visible. Hay que cargar los datos del modelo
              para que se muestren en el formulario*/
            var guiasAAdmitir = modelo.LGuiasAAdmitir;
            var cajas = modelo.LCajas;

            // Aqui se pueden cargar los datos en los controles del formulario, como ComboBox, DataGridView, etc.
            NumeroGuiaTextBox.Clear();
            FechaGuiaLabel.Text = string.Empty;
            CDOrigenGuiaLabel.Text = string.Empty;
            CDDestinoGuiaLabel.Text = string.Empty;
            EstadoGuiaLabel.Text = string.Empty;
            ObservacionesTextBox.Text = string.Empty;
            TamañoDeclaradoLabel.Text = string.Empty;

            // Cargar los datos de las cajas en el ComboBox
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

            if (string.IsNullOrWhiteSpace(NumeroGuiaTextBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de guía válido.");
                return;
            }
            if (!int.TryParse(NumeroGuiaTextBox.Text, out int numeroGuia))
            {
                MessageBox.Show("El número de guía debe ser un valor numérico.");
                return;
            }

            foreach (var guia in modelo.LGuiasAAdmitir)
            {
                if (guia.numeroGuia == numeroGuia)
                {
                    guiaActual = guia;
                    FechaGuiaLabel.Text = guia.fechaImposicion.ToString("dd/MM/yyyy");
                    CDOrigenGuiaLabel.Text = guia.CDorigen;
                    CDDestinoGuiaLabel.Text = guia.CDdestino;
                    EstadoGuiaLabel.Text = guia.estadoGuia.ToString();
                    ObservacionesTextBox.Text = guia.observaciones;
                    TamañoDeclaradoLabel.Text = guia.tamaño;
                    encuentro = true;

                    // Resetear el radio button y el combo al cargar una nueva guía
                    TamañoCorrectoBoton.Checked = true;
                    TamañoReclasificacionComboBox.SelectedIndex = -1;
                    return;
                }
            }
            MessageBox.Show("No se encontró la guía con el número proporcionado.");
        }

        private void TamañoCorrectoBoton_CheckedChanged(object sender, EventArgs e)
        {
            // Separar claramente ambas condiciones
            bool habilitarReclasificacion = !TamañoCorrectoBoton.Checked && encuentro;
            TamañoReclasificacionComboBox.Enabled = habilitarReclasificacion;
            CambiarTamañoBoton.Enabled = habilitarReclasificacion;
        }

        private void ObservacionesTextBox_TextChanged(object sender, EventArgs e)
        {
            // string observaciones = ObservacionesTextBox.Text;
        }

        private void AdmitirBoton_Click(object sender, EventArgs e)
        {
            if (encuentro == false)
            {
                MessageBox.Show("No se ha encontrado la guía. Por favor, busque una guía válida antes de admitir.");
                return;
            }

            if (!TamañoCorrectoBoton.Checked)
            {
                if (TamañoReclasificacionComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un nuevo tamaño para la guía.");
                    return;
                }

                // Asignar el nuevo tamaño a guiaActual ANTES de calcular el importe
                string nuevoTamañoNombre = ((Cajas)TamañoReclasificacionComboBox.SelectedItem).nombre;
                guiaActual.tamaño = nuevoTamañoNombre;
            }

            decimal importeTransporte = CalculadorLogistica.CalcularTransporte(CDOrigenGuiaLabel.Text, CDDestinoGuiaLabel.Text, guiaActual.tamaño, guiaActual.clienteID);
            decimal importeImposicion = CalculadorLogistica.CalcularImposicion(guiaActual.clienteID, guiaActual.tipoImposicion);
            decimal importeEntrega = CalculadorLogistica.CalcularEntrega(guiaActual.clienteID, guiaActual.tipoEntrega);
            decimal importe = importeTransporte + importeImposicion + importeEntrega;

            guiaActual.importeImposicion = importeImposicion;
            guiaActual.importeEntrega = importeEntrega;
            guiaActual.importeTransporte = importeTransporte;
            guiaActual.fechaAdmision = DateTime.Now;
            guiaActual.estadoGuia = "Admitida";
            guiaActual.importe = importe;

            MessageBox.Show($"Guía admitida. El importe calculado para la guía es: {importe:C}.");
            LimpiaYCierra(sender, e);
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

            // Actualizar el estado de la guía y guardar las observaciones del rechazo
            guiaActual.estadoGuia = "Rechazada";
            guiaActual.observaciones = ObservacionesTextBox.Text;

            MessageBox.Show("La guía ha sido rechazada.");
            LimpiaYCierra(sender, e);
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            guiaActual.tamaño = nuevoTamañoNombre;
            MessageBox.Show($"El tamaño de la guía ha sido cambiado a: {nuevoTamañoNombre}.");
            TamañoCorrectoBoton.Checked = true;
        }

        private void LimpiaYCierra(object sender, EventArgs e)
        {
            // FIX 1: Primero limpiar el estado, luego cerrar
            encuentro = false;
            guiaActual = null;

            // Limpiar campos de texto y etiquetas
            NumeroGuiaTextBox.Clear();
            FechaGuiaLabel.Text = string.Empty;
            CDOrigenGuiaLabel.Text = string.Empty;
            CDDestinoGuiaLabel.Text = string.Empty;
            EstadoGuiaLabel.Text = string.Empty;
            ObservacionesTextBox.Clear();
            TamañoDeclaradoLabel.Text = string.Empty;

            // Resetear controles de tamaño
            TamañoReclasificacionComboBox.SelectedIndex = -1;
            TamañoReclasificacionComboBox.Enabled = false;
            CambiarTamañoBoton.Enabled = false;

            // Resetear el radio button
            TamañoCorrectoBoton.Checked = true;

            // Cerrar al final, una vez que todo está limpio
            this.Close();
        }
    }
}
