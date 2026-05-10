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
        GuiasAImponer guiaActual = null;

        public AdmisionForm()
        {
            InitializeComponent();
        }
        private void AdmisionForm_Load(object sender, EventArgs e)
        {
            /*Todavia el formulario no esta visible. Hay que cargar los datos del modelo
              para que se muestren en el formulario*/
            var guiasAImponer = modelo.LGuiasAImponer;
            var cajas = modelo.LCajas;
            
            //Aqui se pueden cargar los datos en los controles del formulario, como ComboBox, DataGridView, etc.
            NumeroGuiaTextBox.Clear();
            FechaGuiaLabel.Text = string.Empty;
            CDOrigenGuiaLabel.Text = string.Empty;
            CDDestinoGuiaLabel.Text = string.Empty;
            EstadoGuiaLabel.Text = string.Empty;
            ObservacionesTextBox.Text = string.Empty;
            TamañoDeclaradoLabel.Text = string.Empty;
            //cargar los datos de las cajas en el ComboBox
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
            foreach (var guia in modelo.LGuiasAImponer)
            {
                if (guia.numeroGuia == NumeroGuiaTextBox.Text)
                {
                    guiaActual = guia;
                    FechaGuiaLabel.Text = guia.fechaImposicion.ToString("dd/MM/yyyy");
                    CDOrigenGuiaLabel.Text = guia.CDorigen;
                    CDDestinoGuiaLabel.Text = guia.CDdestino;
                    EstadoGuiaLabel.Text = guia.estadoGuia.ToString();
                    ObservacionesTextBox.Text = guia.observaciones;
                    TamañoDeclaradoLabel.Text = guia.tamaño;
                    encuentro = true;
                    return;
                }
            }
            if (encuentro == false)
            {
                MessageBox.Show("No se encontró la guía con el número proporcionado.");
                return;
            }
        }

        private void TamañoCorrectoBoton_CheckedChanged(object sender, EventArgs e)
        {
            if (TamañoCorrectoBoton.Checked || encuentro == false)
            {
                TamañoReclasificacionComboBox.Enabled = false;
                CambiarTamañoBoton.Enabled = false;
            }
            else
            {
                TamañoReclasificacionComboBox.Enabled = true;
                CambiarTamañoBoton.Enabled = true;
            }
        }
        private void ObservacionesTextBox_TextChanged(object sender, EventArgs e)
        {
            //string observaciones = ObservacionesTextBox.Text;
        }

        private void AdmitirBoton_Click(object sender, EventArgs e)
        {
            if (encuentro == false)
            {
                MessageBox.Show("No se ha encontrado la guía. Por favor, busque una guía válida antes de admitir.");
                return;
            }
            if (TamañoCorrectoBoton.Checked)
            {                                              
                MessageBox.Show("La guía ha sido admitida con el tamaño declarado.");
            }
            else
            {
                if (TamañoReclasificacionComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un nuevo tamaño para la guía.");
                    return;
                }
                var nuevoTamaño = TamañoReclasificacionComboBox.SelectedItem.ToString();
                string nuevoTamañoNombre = ((Cajas)TamañoReclasificacionComboBox.SelectedItem).nombre;
                guiaActual.tamaño = nuevoTamañoNombre ; 
                MessageBox.Show($"La guía ha sido admitida con el nuevo tamaño: {nuevoTamañoNombre}.");
            }
            decimal importe= CalculadorLogistica.ProcesarGuia(CDOrigenGuiaLabel.Text, CDDestinoGuiaLabel.Text, guiaActual.tamaño, guiaActual.clienteID, guiaActual.tipoImposicion, guiaActual.tipoEntrega);
            MessageBox.Show($"El importe calculado para la guía es: {importe:C}.");
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
            {MessageBox.Show("No se ha encontrado la guía. Por favor, busque una guía válida antes de cambiar el tamaño.");
                return;
            }
            var nuevoTamaño = TamañoReclasificacionComboBox.SelectedItem.ToString();
            string nuevoTamañoNombre = ((Cajas)TamañoReclasificacionComboBox.SelectedItem).nombre;
            if(nuevoTamañoNombre == TamañoDeclaradoLabel.Text)
            {
                MessageBox.Show("El nuevo tamaño seleccionado es el mismo que el tamaño declarado. Por favor, seleccione un tamaño diferente.");
                return;
            }
            MessageBox.Show($"El tamaño de la guía ha sido cambiado a: {nuevoTamañoNombre}.");
            TamañoDeclaradoLabel.Text = nuevoTamañoNombre;
        }
        private void LimpiaYCierra(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
            // Crea una nueva instancia y la muestra
            // Resetear estado interno
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

            // Resetear el radio button si corresponde
            TamañoCorrectoBoton.Checked = true;
        }
    }
}
