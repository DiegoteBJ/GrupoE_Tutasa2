namespace GrupoE_Tutasa.RendicionHDR
{
    partial class RendicionHDRForm
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
            BusquedaHDRgroupBox = new GroupBox();
            HDRDistribucionRadioBoton = new RadioButton();
            HDRRetiroRadioBoton = new RadioButton();
            BuscarHDRboton = new Button();
            HDRtextBox = new TextBox();
            DatosViajegroupBox = new GroupBox();
            RespuestaTotalGuiasLabel = new Label();
            TotalGuiasLabel = new Label();
            RespuestaTipoHDRLabel = new Label();
            TipoHDRLabel = new Label();
            RespuestaFechaLabel = new Label();
            FechaLabel = new Label();
            RespuestaFleteroLabel = new Label();
            FleteroLabel = new Label();
            DetalleHDRGroupBox = new GroupBox();
            RespCantidadGuiasNoCumplidasLabel = new Label();
            CantGuiasNoCumplidasLabel = new Label();
            CambiarNoCumplidasBoton = new Button();
            CambiarCumplidasBoton = new Button();
            RespCantGuiasCumplidasLabel = new Label();
            CantGuiasCumplidasLabel = new Label();
            DetalleHDRListView = new ListView();
            GuiacolumnHeader = new ColumnHeader();
            RemitentecolumnHeader = new ColumnHeader();
            DestinatariocolumnHeader = new ColumnHeader();
            DomiciliocolumnHeader = new ColumnHeader();
            TamcolumnHeader = new ColumnHeader();
            IntentocolumnHeader = new ColumnHeader();
            EstadocolumnHeader = new ColumnHeader();
            ConfirmarRendicionBoton = new Button();
            CancelarRendicionBoton = new Button();
            BusquedaHDRgroupBox.SuspendLayout();
            DatosViajegroupBox.SuspendLayout();
            DetalleHDRGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // BusquedaHDRgroupBox
            // 
            BusquedaHDRgroupBox.Controls.Add(HDRDistribucionRadioBoton);
            BusquedaHDRgroupBox.Controls.Add(HDRRetiroRadioBoton);
            BusquedaHDRgroupBox.Controls.Add(BuscarHDRboton);
            BusquedaHDRgroupBox.Controls.Add(HDRtextBox);
            BusquedaHDRgroupBox.Location = new Point(19, 19);
            BusquedaHDRgroupBox.Name = "BusquedaHDRgroupBox";
            BusquedaHDRgroupBox.Size = new Size(815, 111);
            BusquedaHDRgroupBox.TabIndex = 0;
            BusquedaHDRgroupBox.TabStop = false;
            BusquedaHDRgroupBox.Text = "Búsqueda de Hoja de Ruta";
            // 
            // HDRDistribucionRadioBoton
            // 
            HDRDistribucionRadioBoton.AutoSize = true;
            HDRDistribucionRadioBoton.Location = new Point(435, 32);
            HDRDistribucionRadioBoton.Margin = new Padding(3, 4, 3, 4);
            HDRDistribucionRadioBoton.Name = "HDRDistribucionRadioBoton";
            HDRDistribucionRadioBoton.Size = new Size(110, 24);
            HDRDistribucionRadioBoton.TabIndex = 25;
            HDRDistribucionRadioBoton.TabStop = true;
            HDRDistribucionRadioBoton.Text = "Distribución";
            HDRDistribucionRadioBoton.UseVisualStyleBackColor = true;
            // 
            // HDRRetiroRadioBoton
            // 
            HDRRetiroRadioBoton.AutoSize = true;
            HDRRetiroRadioBoton.Location = new Point(365, 32);
            HDRRetiroRadioBoton.Margin = new Padding(3, 4, 3, 4);
            HDRRetiroRadioBoton.Name = "HDRRetiroRadioBoton";
            HDRRetiroRadioBoton.Size = new Size(70, 24);
            HDRRetiroRadioBoton.TabIndex = 25;
            HDRRetiroRadioBoton.TabStop = true;
            HDRRetiroRadioBoton.Text = "Retiro";
            HDRRetiroRadioBoton.UseVisualStyleBackColor = true;
            // 
            // BuscarHDRboton
            // 
            BuscarHDRboton.Location = new Point(6, 59);
            BuscarHDRboton.Name = "BuscarHDRboton";
            BuscarHDRboton.Size = new Size(94, 29);
            BuscarHDRboton.TabIndex = 1;
            BuscarHDRboton.Text = "Buscar";
            BuscarHDRboton.UseVisualStyleBackColor = true;
            BuscarHDRboton.Click += BuscarHDRboton_Click;
            // 
            // HDRtextBox
            // 
            HDRtextBox.Location = new Point(6, 27);
            HDRtextBox.Name = "HDRtextBox";
            HDRtextBox.Size = new Size(324, 27);
            HDRtextBox.TabIndex = 0;
            // 
            // DatosViajegroupBox
            // 
            DatosViajegroupBox.Controls.Add(RespuestaTotalGuiasLabel);
            DatosViajegroupBox.Controls.Add(TotalGuiasLabel);
            DatosViajegroupBox.Controls.Add(RespuestaTipoHDRLabel);
            DatosViajegroupBox.Controls.Add(TipoHDRLabel);
            DatosViajegroupBox.Controls.Add(RespuestaFechaLabel);
            DatosViajegroupBox.Controls.Add(FechaLabel);
            DatosViajegroupBox.Controls.Add(RespuestaFleteroLabel);
            DatosViajegroupBox.Controls.Add(FleteroLabel);
            DatosViajegroupBox.Location = new Point(19, 148);
            DatosViajegroupBox.Name = "DatosViajegroupBox";
            DatosViajegroupBox.Size = new Size(815, 111);
            DatosViajegroupBox.TabIndex = 1;
            DatosViajegroupBox.TabStop = false;
            DatosViajegroupBox.Text = "Datos del viaje";
            // 
            // RespuestaTotalGuiasLabel
            // 
            RespuestaTotalGuiasLabel.AutoSize = true;
            RespuestaTotalGuiasLabel.Location = new Point(656, 76);
            RespuestaTotalGuiasLabel.Name = "RespuestaTotalGuiasLabel";
            RespuestaTotalGuiasLabel.Size = new Size(44, 20);
            RespuestaTotalGuiasLabel.TabIndex = 7;
            RespuestaTotalGuiasLabel.Text = "[Nro]";
            // 
            // TotalGuiasLabel
            // 
            TotalGuiasLabel.AutoSize = true;
            TotalGuiasLabel.Location = new Point(566, 76);
            TotalGuiasLabel.Name = "TotalGuiasLabel";
            TotalGuiasLabel.Size = new Size(84, 20);
            TotalGuiasLabel.TabIndex = 6;
            TotalGuiasLabel.Text = "Total guías:";
            // 
            // RespuestaTipoHDRLabel
            // 
            RespuestaTipoHDRLabel.AutoSize = true;
            RespuestaTipoHDRLabel.Location = new Point(559, 37);
            RespuestaTipoHDRLabel.Name = "RespuestaTipoHDRLabel";
            RespuestaTipoHDRLabel.Size = new Size(145, 20);
            RespuestaTipoHDRLabel.TabIndex = 5;
            RespuestaTipoHDRLabel.Text = "[Distribución/Retiro]";
            // 
            // TipoHDRLabel
            // 
            TipoHDRLabel.AutoSize = true;
            TipoHDRLabel.Location = new Point(455, 37);
            TipoHDRLabel.Name = "TipoHDRLabel";
            TipoHDRLabel.Size = new Size(98, 20);
            TipoHDRLabel.TabIndex = 4;
            TipoHDRLabel.Text = "Tipo de HDR:";
            // 
            // RespuestaFechaLabel
            // 
            RespuestaFechaLabel.AutoSize = true;
            RespuestaFechaLabel.Location = new Point(293, 37);
            RespuestaFechaLabel.Name = "RespuestaFechaLabel";
            RespuestaFechaLabel.Size = new Size(123, 20);
            RespuestaFechaLabel.TabIndex = 3;
            RespuestaFechaLabel.Text = "[FechaRendicion]";
            // 
            // FechaLabel
            // 
            FechaLabel.AutoSize = true;
            FechaLabel.Location = new Point(248, 37);
            FechaLabel.Name = "FechaLabel";
            FechaLabel.Size = new Size(50, 20);
            FechaLabel.TabIndex = 2;
            FechaLabel.Text = "Fecha:";
            // 
            // RespuestaFleteroLabel
            // 
            RespuestaFleteroLabel.AutoSize = true;
            RespuestaFleteroLabel.Location = new Point(66, 37);
            RespuestaFleteroLabel.Name = "RespuestaFleteroLabel";
            RespuestaFleteroLabel.Size = new Size(138, 20);
            RespuestaFleteroLabel.TabIndex = 1;
            RespuestaFleteroLabel.Text = "[Apellido, Nombre]";
            // 
            // FleteroLabel
            // 
            FleteroLabel.AutoSize = true;
            FleteroLabel.Location = new Point(13, 37);
            FleteroLabel.Name = "FleteroLabel";
            FleteroLabel.Size = new Size(58, 20);
            FleteroLabel.TabIndex = 0;
            FleteroLabel.Text = "Fletero:";
            // 
            // DetalleHDRGroupBox
            // 
            DetalleHDRGroupBox.Controls.Add(RespCantidadGuiasNoCumplidasLabel);
            DetalleHDRGroupBox.Controls.Add(CantGuiasNoCumplidasLabel);
            DetalleHDRGroupBox.Controls.Add(CambiarNoCumplidasBoton);
            DetalleHDRGroupBox.Controls.Add(CambiarCumplidasBoton);
            DetalleHDRGroupBox.Controls.Add(RespCantGuiasCumplidasLabel);
            DetalleHDRGroupBox.Controls.Add(CantGuiasCumplidasLabel);
            DetalleHDRGroupBox.Controls.Add(DetalleHDRListView);
            DetalleHDRGroupBox.Location = new Point(19, 279);
            DetalleHDRGroupBox.Name = "DetalleHDRGroupBox";
            DetalleHDRGroupBox.Size = new Size(815, 326);
            DetalleHDRGroupBox.TabIndex = 2;
            DetalleHDRGroupBox.TabStop = false;
            DetalleHDRGroupBox.Text = "Detalle de HDR";
            // 
            // RespCantidadGuiasNoCumplidasLabel
            // 
            RespCantidadGuiasNoCumplidasLabel.AutoSize = true;
            RespCantidadGuiasNoCumplidasLabel.Location = new Point(706, 277);
            RespCantidadGuiasNoCumplidasLabel.Name = "RespCantidadGuiasNoCumplidasLabel";
            RespCantidadGuiasNoCumplidasLabel.Size = new Size(83, 20);
            RespCantidadGuiasNoCumplidasLabel.TabIndex = 6;
            RespCantidadGuiasNoCumplidasLabel.Text = "[Nro/Total]";
            // 
            // CantGuiasNoCumplidasLabel
            // 
            CantGuiasNoCumplidasLabel.AutoSize = true;
            CantGuiasNoCumplidasLabel.Location = new Point(503, 277);
            CantGuiasNoCumplidasLabel.Name = "CantGuiasNoCumplidasLabel";
            CantGuiasNoCumplidasLabel.Size = new Size(201, 20);
            CantGuiasNoCumplidasLabel.TabIndex = 5;
            CantGuiasNoCumplidasLabel.Text = "Cantidad guías no cumplidas";
            // 
            // CambiarNoCumplidasBoton
            // 
            CambiarNoCumplidasBoton.Location = new Point(14, 277);
            CambiarNoCumplidasBoton.Name = "CambiarNoCumplidasBoton";
            CambiarNoCumplidasBoton.Size = new Size(213, 29);
            CambiarNoCumplidasBoton.TabIndex = 4;
            CambiarNoCumplidasBoton.Text = "Cambiar a No Cumplidas";
            CambiarNoCumplidasBoton.UseVisualStyleBackColor = true;
            CambiarNoCumplidasBoton.Click += CambiarNoCumplidasBoton_Click;
            // 
            // CambiarCumplidasBoton
            // 
            CambiarCumplidasBoton.Location = new Point(14, 235);
            CambiarCumplidasBoton.Name = "CambiarCumplidasBoton";
            CambiarCumplidasBoton.Size = new Size(213, 29);
            CambiarCumplidasBoton.TabIndex = 3;
            CambiarCumplidasBoton.Text = "Cambiar a Cumplidas";
            CambiarCumplidasBoton.UseVisualStyleBackColor = true;
            CambiarCumplidasBoton.Click += CambiarCumplidasBoton_Click;
            // 
            // RespCantGuiasCumplidasLabel
            // 
            RespCantGuiasCumplidasLabel.AutoSize = true;
            RespCantGuiasCumplidasLabel.Location = new Point(706, 239);
            RespCantGuiasCumplidasLabel.Name = "RespCantGuiasCumplidasLabel";
            RespCantGuiasCumplidasLabel.Size = new Size(83, 20);
            RespCantGuiasCumplidasLabel.TabIndex = 2;
            RespCantGuiasCumplidasLabel.Text = "[Nro/Total]";
            // 
            // CantGuiasCumplidasLabel
            // 
            CantGuiasCumplidasLabel.AutoSize = true;
            CantGuiasCumplidasLabel.Location = new Point(520, 239);
            CantGuiasCumplidasLabel.Name = "CantGuiasCumplidasLabel";
            CantGuiasCumplidasLabel.Size = new Size(180, 20);
            CantGuiasCumplidasLabel.TabIndex = 1;
            CantGuiasCumplidasLabel.Text = "Cantidad guías cumplidas";
            // 
            // DetalleHDRListView
            // 
            DetalleHDRListView.Columns.AddRange(new ColumnHeader[] { GuiacolumnHeader, RemitentecolumnHeader, DestinatariocolumnHeader, DomiciliocolumnHeader, TamcolumnHeader, IntentocolumnHeader, EstadocolumnHeader });
            DetalleHDRListView.FullRowSelect = true;
            DetalleHDRListView.Location = new Point(14, 27);
            DetalleHDRListView.Name = "DetalleHDRListView";
            DetalleHDRListView.Size = new Size(785, 193);
            DetalleHDRListView.TabIndex = 0;
            DetalleHDRListView.UseCompatibleStateImageBehavior = false;
            DetalleHDRListView.View = View.Details;
            // 
            // GuiacolumnHeader
            // 
            GuiacolumnHeader.Text = "Nro. Guía";
            GuiacolumnHeader.Width = 100;
            // 
            // RemitentecolumnHeader
            // 
            RemitentecolumnHeader.Text = "Remitente";
            RemitentecolumnHeader.Width = 110;
            // 
            // DestinatariocolumnHeader
            // 
            DestinatariocolumnHeader.Text = "Destinatario";
            DestinatariocolumnHeader.Width = 110;
            // 
            // DomiciliocolumnHeader
            // 
            DomiciliocolumnHeader.Text = "Domicilio";
            DomiciliocolumnHeader.Width = 130;
            // 
            // TamcolumnHeader
            // 
            TamcolumnHeader.Text = "Tam.";
            // 
            // IntentocolumnHeader
            // 
            IntentocolumnHeader.Text = "Intento";
            IntentocolumnHeader.Width = 70;
            // 
            // EstadocolumnHeader
            // 
            EstadocolumnHeader.Text = "Estado";
            EstadocolumnHeader.Width = 90;
            // 
            // ConfirmarRendicionBoton
            // 
            ConfirmarRendicionBoton.Location = new Point(487, 637);
            ConfirmarRendicionBoton.Name = "ConfirmarRendicionBoton";
            ConfirmarRendicionBoton.Size = new Size(182, 32);
            ConfirmarRendicionBoton.TabIndex = 3;
            ConfirmarRendicionBoton.Text = "Confirmar Rendición";
            ConfirmarRendicionBoton.UseVisualStyleBackColor = true;
            ConfirmarRendicionBoton.Click += ConfirmarRendicionBoton_Click;
            // 
            // CancelarRendicionBoton
            // 
            CancelarRendicionBoton.Location = new Point(699, 637);
            CancelarRendicionBoton.Name = "CancelarRendicionBoton";
            CancelarRendicionBoton.Size = new Size(135, 32);
            CancelarRendicionBoton.TabIndex = 4;
            CancelarRendicionBoton.Text = "Cancelar";
            CancelarRendicionBoton.UseVisualStyleBackColor = true;
            CancelarRendicionBoton.Click += CancelarRendicionBoton_Click;
            // 
            // RendicionHDRForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 681);
            Controls.Add(CancelarRendicionBoton);
            Controls.Add(ConfirmarRendicionBoton);
            Controls.Add(DetalleHDRGroupBox);
            Controls.Add(DatosViajegroupBox);
            Controls.Add(BusquedaHDRgroupBox);
            Name = "RendicionHDRForm";
            Text = "Rendicion de HDR";
            BusquedaHDRgroupBox.ResumeLayout(false);
            BusquedaHDRgroupBox.PerformLayout();
            DatosViajegroupBox.ResumeLayout(false);
            DatosViajegroupBox.PerformLayout();
            DetalleHDRGroupBox.ResumeLayout(false);
            DetalleHDRGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BusquedaHDRgroupBox;
        private TextBox HDRtextBox;
        private Button BuscarHDRboton;
        private GroupBox DatosViajegroupBox;
        private Label FleteroLabel;
        private Label RespuestaTipoHDRLabel;
        private Label TipoHDRLabel;
        private Label RespuestaFechaLabel;
        private Label FechaLabel;
        private Label RespuestaFleteroLabel;
        private Label RespuestaTotalGuiasLabel;
        private Label TotalGuiasLabel;
        private GroupBox DetalleHDRGroupBox;
        private ListView DetalleHDRListView;
        private ColumnHeader GuiacolumnHeader;
        private ColumnHeader RemitentecolumnHeader;
        private ColumnHeader DestinatariocolumnHeader;
        private ColumnHeader DomiciliocolumnHeader;
        private ColumnHeader TamcolumnHeader;
        private ColumnHeader IntentocolumnHeader;
        private Button ConfirmarRendicionBoton;
        private Label CantGuiasCumplidasLabel;
        private Button CancelarRendicionBoton;
        private Label RespCantGuiasCumplidasLabel;
        private RadioButton HDRDistribucionRadioBoton;
        private RadioButton HDRRetiroRadioBoton;
        private ColumnHeader EstadocolumnHeader;
        private Button CambiarNoCumplidasBoton;
        private Button CambiarCumplidasBoton;
        private Label RespCantidadGuiasNoCumplidasLabel;
        private Label CantGuiasNoCumplidasLabel;
    }
}