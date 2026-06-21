namespace GrupoE_Tutasa.Imposicion
{
    partial class ImposicionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            NombreRemitenteLabel = new Label();
            TelefonoRemitenteLabel = new Label();
            DireccionRemitenteLabel = new Label();
            DireccionRemitente_Label = new Label();
            TelefonoRemitente_Label = new Label();
            NombreRemitente_Label = new Label();
            CuitRemitente_TextBox = new TextBox();
            Cuit_Remitente_Label = new Label();
            panel3 = new Panel();
            BuscarRemitente_Boton = new Button();
            groupBox5 = new GroupBox();
            DomicilioFiscalCheck = new CheckBox();
            label37 = new Label();
            DireccionFiscal_Label = new Label();
            ProvinciaRetiroComboBox = new ComboBox();
            Provincia_Retiro_Label = new Label();
            LocalidadRetiroComboBox = new ComboBox();
            Localidad_Retiro_Label = new Label();
            DireccionRetiroTextBox = new TextBox();
            Direccion_retiro_Label = new Label();
            CPRetiroTextBox = new TextBox();
            CP_Retiro_Label = new Label();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            NombreDestinatarioTextBox = new TextBox();
            NombreDestinatario_Label = new Label();
            ApellidoDestinatarioTextBox = new TextBox();
            ApellidoDestinatario_Label = new Label();
            DNIDestinatarioTextBox = new TextBox();
            DniDestinatario_Label = new Label();
            groupBox3 = new GroupBox();
            ProvinciaEntregaComboBox = new ComboBox();
            label10 = new Label();
            LocalidadEntregaComboBox = new ComboBox();
            label9 = new Label();
            TipoEntregaComboBox = new ComboBox();
            label8 = new Label();
            DestinoComboBox = new ComboBox();
            labelDestino = new Label();
            panel1 = new Panel();
            EntregaDomicilio_Titulo_Label = new Label();
            DireccionDomicilioTextBox = new TextBox();
            Direccion_Entrega_Label = new Label();
            CPDomicilioTextBox = new TextBox();
            CP_Entrega_Label = new Label();
            groupBox4 = new GroupBox();
            GuiasAgenerar_Label = new Label();
            CantidadSTextBox = new TextBox();
            TipoS_Encomienda_Label = new Label();
            Total_Guias_Label = new Label();
            CantidadMTextBox = new TextBox();
            TipoM_Encomienda_Label = new Label();
            CantidadLTextBox = new TextBox();
            TipoL_Encomienda_Label = new Label();
            CantidadXLTextBox = new TextBox();
            TipoXL_Encomienda_Label = new Label();
            Indicaciones_Encomienda_Label = new Label();
            label20 = new Label();
            Cancelar_Boton = new Button();
            Confirmar_Boton = new Button();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NombreRemitenteLabel);
            groupBox1.Controls.Add(TelefonoRemitenteLabel);
            groupBox1.Controls.Add(DireccionRemitenteLabel);
            groupBox1.Controls.Add(DireccionRemitente_Label);
            groupBox1.Controls.Add(TelefonoRemitente_Label);
            groupBox1.Controls.Add(NombreRemitente_Label);
            groupBox1.Controls.Add(CuitRemitente_TextBox);
            groupBox1.Controls.Add(Cuit_Remitente_Label);
            groupBox1.Controls.Add(panel3);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 33);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(831, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Remitente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // NombreRemitenteLabel
            // 
            NombreRemitenteLabel.AutoSize = true;
            NombreRemitenteLabel.Location = new Point(647, 19);
            NombreRemitenteLabel.Name = "NombreRemitenteLabel";
            NombreRemitenteLabel.Size = new Size(0, 15);
            NombreRemitenteLabel.TabIndex = 22;
            // 
            // TelefonoRemitenteLabel
            // 
            TelefonoRemitenteLabel.AutoSize = true;
            TelefonoRemitenteLabel.Location = new Point(551, 47);
            TelefonoRemitenteLabel.Name = "TelefonoRemitenteLabel";
            TelefonoRemitenteLabel.Size = new Size(0, 15);
            TelefonoRemitenteLabel.TabIndex = 23;
            // 
            // DireccionRemitenteLabel
            // 
            DireccionRemitenteLabel.AutoSize = true;
            DireccionRemitenteLabel.Location = new Point(557, 77);
            DireccionRemitenteLabel.Name = "DireccionRemitenteLabel";
            DireccionRemitenteLabel.Size = new Size(0, 15);
            DireccionRemitenteLabel.TabIndex = 24;
            // 
            // DireccionRemitente_Label
            // 
            DireccionRemitente_Label.AutoSize = true;
            DireccionRemitente_Label.Location = new Point(484, 77);
            DireccionRemitente_Label.Name = "DireccionRemitente_Label";
            DireccionRemitente_Label.Size = new Size(64, 15);
            DireccionRemitente_Label.TabIndex = 7;
            DireccionRemitente_Label.Text = "Dirección:";
            DireccionRemitente_Label.Click += label4_Click;
            // 
            // TelefonoRemitente_Label
            // 
            TelefonoRemitente_Label.AutoSize = true;
            TelefonoRemitente_Label.Location = new Point(484, 47);
            TelefonoRemitente_Label.Name = "TelefonoRemitente_Label";
            TelefonoRemitente_Label.Size = new Size(58, 15);
            TelefonoRemitente_Label.TabIndex = 5;
            TelefonoRemitente_Label.Text = "Telefono:";
            TelefonoRemitente_Label.Click += label3_Click;
            // 
            // NombreRemitente_Label
            // 
            NombreRemitente_Label.AutoSize = true;
            NombreRemitente_Label.Location = new Point(484, 19);
            NombreRemitente_Label.Name = "NombreRemitente_Label";
            NombreRemitente_Label.Size = new Size(140, 15);
            NombreRemitente_Label.TabIndex = 3;
            NombreRemitente_Label.Text = "Nombre / Razon Social :";
            // 
            // CuitRemitente_TextBox
            // 
            CuitRemitente_TextBox.Location = new Point(153, 30);
            CuitRemitente_TextBox.Margin = new Padding(4, 3, 4, 3);
            CuitRemitente_TextBox.Name = "CuitRemitente_TextBox";
            CuitRemitente_TextBox.Size = new Size(116, 21);
            CuitRemitente_TextBox.TabIndex = 1;
            // 
            // Cuit_Remitente_Label
            // 
            Cuit_Remitente_Label.AutoSize = true;
            Cuit_Remitente_Label.Location = new Point(66, 33);
            Cuit_Remitente_Label.Name = "Cuit_Remitente_Label";
            Cuit_Remitente_Label.Size = new Size(33, 15);
            Cuit_Remitente_Label.TabIndex = 0;
            Cuit_Remitente_Label.Text = "CUIT";
            // 
            // panel3
            // 
            panel3.Controls.Add(BuscarRemitente_Boton);
            panel3.Location = new Point(58, 17);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 48);
            panel3.TabIndex = 21;
            // 
            // BuscarRemitente_Boton
            // 
            BuscarRemitente_Boton.ForeColor = Color.Black;
            BuscarRemitente_Boton.Location = new Point(268, 10);
            BuscarRemitente_Boton.Margin = new Padding(4, 3, 4, 3);
            BuscarRemitente_Boton.Name = "BuscarRemitente_Boton";
            BuscarRemitente_Boton.Size = new Size(88, 27);
            BuscarRemitente_Boton.TabIndex = 2;
            BuscarRemitente_Boton.Text = "Buscar";
            BuscarRemitente_Boton.UseVisualStyleBackColor = true;
            BuscarRemitente_Boton.Click += BuscarRemitenteBoton_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(DomicilioFiscalCheck);
            groupBox5.Controls.Add(label37);
            groupBox5.Controls.Add(DireccionFiscal_Label);
            groupBox5.Controls.Add(ProvinciaRetiroComboBox);
            groupBox5.Controls.Add(Provincia_Retiro_Label);
            groupBox5.Controls.Add(LocalidadRetiroComboBox);
            groupBox5.Controls.Add(Localidad_Retiro_Label);
            groupBox5.Controls.Add(DireccionRetiroTextBox);
            groupBox5.Controls.Add(Direccion_retiro_Label);
            groupBox5.Controls.Add(CPRetiroTextBox);
            groupBox5.Controls.Add(CP_Retiro_Label);
            groupBox5.Controls.Add(panel4);
            groupBox5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(24, 161);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(831, 143);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "Domicilio de retiro";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // DomicilioFiscalCheck
            // 
            DomicilioFiscalCheck.AutoSize = true;
            DomicilioFiscalCheck.Location = new Point(56, 38);
            DomicilioFiscalCheck.Name = "DomicilioFiscalCheck";
            DomicilioFiscalCheck.Size = new Size(114, 19);
            DomicilioFiscalCheck.TabIndex = 29;
            DomicilioFiscalCheck.Text = "Domicilio Fiscal";
            DomicilioFiscalCheck.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(128, 83);
            label37.Name = "label37";
            label37.Size = new Size(0, 15);
            label37.TabIndex = 26;
            label37.Visible = false;
            // 
            // DireccionFiscal_Label
            // 
            DireccionFiscal_Label.AutoSize = true;
            DireccionFiscal_Label.Location = new Point(56, 84);
            DireccionFiscal_Label.Name = "DireccionFiscal_Label";
            DireccionFiscal_Label.Size = new Size(64, 15);
            DireccionFiscal_Label.TabIndex = 25;
            DireccionFiscal_Label.Text = "Dirección:";
            // 
            // ProvinciaRetiroComboBox
            // 
            ProvinciaRetiroComboBox.FormattingEnabled = true;
            ProvinciaRetiroComboBox.Location = new Point(430, 22);
            ProvinciaRetiroComboBox.Margin = new Padding(4, 3, 4, 3);
            ProvinciaRetiroComboBox.Name = "ProvinciaRetiroComboBox";
            ProvinciaRetiroComboBox.Size = new Size(140, 23);
            ProvinciaRetiroComboBox.TabIndex = 25;
            // 
            // Provincia_Retiro_Label
            // 
            Provincia_Retiro_Label.AutoSize = true;
            Provincia_Retiro_Label.Location = new Point(357, 25);
            Provincia_Retiro_Label.Name = "Provincia_Retiro_Label";
            Provincia_Retiro_Label.Size = new Size(60, 15);
            Provincia_Retiro_Label.TabIndex = 23;
            Provincia_Retiro_Label.Text = "Provincia";
            // 
            // LocalidadRetiroComboBox
            // 
            LocalidadRetiroComboBox.FormattingEnabled = true;
            LocalidadRetiroComboBox.Location = new Point(669, 22);
            LocalidadRetiroComboBox.Margin = new Padding(4, 3, 4, 3);
            LocalidadRetiroComboBox.Name = "LocalidadRetiroComboBox";
            LocalidadRetiroComboBox.Size = new Size(140, 23);
            LocalidadRetiroComboBox.TabIndex = 26;
            // 
            // Localidad_Retiro_Label
            // 
            Localidad_Retiro_Label.AutoSize = true;
            Localidad_Retiro_Label.Location = new Point(596, 25);
            Localidad_Retiro_Label.Name = "Localidad_Retiro_Label";
            Localidad_Retiro_Label.Size = new Size(65, 15);
            Localidad_Retiro_Label.TabIndex = 24;
            Localidad_Retiro_Label.Text = "Localidad ";
            // 
            // DireccionRetiroTextBox
            // 
            DireccionRetiroTextBox.Location = new Point(453, 65);
            DireccionRetiroTextBox.Margin = new Padding(4, 3, 4, 3);
            DireccionRetiroTextBox.Name = "DireccionRetiroTextBox";
            DireccionRetiroTextBox.Size = new Size(245, 21);
            DireccionRetiroTextBox.TabIndex = 14;
            // 
            // Direccion_retiro_Label
            // 
            Direccion_retiro_Label.AutoSize = true;
            Direccion_retiro_Label.Location = new Point(355, 68);
            Direccion_retiro_Label.Name = "Direccion_retiro_Label";
            Direccion_retiro_Label.Size = new Size(64, 15);
            Direccion_retiro_Label.TabIndex = 21;
            Direccion_retiro_Label.Text = "Dirección ";
            // 
            // CPRetiroTextBox
            // 
            CPRetiroTextBox.Location = new Point(453, 104);
            CPRetiroTextBox.Margin = new Padding(4, 3, 4, 3);
            CPRetiroTextBox.Name = "CPRetiroTextBox";
            CPRetiroTextBox.Size = new Size(92, 21);
            CPRetiroTextBox.TabIndex = 23;
            CPRetiroTextBox.TextChanged += CPRetiroTextBox_TextChanged;
            // 
            // CP_Retiro_Label
            // 
            CP_Retiro_Label.AutoSize = true;
            CP_Retiro_Label.Location = new Point(355, 107);
            CP_Retiro_Label.Name = "CP_Retiro_Label";
            CP_Retiro_Label.Size = new Size(71, 15);
            CP_Retiro_Label.TabIndex = 22;
            CP_Retiro_Label.Text = "Cód. Postal";
            // 
            // panel4
            // 
            panel4.Location = new Point(37, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 59);
            panel4.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NombreDestinatarioTextBox);
            groupBox2.Controls.Add(NombreDestinatario_Label);
            groupBox2.Controls.Add(ApellidoDestinatarioTextBox);
            groupBox2.Controls.Add(ApellidoDestinatario_Label);
            groupBox2.Controls.Add(DNIDestinatarioTextBox);
            groupBox2.Controls.Add(DniDestinatario_Label);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 334);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(831, 70);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del destinatario";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // NombreDestinatarioTextBox
            // 
            NombreDestinatarioTextBox.Location = new Point(128, 35);
            NombreDestinatarioTextBox.Margin = new Padding(4, 3, 4, 3);
            NombreDestinatarioTextBox.Name = "NombreDestinatarioTextBox";
            NombreDestinatarioTextBox.Size = new Size(116, 21);
            NombreDestinatarioTextBox.TabIndex = 9;
            // 
            // NombreDestinatario_Label
            // 
            NombreDestinatario_Label.AutoSize = true;
            NombreDestinatario_Label.Location = new Point(55, 38);
            NombreDestinatario_Label.Name = "NombreDestinatario_Label";
            NombreDestinatario_Label.Size = new Size(55, 15);
            NombreDestinatario_Label.TabIndex = 9;
            NombreDestinatario_Label.Text = "Nombre ";
            // 
            // ApellidoDestinatarioTextBox
            // 
            ApellidoDestinatarioTextBox.Location = new Point(356, 36);
            ApellidoDestinatarioTextBox.Margin = new Padding(4, 3, 4, 3);
            ApellidoDestinatarioTextBox.Name = "ApellidoDestinatarioTextBox";
            ApellidoDestinatarioTextBox.Size = new Size(116, 21);
            ApellidoDestinatarioTextBox.TabIndex = 13;
            // 
            // ApellidoDestinatario_Label
            // 
            ApellidoDestinatario_Label.AutoSize = true;
            ApellidoDestinatario_Label.Location = new Point(294, 39);
            ApellidoDestinatario_Label.Name = "ApellidoDestinatario_Label";
            ApellidoDestinatario_Label.Size = new Size(55, 15);
            ApellidoDestinatario_Label.TabIndex = 12;
            ApellidoDestinatario_Label.Text = "Apellido ";
            // 
            // DNIDestinatarioTextBox
            // 
            DNIDestinatarioTextBox.Location = new Point(582, 37);
            DNIDestinatarioTextBox.Margin = new Padding(4, 3, 4, 3);
            DNIDestinatarioTextBox.Name = "DNIDestinatarioTextBox";
            DNIDestinatarioTextBox.Size = new Size(116, 21);
            DNIDestinatarioTextBox.TabIndex = 11;
            // 
            // DniDestinatario_Label
            // 
            DniDestinatario_Label.AutoSize = true;
            DniDestinatario_Label.Location = new Point(509, 40);
            DniDestinatario_Label.Name = "DniDestinatario_Label";
            DniDestinatario_Label.Size = new Size(29, 15);
            DniDestinatario_Label.TabIndex = 10;
            DniDestinatario_Label.Text = "DNI ";
            DniDestinatario_Label.Click += label6_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ProvinciaEntregaComboBox);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(LocalidadEntregaComboBox);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(TipoEntregaComboBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(DestinoComboBox);
            groupBox3.Controls.Add(labelDestino);
            groupBox3.Controls.Add(panel1);
            groupBox3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(32, 423);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(823, 202);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos para la Entrega";
            // 
            // ProvinciaEntregaComboBox
            // 
            ProvinciaEntregaComboBox.FormattingEnabled = true;
            ProvinciaEntregaComboBox.Location = new Point(128, 35);
            ProvinciaEntregaComboBox.Margin = new Padding(4, 3, 4, 3);
            ProvinciaEntregaComboBox.Name = "ProvinciaEntregaComboBox";
            ProvinciaEntregaComboBox.Size = new Size(140, 23);
            ProvinciaEntregaComboBox.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 38);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 9;
            label10.Text = "Provincia";
            label10.Click += label10_Click;
            // 
            // LocalidadEntregaComboBox
            // 
            LocalidadEntregaComboBox.FormattingEnabled = true;
            LocalidadEntregaComboBox.Location = new Point(128, 75);
            LocalidadEntregaComboBox.Margin = new Padding(4, 3, 4, 3);
            LocalidadEntregaComboBox.Name = "LocalidadEntregaComboBox";
            LocalidadEntregaComboBox.Size = new Size(140, 23);
            LocalidadEntregaComboBox.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 78);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 10;
            label9.Text = "Localidad ";
            label9.Click += label9_Click;
            // 
            // TipoEntregaComboBox
            // 
            TipoEntregaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TipoEntregaComboBox.FormattingEnabled = true;
            TipoEntregaComboBox.Location = new Point(128, 115);
            TipoEntregaComboBox.Margin = new Padding(4, 3, 4, 3);
            TipoEntregaComboBox.Name = "TipoEntregaComboBox";
            TipoEntregaComboBox.Size = new Size(140, 23);
            TipoEntregaComboBox.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 118);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 14;
            label8.Text = "Tipo Entrega:";
            // 
            // DestinoComboBox
            // 
            DestinoComboBox.FormattingEnabled = true;
            DestinoComboBox.Location = new Point(128, 155);
            DestinoComboBox.Margin = new Padding(4, 3, 4, 3);
            DestinoComboBox.Name = "DestinoComboBox";
            DestinoComboBox.Size = new Size(220, 23);
            DestinoComboBox.TabIndex = 15;
            DestinoComboBox.Visible = false;
            // 
            // labelDestino
            // 
            labelDestino.AutoSize = true;
            labelDestino.Location = new Point(55, 158);
            labelDestino.Name = "labelDestino";
            labelDestino.Size = new Size(53, 15);
            labelDestino.TabIndex = 15;
            labelDestino.Text = "Destino:";
            labelDestino.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(EntregaDomicilio_Titulo_Label);
            panel1.Controls.Add(DireccionDomicilioTextBox);
            panel1.Controls.Add(Direccion_Entrega_Label);
            panel1.Controls.Add(CPDomicilioTextBox);
            panel1.Controls.Add(CP_Entrega_Label);
            panel1.Location = new Point(340, 35);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 114);
            panel1.TabIndex = 20;
            panel1.Visible = false;
            // 
            // EntregaDomicilio_Titulo_Label
            // 
            EntregaDomicilio_Titulo_Label.AutoSize = true;
            EntregaDomicilio_Titulo_Label.Location = new Point(20, 14);
            EntregaDomicilio_Titulo_Label.Name = "EntregaDomicilio_Titulo_Label";
            EntregaDomicilio_Titulo_Label.Size = new Size(134, 15);
            EntregaDomicilio_Titulo_Label.TabIndex = 21;
            EntregaDomicilio_Titulo_Label.Text = "ENTREGA A DOMICILIO";
            EntregaDomicilio_Titulo_Label.Click += label12_Click;
            // 
            // DireccionDomicilioTextBox
            // 
            DireccionDomicilioTextBox.Location = new Point(180, 35);
            DireccionDomicilioTextBox.Margin = new Padding(4, 3, 4, 3);
            DireccionDomicilioTextBox.Name = "DireccionDomicilioTextBox";
            DireccionDomicilioTextBox.Size = new Size(245, 21);
            DireccionDomicilioTextBox.TabIndex = 31;
            // 
            // Direccion_Entrega_Label
            // 
            Direccion_Entrega_Label.AutoSize = true;
            Direccion_Entrega_Label.Location = new Point(90, 38);
            Direccion_Entrega_Label.Name = "Direccion_Entrega_Label";
            Direccion_Entrega_Label.Size = new Size(64, 15);
            Direccion_Entrega_Label.TabIndex = 32;
            Direccion_Entrega_Label.Text = "Dirección ";
            // 
            // CPDomicilioTextBox
            // 
            CPDomicilioTextBox.Location = new Point(180, 69);
            CPDomicilioTextBox.Margin = new Padding(4, 3, 4, 3);
            CPDomicilioTextBox.Name = "CPDomicilioTextBox";
            CPDomicilioTextBox.Size = new Size(92, 21);
            CPDomicilioTextBox.TabIndex = 32;
            CPDomicilioTextBox.TextChanged += CPDomicilioTextBox_TextChanged;
            // 
            // CP_Entrega_Label
            // 
            CP_Entrega_Label.AutoSize = true;
            CP_Entrega_Label.Location = new Point(90, 72);
            CP_Entrega_Label.Name = "CP_Entrega_Label";
            CP_Entrega_Label.Size = new Size(71, 15);
            CP_Entrega_Label.TabIndex = 31;
            CP_Entrega_Label.Text = "Cód. Postal";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(GuiasAgenerar_Label);
            groupBox4.Controls.Add(CantidadSTextBox);
            groupBox4.Controls.Add(TipoS_Encomienda_Label);
            groupBox4.Controls.Add(Total_Guias_Label);
            groupBox4.Controls.Add(CantidadMTextBox);
            groupBox4.Controls.Add(TipoM_Encomienda_Label);
            groupBox4.Controls.Add(CantidadLTextBox);
            groupBox4.Controls.Add(TipoL_Encomienda_Label);
            groupBox4.Controls.Add(CantidadXLTextBox);
            groupBox4.Controls.Add(TipoXL_Encomienda_Label);
            groupBox4.Controls.Add(Indicaciones_Encomienda_Label);
            groupBox4.Controls.Add(label20);
            groupBox4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(32, 631);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(823, 127);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalle de Encomiendas";
            // 
            // GuiasAgenerar_Label
            // 
            GuiasAgenerar_Label.AutoSize = true;
            GuiasAgenerar_Label.Location = new Point(482, 34);
            GuiasAgenerar_Label.Name = "GuiasAgenerar_Label";
            GuiasAgenerar_Label.Size = new Size(101, 15);
            GuiasAgenerar_Label.TabIndex = 34;
            GuiasAgenerar_Label.Text = "Guias a Generar:";
            // 
            // CantidadSTextBox
            // 
            CantidadSTextBox.Location = new Point(9, 65);
            CantidadSTextBox.Margin = new Padding(4, 3, 4, 3);
            CantidadSTextBox.Name = "CantidadSTextBox";
            CantidadSTextBox.Size = new Size(92, 21);
            CantidadSTextBox.TabIndex = 24;
            // 
            // TipoS_Encomienda_Label
            // 
            TipoS_Encomienda_Label.AutoSize = true;
            TipoS_Encomienda_Label.Location = new Point(9, 47);
            TipoS_Encomienda_Label.Name = "TipoS_Encomienda_Label";
            TipoS_Encomienda_Label.Size = new Size(42, 15);
            TipoS_Encomienda_Label.TabIndex = 21;
            TipoS_Encomienda_Label.Text = "Tipo S";
            // 
            // Total_Guias_Label
            // 
            Total_Guias_Label.AutoSize = true;
            Total_Guias_Label.Location = new Point(617, 34);
            Total_Guias_Label.Name = "Total_Guias_Label";
            Total_Guias_Label.Size = new Size(77, 15);
            Total_Guias_Label.TabIndex = 37;
            Total_Guias_Label.Text = "[Total Guias]";
            // 
            // CantidadMTextBox
            // 
            CantidadMTextBox.Location = new Point(128, 65);
            CantidadMTextBox.Margin = new Padding(4, 3, 4, 3);
            CantidadMTextBox.Name = "CantidadMTextBox";
            CantidadMTextBox.Size = new Size(92, 21);
            CantidadMTextBox.TabIndex = 26;
            // 
            // TipoM_Encomienda_Label
            // 
            TipoM_Encomienda_Label.AutoSize = true;
            TipoM_Encomienda_Label.Location = new Point(128, 47);
            TipoM_Encomienda_Label.Name = "TipoM_Encomienda_Label";
            TipoM_Encomienda_Label.Size = new Size(44, 15);
            TipoM_Encomienda_Label.TabIndex = 25;
            TipoM_Encomienda_Label.Text = "Tipo M";
            // 
            // CantidadLTextBox
            // 
            CantidadLTextBox.Location = new Point(248, 65);
            CantidadLTextBox.Margin = new Padding(4, 3, 4, 3);
            CantidadLTextBox.Name = "CantidadLTextBox";
            CantidadLTextBox.Size = new Size(92, 21);
            CantidadLTextBox.TabIndex = 28;
            // 
            // TipoL_Encomienda_Label
            // 
            TipoL_Encomienda_Label.AutoSize = true;
            TipoL_Encomienda_Label.Location = new Point(250, 47);
            TipoL_Encomienda_Label.Name = "TipoL_Encomienda_Label";
            TipoL_Encomienda_Label.Size = new Size(41, 15);
            TipoL_Encomienda_Label.TabIndex = 27;
            TipoL_Encomienda_Label.Text = "Tipo L";
            // 
            // CantidadXLTextBox
            // 
            CantidadXLTextBox.Location = new Point(367, 65);
            CantidadXLTextBox.Margin = new Padding(4, 3, 4, 3);
            CantidadXLTextBox.Name = "CantidadXLTextBox";
            CantidadXLTextBox.Size = new Size(92, 21);
            CantidadXLTextBox.TabIndex = 30;
            // 
            // TipoXL_Encomienda_Label
            // 
            TipoXL_Encomienda_Label.AutoSize = true;
            TipoXL_Encomienda_Label.Location = new Point(367, 47);
            TipoXL_Encomienda_Label.Name = "TipoXL_Encomienda_Label";
            TipoXL_Encomienda_Label.Size = new Size(49, 15);
            TipoXL_Encomienda_Label.TabIndex = 29;
            TipoXL_Encomienda_Label.Text = "Tipo XL";
            TipoXL_Encomienda_Label.Click += label19_Click;
            // 
            // Indicaciones_Encomienda_Label
            // 
            Indicaciones_Encomienda_Label.AutoSize = true;
            Indicaciones_Encomienda_Label.Location = new Point(9, 19);
            Indicaciones_Encomienda_Label.Name = "Indicaciones_Encomienda_Label";
            Indicaciones_Encomienda_Label.Size = new Size(258, 15);
            Indicaciones_Encomienda_Label.TabIndex = 22;
            Indicaciones_Encomienda_Label.Text = "Ingrese la cantidad de encomiendas por tipo";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(445, 158);
            label20.Name = "label20";
            label20.Size = new Size(0, 15);
            label20.TabIndex = 31;
            // 
            // Cancelar_Boton
            // 
            Cancelar_Boton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelar_Boton.Location = new Point(630, 776);
            Cancelar_Boton.Margin = new Padding(4, 3, 4, 3);
            Cancelar_Boton.Name = "Cancelar_Boton";
            Cancelar_Boton.Size = new Size(88, 27);
            Cancelar_Boton.TabIndex = 16;
            Cancelar_Boton.Text = "Cancelar";
            Cancelar_Boton.UseVisualStyleBackColor = true;
            // 
            // Confirmar_Boton
            // 
            Confirmar_Boton.BackColor = SystemColors.Highlight;
            Confirmar_Boton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirmar_Boton.ForeColor = SystemColors.ButtonFace;
            Confirmar_Boton.Location = new Point(744, 776);
            Confirmar_Boton.Margin = new Padding(4, 3, 4, 3);
            Confirmar_Boton.Name = "Confirmar_Boton";
            Confirmar_Boton.Size = new Size(88, 27);
            Confirmar_Boton.TabIndex = 17;
            Confirmar_Boton.Text = "Confirmar";
            Confirmar_Boton.UseVisualStyleBackColor = false;
            Confirmar_Boton.Click += button3_Click;
            // 
            // ImposicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(744, 430);
            Controls.Add(groupBox1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(Cancelar_Boton);
            Controls.Add(Confirmar_Boton);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ImposicionForm";
            Text = "Imposicion de Encomiendas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ── Declaraciones de campos ──
        private GroupBox groupBox1;
        private Label Cuit_Remitente_Label, NombreRemitente_Label, TelefonoRemitente_Label, DireccionRemitente_Label;
        private TextBox CuitRemitente_TextBox;
        private Label NombreRemitenteLabel, TelefonoRemitenteLabel, DireccionRemitenteLabel;
        private Panel panel3;
        private Button BuscarRemitente_Boton;

        private GroupBox groupBox5;
        private CheckBox DomicilioFiscalCheck;
        private Label label37, DireccionFiscal_Label;
        private ComboBox ProvinciaRetiroComboBox;
        private Label Provincia_Retiro_Label;
        private ComboBox LocalidadRetiroComboBox;
        private Label Localidad_Retiro_Label;
        private TextBox DireccionRetiroTextBox;
        private Label Direccion_retiro_Label;
        private TextBox CPRetiroTextBox;
        private Label CP_Retiro_Label;
        private Panel panel4;

        private GroupBox groupBox2;
        private TextBox NombreDestinatarioTextBox;
        private Label NombreDestinatario_Label;
        private TextBox ApellidoDestinatarioTextBox;
        private Label ApellidoDestinatario_Label;
        private TextBox DNIDestinatarioTextBox;
        private Label DniDestinatario_Label;

        private GroupBox groupBox3;
        private ComboBox ProvinciaEntregaComboBox;
        private Label label10;
        private ComboBox LocalidadEntregaComboBox;
        private Label label9;
        private ComboBox TipoEntregaComboBox;
        private Label label8;
        private ComboBox DestinoComboBox;
        private Label labelDestino;
        private Panel panel1;
        private Label EntregaDomicilio_Titulo_Label;
        private TextBox DireccionDomicilioTextBox;
        private Label Direccion_Entrega_Label;
        private TextBox CPDomicilioTextBox;
        private Label CP_Entrega_Label;

        private GroupBox groupBox4;
        private TextBox CantidadSTextBox;
        private Label TipoS_Encomienda_Label;
        private TextBox CantidadMTextBox;
        private Label TipoM_Encomienda_Label;
        private TextBox CantidadLTextBox;
        private Label TipoL_Encomienda_Label;
        private TextBox CantidadXLTextBox;
        private Label TipoXL_Encomienda_Label;
        private Label Indicaciones_Encomienda_Label, label20;
        private Label GuiasAgenerar_Label;
        private Label Total_Guias_Label;

        private Button Cancelar_Boton, Confirmar_Boton;
        
    }
}