namespace GrupoE_Tutasa.Imposicion
{
    public partial class ImposicionForm : Form
    {
        private ImposicionModelo modelo = new();

        public ImposicionForm()
        {
            InitializeComponent();
            button2.Click += button2_Click;
        }

        private ClienteRemitente clienteActual = null;

        // ─────────────────────────────────────────────
        // CARGA DEL FORMULARIO
        // ─────────────────────────────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            // ── Remitente ──
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            // ── Domicilio de retiro ──
            label37.Visible = false;

            ProvinciaRetiroComboBox.DataSource = modelo.LProvincias;
            ProvinciaRetiroComboBox.DisplayMember = "Nombre";
            ProvinciaRetiroComboBox.ValueMember = "ProvinciaId";
            ProvinciaRetiroComboBox.SelectedIndex = -1;
            ProvinciaRetiroComboBox.SelectedIndexChanged += ProvinciaRetiroComboBox_SelectedIndexChanged;

            LocalidadRetiroComboBox.Enabled = false;

            DomicilioFiscalCheck.CheckedChanged += DomicilioFiscalCheck_CheckedChanged;

            // ── Datos para la Entrega ──
            ProvinciaEntregaComboBox.DataSource = modelo.LProvincias;
            ProvinciaEntregaComboBox.DisplayMember = "Nombre";
            ProvinciaEntregaComboBox.ValueMember = "ProvinciaId";
            ProvinciaEntregaComboBox.SelectedIndex = -1;
            ProvinciaEntregaComboBox.SelectedIndexChanged += ProvinciaEntregaComboBox_SelectedIndexChanged;

            LocalidadEntregaComboBox.Enabled = false;
            LocalidadEntregaComboBox.SelectedIndexChanged += LocalidadEntregaComboBox_SelectedIndexChanged;

            TipoEntregaComboBox.SelectedIndex = -1;
            TipoEntregaComboBox.Enabled = false;
            TipoEntregaComboBox.SelectedIndexChanged += TipoEntregaComboBox_SelectedIndexChanged;

            DestinoComboBox.Enabled = false;
            DestinoComboBox.Visible = false;
            labelDestino.Visible = false;
            panel1.Visible = false;

            // ── Cantidades ──
            CantidadSTextBox.TextChanged += CantidadSTextBox_TextChanged;
            CantidadMTextBox.TextChanged += CantidadMTextBox_TextChanged;
            CantidadLTextBox.TextChanged += CantidadLTextBox_TextChanged;
            CantidadXLTextBox.TextChanged += CantidadXLTextBox_TextChanged;

            // ── Totales ──
            GuiasAGenerarLabel.Text = "[Total Guias]";
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

                    // Si el check fiscal está tildado, actualizar label con dirección del remitente
                    if (DomicilioFiscalCheck.Checked)
                        label37.Text = cliente.Direccion;
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

            label37.Visible = fiscal;

            if (fiscal && clienteActual != null)
                label37.Text = clienteActual.Direccion;

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
            LocalidadEntregaComboBox.Enabled = false;
            TipoEntregaComboBox.Items.Clear();
            TipoEntregaComboBox.SelectedIndex = -1;
            TipoEntregaComboBox.Enabled = false;
            DestinoComboBox.DataSource = null;
            DestinoComboBox.Enabled = false;
            DestinoComboBox.Visible = false;
            labelDestino.Visible = false;
            panel1.Visible = false;

            if (ProvinciaEntregaComboBox.SelectedItem is not Provincia prov) return;

            var localidades = modelo.ObtenerLocalidadesPorProvincia(prov.ProvinciaId);
            LocalidadEntregaComboBox.DataSource = localidades;
            LocalidadEntregaComboBox.DisplayMember = "Nombre";
            LocalidadEntregaComboBox.ValueMember = "LocalidadId";
            LocalidadEntregaComboBox.SelectedIndex = -1;
            LocalidadEntregaComboBox.Enabled = true;
        }

        // ─────────────────────────────────────────────
        // CASCADA ENTREGA: Localidad → TipoEntrega
        // Solo carga las opciones disponibles según la localidad
        // ─────────────────────────────────────────────
        private void LocalidadEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoEntregaComboBox.Items.Clear();
            TipoEntregaComboBox.SelectedIndex = -1;
            TipoEntregaComboBox.Enabled = false;
            DestinoComboBox.DataSource = null;
            DestinoComboBox.Enabled = false;
            DestinoComboBox.Visible = false;
            labelDestino.Visible = false;
            panel1.Visible = false;

