namespace GrupoE_Tutasa.Imposicion
{
    public partial class ImposicionForm : Form
    {
        private readonly ImposicionModelo modelo = new();

        /// <summary>
        /// CD donde opera el usuario actual. En producción se inyecta desde el contexto de sesión.
        /// </summary>
        private readonly int _cdActualId = 1;

        private ClienteRemitente _clienteActual = null;

        public ImposicionForm()
        {
            InitializeComponent();
            button2.Click += button2_Click;
        }

        // ─────────────────────────────────────────────
        // CARGA DEL FORMULARIO
        // ─────────────────────────────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            // ── Remitente ──
            NombreRemitenteLabel.Text    = string.Empty;
            TelefonoRemitenteLabel.Text  = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            // ── Domicilio de retiro ──
            label37.Visible = false;

            ProvinciaRetiroComboBox.DataSource    = modelo.LProvincias;
            ProvinciaRetiroComboBox.DisplayMember = "Nombre";
            ProvinciaRetiroComboBox.ValueMember   = "ProvinciaId";
            ProvinciaRetiroComboBox.SelectedIndex = -1;
            ProvinciaRetiroComboBox.SelectedIndexChanged += ProvinciaRetiroComboBox_SelectedIndexChanged;

            LocalidadRetiroComboBox.Enabled = false;

            DomicilioFiscalCheck.CheckedChanged += DomicilioFiscalCheck_CheckedChanged;

            // ── Datos para la Entrega ──
            ProvinciaEntregaComboBox.DataSource    = modelo.LProvincias;
            ProvinciaEntregaComboBox.DisplayMember = "Nombre";
            ProvinciaEntregaComboBox.ValueMember   = "ProvinciaId";
            ProvinciaEntregaComboBox.SelectedIndex = -1;
            ProvinciaEntregaComboBox.SelectedIndexChanged += ProvinciaEntregaComboBox_SelectedIndexChanged;

            LocalidadEntregaComboBox.Enabled = false;
            LocalidadEntregaComboBox.SelectedIndexChanged += LocalidadEntregaComboBox_SelectedIndexChanged;

            TipoEntregaComboBox.SelectedIndex = -1;
            TipoEntregaComboBox.Enabled       = false;
            TipoEntregaComboBox.SelectedIndexChanged += TipoEntregaComboBox_SelectedIndexChanged;

            DestinoComboBox.Enabled = false;
            DestinoComboBox.Visible = false;
            labelDestino.Visible    = false;
            panel1.Visible          = false;

            // ── Cantidades ──
            CantidadSTextBox.TextChanged  += CantidadSTextBox_TextChanged;
            CantidadMTextBox.TextChanged  += CantidadMTextBox_TextChanged;
            CantidadLTextBox.TextChanged  += CantidadLTextBox_TextChanged;
            CantidadXLTextBox.TextChanged += CantidadXLTextBox_TextChanged;

            // ── Totales ──
            GuiasAGenerarLabel.Text   = "[Total Guias]";
            ImporteEstimadoLabel.Text = "[ $... ]";
        }

        // ─────────────────────────────────────────────
        // BUSCAR REMITENTE
        // ─────────────────────────────────────────────
        private void BuscarRemitenteBoton_Click(object sender, EventArgs e)
        {
            _clienteActual = null;
            NombreRemitenteLabel.Text    = string.Empty;
            TelefonoRemitenteLabel.Text  = string.Empty;
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

            string cuitBuscado = new string(CuitRemitenteTextBox.Text.Where(char.IsDigit).ToArray());

            var cliente = modelo.LClientes
                .FirstOrDefault(c => new string(c.CUIT.Where(char.IsDigit).ToArray()) == cuitBuscado);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró ningún remitente con el CUIT ingresado.");
                CuitRemitenteTextBox.Clear();
                return;
            }

            _clienteActual = cliente;

            string nombreMostrar = string.IsNullOrWhiteSpace(cliente.RazonSocial)
                ? $"{cliente.Nombre} {cliente.Apellido}".Trim()
                : cliente.RazonSocial;

            NombreRemitenteLabel.Text    = nombreMostrar;
            TelefonoRemitenteLabel.Text  = cliente.Telefono;
            DireccionRemitenteLabel.Text = FormatearDomicilio(cliente.Domicilio);

