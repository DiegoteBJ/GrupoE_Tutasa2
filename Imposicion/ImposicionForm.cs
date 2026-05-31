namespace GrupoE_Tutasa.Imposicion
{
    public partial class ImposicionForm : Form
    {
        private ImposicionModelo modelo = new();

        public ImposicionForm()
        {
            InitializeComponent();
            button2.Click += button2_Click;  // Cancelar
        }

        private ClienteRemitente clienteActual = null;

        // ─────────────────────────────────────────────
        // CARGA DEL FORMULARIO
        // ─────────────────────────────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            // Provincias entrega
            ProvinciaEntregaComboBox.DataSource = modelo.LProvincias;
            ProvinciaEntregaComboBox.DisplayMember = "Nombre";
            ProvinciaEntregaComboBox.ValueMember = "ProvinciaId";
            ProvinciaEntregaComboBox.SelectedIndex = -1;
            ProvinciaEntregaComboBox.SelectedIndexChanged += ProvinciaEntregaComboBox_SelectedIndexChanged;

            LocalidadEntregaComboBox.Enabled = false;
            LocalidadEntregaComboBox.SelectedIndexChanged += LocalidadEntregaComboBox_SelectedIndexChanged;

            AgenciaEntregaComboBox.Enabled = false;
            AgenciaEntregaComboBox.Visible = false;
            CDEntregaComboBox.Enabled = false;
            CDEntregaComboBox.Visible = false;

            DomicilioEntregaRadio.CheckedChanged += DomicilioEntregaRadio_CheckedChanged;

            // Provincias retiro
            ProvinciaRetiroComboBox.DataSource = modelo.LProvincias;
            ProvinciaRetiroComboBox.DisplayMember = "Nombre";
            ProvinciaRetiroComboBox.ValueMember = "ProvinciaId";
            ProvinciaRetiroComboBox.SelectedIndex = -1;
            ProvinciaRetiroComboBox.SelectedIndexChanged += ProvinciaRetiroComboBox_SelectedIndexChanged;

            LocalidadRetiroComboBox.Enabled = false;

            DomicilioFiscalCheck.CheckedChanged += DomicilioFiscalCheck_CheckedChanged;

            // Cantidades
            CantidadSTextBox.TextChanged += CantidadSTextBox_TextChanged;
            CantidadMTextBox.TextChanged += CantidadMTextBox_TextChanged;
            CantidadLTextBox.TextChanged += CantidadLTextBox_TextChanged;
            CantidadXLTextBox.TextChanged += CantidadXLTextBox_TextChanged;

            panel1.Visible = false;

            // Limpiar labels remitente
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            // Limpiar totales
            TotalBultosLabel.Text = "[Total]";
            GuiasAGenerarLabel.Text = "[Guias]";
            ImporteEstimadoLabel.Text = "[ $... ]";
        }

        // ─────────────────────────────────────────────
        // BUSCAR REMITENTE
        // ─────────────────────────────────────────────
        private void BuscarRemitenteBoton_Click(object sender, EventArgs e)
        {
            clienteActual = null;
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(CuitRemitenteTextBox.Text))
            {
                MessageBox.Show("Es necesario que ingrese un dato.");
                return;
            }
            if (!ImposicionModelo.ValidarCuit(CuitRemitenteTextBox.Text))
            {
                MessageBox.Show("Ingresá un CUIT válido.");
                CuitRemitenteTextBox.Clear();
                return;
            }
            if (!long.TryParse(CuitRemitenteTextBox.Text, out long cuit))
            {
                MessageBox.Show("El CUIT debe ser un número válido.");
                return;
            }

            int encuentro = 0;
            foreach (var cliente in modelo.LClientes)
            {
                if (cliente.CUIT == cuit)
                {
                    clienteActual = cliente;
                    NombreRemitenteLabel.Text = cliente.Nombre;
                    TelefonoRemitenteLabel.Text = cliente.Telefono;
                    DireccionRemitenteLabel.Text = cliente.Direccion;
                    encuentro = 1;
                }
            }
            if (encuentro == 0)
            {
                MessageBox.Show("Ingresá un CUIT válido.");
                CuitRemitenteTextBox.Clear();
            }
        }

        // ─────────────────────────────────────────────
        // DOMICILIO FISCAL
        // ─────────────────────────────────────────────
        private void DomicilioFiscalCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool fiscal = DomicilioFiscalCheck.Checked;
            ProvinciaRetiroComboBox.Enabled = !fiscal;
            LocalidadRetiroComboBox.Enabled = !fiscal;
            DireccionRetiroTextBox.Enabled = !fiscal;
            CPRetiroTextBox.Enabled = !fiscal;
        }

        // ─────────────────────────────────────────────
        // CASCADA RETIRO: Provincia → Localidad
        // ─────────────────────────────────────────────
        private void ProvinciaRetiroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadRetiroComboBox.DataSource = null;
            LocalidadRetiroComboBox.Enabled = false;

            if (ProvinciaRetiroComboBox.SelectedItem is not Provincia prov) return;

            var localidades = modelo.ObtenerLocalidadesPorProvincia(prov.ProvinciaId);
            LocalidadRetiroComboBox.DataSource = localidades;
            LocalidadRetiroComboBox.DisplayMember = "Nombre";
            LocalidadRetiroComboBox.ValueMember = "LocalidadId";
            LocalidadRetiroComboBox.SelectedIndex = -1;
            LocalidadRetiroComboBox.Enabled = true;
        }

        // ─────────────────────────────────────────────
        // CASCADA ENTREGA: Provincia → Localidad
        // ─────────────────────────────────────────────
        private void ProvinciaEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadEntregaComboBox.DataSource = null;
            AgenciaEntregaComboBox.DataSource = null;
            CDEntregaComboBox.DataSource = null;
            LocalidadEntregaComboBox.Enabled = false;
            AgenciaEntregaComboBox.Enabled = false;
            AgenciaEntregaComboBox.Visible = false;
            CDEntregaComboBox.Enabled = false;
            CDEntregaComboBox.Visible = false;

            if (ProvinciaEntregaComboBox.SelectedItem is not Provincia prov) return;

            var localidades = modelo.ObtenerLocalidadesPorProvincia(prov.ProvinciaId);
            LocalidadEntregaComboBox.DataSource = localidades;
            LocalidadEntregaComboBox.DisplayMember = "Nombre";
            LocalidadEntregaComboBox.ValueMember = "LocalidadId";
            LocalidadEntregaComboBox.SelectedIndex = -1;
            LocalidadEntregaComboBox.Enabled = true;
        }

        // ─────────────────────────────────────────────
        // CASCADA ENTREGA: Localidad → Agencia / CD
        // ─────────────────────────────────────────────
        private void LocalidadEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgenciaEntregaComboBox.DataSource = null;
            CDEntregaComboBox.DataSource = null;
            AgenciaEntregaComboBox.Enabled = false;
            AgenciaEntregaComboBox.Visible = false;
            CDEntregaComboBox.Enabled = false;
            CDEntregaComboBox.Visible = false;

            if (LocalidadEntregaComboBox.SelectedItem is not Localidad loc) return;

            var agencias = modelo.ObtenerAgenciasPorLocalidad(loc.LocalidadId);
            var cds = modelo.ObtenerCDsPorLocalidad(loc.LocalidadId);

            if (agencias.Count > 0)
            {
                AgenciaEntregaComboBox.DataSource = agencias;
                AgenciaEntregaComboBox.DisplayMember = "Nombre";
                AgenciaEntregaComboBox.ValueMember = "AgenciaId";
                AgenciaEntregaComboBox.SelectedIndex = -1;
                AgenciaEntregaComboBox.Visible = true;
                AgenciaEntregaComboBox.Enabled = true;
            }
            if (cds.Count > 0)
            {
                CDEntregaComboBox.DataSource = cds;
                CDEntregaComboBox.DisplayMember = "Nombre";
                CDEntregaComboBox.ValueMember = "CDId";
                CDEntregaComboBox.SelectedIndex = -1;
                CDEntregaComboBox.Visible = true;
                CDEntregaComboBox.Enabled = true;
            }
        }

        // ─────────────────────────────────────────────
        // RADIO DOMICILIO
        // ─────────────────────────────────────────────
        private void DomicilioEntregaRadio_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = DomicilioEntregaRadio.Checked;
        }

        // ─────────────────────────────────────────────
        // CÁLCULO DE TOTALES
        // ─────────────────────────────────────────────
        private void ActualizarTotales()
        {
            int.TryParse(CantidadSTextBox.Text, out int cantS);
            int.TryParse(CantidadMTextBox.Text, out int cantM);
            int.TryParse(CantidadLTextBox.Text, out int cantL);
            int.TryParse(CantidadXLTextBox.Text, out int cantXL);

            int totalBultos = cantS + cantM + cantL + cantXL;
            TotalBultosLabel.Text = totalBultos.ToString();
            GuiasAGenerarLabel.Text = totalBultos.ToString();

            decimal importe = modelo.CalcularImporteEstimado(cantS, cantM, cantL, cantXL);
            ImporteEstimadoLabel.Text = $"$ {importe:N2}";
        }

        private void CantidadSTextBox_TextChanged(object sender, EventArgs e) => ActualizarTotales();
        private void CantidadMTextBox_TextChanged(object sender, EventArgs e) => ActualizarTotales();
        private void CantidadLTextBox_TextChanged(object sender, EventArgs e) => ActualizarTotales();
        private void CantidadXLTextBox_TextChanged(object sender, EventArgs e) => ActualizarTotales();

        // ─────────────────────────────────────────────
        // CONFIRMAR
        // ─────────────────────────────────────────────
        private void button3_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                MessageBox.Show("Debe seleccionar un remitente antes de confirmar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(NombreDestinatarioTextBox.Text) ||
                !NombreDestinatarioTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre y Apellido deben ser válidos (solo letras).");
                return;
            }
            if (string.IsNullOrWhiteSpace(ApellidoDestinatarioTextBox.Text) ||
                !ApellidoDestinatarioTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre y Apellido deben ser válidos (solo letras).");
                return;
            }
            if (!long.TryParse(DNIDestinatarioTextBox.Text, out long dni) ||
                DNIDestinatarioTextBox.Text.Length < 7 || DNIDestinatarioTextBox.Text.Length > 8)
            {
                MessageBox.Show("Ingresá un DNI válido (7-8 dígitos).");
                return;
            }
            if (ProvinciaEntregaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una provincia.");
                return;
            }
            if (LocalidadEntregaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una localidad.");
                return;
            }
            if (!DomicilioEntregaRadio.Checked &&
                AgenciaEntregaComboBox.SelectedIndex == -1 &&
                CDEntregaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná el tipo de entrega: elegí una Agencia, un CD, o marcá Domicilio.");
                return;
            }
            if (DomicilioEntregaRadio.Checked && string.IsNullOrWhiteSpace(DireccionDomicilioTextBox.Text))
            {
                MessageBox.Show("Ingresá una dirección válida.");
                return;
            }

            int.TryParse(CantidadSTextBox.Text, out int cantS);
            int.TryParse(CantidadMTextBox.Text, out int cantM);
            int.TryParse(CantidadLTextBox.Text, out int cantL);
            int.TryParse(CantidadXLTextBox.Text, out int cantXL);

            if (cantS + cantM + cantL + cantXL == 0)
            {
                MessageBox.Show("Indicá al menos una encomienda (S/M/L/XL).");
                return;
            }

            string tipoEntrega = DomicilioEntregaRadio.Checked ? "Domicilio" :
                                   AgenciaEntregaComboBox.SelectedIndex != -1 ? "Agencia" : "CD";
            string direccionDest = string.Empty;
            string cpDest = string.Empty;

            if (AgenciaEntregaComboBox.SelectedItem is Agencia agencia)
            {
                direccionDest = agencia.Direccion;
                cpDest = agencia.CodigoPostal;
            }
            else if (CDEntregaComboBox.SelectedItem is CentroDistribucion cd)
            {
                direccionDest = cd.Direccion;
                cpDest = cd.CodigoPostal;
            }
            else if (DomicilioEntregaRadio.Checked)
            {
                direccionDest = DireccionDomicilioTextBox.Text;
                cpDest = CPDomicilioTextBox.Text;
            }

            int totalBultos = cantS + cantM + cantL + cantXL;
            decimal importeEstimado = modelo.CalcularImporteEstimado(cantS, cantM, cantL, cantXL);
            var guiasGeneradas = new List<string>();

            void RegistrarPorTipo(int cantidad, string tipo)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    var guia = new Guia
                    {
                        ClienteId = clienteActual.ClienteId,
                        TipoEncomienda = tipo,
                        TipoEntrega = tipoEntrega,
                        DireccionDestino = direccionDest,
                        CPDestino = cpDest,
                        NombreDestinatario = NombreDestinatarioTextBox.Text,
                        ApellidoDestinatario = ApellidoDestinatarioTextBox.Text,
                        DNIDestinatario = dni,
                        Estado = "A retirar",
                        ImporteEstimado = importeEstimado / totalBultos,
                    };
                    modelo.RegistrarGuia(guia);
                    guiasGeneradas.Add($"{guia.NumeroGuia} ({tipo})");
                }
            }

            RegistrarPorTipo(cantS, "S");
            RegistrarPorTipo(cantM, "M");
            RegistrarPorTipo(cantL, "L");
            RegistrarPorTipo(cantXL, "XL");

            string detalle = string.Join("\n", guiasGeneradas);
            MessageBox.Show($"Operación confirmada. Guías generadas exitosamente:\n{detalle}");

            LimpiarFormulario();
        }

        // ─────────────────────────────────────────────
        // CANCELAR
        // ─────────────────────────────────────────────
        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "Si sale se eliminarán los datos ingresados. ¿Salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Operación cancelada. No se ha registrado ninguna solicitud de imposición.");
                this.Close();
            }
        }

        // ─────────────────────────────────────────────
        // LIMPIEZA
        // ─────────────────────────────────────────────
        private void LimpiarFormulario()
        {
            clienteActual = null;

            CuitRemitenteTextBox.Clear();
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            NombreDestinatarioTextBox.Clear();
            ApellidoDestinatarioTextBox.Clear();
            DNIDestinatarioTextBox.Clear();

            ProvinciaEntregaComboBox.SelectedIndex = -1;
            LocalidadEntregaComboBox.DataSource = null;
            LocalidadEntregaComboBox.Enabled = false;
            DomicilioEntregaRadio.Checked = false;
            AgenciaEntregaComboBox.DataSource = null;
            AgenciaEntregaComboBox.Enabled = false;
            AgenciaEntregaComboBox.Visible = false;
            CDEntregaComboBox.DataSource = null;
            CDEntregaComboBox.Enabled = false;
            CDEntregaComboBox.Visible = false;
            panel1.Visible = false;
            DireccionDomicilioTextBox.Clear();
            CPDomicilioTextBox.Clear();

            CantidadSTextBox.Clear();
            CantidadMTextBox.Clear();
            CantidadLTextBox.Clear();
            CantidadXLTextBox.Clear();

            TotalBultosLabel.Text = "[Total]";
            GuiasAGenerarLabel.Text = "[Guias]";
            ImporteEstimadoLabel.Text = "[ $... ]";
        }

        // ─────────────────────────────────────────────
        // HANDLERS REQUERIDOS POR EL DESIGNER
        // ─────────────────────────────────────────────
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void label26_Click(object sender, EventArgs e) { }
        private void CPDomicilioTextBox_TextChanged(object sender, EventArgs e) => ActualizarTotales();
    }
}