            if (LocalidadEntregaComboBox.SelectedItem is not Localidad loc) return;

            var agencias = modelo.ObtenerAgenciasPorLocalidad(loc.LocalidadId);
            var cds = modelo.ObtenerCDsPorLocalidad(loc.LocalidadId);

            // Solo agregar las opciones que tienen datos disponibles
            if (cds.Count > 0)
                TipoEntregaComboBox.Items.Add("CD");

            if (agencias.Count > 0)
                TipoEntregaComboBox.Items.Add("Agencia");

            // A domicilio siempre disponible
            TipoEntregaComboBox.Items.Add("A domicilio");

            TipoEntregaComboBox.Enabled = true;
        }

        // ─────────────────────────────────────────────
        // TIPO ENTREGA → carga Destino o panel domicilio
        // ─────────────────────────────────────────────
        private void TipoEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DestinoComboBox.DataSource = null;
            DestinoComboBox.Enabled = false;
            DestinoComboBox.Visible = false;
            labelDestino.Visible = false;
            panel1.Visible = false;

            if (TipoEntregaComboBox.SelectedItem is not string tipoSeleccionado) return;
            if (LocalidadEntregaComboBox.SelectedItem is not Localidad loc) return;

            if (tipoSeleccionado == "A domicilio")
            {
                panel1.Visible = true;
            }
            else if (tipoSeleccionado == "CD")
            {
                var cds = modelo.ObtenerCDsPorLocalidad(loc.LocalidadId);
                DestinoComboBox.DataSource = cds;
                DestinoComboBox.DisplayMember = "Nombre";
                DestinoComboBox.ValueMember = "CDId";
                DestinoComboBox.SelectedIndex = -1;
                DestinoComboBox.Enabled = true;
                DestinoComboBox.Visible = true;
                labelDestino.Visible = true;
            }
            else if (tipoSeleccionado == "Agencia")
            {
                var agencias = modelo.ObtenerAgenciasPorLocalidad(loc.LocalidadId);
                DestinoComboBox.DataSource = agencias;
                DestinoComboBox.DisplayMember = "Nombre";
                DestinoComboBox.ValueMember = "AgenciaId";
                DestinoComboBox.SelectedIndex = -1;
                DestinoComboBox.Enabled = true;
                DestinoComboBox.Visible = true;
                labelDestino.Visible = true;
            }
        }

        // ─────────────────────────────────────────────
        // VALIDACIÓN CÓDIGO POSTAL
        // Solo letras → inválido
        // Solo números o letras+números → válido
        // ─────────────────────────────────────────────
        private bool ValidarCodigoPostal(string cp)
        {
            if (string.IsNullOrWhiteSpace(cp)) return true;
            bool tieneLetras = cp.Any(char.IsLetter);
            bool tieneNumeros = cp.Any(char.IsDigit);
            if (tieneLetras && !tieneNumeros) return false;
            return true;
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

            int totalGuias = cantS + cantM + cantL + cantXL;
            GuiasAGenerarLabel.Text = totalGuias.ToString();
            decimal importe = modelo.CalcularImporteEstimado(cantS, cantM, cantL, cantXL);
            ImporteEstimadoLabel.Text = totalGuias > 0 ? $"$ {importe:N2}" : "[ $... ]";
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
            // ── Validar remitente ──
            if (clienteActual == null)
            {
                MessageBox.Show("Debe seleccionar un remitente antes de confirmar.");
                return;
            }

            // ── Validar nombre destinatario ──
            if (string.IsNullOrWhiteSpace(NombreDestinatarioTextBox.Text) ||
                !NombreDestinatarioTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre y apellido del destinatario deben ser válidos (solo letras).");
                return;
            }

            // ── Validar apellido destinatario ──
            if (string.IsNullOrWhiteSpace(ApellidoDestinatarioTextBox.Text) ||
                !ApellidoDestinatarioTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre y apellido del destinatario deben ser válidos (solo letras).");
                return;
            }

            // ── Validar DNI ──
            if (!long.TryParse(DNIDestinatarioTextBox.Text, out long dni) ||
                DNIDestinatarioTextBox.Text.Length < 7 || DNIDestinatarioTextBox.Text.Length > 8)
            {
                MessageBox.Show("Ingresá un DNI válido (7-8 dígitos).");
                return;
            }

            // ── Validar CP de retiro ──
            if (!DomicilioFiscalCheck.Checked && !ValidarCodigoPostal(CPRetiroTextBox.Text))
            {
                MessageBox.Show("El código postal de retiro es incorrecto. Debe contener al menos un número.");
                return;
            }

            // ── Validar provincia y localidad de entrega ──
            if (ProvinciaEntregaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una provincia de entrega.");
                return;
            }
            if (LocalidadEntregaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una localidad de entrega.");
                return;
            }
            if (TipoEntregaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná el tipo de entrega.");
                return;
            }

            string tipoSeleccionado = TipoEntregaComboBox.SelectedItem.ToString();

            if (tipoSeleccionado != "A domicilio" && DestinoComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná el destino correspondiente.");
                return;
            }

            // ── Validar dirección y CP de domicilio ──
            if (tipoSeleccionado == "A domicilio" && string.IsNullOrWhiteSpace(DireccionDomicilioTextBox.Text))
            {
                MessageBox.Show("Ingresá una dirección de entrega válida.");
                return;
            }
            if (tipoSeleccionado == "A domicilio" && !ValidarCodigoPostal(CPDomicilioTextBox.Text))
            {
                MessageBox.Show("El código postal de entrega es incorrecto. Debe contener al menos un número.");
                return;
            }

            // ── Validar que las cantidades sean solo números ──
            if (!string.IsNullOrWhiteSpace(CantidadSTextBox.Text) && !CantidadSTextBox.Text.All(char.IsDigit) ||
                !string.IsNullOrWhiteSpace(CantidadMTextBox.Text) && !CantidadMTextBox.Text.All(char.IsDigit) ||
                !string.IsNullOrWhiteSpace(CantidadLTextBox.Text) && !CantidadLTextBox.Text.All(char.IsDigit) ||
                !string.IsNullOrWhiteSpace(CantidadXLTextBox.Text) && !CantidadXLTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Las cantidades de encomiendas deben ser valores numéricos enteros. " +
                                "Por favor, revisá los campos S, M, L y XL.");
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

            // ── Determinar dirección y CP destino ──
            string tipoEntrega = tipoSeleccionado;
            string direccionDest = string.Empty;
            string cpDest = string.Empty;

            if (tipoSeleccionado == "Agencia" && DestinoComboBox.SelectedItem is Agencia agencia)
            {
                direccionDest = agencia.Direccion;
                cpDest = agencia.CodigoPostal;
            }
            else if (tipoSeleccionado == "CD" && DestinoComboBox.SelectedItem is CentroDistribucion cd)
            {
                direccionDest = cd.Direccion;
                cpDest = cd.CodigoPostal;
            }
            else if (tipoSeleccionado == "A domicilio")
            {
                direccionDest = DireccionDomicilioTextBox.Text;
                cpDest = CPDomicilioTextBox.Text;
            }

            // ── Registrar guías ──
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

            // Remitente
            CuitRemitenteTextBox.Clear();
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            // Retiro
            DomicilioFiscalCheck.Checked = false;
            label37.Visible = false;
            label37.Text = string.Empty;
            ProvinciaRetiroComboBox.SelectedIndex = -1;
            LocalidadRetiroComboBox.DataSource = null;
            LocalidadRetiroComboBox.Enabled = false;
            DireccionRetiroTextBox.Clear();
            CPRetiroTextBox.Clear();

            // Destinatario
            NombreDestinatarioTextBox.Clear();
            ApellidoDestinatarioTextBox.Clear();
            DNIDestinatarioTextBox.Clear();

            // Entrega
            ProvinciaEntregaComboBox.SelectedIndex = -1;
            LocalidadEntregaComboBox.DataSource = null;
            LocalidadEntregaComboBox.Enabled = false;
            TipoEntregaComboBox.Items.Clear();
            TipoEntregaComboBox.SelectedIndex = -1;
            TipoEntregaComboBox.Enabled = false;
            DestinoComboBox.DataSource = null;
            DestinoComboBox.Enabled = false;
            DestinoComboBox.Visible = false;
            labelDestino.Visible = false;
            panel1.Visible = false;
            DireccionDomicilioTextBox.Clear();
            CPDomicilioTextBox.Clear();

            // Cantidades
            CantidadSTextBox.Clear();
            CantidadMTextBox.Clear();
            CantidadLTextBox.Clear();
            CantidadXLTextBox.Clear();

            // Totales
            GuiasAGenerarLabel.Text = "[Total Guias]";
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

        private void CPRetiroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
