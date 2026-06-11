namespace GrupoE_Tutasa.Imposicion
{
    public partial class ImposicionForm : Form
    {
        private ImposicionModelo modelo = new();
        

        public ImposicionForm()
        {
            InitializeComponent();
            Cancelar_Boton.Click += button2_Click;
        }

        // Carga inicial del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Limpieza de etiquetas del remitente
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            label37.Visible = false;

            // Carga de provincias en el combo de retiro
            ProvinciaRetiroComboBox.Items.Clear();
            ProvinciaRetiroComboBox.DataSource = modelo.LProvincias;
            ProvinciaRetiroComboBox.DisplayMember = "Nombre";
            ProvinciaRetiroComboBox.ValueMember = "ProvinciaId";
            ProvinciaRetiroComboBox.SelectedIndex = -1;
            ProvinciaRetiroComboBox.SelectedIndexChanged += ProvinciaRetiroComboBox_SelectedIndexChanged;

            LocalidadRetiroComboBox.Enabled = false;

            DomicilioFiscalCheck.CheckedChanged += DomicilioFiscalCheck_CheckedChanged;

            // Carga de provincias en el combo de entrega.
            ProvinciaEntregaComboBox.Items.Clear();
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

            CantidadSTextBox.TextChanged += CantidadSTextBox_TextChanged;
            CantidadMTextBox.TextChanged += CantidadMTextBox_TextChanged;
            CantidadLTextBox.TextChanged += CantidadLTextBox_TextChanged;
            CantidadXLTextBox.TextChanged += CantidadXLTextBox_TextChanged;

            Total_Guias_Label.Text = "[Total Guias]";

        }

        // Búsqueda del remitente por CUIT
        private void BuscarRemitenteBoton_Click(object sender, EventArgs e)
        {
            modelo.clienteActual = null;
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(CuitRemitente_TextBox.Text))
            {
                MessageBox.Show("Es necesario que ingrese un dato.");
                return;
            }
            if (!modelo.ValidarCuit(CuitRemitente_TextBox.Text))
            {
                MessageBox.Show("Ingresá un CUIT válido.");
                CuitRemitente_TextBox.Clear();
                return;
            }

            string cuitBuscado = CuitRemitente_TextBox.Text.Trim();
            int encuentro = 0;

            foreach (var cliente in modelo.LClientes)
            {
                if (cliente.CUIT == cuitBuscado)
                {
                    modelo.clienteActual = cliente;
                    encuentro = 1;
                    break;
                }
            }

            if (encuentro == 0)
            {
                MessageBox.Show("No se encontró ningún remitente con el CUIT ingresado.");
                CuitRemitente_TextBox.Clear();
                return;
            }

            // Mostrar datos del remitente encontrado
            string nombreMostrar = modelo.clienteActual.RazonSocial;
            if (string.IsNullOrWhiteSpace(nombreMostrar))
            {
                nombreMostrar = modelo.clienteActual.Nombre + " " + modelo.clienteActual.Apellido;
            }

            NombreRemitenteLabel.Text = nombreMostrar;
            TelefonoRemitenteLabel.Text = modelo.clienteActual.Telefono;
            DireccionRemitenteLabel.Text = FormatearDomicilio(modelo.clienteActual.Domicilio);

            if (DomicilioFiscalCheck.Checked)
            {
                label37.Text = FormatearDomicilio(modelo.clienteActual.Domicilio);
            }
        }

        // Uso del domicilio fiscal como domicilio de retiro
        private void DomicilioFiscalCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool fiscal = DomicilioFiscalCheck.Checked;

            label37.Visible = fiscal;

            if (fiscal && modelo.clienteActual != null)
            {
                label37.Text = FormatearDomicilio(modelo.clienteActual.Domicilio);
            }

            ProvinciaRetiroComboBox.Enabled = !fiscal;
            LocalidadRetiroComboBox.Enabled = !fiscal;
            DireccionRetiroTextBox.Enabled = !fiscal;
            CPRetiroTextBox.Enabled = !fiscal;
        }

        // Carga de localidades de retiro según provincia seleccionada
        private void ProvinciaRetiroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadRetiroComboBox.DataSource = null;
            LocalidadRetiroComboBox.Enabled = false;

            if (ProvinciaRetiroComboBox.SelectedItem == null) return;

            Provincia prov = (Provincia)ProvinciaRetiroComboBox.SelectedItem;
            var localidades = modelo.ObtenerLocalidadesPorProvincia(prov.ProvinciaId);

            LocalidadRetiroComboBox.DataSource = localidades;
            LocalidadRetiroComboBox.DisplayMember = "Nombre";
            LocalidadRetiroComboBox.ValueMember = "LocalidadId";
            LocalidadRetiroComboBox.SelectedIndex = -1;
            LocalidadRetiroComboBox.Enabled = true;
        }

        // Carga de localidades de entrega según provincia seleccionada
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

            if (ProvinciaEntregaComboBox.SelectedItem == null) return;

            Provincia prov = (Provincia)ProvinciaEntregaComboBox.SelectedItem;
            var localidades = modelo.ObtenerLocalidadesPorProvincia(prov.ProvinciaId);

            LocalidadEntregaComboBox.DataSource = localidades;
            LocalidadEntregaComboBox.DisplayMember = "Nombre";
            LocalidadEntregaComboBox.ValueMember = "LocalidadId";
            LocalidadEntregaComboBox.SelectedIndex = -1;
            LocalidadEntregaComboBox.Enabled = true;
        }

        // Carga de opciones de tipo de entrega según localidad seleccionada
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

            if (LocalidadEntregaComboBox.SelectedItem == null) return;

            Localidad loc = (Localidad)LocalidadEntregaComboBox.SelectedItem;
            var agencias = modelo.ObtenerAgenciasPorLocalidad(loc.LocalidadId);
            var cds = modelo.ObtenerCDsPorLocalidad(loc.LocalidadId);

            if (cds.Count > 0)
                TipoEntregaComboBox.Items.Add("CD");

            if (agencias.Count > 0)
                TipoEntregaComboBox.Items.Add("Agencia");

            // A domicilio siempre disponible
            TipoEntregaComboBox.Items.Add("A domicilio");

            TipoEntregaComboBox.Enabled = true;
        }

        // Muestra el destino correspondiente según el tipo de entrega elegido
        private void TipoEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DestinoComboBox.DataSource = null;
            DestinoComboBox.Enabled = false;
            DestinoComboBox.Visible = false;
            labelDestino.Visible = false;
            panel1.Visible = false;

            if (TipoEntregaComboBox.SelectedItem == null) return;

            string tipoSeleccionado = TipoEntregaComboBox.SelectedItem.ToString();
            Localidad loc = (Localidad)LocalidadEntregaComboBox.SelectedItem;

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
                DestinoComboBox.DisplayMember = "RazonSocial";
                DestinoComboBox.ValueMember = "AgenciaId";
                DestinoComboBox.SelectedIndex = -1;
                DestinoComboBox.Enabled = true;
                DestinoComboBox.Visible = true;
                labelDestino.Visible = true;
            }

            ActualizarTotales();
        }

        // Validación del formato de código postal
        private bool ValidarCodigoPostal(string cp)
        {
            if (string.IsNullOrWhiteSpace(cp)) return true;
            bool tieneLetras = false;
            bool tieneNumeros = false;

            foreach (char c in cp)
            {
                if (char.IsLetter(c)) tieneLetras = true;
                if (char.IsDigit(c)) tieneNumeros = true;
            }

            if (tieneLetras && !tieneNumeros) return false;
            return true;
        }

        // Actualización del contador de guías a generar
        private void ActualizarTotales()
        {
            int cantS = 0;
            int cantM = 0;
            int cantL = 0;
            int cantXL = 0;
            int.TryParse(CantidadSTextBox.Text, out cantS);
            int.TryParse(CantidadMTextBox.Text, out cantM);
            int.TryParse(CantidadLTextBox.Text, out cantL);
            int.TryParse(CantidadXLTextBox.Text, out cantXL);

            int totalGuias = cantS + cantM + cantL + cantXL;
            Total_Guias_Label.Text = totalGuias.ToString();
        }

        // Resolución de la modalidad de entrega según selección del usuario
        private ModalidadEntregaEnum ResolverModalidadEntrega()
        {
            if (TipoEntregaComboBox.SelectedItem == null)
                return ModalidadEntregaEnum.CD;

            string tipo = TipoEntregaComboBox.SelectedItem.ToString();

            if (tipo == "A domicilio") return ModalidadEntregaEnum.DOMICILIO;
            if (tipo == "Agencia") return ModalidadEntregaEnum.AGENCIA;
            return ModalidadEntregaEnum.CD;
        }

        private void CantidadSTextBox_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void CantidadMTextBox_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void CantidadLTextBox_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void CantidadXLTextBox_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        // Confirmación y registro de la imposición
        private void button3_Click(object sender, EventArgs e)
        {
            // Validar remitente
            if (modelo.clienteActual == null)
            {
                MessageBox.Show("Debe seleccionar un remitente antes de confirmar.");
                return;
            }

            // Validar nombre destinatario
            if (string.IsNullOrWhiteSpace(NombreDestinatarioTextBox.Text))
            {
                MessageBox.Show("El nombre del destinatario debe ser válido (solo letras).");
                return;
            }
            foreach (char c in NombreDestinatarioTextBox.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("El nombre del destinatario debe ser válido (solo letras).");
                    return;
                }
            }

            // Validar apellido destinatario
            if (string.IsNullOrWhiteSpace(ApellidoDestinatarioTextBox.Text))
            {
                MessageBox.Show("El apellido del destinatario debe ser válido (solo letras).");
                return;
            }
            foreach (char c in ApellidoDestinatarioTextBox.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("El apellido del destinatario debe ser válido (solo letras).");
                    return;
                }
            }

            // Validar DNI
            if (!int.TryParse(DNIDestinatarioTextBox.Text, out int dni) ||
                DNIDestinatarioTextBox.Text.Length < 7 ||
                DNIDestinatarioTextBox.Text.Length > 8)
            {
                MessageBox.Show("Ingresá un DNI válido (7-8 dígitos).");
                return;
            }

            // Validar CP de retiro solo si la imposición es a domicilio (telefónica)
            if (modelo.ModalidadImposicionActual == ModalidadImposicionEnum.DOMICILIO &&
                !ValidarCodigoPostal(CPRetiroTextBox.Text))
            {
                MessageBox.Show("El código postal de retiro es incorrecto.");
                return;
            }

            // Validar datos de entrega
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

            // Validar cantidades de encomiendas
            bool cantidadesValidas = true;
            if (!string.IsNullOrWhiteSpace(CantidadSTextBox.Text))
            {
                foreach (char c in CantidadSTextBox.Text)
                    if (!char.IsDigit(c)) cantidadesValidas = false;
            }
            if (!string.IsNullOrWhiteSpace(CantidadMTextBox.Text))
            {
                foreach (char c in CantidadMTextBox.Text)
                    if (!char.IsDigit(c)) cantidadesValidas = false;
            }
            if (!string.IsNullOrWhiteSpace(CantidadLTextBox.Text))
            {
                foreach (char c in CantidadLTextBox.Text)
                    if (!char.IsDigit(c)) cantidadesValidas = false;
            }
            if (!string.IsNullOrWhiteSpace(CantidadXLTextBox.Text))
            {
                foreach (char c in CantidadXLTextBox.Text)
                    if (!char.IsDigit(c)) cantidadesValidas = false;
            }

            if (!cantidadesValidas)
            {
                MessageBox.Show("Las cantidades de encomiendas deben ser valores numéricos enteros.");
                return;
            }

            int cantS = 0;
            int cantM = 0;
            int cantL = 0;
            int cantXL = 0;
            int.TryParse(CantidadSTextBox.Text, out cantS);
            int.TryParse(CantidadMTextBox.Text, out cantM);
            int.TryParse(CantidadLTextBox.Text, out cantL);
            int.TryParse(CantidadXLTextBox.Text, out cantXL);

            if (cantS + cantM + cantL + cantXL == 0)
            {
                MessageBox.Show("Indicá al menos una encomienda (S/M/L/XL).");
                return;
            }

            ModalidadEntregaEnum modalidadEntrega = ResolverModalidadEntrega();

            // Determinación del domicilio y destino de entrega
            Domicilio domicilioEntrega = null;
            int agenciaDestinoId = 0;
            bool tieneAgenciaDestino = false;
            int cdDestinoId = ImposicionModelo.cdTrabajoId;

            if (tipoSeleccionado == "Agencia" && DestinoComboBox.SelectedItem != null)
            {
                Agencia agencia = (Agencia)DestinoComboBox.SelectedItem;
                agenciaDestinoId = agencia.AgenciaId;
                tieneAgenciaDestino = true;
                domicilioEntrega = agencia.Domicilio;
                cdDestinoId = agencia.CDAsignadoId;
            }
            else if (tipoSeleccionado == "CD" && DestinoComboBox.SelectedItem != null)
            {
                CentroDistribucion cd = (CentroDistribucion)DestinoComboBox.SelectedItem;
                domicilioEntrega = cd.Domicilio;
                cdDestinoId = cd.CDId;
            }
            else if (tipoSeleccionado == "A domicilio")
            {
                int localidadEntregaId = 0;
                if (LocalidadEntregaComboBox.SelectedItem != null)
                {
                    Localidad localidadEntrega = (Localidad)LocalidadEntregaComboBox.SelectedItem;
                    localidadEntregaId = localidadEntrega.LocalidadId;
                }
                domicilioEntrega = new Domicilio
                {
                    Calle = DireccionDomicilioTextBox.Text,
                    CodigoPostal = CPDomicilioTextBox.Text,
                    LocalidadId = localidadEntregaId
                };

                // Entrega a domicilio: el CD de destino se resuelve por el CP de entrega ingresado.
                cdDestinoId = modelo.ResolverCDActualIdPorCodigoPostal(CPDomicilioTextBox.Text) ?? cdDestinoId;
            }

            // Determinación del domicilio de retiro
            Domicilio domicilioRetiro;
            if (DomicilioFiscalCheck.Checked)
            {
                domicilioRetiro = modelo.clienteActual.Domicilio;
            }
            else
            {
                int localidadRetiroId = 0;
                if (LocalidadRetiroComboBox.SelectedItem != null)
                {
                    Localidad localidadRetiro = (Localidad)LocalidadRetiroComboBox.SelectedItem;
                    localidadRetiroId = localidadRetiro.LocalidadId;
                }
                domicilioRetiro = new Domicilio
                {
                    Calle        = DireccionRetiroTextBox.Text,
                    CodigoPostal = CPRetiroTextBox.Text,
                    LocalidadId  = localidadRetiroId
                };
            }

            // Registro de guías por tipo de caja
            string detalle = "";
            for (int i = 0; i < cantS; i++)
            {
                Guia guia = new Guia();
                guia.ClienteId            = modelo.clienteActual.ClienteId;
                guia.CDDestinoId          = cdDestinoId;
                modelo.AsignarDatosOrigen(guia, domicilioRetiro);
                guia.ModalidadEntrega     = modalidadEntrega;
                guia.AgenciaDestinoId     = tieneAgenciaDestino ? agenciaDestinoId : (int?)null;
                guia.DomicilioEntrega     = domicilioEntrega;
                guia.NombreDestinatario   = NombreDestinatarioTextBox.Text.Trim();
                guia.ApellidoDestinatario = ApellidoDestinatarioTextBox.Text.Trim();
                guia.DNIDestinatario      = dni;
                guia.TipoCaja             = TipoCajaEnum.S;
                guia.IntentosDeEntrega    = 0;
                guia.TarifarioId          = 1;
                modelo.RegistrarGuia(guia);
                detalle = detalle + guia.GuiaId.ToString("D8") + " (S)\n";
            }

            for (int i = 0; i < cantM; i++)
            {
                Guia guia = new Guia();
                guia.ClienteId            = modelo.clienteActual.ClienteId;
                guia.CDDestinoId          = cdDestinoId;
                modelo.AsignarDatosOrigen(guia, domicilioRetiro);
                guia.ModalidadEntrega     = modalidadEntrega;
                guia.AgenciaDestinoId     = tieneAgenciaDestino ? agenciaDestinoId : (int?)null;
                guia.DomicilioEntrega     = domicilioEntrega;
                guia.NombreDestinatario   = NombreDestinatarioTextBox.Text.Trim();
                guia.ApellidoDestinatario = ApellidoDestinatarioTextBox.Text.Trim();
                guia.DNIDestinatario      = dni;
                guia.TipoCaja             = TipoCajaEnum.M;
                guia.IntentosDeEntrega    = 0;
                guia.TarifarioId          = 1;
                modelo.RegistrarGuia(guia);
                detalle = detalle + guia.GuiaId.ToString("D8") + " (M)\n";
            }

            for (int i = 0; i < cantL; i++)
            {
                Guia guia = new Guia();
                guia.ClienteId            = modelo.clienteActual.ClienteId;
                guia.CDDestinoId          = cdDestinoId;
                modelo.AsignarDatosOrigen(guia, domicilioRetiro);
                guia.ModalidadEntrega     = modalidadEntrega;
                guia.AgenciaDestinoId     = tieneAgenciaDestino ? agenciaDestinoId : (int?)null;
                guia.DomicilioEntrega     = domicilioEntrega;
                guia.NombreDestinatario   = NombreDestinatarioTextBox.Text.Trim();
                guia.ApellidoDestinatario = ApellidoDestinatarioTextBox.Text.Trim();
                guia.DNIDestinatario      = dni;
                guia.TipoCaja             = TipoCajaEnum.L;
                guia.IntentosDeEntrega    = 0;
                guia.TarifarioId          = 1;
                modelo.RegistrarGuia(guia);
                detalle = detalle + guia.GuiaId.ToString("D8") + " (L)\n";
            }

            for (int i = 0; i < cantXL; i++)
            {
                Guia guia = new Guia();
                guia.ClienteId            = modelo.clienteActual.ClienteId;
                guia.CDDestinoId          = cdDestinoId;
                modelo.AsignarDatosOrigen(guia, domicilioRetiro);
                guia.ModalidadEntrega     = modalidadEntrega;
                guia.AgenciaDestinoId     = tieneAgenciaDestino ? agenciaDestinoId : (int?)null;
                guia.DomicilioEntrega     = domicilioEntrega;
                guia.NombreDestinatario   = NombreDestinatarioTextBox.Text.Trim();
                guia.ApellidoDestinatario = ApellidoDestinatarioTextBox.Text.Trim();
                guia.DNIDestinatario      = dni;
                guia.TipoCaja             = TipoCajaEnum.XL;
                guia.IntentosDeEntrega    = 0;
                guia.TarifarioId          = 1;
                modelo.RegistrarGuia(guia);
                detalle = detalle + guia.GuiaId.ToString("D8") + " (XL)\n";
            }

            MessageBox.Show("Operación confirmada. Guías generadas exitosamente:\n" + detalle);

            LimpiarFormulario();
        }

        // Cancelación de la operación y cierre del formulario
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Si sale se eliminarán los datos ingresados. ¿Salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Operación cancelada. No se ha registrado ninguna solicitud de imposición.");
                this.Close();
            }
        }

        // Limpieza de todos los campos del formulario
        private void LimpiarFormulario()
        {
            modelo.clienteActual = null;

            CuitRemitente_TextBox.Clear();
            NombreRemitenteLabel.Text = string.Empty;
            TelefonoRemitenteLabel.Text = string.Empty;
            DireccionRemitenteLabel.Text = string.Empty;

            DomicilioFiscalCheck.Checked = false;
            label37.Visible = false;
            label37.Text = string.Empty;
            ProvinciaRetiroComboBox.SelectedIndex = -1;
            LocalidadRetiroComboBox.DataSource = null;
            LocalidadRetiroComboBox.Enabled = false;
            DireccionRetiroTextBox.Clear();
            CPRetiroTextBox.Clear();

            NombreDestinatarioTextBox.Clear();
            ApellidoDestinatarioTextBox.Clear();
            DNIDestinatarioTextBox.Clear();

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

            CantidadSTextBox.Clear();
            CantidadMTextBox.Clear();
            CantidadLTextBox.Clear();
            CantidadXLTextBox.Clear();

            Total_Guias_Label.Text = "[Total Guias]";

        }

        // Formateo del domicilio para mostrar en pantalla
        private string FormatearDomicilio(Domicilio d)
        {
            if (d == null) return string.Empty;

            string resultado = "";

            if (!string.IsNullOrWhiteSpace(d.Calle))
                resultado = resultado + d.Calle + " ";

            if (!string.IsNullOrWhiteSpace(d.Numero))
                resultado = resultado + d.Numero + " ";

            if (!string.IsNullOrWhiteSpace(d.Piso))
                resultado = resultado + "P" + d.Piso + " ";

            if (!string.IsNullOrWhiteSpace(d.Depto))
                resultado = resultado + "D" + d.Depto + " ";

            return resultado.Trim();
        }

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
        private void label16_Click(object sender, EventArgs e) { }
        private void CPDomicilioTextBox_TextChanged(object sender, EventArgs e) { ActualizarTotales(); }
        private void CPRetiroTextBox_TextChanged(object sender, EventArgs e) { }
        private void CuitRemitenteTextBox_TextChanged(object sender, EventArgs e) { }
    }
}
