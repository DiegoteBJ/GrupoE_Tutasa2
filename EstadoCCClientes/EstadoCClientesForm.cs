using GrupoE_Tutasa.EmitirFactura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.EstadoCCClientes
{
    public partial class EstadoCClientesForm : Form
    {
        private EstadoCCClientesModelo modelo = new();
        public EstadoCClientesForm()
        {
            InitializeComponent();
        }

        private void EstadoCClientesForm_Load(object sender, EventArgs e)
        {
            var clientes = modelo.LClientes;
            var documentos = modelo.LDocumentos;
            CuitClienteBox.Clear();
            DatosCLienteRespuestaLabel.Text = string.Empty;
            SaldoInicioLabel.Text = $"0";
            SaldoCierreLabel.Text = $"0";
        }

        private void BuscarClienteBoton_Click(object sender, EventArgs e)
        {
            //1 definir variables
            int encuentro = 0;
            int clienteId = 0;
            DocumentosListView.Items.Clear();

            //2 Validar Datos
            if (string.IsNullOrWhiteSpace(CuitClienteBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un CUIT válido.");
                return;
            }
            if (!long.TryParse(CuitClienteBox.Text, out long cuit))
            {
                MessageBox.Show("El CUIT debe ser un número válido.");
                return;
            }

            foreach (var cliente in modelo.LClientes)
            {
                if (cliente.clienteCUIT == cuit)
                {
                    DatosCLienteRespuestaLabel.Text = $"{cliente.clienteName}";
                    clienteId = cliente.clienteId;
                    encuentro = 1;
                }
            }
            if (encuentro == 0)
            {
                DatosCLienteRespuestaLabel.Text = "Cliente no encontrado.";
                return;
            }
            ClienteIDLabel.Text = clienteId.ToString();
        }

        private void BuscarMovimientosBoton_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = DesdeDateTime.Value.Date;
            DateTime fechaHasta = HastaDateTime.Value.Date;
            DocumentosListView.Items.Clear();
            decimal totalImporte = 0;
            decimal saldoInicio = 0;
            decimal saldoCierre = 0;
            int clienteId = int.Parse(ClienteIDLabel.Text);

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha desde no puede ser mayor que la fecha hasta.");
                return;
            }
            if (clienteId == 0)
            {
                MessageBox.Show("Por favor, busque un cliente antes de buscar movimientos.");
                return;
            }

            // Generar opercion de busqueda
            foreach (var documento in modelo.LDocumentos)
            {
                if (documento.clienteId == clienteId)
                {
                    if (documento.documentoFecha < fechaDesde)
                    {
                        saldoInicio = saldoInicio + documento.documentoTotal;
                        continue; // Saltar documentos fuera del rango de fechas
                    }
                    if (documento.documentoFecha > fechaHasta)
                    {
                        continue; // Saltar documentos fuera del rango de fechas
                    }

                    ListViewItem item = new ListViewItem(documento.documentoFecha.ToString());
                    //item.SubItems.Add(documento.documentoFecha.ToShortDateString());
                    item.SubItems.Add(documento.documentoTipo);
                    item.SubItems.Add(documento.documentoNumero.ToString());

                    if (documento.documentoTipo == "FC" || documento.documentoTipo == "ND")
                    {
                        item.SubItems.Add(documento.documentoTotal.ToString("C"));
                        item.SubItems.Add(string.Empty);
                    }
                    else if (documento.documentoTipo == "RC" || documento.documentoTipo == "NC")
                    {
                        item.SubItems.Add(string.Empty);
                        item.SubItems.Add((documento.documentoTotal * -1).ToString("C"));
                    }

                    DocumentosListView.Items.Add(item);
                    totalImporte = documento.documentoTotal + totalImporte;
                }
            }
            SaldoInicioLabel.Text = saldoInicio.ToString("C");
            SaldoCierreLabel.Text = (saldoInicio + totalImporte).ToString("C");
        }

        private void VerOtroBoton_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
            // Crea una nueva instancia y la muestra
            EstadoCClientesForm nuevoForm = new EstadoCClientesForm();
            nuevoForm.Show();
        }
    }
}
