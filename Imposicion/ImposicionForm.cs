using GrupoE_Tutasa.MonitoreoResultados;

namespace GrupoE_Tutasa.Imposicion
{
    public partial class ImposicionForm : Form
    {
        private ImposicionModelo modelo = new();

        public ImposicionForm()
        {
            InitializeComponent();
            button2.Click += button2_Click;  // Cancelar (no tiene Click en el Designer)
        }

        // Variable de estado: remitente encontrado al buscar por CUIT
        private ClienteRemitente clienteActual = null;

        // ─────────────────────────────────────────────
        // CARGA DEL FORMULARIO
        // ─────────────────────────────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            /* El formulario aún no es visible. Se cargan los datos del modelo
               para inicializar los controles antes de que el usuario interactúe. */

            // comboBox1 = Provincia (Datos para la Entrega)
            comboBox1.DataSource = modelo.LProvincias;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "ProvinciaId";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // comboBox2 = Localidad entrega → deshabilitado hasta elegir provincia
            comboBox2.Enabled = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            // comboBox3 = Agencia, comboBox4 = CD → deshabilitados al inicio
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;

          
            // radioButton2 ya tiene CheckedChanged en el Designer

            // textBoxes de cantidades → suscribir eventos
            textBox10.TextChanged += textBox10_TextChanged;
            textBox11.TextChanged += textBox11_TextChanged;
            textBox12.TextChanged += textBox12_TextChanged;
            textBox13.TextChanged += textBox13_TextChanged;

            // panel1 = panel "Entrega a domicilio" → oculto al inicio
            panel1.Visible = false;

            // Limpiar labels de respuesta del remitente
            // label27 = Nombre, label28 = Teléfono, label29 = Dirección
            label27.Text = string.Empty;
            label28.Text = string.Empty;
            label29.Text = string.Empty;

            // Limpiar totales
            // label31 = Total Bultos, label32 = Guías a Generar, label33 = Importe Estimado
            label31.Text = "[Total]";
            label32.Text = "[Guias]";
            label33.Text = "[ $... ]";

            // MEJORAS DEL FORMULARIO

            // Cargar provincias en comboBox6 (Provincia - Domicilio de retiro)
            comboBox6.DataSource = modelo.LProvincias;
            comboBox6.DisplayMember = "Nombre";
            comboBox6.ValueMember = "ProvinciaId";
            comboBox6.SelectedIndex = -1;

            // comboBox5 = Localidad retiro → deshabilitado hasta elegir provincia
            comboBox5.Enabled = false;

            // Suscribir eventos del checkbox y cascada de retiro
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
        }

