namespace GrupoE_Tutasa.EmitirFactura
{
    public partial class EmitirFacturaForm : Form
    {
        private EmisionFacturaModelo modelo = new();
        public EmitirFacturaForm()
        {
            InitializeComponent();
        }

        private void EmitirFacturaForm_Load(object sender, EventArgs e)
        {
            /*Todavia el formulario no esta visible. Hay que cargar los datos del modelo
              para que se muestren en el formulario*/
            var clientes = modelo.LClientes;
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
    }
}
