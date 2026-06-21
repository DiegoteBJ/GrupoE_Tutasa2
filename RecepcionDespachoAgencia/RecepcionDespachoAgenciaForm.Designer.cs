namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    partial class RecepcionDespachoAgenciaForm
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
            HojasdeRutaGroupBox = new GroupBox();
            HojasdeRutaListView = new ListView();
            HDRaRendirAgenciaGroupBox = new GroupBox();
            HDRaRendirAgenciaListView = new ListView();
            UsuarioLabel = new Label();
            AgenciaLabel = new Label();
            NombreFleteroLabel = new Label();
            UsuarioRespuestaLabel = new Label();
            AgenciaRespuestaLabel = new Label();
            NombreFleteroRespuestaLabel = new Label();
            DNIFleteroBox = new TextBox();
            BuscarFleteroBoton = new Button();
            CancelarBoton = new Button();
            ConfirmarBoton = new Button();
            BuscarFleteroGroupBox = new GroupBox();
            DNILabel = new Label();
            ApellidoRespuestaLabel = new Label();
            ApellidoLabel = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            NumeroHDRSuperiorLabel = new Label();
            DetalleGuiasListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label2 = new Label();
            HojasdeRutaGroupBox.SuspendLayout();
            HDRaRendirAgenciaGroupBox.SuspendLayout();
            BuscarFleteroGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // HojasdeRutaGroupBox
            // 
            HojasdeRutaGroupBox.Controls.Add(HojasdeRutaListView);
            HojasdeRutaGroupBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HojasdeRutaGroupBox.Location = new Point(340, 156);
            HojasdeRutaGroupBox.Margin = new Padding(3, 2, 3, 2);
            HojasdeRutaGroupBox.Name = "HojasdeRutaGroupBox";
            HojasdeRutaGroupBox.Padding = new Padding(3, 2, 3, 2);
            HojasdeRutaGroupBox.Size = new Size(286, 165);
            HojasdeRutaGroupBox.TabIndex = 0;
            HojasdeRutaGroupBox.TabStop = false;
            HojasdeRutaGroupBox.Text = "Hojas de ruta a despachar";
            // 
            // HojasdeRutaListView
            // 
            HojasdeRutaListView.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HojasdeRutaListView.Location = new Point(18, 21);
            HojasdeRutaListView.Margin = new Padding(3, 2, 3, 2);
            HojasdeRutaListView.Name = "HojasdeRutaListView";
            HojasdeRutaListView.Size = new Size(246, 132);
            HojasdeRutaListView.TabIndex = 0;
            HojasdeRutaListView.UseCompatibleStateImageBehavior = false;
            HojasdeRutaListView.View = View.Details;
            HojasdeRutaListView.SelectedIndexChanged += HojasdeRutaListView_SelectedIndexChanged;
            // 
            // HDRaRendirAgenciaGroupBox
            // 
            HDRaRendirAgenciaGroupBox.Controls.Add(HDRaRendirAgenciaListView);
            HDRaRendirAgenciaGroupBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HDRaRendirAgenciaGroupBox.Location = new Point(27, 156);
            HDRaRendirAgenciaGroupBox.Margin = new Padding(3, 2, 3, 2);
            HDRaRendirAgenciaGroupBox.Name = "HDRaRendirAgenciaGroupBox";
            HDRaRendirAgenciaGroupBox.Padding = new Padding(3, 2, 3, 2);
            HDRaRendirAgenciaGroupBox.Size = new Size(291, 165);
            HDRaRendirAgenciaGroupBox.TabIndex = 1;
            HDRaRendirAgenciaGroupBox.TabStop = false;
            HDRaRendirAgenciaGroupBox.Text = "Hojas de ruta a recepcionar";
            // 
            // HDRaRendirAgenciaListView
            // 
            HDRaRendirAgenciaListView.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HDRaRendirAgenciaListView.Location = new Point(20, 21);
            HDRaRendirAgenciaListView.Margin = new Padding(3, 2, 3, 2);
            HDRaRendirAgenciaListView.Name = "HDRaRendirAgenciaListView";
            HDRaRendirAgenciaListView.Size = new Size(246, 132);
            HDRaRendirAgenciaListView.TabIndex = 0;
            HDRaRendirAgenciaListView.UseCompatibleStateImageBehavior = false;
            HDRaRendirAgenciaListView.View = View.Details;
            HDRaRendirAgenciaListView.SelectedIndexChanged += HDRaRendirAgenciaListView_SelectedIndexChanged;
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsuarioLabel.Location = new Point(27, 16);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(50, 15);
            UsuarioLabel.TabIndex = 2;
            UsuarioLabel.Text = "Usuario:";
            // 
            // AgenciaLabel
            // 
            AgenciaLabel.AutoSize = true;
            AgenciaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgenciaLabel.Location = new Point(191, 16);
            AgenciaLabel.Name = "AgenciaLabel";
            AgenciaLabel.Size = new Size(53, 15);
            AgenciaLabel.TabIndex = 3;
            AgenciaLabel.Text = "Agencia:";
            // 
            // NombreFleteroLabel
            // 
            NombreFleteroLabel.AutoSize = true;
            NombreFleteroLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NombreFleteroLabel.Location = new Point(272, 24);
            NombreFleteroLabel.Name = "NombreFleteroLabel";
            NombreFleteroLabel.Size = new Size(52, 15);
            NombreFleteroLabel.TabIndex = 4;
            NombreFleteroLabel.Text = "Nombre";
            // 
            // UsuarioRespuestaLabel
            // 
            UsuarioRespuestaLabel.AutoSize = true;
            UsuarioRespuestaLabel.Location = new Point(87, 16);
            UsuarioRespuestaLabel.Name = "UsuarioRespuestaLabel";
            UsuarioRespuestaLabel.Size = new Size(65, 15);
            UsuarioRespuestaLabel.TabIndex = 6;
            UsuarioRespuestaLabel.Text = "Usuario01";
            // 
            // AgenciaRespuestaLabel
            // 
            AgenciaRespuestaLabel.AutoSize = true;
            AgenciaRespuestaLabel.Location = new Point(254, 16);
            AgenciaRespuestaLabel.Name = "AgenciaRespuestaLabel";
            AgenciaRespuestaLabel.Size = new Size(133, 15);
            AgenciaRespuestaLabel.TabIndex = 7;
            AgenciaRespuestaLabel.Text = "Agencia Moron Centro";
            // 
            // NombreFleteroRespuestaLabel
            // 
            NombreFleteroRespuestaLabel.AutoSize = true;
            NombreFleteroRespuestaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreFleteroRespuestaLabel.Location = new Point(272, 44);
            NombreFleteroRespuestaLabel.Name = "NombreFleteroRespuestaLabel";
            NombreFleteroRespuestaLabel.Size = new Size(90, 15);
            NombreFleteroRespuestaLabel.TabIndex = 8;
            NombreFleteroRespuestaLabel.Text = "Nombre Fletero";
            // 
            // DNIFleteroBox
            // 
            DNIFleteroBox.Location = new Point(20, 41);
            DNIFleteroBox.Margin = new Padding(3, 2, 3, 2);
            DNIFleteroBox.Name = "DNIFleteroBox";
            DNIFleteroBox.Size = new Size(110, 21);
            DNIFleteroBox.TabIndex = 10;
            // 
            // BuscarFleteroBoton
            // 
            BuscarFleteroBoton.Location = new Point(166, 100);
            BuscarFleteroBoton.Margin = new Padding(3, 2, 3, 2);
            BuscarFleteroBoton.Name = "BuscarFleteroBoton";
            BuscarFleteroBoton.Size = new Size(102, 22);
            BuscarFleteroBoton.TabIndex = 11;
            BuscarFleteroBoton.Text = "Buscar Fletero";
            BuscarFleteroBoton.UseVisualStyleBackColor = true;
            BuscarFleteroBoton.Click += BuscarFleteroBoton_Click;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(544, 522);
            CancelarBoton.Margin = new Padding(3, 2, 3, 2);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(94, 22);
            CancelarBoton.TabIndex = 12;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // ConfirmarBoton
            // 
            ConfirmarBoton.Location = new Point(410, 522);
            ConfirmarBoton.Margin = new Padding(3, 2, 3, 2);
            ConfirmarBoton.Name = "ConfirmarBoton";
            ConfirmarBoton.Size = new Size(93, 22);
            ConfirmarBoton.TabIndex = 13;
            ConfirmarBoton.Text = "Confirmar";
            ConfirmarBoton.UseVisualStyleBackColor = true;
            ConfirmarBoton.Click += ConfirmarBoton_Click_1;
            // 
            // BuscarFleteroGroupBox
            // 
            BuscarFleteroGroupBox.Controls.Add(DNILabel);
            BuscarFleteroGroupBox.Controls.Add(NombreFleteroRespuestaLabel);
            BuscarFleteroGroupBox.Controls.Add(ApellidoRespuestaLabel);
            BuscarFleteroGroupBox.Controls.Add(DNIFleteroBox);
            BuscarFleteroGroupBox.Controls.Add(ApellidoLabel);
            BuscarFleteroGroupBox.Controls.Add(NombreFleteroLabel);
            BuscarFleteroGroupBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarFleteroGroupBox.Location = new Point(26, 59);
            BuscarFleteroGroupBox.Margin = new Padding(3, 2, 3, 2);
            BuscarFleteroGroupBox.Name = "BuscarFleteroGroupBox";
            BuscarFleteroGroupBox.Padding = new Padding(3, 2, 3, 2);
            BuscarFleteroGroupBox.Size = new Size(668, 82);
            BuscarFleteroGroupBox.TabIndex = 14;
            BuscarFleteroGroupBox.TabStop = false;
            BuscarFleteroGroupBox.Text = "Buscar DNI";
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DNILabel.Location = new Point(20, 20);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(34, 15);
            DNILabel.TabIndex = 10;
            DNILabel.Text = "DNI *";
            // 
            // ApellidoRespuestaLabel
            // 
            ApellidoRespuestaLabel.AutoSize = true;
            ApellidoRespuestaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApellidoRespuestaLabel.Location = new Point(402, 44);
            ApellidoRespuestaLabel.Name = "ApellidoRespuestaLabel";
            ApellidoRespuestaLabel.Size = new Size(90, 15);
            ApellidoRespuestaLabel.TabIndex = 9;
            ApellidoRespuestaLabel.Text = "Apellido Fletero";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApellidoLabel.Location = new Point(402, 24);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(52, 15);
            ApellidoLabel.TabIndex = 5;
            ApellidoLabel.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 323);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NumeroHDRSuperiorLabel);
            groupBox1.Controls.Add(DetalleGuiasListView);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 333);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(366, 189);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Hoja de ruta";
            // 
            // NumeroHDRSuperiorLabel
            // 
            NumeroHDRSuperiorLabel.AutoSize = true;
            NumeroHDRSuperiorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumeroHDRSuperiorLabel.Location = new Point(78, 17);
            NumeroHDRSuperiorLabel.Name = "NumeroHDRSuperiorLabel";
            NumeroHDRSuperiorLabel.Size = new Size(88, 15);
            NumeroHDRSuperiorLabel.TabIndex = 2;
            NumeroHDRSuperiorLabel.Text = "[HDR-Numero]";
            // 
            // DetalleGuiasListView
            // 
            DetalleGuiasListView.CheckBoxes = true;
            DetalleGuiasListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader2 });
            DetalleGuiasListView.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetalleGuiasListView.ForeColor = Color.Blue;
            DetalleGuiasListView.Location = new Point(19, 42);
            DetalleGuiasListView.Name = "DetalleGuiasListView";
            DetalleGuiasListView.Size = new Size(325, 135);
            DetalleGuiasListView.TabIndex = 17;
            DetalleGuiasListView.UseCompatibleStateImageBehavior = false;
            DetalleGuiasListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Entregado";
            columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro. Guia";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 17);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "N° HDR";
            // 
            // RecepcionDespachoAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 553);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(ConfirmarBoton);
            Controls.Add(CancelarBoton);
            Controls.Add(BuscarFleteroBoton);
            Controls.Add(AgenciaRespuestaLabel);
            Controls.Add(UsuarioRespuestaLabel);
            Controls.Add(AgenciaLabel);
            Controls.Add(UsuarioLabel);
            Controls.Add(HDRaRendirAgenciaGroupBox);
            Controls.Add(BuscarFleteroGroupBox);
            Controls.Add(HojasdeRutaGroupBox);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RecepcionDespachoAgenciaForm";
            Text = "Recepción y despacho en agencia";
            Load += RecepcionDespachoAgenciaForm_Load;
            HojasdeRutaGroupBox.ResumeLayout(false);
            HDRaRendirAgenciaGroupBox.ResumeLayout(false);
            BuscarFleteroGroupBox.ResumeLayout(false);
            BuscarFleteroGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox HojasdeRutaGroupBox;
        private GroupBox HDRaRendirAgenciaGroupBox;
        private Label UsuarioLabel;
        private Label AgenciaLabel;
        private Label NombreFleteroLabel;
        private Label UsuarioRespuestaLabel;
        private Label AgenciaRespuestaLabel;
        private Label NombreFleteroRespuestaLabel;
        private TextBox DNIFleteroBox;
        private Button BuscarFleteroBoton;
        private Button CancelarBoton;
        private Button ConfirmarBoton;
        private ListView HojasdeRutaListView;
        private ListView HDRaRendirAgenciaListView;
        private GroupBox BuscarFleteroGroupBox;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ListView DetalleGuiasListView;
        private Label DNILabel;
        private Label ApellidoRespuestaLabel;
        private Label ApellidoLabel;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label NumeroHDRSuperiorLabel;
    }
}