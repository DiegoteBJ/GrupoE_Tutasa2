using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.GenerarHDRTransporte
{
    public partial class GenerarHDRTransporteForm : Form
    {

        private  GenerarHDRTransporteModelo _modelo = new();

        public GenerarHDRTransporteForm()
        {
            InitializeComponent();
            LimpiarDatos();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string nro = textBoxNrodeServicioTransporte.Text.Trim();

            if (_modelo.EsNroVacio(nro))
            {
                MessageBox.Show("Debe ingresar el Nro. de servicio de transporte.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNrodeServicioTransporte.Focus();
                return;
            }

            if (_modelo.TieneFormatoInvalido(nro))
            {
                MessageBox.Show("El formato ingresado no es válido. Debe ingresar solo caracteres numéricos.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNrodeServicioTransporte.Clear();
                textBoxNrodeServicioTransporte.Focus();
                return;
            }

            if (!_modelo.ExisteServicio(nro))
            {
                MessageBox.Show("No se encontró ningún servicio con el número ingresado. Vuelva a intentarlo.", "Servicio no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNrodeServicioTransporte.Clear();
                textBoxNrodeServicioTransporte.Focus();
                LimpiarDatos();
                return;
            }

            MostrarDatos(_modelo.BuscarServicio(nro));
        }

        private void MostrarDatos(ServicioTransporte s)
        {
            labelResultadoEmpresaTransporte.Text = s.NombreEmpresa;
            labelResultadoFechaHoraSalida.Text = s.FechaHoraSalida.ToString("dd/MM/yyyy - HH:mm tt");   // fecha y hora salida
            labelResultadoRutadelTransporte.Text = s.Ruta;

            listViewEncomiendasPendientes.Items.Clear();
            foreach (var g in s.GuiasPendientes)
            {
                var item = new ListViewItem(g.NroGuia);
                item.SubItems.Add(g.Tamaño);
                item.SubItems.Add(g.Destino);
                listViewEncomiendasPendientes.Items.Add(item);
            }

            listViewEncomiendasAsignadas.Items.Clear();
        }

        private void LimpiarDatos()
        {
            labelResultadoEmpresaTransporte.Text = string.Empty;
            labelResultadoFechaHoraSalida.Text = String.Empty;
            labelResultadoRutadelTransporte.Text = string.Empty;
            listViewEncomiendasPendientes.Items.Clear();
            listViewEncomiendasAsignadas.Items.Clear();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (listViewEncomiendasPendientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una encomienda para agregar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sel = listViewEncomiendasPendientes.SelectedItems[0];
            var item = new ListViewItem(sel.Text);
            foreach (ListViewItem.ListViewSubItem sub in sel.SubItems)
                if (sub != sel.SubItems[0]) item.SubItems.Add(sub.Text);
            listViewEncomiendasAsignadas.Items.Add(item);
            listViewEncomiendasPendientes.Items.Remove(sel);
        }

        private void botonAgregarTodo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewEncomiendasPendientes.Items)
            {
                var nuevo = new ListViewItem(item.Text);
                foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
                    if (sub != item.SubItems[0]) nuevo.SubItems.Add(sub.Text);
                listViewEncomiendasAsignadas.Items.Add(nuevo);
            }
            listViewEncomiendasPendientes.Items.Clear();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewEncomiendasAsignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una encomienda para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sel = listViewEncomiendasAsignadas.SelectedItems[0];
            var item = new ListViewItem(sel.Text);
            foreach (ListViewItem.ListViewSubItem sub in sel.SubItems)
                if (sub != sel.SubItems[0]) item.SubItems.Add(sub.Text);
            listViewEncomiendasPendientes.Items.Add(item);
            listViewEncomiendasAsignadas.Items.Remove(sel);
        }

        private void botonEliminarTodo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewEncomiendasAsignadas.Items)
            {
                var nuevo = new ListViewItem(item.Text);
                foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
                    if (sub != item.SubItems[0]) nuevo.SubItems.Add(sub.Text);
                listViewEncomiendasPendientes.Items.Add(nuevo);
            }
            listViewEncomiendasAsignadas.Items.Clear();
        }

        private void botonGenerarHDR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelResultadoEmpresaTransporte.Text))
            {
                MessageBox.Show("Primero busque un servicio de transporte.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listViewEncomiendasAsignadas.Items.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos una encomienda para generar la Hoja de Ruta.", "Sin encomiendas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Hoja de Ruta de Transporte generada correctamente.", "HDR Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarDatos();
            textBoxNrodeServicioTransporte.Clear();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            textBoxNrodeServicioTransporte.Clear();
        }

        private void textBoxNrodeServicioTransporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                botonBuscar_Click(sender, e);
        }

        private void labelResultadoRutadelTransporte_Click(object sender, EventArgs e)
        {

        }

        private void GenerarHDRTransporteForm_Load(object sender, EventArgs e)
        {
            labelUsuarioResultado.Text = "1";
            labelResultadoCD.Text = _modelo.GetNombreCDOperario();
            labelResultadoFechaEmision.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelResultadoFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