            if (DomicilioFiscalCheck.Checked)
                label37.Text = FormatearDomicilio(cliente.Domicilio);
        }

        // ─────────────────────────────────────────────
        // DOMICILIO FISCAL
        // ─────────────────────────────────────────────
        private void DomicilioFiscalCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool fiscal = DomicilioFiscalCheck.Checked;

            label37.Visible = fiscal;

            if (fiscal && _clienteActual != null)
                label37.Text = FormatearDomicilio(_clienteActual.Domicilio);

            ProvinciaRetiroComboBox.Enabled  = !fiscal;
            LocalidadRetiroComboBox.Enabled  = !fiscal;
            DireccionRetiroTextBox.Enabled   = !fiscal;
            CPRetiroTextBox.Enabled          = !fiscal;
        }

        // ─────────────────────────────────────────────
        // CASCADA RETIRO: Provincia → Localidad
        // ─────────────────────────────────────────────
        private void ProvinciaRetiroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadRetiroComboBox.DataSource = null;
            LocalidadRetiroComboBox.Enabled    = false;

            if (ProvinciaRetiroComboBox.SelectedItem is not Provincia prov) return;

            var localidades = modelo.ObtenerLocalidadesPorProvincia(prov.ProvinciaId);
            LocalidadRetiroComboBox.DataSource    = localidades;
            LocalidadRetiroComboBox.DisplayMember = "Nombre";
            LocalidadRetiroComboBox.ValueMember   = "LocalidadId";
            LocalidadRetiroComboBox.SelectedIndex = -1;
            LocalidadRetiroComboBox.Enabled       = true;
        }

        // ─────────────────────────────────────────────
        // CASCADA ENTREGA: Provincia → Localidad
        // ─────────────────────────────────────────────
        private void ProvinciaEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadEntregaComboBox.DataSource = null;
            LocalidadEntregaComboBox.Enabled    = false;
            TipoEntregaComboBox.Items.Clear();
            TipoEntregaComboBox.SelectedIndex   = -1;
            TipoEntregaComboBox.Enabled         = false;
            DestinoComboBox.DataSource          = null;
            DestinoComboBox.Enabled             = false;
            DestinoComboBox.Visible             = false;
            labelDestino.Visible                = false;
            panel1.Visible                      = false;

            if (ProvinciaEntregaComboBox.SelectedItem is not Provincia prov) return;

            var localidades = modelo.ObtenerLocalidadesPorProvincia(prov.ProvinciaId);
            LocalidadEntregaComboBox.DataSource    = localidades;
            LocalidadEntregaComboBox.DisplayMember = "Nombre";
            LocalidadEntregaComboBox.ValueMember   = "LocalidadId";
            LocalidadEntregaComboBox.SelectedIndex = -1;
            LocalidadEntregaComboBox.Enabled       = true;
        }

        // ─────────────────────────────────────────────
        // CASCADA ENTREGA: Localidad → TipoEntrega
        // Solo carga las opciones disponibles según la localidad
        // ─────────────────────────────────────────────
        private void LocalidadEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoEntregaComboBox.Items.Clear();
            TipoEntregaComboBox.SelectedIndex = -1;
            TipoEntregaComboBox.Enabled       = false;
            DestinoComboBox.DataSource        = null;
            DestinoComboBox.Enabled           = false;
            DestinoComboBox.Visible           = false;
            labelDestino.Visible              = false;
            panel1.Visible                    = false;

            if (LocalidadEntregaComboBox.SelectedItem is not Localidad loc) return;

            var agencias = modelo.ObtenerAgenciasPorLocalidad(loc.LocalidadId);
            var cds      = modelo.ObtenerCDsPorLocalidad(loc.LocalidadId);

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
            DestinoComboBox.Enabled    = false;
            DestinoComboBox.Visible    = false;
            labelDestino.Visible       = false;
            panel1.Visible             = false;

            if (TipoEntregaComboBox.SelectedItem is not string tipoSeleccionado) return;
            if (LocalidadEntregaComboBox.SelectedItem is not Localidad loc) return;

            if (tipoSeleccionado == "A domicilio")
            {
                panel1.Visible = true;
            }
            else if (tipoSeleccionado == "CD")
            {
                var cds = modelo.ObtenerCDsPorLocalidad(loc.LocalidadId);
                DestinoComboBox.DataSource    = cds;
                DestinoComboBox.DisplayMember = "Nombre";
                DestinoComboBox.ValueMember   = "CDId";
                DestinoComboBox.SelectedIndex = -1;
                DestinoComboBox.Enabled       = true;
                DestinoComboBox.Visible       = true;
                labelDestino.Visible          = true;
            }
            else if (tipoSeleccionado == "Agencia")
            {
                var agencias = modelo.ObtenerAgenciasPorLocalidad(loc.LocalidadId);
                DestinoComboBox.DataSource    = agencias;
                DestinoComboBox.DisplayMember = "RazonSocial";
                DestinoComboBox.ValueMember   = "AgenciaId";
                DestinoComboBox.SelectedIndex = -1;
                DestinoComboBox.Enabled       = true;
                DestinoComboBox.Visible       = true;
                labelDestino.Visible          = true;
            }

            ActualizarTotales();
        }

        // ─────────────────────────────────────────────
        // VALIDACIÓN CÓDIGO POSTAL
        // Solo letras → inválido; números o alfanumérico → válido
        // ─────────────────────────────────────────────
        private static bool ValidarCodigoPostal(string cp)
        {
            if (string.IsNullOrWhiteSpace(cp)) return true;
            bool tieneLetras  = cp.Any(char.IsLetter);
            bool tieneNumeros = cp.Any(char.IsDigit);
            if (tieneLetras && !tieneNumeros) return false;
            return true;
        }

        // ─────────────────────────────────────────────
        // CÁLCULO DE TOTALES
        // ─────────────────────────────────────────────
        private void ActualizarTotales()
        {
            int.TryParse(CantidadSTextBox.Text,  out int cantS);
            int.TryParse(CantidadMTextBox.Text,  out int cantM);
            int.TryParse(CantidadLTextBox.Text,  out int cantL);
            int.TryParse(CantidadXLTextBox.Text, out int cantXL);

            int totalGuias = cantS + cantM + cantL + cantXL;
            GuiasAGenerarLabel.Text = totalGuias.ToString();

            var modalidadEntrega = ResolverModalidadEntrega();
            decimal importe = modelo.CalcularImporteEstimado(cantS, cantM, cantL, cantXL,
                                                             _cdActualId, _cdActualId, modalidadEntrega);
            ImporteEstimadoLabel.Text = totalGuias > 0 ? $"$ {importe:N2}" : "[ $... ]";
        }

        private ModalidadEntregaEnum ResolverModalidadEntrega()
        {
            if (TipoEntregaComboBox.SelectedItem is not string tipo)
                return ModalidadEntregaEnum.CD;

            return tipo switch
            {
                "A domicilio" => ModalidadEntregaEnum.DOMICILIO,
                "Agencia"     => ModalidadEntregaEnum.AGENCIA,
                _             => ModalidadEntregaEnum.CD
            };
        }

        private void CantidadSTextBox_TextChanged(object sender, EventArgs e)  => ActualizarTotales();
        private void CantidadMTextBox_TextChanged(object sender, EventArgs e)  => ActualizarTotales();
        private void CantidadLTextBox_TextChanged(object sender, EventArgs e)  => ActualizarTotales();
        private void CantidadXLTextBox_TextChanged(object sender, EventArgs e) => ActualizarTotales();

        // ─────────────────────────────────────────────
        // CONFIRMAR
        // ─────────────────────────────────────────────
        private void button3_Click(object sender, EventArgs e)
        {
            // ── Validar remitente ──
            if (_clienteActual == null)
            {
                MessageBox.Show("Debe seleccionar un remitente antes de confirmar.");
                return;
            }

            // ── Validar nombre destinatario ──
            if (string.IsNullOrWhiteSpace(NombreDestinatarioTextBox.Text) ||
                !NombreDestinatarioTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El nombre del destinatario debe ser válido (solo letras).");
                return;
            }

            // ── Validar apellido destinatario ──
            if (string.IsNullOrWhiteSpace(ApellidoDestinatarioTextBox.Text) ||
                !ApellidoDestinatarioTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El apellido del destinatario debe ser válido (solo letras).");
                return;
            }

            // ── Validar DNI ──
            if (!int.TryParse(DNIDestinatarioTextBox.Text, out int dni) ||
                DNIDestinatarioTextBox.Text.Length < 7 ||
                DNIDestinatarioTextBox.Text.Length > 8)
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

            // ── Validar entrega ──
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

            // ── Validar cantidades ──
            if ((!string.IsNullOrWhiteSpace(CantidadSTextBox.Text)  && !CantidadSTextBox.Text.All(char.IsDigit))  ||
                (!string.IsNullOrWhiteSpace(CantidadMTextBox.Text)  && !CantidadMTextBox.Text.All(char.IsDigit))  ||
                (!string.IsNullOrWhiteSpace(CantidadLTextBox.Text)  && !CantidadLTextBox.Text.All(char.IsDigit))  ||
                (!string.IsNullOrWhiteSpace(CantidadXLTextBox.Text) && !CantidadXLTextBox.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Las cantidades de encomiendas deben ser valores numéricos enteros.");
                return;
            }

            int.TryParse(CantidadSTextBox.Text,  out int cantS);
            int.TryParse(CantidadMTextBox.Text,  out int cantM);
            int.TryParse(CantidadLTextBox.Text,  out int cantL);
            int.TryParse(CantidadXLTextBox.Text, out int cantXL);

            if (cantS + cantM + cantL + cantXL == 0)
            {
                MessageBox.Show("Indicá al menos una encomienda (S/M/L/XL).");
                return;
            }

            // ── Resolver modalidad de entrega y domicilio destino ──
            var modalidadEntrega = ResolverModalidadEntrega();

            Domicilio domicilioEntrega = null;
            int?      agenciaDestinoId = null;
            int       cdDestinoId      = _cdActualId; // fallback: mismo CD

            if (tipoSeleccionado == "Agencia" && DestinoComboBox.SelectedItem is Agencia agencia)
            {
                agenciaDestinoId = agencia.AgenciaId;
                domicilioEntrega = agencia.Domicilio;
                cdDestinoId      = agencia.CDAsignadoId;
            }
            else if (tipoSeleccionado == "CD" && DestinoComboBox.SelectedItem is CentroDistribucion cd)
            {
                domicilioEntrega = cd.Domicilio;
                cdDestinoId      = cd.CDId;
            }
            else if (tipoSeleccionado == "A domicilio")
            {
                var localidadEntrega = LocalidadEntregaComboBox.SelectedItem as Localidad;
                domicilioEntrega = new Domicilio
                {
                    Calle        = DireccionDomicilioTextBox.Text,
                    CodigoPostal = CPDomicilioTextBox.Text,
                    LocalidadId  = localidadEntrega?.LocalidadId ?? 0
                };
            }

            // ── Construir domicilio de retiro ──
            Domicilio domicilioRetiro;
            if (DomicilioFiscalCheck.Checked)
            {
                domicilioRetiro = _clienteActual.Domicilio;
            }
            else
            {
                var localidadRetiro = LocalidadRetiroComboBox.SelectedItem as Localidad;
                domicilioRetiro = new Domicilio
                {
                    Calle        = DireccionRetiroTextBox.Text,
                    CodigoPostal = CPRetiroTextBox.Text,
                    LocalidadId  = localidadRetiro?.LocalidadId ?? 0
                };
            }

            // ── Registrar guías (una por bulto) ──
            int totalBultos     = cantS + cantM + cantL + cantXL;
            decimal importeTotal = modelo.CalcularImporteEstimado(cantS, cantM, cantL, cantXL,
                                                                  _cdActualId, cdDestinoId, modalidadEntrega);
            decimal importePorBulto = importeTotal / totalBultos;

            var guiasGeneradas = new List<string>();

            void RegistrarPorTipo(int cantidad, TipoCajaEnum tipoCaja)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    var guia = new Guia
                    {
                        ClienteId            = _clienteActual.ClienteId,
                        CDOrigenId           = _cdActualId,
                        CDDestinoId          = cdDestinoId,
                        ModalidadImposicion  = ModalidadImposicionEnum.CD,   // imposición en CD
                        DomicilioRetiro      = domicilioRetiro,
                        ModalidadEntrega     = modalidadEntrega,
                        AgenciaDestinoId     = agenciaDestinoId,
                        DomicilioEntrega     = domicilioEntrega,
                        NombreDestinatario   = NombreDestinatarioTextBox.Text.Trim(),
                        ApellidoDestinatario = ApellidoDestinatarioTextBox.Text.Trim(),
                        DNIDestinatario      = dni,
                        TipoCaja             = tipoCaja,
                        IntentosDeEntrega    = 0,
                        Estado               = EstadoGuiaEnum.A_RETIRAR,
                        TarifarioId          = 1,
                    };

                    // Regla de negocio: CDActualId se asigna dentro de RegistrarGuia
                    // solo cuando ModalidadImposicion == CD (que es este caso).
                    modelo.RegistrarGuia(guia, _cdActualId);
                    guiasGeneradas.Add($"{guia.GuiaId:D8} ({tipoCaja})");
                }
            }

            RegistrarPorTipo(cantS,  TipoCajaEnum.S);
            RegistrarPorTipo(cantM,  TipoCajaEnum.M);
            RegistrarPorTipo(cantL,  TipoCajaEnum.L);
            RegistrarPorTipo(cantXL, TipoCajaEnum.XL);

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
            _clienteActual = null;

            CuitRemitenteTextBox.Clear();
            NombreRemitenteLabel.Text    = string.Empty;
            TelefonoRemitenteLabel.Text  = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            DomicilioFiscalCheck.Checked = false;
            label37.Visible              = false;
            label37.Text                 = string.Empty;
            ProvinciaRetiroComboBox.SelectedIndex = -1;
            LocalidadRetiroComboBox.DataSource    = null;
            LocalidadRetiroComboBox.Enabled       = false;
            DireccionRetiroTextBox.Clear();
            CPRetiroTextBox.Clear();

            NombreDestinatarioTextBox.Clear();
            ApellidoDestinatarioTextBox.Clear();
            DNIDestinatarioTextBox.Clear();

            ProvinciaEntregaComboBox.SelectedIndex = -1;
            LocalidadEntregaComboBox.DataSource    = null;
            LocalidadEntregaComboBox.Enabled       = false;
            TipoEntregaComboBox.Items.Clear();
            TipoEntregaComboBox.SelectedIndex      = -1;
            TipoEntregaComboBox.Enabled            = false;
            DestinoComboBox.DataSource             = null;
            DestinoComboBox.Enabled                = false;
            DestinoComboBox.Visible                = false;
            labelDestino.Visible                   = false;
            panel1.Visible                         = false;
            DireccionDomicilioTextBox.Clear();
            CPDomicilioTextBox.Clear();

            CantidadSTextBox.Clear();
            CantidadMTextBox.Clear();
            CantidadLTextBox.Clear();
            CantidadXLTextBox.Clear();

            GuiasAGenerarLabel.Text   = "[Total Guias]";
            ImporteEstimadoLabel.Text = "[ $... ]";
        }

        // ─────────────────────────────────────────────
        // HELPERS
        // ─────────────────────────────────────────────
        private static string FormatearDomicilio(Domicilio d)
        {
            if (d == null) return string.Empty;
            var partes = new List<string>();
            if (!string.IsNullOrWhiteSpace(d.Calle))   partes.Add(d.Calle);
            if (!string.IsNullOrWhiteSpace(d.Numero))  partes.Add(d.Numero);
            if (!string.IsNullOrWhiteSpace(d.Piso))    partes.Add($"P{d.Piso}");
            if (!string.IsNullOrWhiteSpace(d.Depto))   partes.Add($"D{d.Depto}");
            return string.Join(" ", partes);
        }

        // ─────────────────────────────────────────────
        // HANDLERS REQUERIDOS POR EL DESIGNER
        // ─────────────────────────────────────────────
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e)    { }
        private void label4_Click(object sender, EventArgs e)    { }
        private void label6_Click(object sender, EventArgs e)    { }
        private void label9_Click(object sender, EventArgs e)    { }
        private void label10_Click(object sender, EventArgs e)   { }
        private void label12_Click(object sender, EventArgs e)   { }
        private void label19_Click(object sender, EventArgs e)   { }
        private void label26_Click(object sender, EventArgs e)   { }
        private void CPDomicilioTextBox_TextChanged(object sender, EventArgs e) => ActualizarTotales();
        private void CPRetiroTextBox_TextChanged(object sender, EventArgs e)    { }
    }
}
