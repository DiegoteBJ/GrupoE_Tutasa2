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
            /*Todavia el formulario no esta visible. Hay que cargar los datos del modelo
              para que se muestren en el formulario*/
            var clientes = modelo.LClientes;
            var documentos = modelo.LDocumentos;
            var guiasPendientes = modelo.LGuiasPendientes;
            //Aqui se pueden cargar los datos en los controles del formulario, como ComboBox, DataGridView, etc.
            CuitClienteBox.Clear();
            DatosCLienteRespuestaLabel.Text = string.Empty;
            TotalAFacturarLabel.Text = $"0";
        }

        private void BuscarClienteBoton_Click(object sender, EventArgs e)
        {
            //1 definir variables
            int encuentro = 0;
            int clienteId = 0;
            decimal totalImporte = 0;
            DetalleEnviosListView.Items.Clear();

            //2 Validar Datos
            if (string.IsNullOrWhiteSpace(CuitClienteBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un CUIT válido.");
                return;
            }
            if (!EmisionFacturaModelo.ValidarCuit(CuitClienteBox.Text))
            {
                MessageBox.Show("El CUIT ingresado no es válido.");
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
                    clienteActual = cliente;
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
            //3 Generar opercion de busqueda
            foreach (var guia in modelo.LGuiasPendientes)
            {
                if (guia.clienteID == clienteId)
                {
                    ListViewItem item = new ListViewItem(guia.numeroGuia.ToString());
                    item.SubItems.Add(guia.fechaAdmision.ToShortDateString());
                    item.SubItems.Add(guia.origen);
                    item.SubItems.Add(guia.destino);
                    item.SubItems.Add(guia.tamaño);
                    item.SubItems.Add(guia.importe.ToString());
                    totalImporte = totalImporte + guia.importe;
                    DetalleEnviosListView.Items.Add(item);
                }
            }
            TotalAFacturarLabel.Text = $"{totalImporte}";
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
            int nuevoDocumentoId = Documentos.ObtenerUltimoId(modelo.LDocumentos) + 1;
            if (clienteActual == null)
                {
                MessageBox.Show("Debe seleccionar un cliente antes de poder generar la factura");
                return;
                }
            if (TotalAFacturarLabel.Text == "0")
                {
                MessageBox.Show("No hay importe a facturar. Por favor, seleccione un cliente con guías pendientes.");
                return;
                }
            int clienteId = clienteActual.clienteId;
            string documentoTipo = "FC";
            DateTime documentoFecha = DateTime.Now;
            string numeroDocumento = $"{nuevoDocumentoId:00000000}";
            decimal netoGravado = TotalAFacturarLabel.Text != string.Empty ? decimal.Parse(TotalAFacturarLabel.Text) : 0;
            decimal iva = netoGravado * 0.21m;
            decimal documentoTotal = netoGravado + iva;
            
            modelo.LDocumentos.Add(new Documentos
            {
                documentoId = nuevoDocumentoId,
                clienteId = clienteId,
                documentoTipo = documentoTipo,
                documentoFecha = documentoFecha,
                documentoNumero = numeroDocumento,
                netoGravado = netoGravado,
                ivaDF = iva,
                documentoTotal = documentoTotal,
            });
            MessageBox.Show($"Factura emitida exitosamente. Número de documento: {numeroDocumento}\n" + $"Importe facturado: {documentoTotal}\n" + $"Importe sin IVA: {netoGravado}");
            EmitirFacturaBoton.Enabled = false;
            CancelarBoton.Text = "Cerrar";
        }
    }
}
