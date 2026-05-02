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
            EmitirFacturaBoton = new Button();
            label2 = new Label();
            BuscarClienteBoton = new Button();
            CuitClienteBox = new TextBox();
            SaldoAlCierreLabel = new Label();
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
            DocumentosLista = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // EmitirFacturaBoton
            // 
            EmitirFacturaBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EmitirFacturaBoton.ForeColor = Color.FromArgb(64, 0, 64);
            EmitirFacturaBoton.Location = new Point(593, 647);
            EmitirFacturaBoton.Name = "EmitirFacturaBoton";
            EmitirFacturaBoton.Size = new Size(165, 52);
            EmitirFacturaBoton.TabIndex = 20;
            EmitirFacturaBoton.Text = "Salir";
            EmitirFacturaBoton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(30, 12);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 18;
            label2.Text = "Seleccione el cliente";
            // 
            // BuscarClienteBoton
            // 
            BuscarClienteBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarClienteBoton.Location = new Point(593, 56);
            BuscarClienteBoton.Name = "BuscarClienteBoton";
            BuscarClienteBoton.Size = new Size(165, 52);
            BuscarClienteBoton.TabIndex = 15;
            BuscarClienteBoton.Text = "Buscar Cliente";
            BuscarClienteBoton.UseVisualStyleBackColor = true;
            // 
            // CuitClienteBox
            // 
            CuitClienteBox.Location = new Point(184, 50);
            CuitClienteBox.Name = "CuitClienteBox";
            CuitClienteBox.Size = new Size(207, 27);
            CuitClienteBox.TabIndex = 13;
            // 
            // SaldoAlCierreLabel
            // 
            SaldoAlCierreLabel.AutoSize = true;
            SaldoAlCierreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaldoAlCierreLabel.Location = new Point(654, 602);
            SaldoAlCierreLabel.Name = "SaldoAlCierreLabel";
            SaldoAlCierreLabel.Size = new Size(102, 20);
            SaldoAlCierreLabel.TabIndex = 17;
            SaldoAlCierreLabel.Text = "1.000.000,23";
            // 
            // DatosCLienteRespuestaLabel
            // 
            DatosCLienteRespuestaLabel.AutoSize = true;
            DatosCLienteRespuestaLabel.Location = new Point(184, 92);
            DatosCLienteRespuestaLabel.Name = "DatosCLienteRespuestaLabel";
            DatosCLienteRespuestaLabel.Size = new Size(123, 20);
            DatosCLienteRespuestaLabel.TabIndex = 11;
            DatosCLienteRespuestaLabel.Text = "Datos del Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(28, 602);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 16;
            label1.Text = "Saldo al cierre $:";
            // 
            // DatosClienteLabel
            // 
            DatosClienteLabel.AutoSize = true;
            DatosClienteLabel.Location = new Point(30, 92);
            DatosClienteLabel.Name = "DatosClienteLabel";
            DatosClienteLabel.Size = new Size(123, 20);
            DatosClienteLabel.TabIndex = 10;
            DatosClienteLabel.Text = "Datos del Cliente";
            // 
            // CUITClienteLabel
            // 
            CUITClienteLabel.AutoSize = true;
            CUITClienteLabel.Location = new Point(30, 56);
            CUITClienteLabel.Name = "CUITClienteLabel";
            CUITClienteLabel.Size = new Size(115, 20);
            CUITClienteLabel.TabIndex = 9;
            CUITClienteLabel.Text = "CUIT del Cliente";
            // 
            // DetalleEnviosLabel
            // 
            DetalleEnviosLabel.AutoSize = true;
            DetalleEnviosLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DetalleEnviosLabel.Location = new Point(28, 296);
            DetalleEnviosLabel.Name = "DetalleEnviosLabel";
            DetalleEnviosLabel.Size = new Size(312, 25);
            DetalleEnviosLabel.TabIndex = 12;
            DetalleEnviosLabel.Text = "Movimientos de Cuenta Corriente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(30, 131);
            label3.Name = "label3";
            label3.Size = new Size(301, 25);
            label3.TabIndex = 21;
            label3.Text = "Ingrese el período de la consulta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 177);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 22;
            label4.Text = "Desde:";
            // 
            // DesdeDateTime
            // 
            DesdeDateTime.Location = new Point(92, 170);
            DesdeDateTime.Name = "DesdeDateTime";
            DesdeDateTime.Size = new Size(250, 27);
            DesdeDateTime.TabIndex = 23;
            // 
            // HastaDateTime
            // 
            HastaDateTime.Location = new Point(508, 170);
            HastaDateTime.Name = "HastaDateTime";
            HastaDateTime.Size = new Size(250, 27);
            HastaDateTime.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 177);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 24;
            label5.Text = "Hasta:";
            // 
            // SaldoInicioLabel
            // 
            SaldoInicioLabel.AutoSize = true;
            SaldoInicioLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaldoInicioLabel.Location = new Point(654, 343);
            SaldoInicioLabel.Name = "SaldoInicioLabel";
            SaldoInicioLabel.Size = new Size(102, 20);
            SaldoInicioLabel.TabIndex = 27;
            SaldoInicioLabel.Text = "1.000.000,23";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(28, 341);
            label7.Name = "label7";
            label7.Size = new Size(142, 23);
            label7.TabIndex = 26;
            label7.Text = "Saldo al inicio $:";
            // 
            // BuscarMovimientosBoton
            // 
            BuscarMovimientosBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarMovimientosBoton.Location = new Point(593, 220);
            BuscarMovimientosBoton.Name = "BuscarMovimientosBoton";
            BuscarMovimientosBoton.Size = new Size(165, 52);
            BuscarMovimientosBoton.TabIndex = 28;
            BuscarMovimientosBoton.Text = "Buscar Movimientos";
            BuscarMovimientosBoton.UseVisualStyleBackColor = true;
            // 
            // DocumentosLista
            // 
            DocumentosLista.BackgroundImageTiled = true;
            DocumentosLista.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            DocumentosLista.GridLines = true;
            DocumentosLista.Location = new Point(34, 377);
            DocumentosLista.Name = "DocumentosLista";
            DocumentosLista.Size = new Size(722, 210);
            DocumentosLista.TabIndex = 29;
            DocumentosLista.UseCompatibleStateImageBehavior = false;
            DocumentosLista.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 120;
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
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Debe";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Haber";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 180;
            // 
            // EstadoCClientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 711);
            Controls.Add(DocumentosLista);
            Controls.Add(BuscarMovimientosBoton);
            Controls.Add(SaldoInicioLabel);
            Controls.Add(label7);
            Controls.Add(HastaDateTime);
            Controls.Add(label5);
            Controls.Add(DesdeDateTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmitirFacturaBoton);
            Controls.Add(label2);
            Controls.Add(BuscarClienteBoton);
            Controls.Add(CuitClienteBox);
            Controls.Add(SaldoAlCierreLabel);
            Controls.Add(DatosCLienteRespuestaLabel);
            Controls.Add(label1);
            Controls.Add(DatosClienteLabel);
            Controls.Add(CUITClienteLabel);
            Controls.Add(DetalleEnviosLabel);
            Name = "EstadoCClientesForm";
            Text = "EstadoCClientesForm";
            Load += EstadoCClientesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmitirFacturaBoton;
        private Label label2;
        private Button BuscarClienteBoton;
        private TextBox CuitClienteBox;
        private Label SaldoAlCierreLabel;
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
        private ListView DocumentosLista;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}