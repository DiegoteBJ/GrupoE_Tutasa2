namespace GrupoE_Tutasa.EstadoCCClientes
{
    partial class EstadoCClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SalirBoton = new Button();
            label2 = new Label();
            BuscarClienteBoton = new Button();
            CuitClienteBox = new TextBox();
            SaldoCierreLabel = new Label();
            DatosCLienteRespuestaLabel = new Label();
            label1 = new Label();
            DatosClienteLabel = new Label();
            CUITClienteLabel = new Label();
            DetalleEnviosLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            DesdeDateTime = new DateTimePicker();
            HastaDateTime = new DateTimePicker();
            label5 = new Label();
            SaldoInicioLabel = new Label();
            label7 = new Label();
            BuscarMovimientosBoton = new Button();
            DocumentosListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            VerOtroBoton = new Button();
            ClienteIDLabel = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // SalirBoton
            // 
            SalirBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalirBoton.ForeColor = Color.Black;
            SalirBoton.Location = new Point(519, 485);
            SalirBoton.Margin = new Padding(3, 2, 3, 2);
            SalirBoton.Name = "SalirBoton";
            SalirBoton.Size = new Size(144, 39);
            SalirBoton.TabIndex = 20;
            SalirBoton.Text = "Salir";
            SalirBoton.UseVisualStyleBackColor = true;
            SalirBoton.Click += SalirBoton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 18);
            label2.TabIndex = 18;
            label2.Text = "Seleccione el cliente";
            // 
            // BuscarClienteBoton
            // 
            BuscarClienteBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarClienteBoton.Location = new Point(519, 42);
            BuscarClienteBoton.Margin = new Padding(3, 2, 3, 2);
            BuscarClienteBoton.Name = "BuscarClienteBoton";
            BuscarClienteBoton.Size = new Size(144, 39);
            BuscarClienteBoton.TabIndex = 15;
            BuscarClienteBoton.Text = "Buscar Cliente";
            BuscarClienteBoton.UseVisualStyleBackColor = true;
            BuscarClienteBoton.Click += BuscarClienteBoton_Click;
            // 
            // CuitClienteBox
            // 
            CuitClienteBox.Location = new Point(161, 38);
            CuitClienteBox.Margin = new Padding(3, 2, 3, 2);
            CuitClienteBox.Name = "CuitClienteBox";
            CuitClienteBox.Size = new Size(182, 21);
            CuitClienteBox.TabIndex = 13;
            // 
            // SaldoCierreLabel
            // 
            SaldoCierreLabel.AutoSize = true;
            SaldoCierreLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaldoCierreLabel.ForeColor = Color.Blue;
            SaldoCierreLabel.Location = new Point(572, 452);
            SaldoCierreLabel.Name = "SaldoCierreLabel";
            SaldoCierreLabel.Size = new Size(102, 19);
            SaldoCierreLabel.TabIndex = 17;
            SaldoCierreLabel.Text = "1.000.000,23";
            // 
            // DatosCLienteRespuestaLabel
            // 
            DatosCLienteRespuestaLabel.AutoSize = true;
            DatosCLienteRespuestaLabel.Location = new Point(161, 69);
            DatosCLienteRespuestaLabel.Name = "DatosCLienteRespuestaLabel";
            DatosCLienteRespuestaLabel.Size = new Size(102, 15);
            DatosCLienteRespuestaLabel.TabIndex = 11;
            DatosCLienteRespuestaLabel.Text = "Datos del Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 452);
            label1.Name = "label1";
            label1.Size = new Size(126, 18);
            label1.TabIndex = 16;
            label1.Text = "Saldo al cierre $:";
            // 
            // DatosClienteLabel
            // 
            DatosClienteLabel.AutoSize = true;
            DatosClienteLabel.Location = new Point(26, 69);
            DatosClienteLabel.Name = "DatosClienteLabel";
            DatosClienteLabel.Size = new Size(102, 15);
            DatosClienteLabel.TabIndex = 10;
            DatosClienteLabel.Text = "Datos del Cliente";
            // 
            // CUITClienteLabel
            // 
            CUITClienteLabel.AutoSize = true;
            CUITClienteLabel.Location = new Point(26, 42);
            CUITClienteLabel.Name = "CUITClienteLabel";
            CUITClienteLabel.Size = new Size(95, 15);
            CUITClienteLabel.TabIndex = 9;
            CUITClienteLabel.Text = "CUIT del Cliente";
            // 
            // DetalleEnviosLabel
            // 
            DetalleEnviosLabel.AutoSize = true;
            DetalleEnviosLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetalleEnviosLabel.Location = new Point(24, 222);
            DetalleEnviosLabel.Name = "DetalleEnviosLabel";
            DetalleEnviosLabel.Size = new Size(248, 18);
            DetalleEnviosLabel.TabIndex = 12;
            DetalleEnviosLabel.Text = "Movimientos de Cuenta Corriente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 98);
            label3.Name = "label3";
            label3.Size = new Size(240, 18);
            label3.TabIndex = 21;
            label3.Text = "Ingrese el período de la consulta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 133);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 22;
            label4.Text = "Desde:";
            // 
            // DesdeDateTime
            // 
            DesdeDateTime.Format = DateTimePickerFormat.Short;
            DesdeDateTime.Location = new Point(80, 128);
            DesdeDateTime.Margin = new Padding(3, 2, 3, 2);
            DesdeDateTime.Name = "DesdeDateTime";
            DesdeDateTime.Size = new Size(219, 21);
            DesdeDateTime.TabIndex = 23;
            // 
            // HastaDateTime
            // 
            HastaDateTime.Format = DateTimePickerFormat.Short;
            HastaDateTime.Location = new Point(444, 128);
            HastaDateTime.Margin = new Padding(3, 2, 3, 2);
            HastaDateTime.Name = "HastaDateTime";
            HastaDateTime.Size = new Size(219, 21);
            HastaDateTime.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 133);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 24;
            label5.Text = "Hasta:";
            // 
            // SaldoInicioLabel
            // 
            SaldoInicioLabel.AutoSize = true;
            SaldoInicioLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaldoInicioLabel.Location = new Point(572, 257);
            SaldoInicioLabel.Name = "SaldoInicioLabel";
            SaldoInicioLabel.Size = new Size(102, 19);
            SaldoInicioLabel.TabIndex = 27;
            SaldoInicioLabel.Text = "1.000.000,23";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 256);
            label7.Name = "label7";
            label7.Size = new Size(122, 18);
            label7.TabIndex = 26;
            label7.Text = "Saldo al inicio $:";
            // 
            // BuscarMovimientosBoton
            // 
            BuscarMovimientosBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarMovimientosBoton.Location = new Point(519, 165);
            BuscarMovimientosBoton.Margin = new Padding(3, 2, 3, 2);
            BuscarMovimientosBoton.Name = "BuscarMovimientosBoton";
            BuscarMovimientosBoton.Size = new Size(144, 39);
            BuscarMovimientosBoton.TabIndex = 28;
            BuscarMovimientosBoton.Text = "Buscar Movimientos";
            BuscarMovimientosBoton.UseVisualStyleBackColor = true;
            BuscarMovimientosBoton.Click += BuscarMovimientosBoton_Click;
            // 
            // DocumentosListView
            // 
            DocumentosListView.BackgroundImageTiled = true;
            DocumentosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            DocumentosListView.GridLines = true;
            DocumentosListView.Location = new Point(30, 283);
            DocumentosListView.Margin = new Padding(3, 2, 3, 2);
            DocumentosListView.Name = "DocumentosListView";
            DocumentosListView.Size = new Size(632, 158);
            DocumentosListView.TabIndex = 29;
            DocumentosListView.UseCompatibleStateImageBehavior = false;
            DocumentosListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo Doc.";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Número Documento";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Debe";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Haber";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // VerOtroBoton
            // 
            VerOtroBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerOtroBoton.ForeColor = Color.Black;
            VerOtroBoton.Location = new Point(369, 485);
            VerOtroBoton.Margin = new Padding(3, 2, 3, 2);
            VerOtroBoton.Name = "VerOtroBoton";
            VerOtroBoton.Size = new Size(144, 39);
            VerOtroBoton.TabIndex = 30;
            VerOtroBoton.Text = "Ver otro cliente";
            VerOtroBoton.UseVisualStyleBackColor = true;
            VerOtroBoton.Click += VerOtroBoton_Click;
            // 
            // ClienteIDLabel
            // 
            ClienteIDLabel.AutoSize = true;
            ClienteIDLabel.Location = new Point(472, 42);
            ClienteIDLabel.Name = "ClienteIDLabel";
            ClienteIDLabel.Size = new Size(14, 15);
            ClienteIDLabel.TabIndex = 31;
            ClienteIDLabel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 42);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 32;
            label6.Text = "Cliente ID: ";
            // 
            // EstadoCClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 533);
            Controls.Add(label6);
            Controls.Add(ClienteIDLabel);
            Controls.Add(VerOtroBoton);
            Controls.Add(DocumentosListView);
            Controls.Add(BuscarMovimientosBoton);
            Controls.Add(SaldoInicioLabel);
            Controls.Add(label7);
            Controls.Add(HastaDateTime);
            Controls.Add(label5);
            Controls.Add(DesdeDateTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SalirBoton);
            Controls.Add(label2);
            Controls.Add(BuscarClienteBoton);
            Controls.Add(CuitClienteBox);
            Controls.Add(SaldoCierreLabel);
            Controls.Add(DatosCLienteRespuestaLabel);
            Controls.Add(label1);
            Controls.Add(DatosClienteLabel);
            Controls.Add(CUITClienteLabel);
            Controls.Add(DetalleEnviosLabel);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EstadoCClientesForm";
            Text = "Estado Cuenta Corriente Clientes";
            Load += EstadoCClientesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SalirBoton;
        private Label label2;
        private Button BuscarClienteBoton;
        private TextBox CuitClienteBox;
        private Label SaldoCierreLabel;
        private Label DatosCLienteRespuestaLabel;
        private Label label1;
        private Label DatosClienteLabel;
        private Label CUITClienteLabel;
        private Label DetalleEnviosLabel;
        private Label label3;
        private Label label4;
        private DateTimePicker DesdeDateTime;
        private DateTimePicker HastaDateTime;
        private Label label5;
        private Label SaldoInicioLabel;
        private Label label7;
        private Button BuscarMovimientosBoton;
        private ListView DocumentosListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button VerOtroBoton;
        private Label ClienteIDLabel;
        private Label label6;
    }
}