        // ─────────────────────────────────────────────
        // BUSCAR REMITENTE POR CUIT
        // button1 = Buscar, textBox1 = campo CUIT
        // label27 = Nombre, label28 = Teléfono, label29 = Dirección
        // ─────────────────────────────────────────────
        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar búsqueda anterior
            clienteActual = null;
            label27.Text = string.Empty;
            label28.Text = string.Empty;
            label29.Text = string.Empty;

            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Es necesario que ingrese un dato.");
                return;
            }

            // Validar formato de CUIT
            if (!ImposicionModelo.ValidarCuit(textBox1.Text))
            {
                MessageBox.Show("Ingresá un CUIT válido.");
                textBox1.Clear();
                return;
            }

            if (!long.TryParse(textBox1.Text, out long cuit))
            {
                MessageBox.Show("El CUIT debe ser un número válido.");
                return;
            }

            // Buscar cliente en el modelo
            int encuentro = 0;
            foreach (var cliente in modelo.LClientes)
            {
                if (cliente.CUIT == cuit)
                {
                    clienteActual = cliente;
                    label27.Text = cliente.Nombre;
                    label28.Text = cliente.Telefono;
                    label29.Text = cliente.Direccion;
                    encuentro = 1;
                }
            }

            if (encuentro == 0)
            {
                MessageBox.Show("Ingresá un CUIT válido.");
                textBox1.Clear();
            }
        }


        //MEJORAS

        // Método nuevo: toggle del domicilio fiscal
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool fiscal = checkBox1.Checked;

            // Deshabilitar/habilitar los controles manuales de retiro
            comboBox6.Enabled = !fiscal;   // Provincia retiro
            comboBox5.Enabled = !fiscal;   // Localidad retiro
            textBox8.Enabled = !fiscal;   // Dirección retiro
            textBox9.Enabled = !fiscal;   // CP retiro
        }

        // Método nuevo: cascada Provincia → Localidad en Domicilio de retiro
        // comboBox6 = Provincia retiro, comboBox5 = Localidad retiro
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.DataSource = null;
            comboBox5.Enabled = false;

            if (comboBox6.SelectedItem is not Provincia provinciaSeleccionada)
                return;

            var localidades = modelo.ObtenerLocalidadesPorProvincia(provinciaSeleccionada.ProvinciaId);
            comboBox5.DataSource = localidades;
            comboBox5.DisplayMember = "Nombre";
            comboBox5.ValueMember = "LocalidadId";
            comboBox5.SelectedIndex = -1;
            comboBox5.Enabled = true;
        }

        // ─────────────────────────────────────────────
        // CASCADA PROVINCIA → LOCALIDAD
        // comboBox1 = Provincia, comboBox2 = Localidad
        // ─────────────────────────────────────────────
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox3.DataSource = null;
            comboBox4.DataSource = null;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;

            if (comboBox1.SelectedItem is not Provincia provinciaSeleccionada)
                return;

            var localidades = modelo.ObtenerLocalidadesPorProvincia(provinciaSeleccionada.ProvinciaId);
            comboBox2.DataSource = localidades;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "LocalidadId";
            comboBox2.SelectedIndex = -1;
            comboBox2.Enabled = true;
        }

        // ─────────────────────────────────────────────
        // CASCADA LOCALIDAD → AGENCIAS / CDs
        // comboBox2 = Localidad, comboBox3 = Agencia, comboBox4 = CD
        // ─────────────────────────────────────────────
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Resetear todo
            comboBox3.DataSource = null;
            comboBox4.DataSource = null;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;

            if (comboBox2.SelectedItem is not Localidad localidadSeleccionada)
                return;

            var agencias = modelo.ObtenerAgenciasPorLocalidad(localidadSeleccionada.LocalidadId);
            var cds = modelo.ObtenerCDsPorLocalidad(localidadSeleccionada.LocalidadId);

            // Mostrar y cargar Agencia solo si hay disponibles
            if (agencias.Count > 0)
            {
                comboBox3.DataSource = agencias;
                comboBox3.DisplayMember = "Nombre";
                comboBox3.ValueMember = "AgenciaId";
                comboBox3.SelectedIndex = -1;
                comboBox3.Visible = true;
                comboBox3.Enabled = true;
            }

            // Mostrar y cargar CD solo si hay disponibles
            if (cds.Count > 0)
            {
                comboBox4.DataSource = cds;
                comboBox4.DisplayMember = "Nombre";
                comboBox4.ValueMember = "CDId";
                comboBox4.SelectedIndex = -1;
                comboBox4.Visible = true;
                comboBox4.Enabled = true;
            }
        }

        // ─────────────────────────────────────────────
        // SELECCIÓN TIPO DE ENTREGA
        // radioButton1 = Agencia, radioButton3 = CD, radioButton2 = Domicilio
        // panel1 = panel "Entrega a domicilio"
        // ─────────────────────────────────────────────
      

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = radioButton2.Checked;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
        }

        // ─────────────────────────────────────────────
        // CÁLCULO AUTOMÁTICO DE TOTALES
        // textBox10=cantS, textBox11=cantM, textBox12=cantL, textBox13=cantXL
        // label31=Total Bultos, label32=Guías, label33=Importe Estimado
        // ─────────────────────────────────────────────
        private void ActualizarTotales()
        {
            int.TryParse(textBox10.Text, out int cantS);
            int.TryParse(textBox11.Text, out int cantM);
            int.TryParse(textBox12.Text, out int cantL);
            int.TryParse(textBox13.Text, out int cantXL);

            int totalBultos = cantS + cantM + cantL + cantXL;
            label31.Text = totalBultos.ToString();
            label32.Text = totalBultos.ToString();  // 1 guía por bulto

            decimal importe = modelo.CalcularImporteEstimado(cantS, cantM, cantL, cantXL);
            label33.Text = $"$ {importe:N2}";
        }

        private void textBox10_TextChanged(object sender, EventArgs e) => ActualizarTotales();
        private void textBox11_TextChanged(object sender, EventArgs e) => ActualizarTotales();
        private void textBox12_TextChanged(object sender, EventArgs e) => ActualizarTotales();
        private void textBox13_TextChanged(object sender, EventArgs e) => ActualizarTotales();

        // ─────────────────────────────────────────────
        // CONFIRMAR
        // button3 = Confirmar
        // ─────────────────────────────────────────────
        private void button3_Click(object sender, EventArgs e)
        {
            // Validar remitente
            if (clienteActual == null)
            {
                MessageBox.Show("Debe seleccionar un remitente antes de confirmar.");
                return;
            }

            // Validar Nombre destinatario (textBox5)
            if (string.IsNullOrWhiteSpace(textBox5.Text) ||
                !textBox5.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre y Apellido deben ser válidos (solo letras).");
                return;
            }

            // Validar Apellido destinatario (textBox7)
            if (string.IsNullOrWhiteSpace(textBox7.Text) ||
                !textBox7.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre y Apellido deben ser válidos (solo letras).");
                return;
            }

            // Validar DNI destinatario (textBox6)
            if (!long.TryParse(textBox6.Text, out long dni) ||
                textBox6.Text.Length < 7 || textBox6.Text.Length > 8)
            {
                MessageBox.Show("Ingresá un DNI válido (7-8 dígitos).");
                return;
            }

            // Validar provincia destino (comboBox1)
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una provincia.");
                return;
            }

            // Validar localidad destino (comboBox2)
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una localidad.");
                return;
            }

            // Validar tipo de entrega
            if (!radioButton2.Checked && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná el tipo de entrega: elegí una Agencia, un CD, o marcá Domicilio.");
                return;
            }

            // Validar dirección domicilio (textBox2)
            if (radioButton2.Checked && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingresá una dirección válida.");
                return;
            }

            // Validar cantidades
            int.TryParse(textBox10.Text, out int cantS);
            int.TryParse(textBox11.Text, out int cantM);
            int.TryParse(textBox12.Text, out int cantL);
            int.TryParse(textBox13.Text, out int cantXL);

            if (cantS + cantM + cantL + cantXL == 0)
            {
                MessageBox.Show("Indicá al menos una encomienda (S/M/L/XL).");
                return;
            }

            // Determinar tipo de entrega y datos del destino
            // Ya no se usan radioButton1/radioButton3 — se detecta por el comboBox seleccionado
            string tipoEntrega = radioButton2.Checked ? "Domicilio" :
                                   comboBox3.SelectedIndex != -1 ? "Agencia" : "CD";
            string direccionDest = string.Empty;
            string cpDest = string.Empty;

            if (comboBox3.SelectedItem is Agencia agencia)
            {
                direccionDest = agencia.Direccion;
                cpDest = agencia.CodigoPostal;
            }
            else if (comboBox4.SelectedItem is CentroDistribucion cd)
            {
                direccionDest = cd.Direccion;
                cpDest = cd.CodigoPostal;
            }
            else if (radioButton2.Checked)
            {
                direccionDest = textBox2.Text;
                cpDest = textBox3.Text;
            }

            // Registrar una guía por cada encomienda
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
                        NombreDestinatario = textBox5.Text,
                        ApellidoDestinatario = textBox7.Text,
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
        // button2 = Cancelar (evento suscripto en el constructor)
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
        // LIMPIEZA DEL FORMULARIO
        // ─────────────────────────────────────────────
        private void LimpiarFormulario()
        {
            clienteActual = null;

            // Sección remitente
            textBox1.Clear();
            label27.Text = string.Empty;
            label28.Text = string.Empty;
            label29.Text = string.Empty;

            // Sección destinatario
            textBox5.Clear();   // Nombre
            textBox7.Clear();   // Apellido
            textBox6.Clear();   // DNI

            // Sección entrega
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = null;
            comboBox2.Enabled = false;
            radioButton2.Checked = false;
            comboBox3.DataSource = null;
            comboBox3.Enabled = false;
            comboBox3.Visible = false;
            comboBox4.DataSource = null;
            comboBox4.Enabled = false;
            comboBox4.Visible = false;
            panel1.Visible = false;
            textBox2.Clear();   // Dirección domicilio
            textBox3.Clear();   // CP domicilio

            // Sección cantidades
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();

            // Totales
            label31.Text = "[Total]";
            label32.Text = "[Guias]";
            label33.Text = "[ $... ]";
        }
        // ─────────────────────────────────────────────
        // HANDLERS REQUERIDOS POR EL DESIGNER (sin lógica)
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
        private void textBox3_TextChanged(object sender, EventArgs e) => ActualizarTotales();
    }
}
