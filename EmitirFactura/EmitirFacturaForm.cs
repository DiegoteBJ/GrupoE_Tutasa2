namespace GrupoE_Tutasa.EmitirFactura
{
    public partial class EmitirFacturaForm : Form
    {
        private EmisionFacturaModelo modelo = new();
        public EmitirFacturaForm()
        {
            InitializeComponent();
        }
        Clientes clienteActual = null;

        private void EmitirFacturaForm_Load(object sender, EventArgs e)
        {
            CuitClienteBox.Clear();
            DatosCLienteRespuestaLabel.Text = string.Empty;
            TotalAFacturarLabel.Text = $"0";
        }

        private void BuscarClienteBoton_Click(object sender, EventArgs e)
        {
            int encuentro = 0;
            int clienteId = 0;
            decimal totalImporte = 0;
            string tamaño = string.Empty;
            DetalleEnviosListView.Items.Clear();

            if (string.IsNullOrWhiteSpace(CuitClienteBox.Text))
            {
                MessageBox.Show("Debe completar el campo CUIT.");
                return;
            }
            if (!EmisionFacturaModelo.ValidarCuit(CuitClienteBox.Text))
            {
                MessageBox.Show("El CUIT ingresado no es válido.");
                return;
            }

            string cuit = CuitClienteBox.Text.Trim();
            foreach (var cliente in modelo.LClientes)
            {
                if (cliente.clienteCUIT == cuit)
                {
                    clienteActual = cliente;
                    DatosCLienteRespuestaLabel.Text = $"{cliente.clienteName}";
                    clienteId = cliente.clienteId;
                    encuentro = 1;
                }
            }
            if (encuentro == 0)
            {
                DatosCLienteRespuestaLabel.Text = "No existe el Cliente seleccionado. Vuelva a intentarlo";
                return;
            }

            foreach (var guiaAFacturar in modelo.LGuiasPendientes)
            {
                if (guiaAFacturar.clienteID == clienteId && !guiaAFacturar.facturada)
                {
                    ListViewItem item = new ListViewItem(guiaAFacturar.numeroGuia.ToString());
                    foreach (var guia in modelo.LGuias)
                    {
                        if (guia.guiaId == guiaAFacturar.numeroGuia)
                        {
                            tamaño = guia.tipoCaja.ToString();
                            break;
                        }
                    }
                    item.SubItems.Add(guiaAFacturar.fechaEntrega.ToShortDateString());
                    item.SubItems.Add(tamaño);
                    item.SubItems.Add(guiaAFacturar.importe.ToString());
                    totalImporte += guiaAFacturar.importe;
                    DetalleEnviosListView.Items.Add(item);
                }
            }
            TotalAFacturarLabel.Text = $"{totalImporte}";
            if (totalImporte == 0)
                MessageBox.Show("No se encontraron ítems pendientes de facturar para el cliente seleccionado. Reintente.");
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturarOtroBoton_Click(object sender, EventArgs e)
        {
            clienteActual = null;
            DetalleEnviosListView.Items.Clear();
            CuitClienteBox.Clear();
            DatosCLienteRespuestaLabel.Text = string.Empty;
            TotalAFacturarLabel.Text = $"0";
            EmitirFacturaBoton.Enabled = true;
            CancelarBoton.Text = "Cancelar";
        }

        private void EmitirFacturaBoton_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                MessageBox.Show("Debe seleccionar un cliente antes de poder generar la factura.");
                return;
            }
            if (!decimal.TryParse(TotalAFacturarLabel.Text, out decimal netoGravado) || netoGravado == 0)
            {
                MessageBox.Show("No hay importe a facturar. Por favor, seleccione un cliente con guías pendientes.");
                return;
            }

            string numeroDocumento = modelo.EmitirFactura(clienteActual.clienteId, netoGravado);

            decimal iva            = netoGravado * 0.21m;
            decimal documentoTotal = netoGravado + iva;

            MessageBox.Show($"Factura emitida exitosamente. Número de documento: {numeroDocumento}\n" +
                            $"Importe facturado: {documentoTotal}\n" +
                            $"Importe sin IVA: {netoGravado}");
            EmitirFacturaBoton.Enabled = false;
            CancelarBoton.Text = "Cerrar";
        }
    }
}
