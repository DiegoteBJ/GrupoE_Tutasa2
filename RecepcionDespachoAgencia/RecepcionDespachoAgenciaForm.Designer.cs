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
            HojasdeRutaGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HojasdeRutaGroupBox.Location = new Point(30, 207);
            HojasdeRutaGroupBox.Name = "HojasdeRutaGroupBox";
            HojasdeRutaGroupBox.Size = new Size(327, 220);
            HojasdeRutaGroupBox.TabIndex = 0;
            HojasdeRutaGroupBox.TabStop = false;
            HojasdeRutaGroupBox.Text = "Hojas de ruta";
            // 
            // HojasdeRutaListView
            // 
            HojasdeRutaListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HojasdeRutaListView.Location = new Point(23, 28);
            HojasdeRutaListView.Name = "HojasdeRutaListView";
            HojasdeRutaListView.Size = new Size(280, 175);
            HojasdeRutaListView.TabIndex = 0;
            HojasdeRutaListView.UseCompatibleStateImageBehavior = false;
            HojasdeRutaListView.View = View.Details;
            HojasdeRutaListView.SelectedIndexChanged += HojasdeRutaListView_SelectedIndexChanged;
            // 
            // HDRaRendirAgenciaGroupBox
            // 
            HDRaRendirAgenciaGroupBox.Controls.Add(HDRaRendirAgenciaListView);
            HDRaRendirAgenciaGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HDRaRendirAgenciaGroupBox.Location = new Point(397, 207);
            HDRaRendirAgenciaGroupBox.Name = "HDRaRendirAgenciaGroupBox";
            HDRaRendirAgenciaGroupBox.Size = new Size(333, 220);
            HDRaRendirAgenciaGroupBox.TabIndex = 1;
            HDRaRendirAgenciaGroupBox.TabStop = false;
            HDRaRendirAgenciaGroupBox.Text = "Hojas de ruta a recepcionar";
            // 
            // HDRaRendirAgenciaListView
            // 
            HDRaRendirAgenciaListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HDRaRendirAgenciaListView.Location = new Point(23, 28);
            HDRaRendirAgenciaListView.Name = "HDRaRendirAgenciaListView";
            HDRaRendirAgenciaListView.Size = new Size(280, 175);
            HDRaRendirAgenciaListView.TabIndex = 0;
            HDRaRendirAgenciaListView.UseCompatibleStateImageBehavior = false;
            HDRaRendirAgenciaListView.View = View.Details;
            HDRaRendirAgenciaListView.SelectedIndexChanged += HDRaRendirAgenciaListView_SelectedIndexChanged;
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsuarioLabel.Location = new Point(31, 21);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(66, 20);
            UsuarioLabel.TabIndex = 2;
            UsuarioLabel.Text = "Usuario:";
            // 
            // AgenciaLabel
            // 
            AgenciaLabel.AutoSize = true;
            AgenciaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgenciaLabel.Location = new Point(218, 21);
            AgenciaLabel.Name = "AgenciaLabel";
            AgenciaLabel.Size = new Size(68, 20);
            AgenciaLabel.TabIndex = 3;
            AgenciaLabel.Text = "Agencia:";
            // 
            // NombreFleteroLabel
            // 
            NombreFleteroLabel.AutoSize = true;
            NombreFleteroLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NombreFleteroLabel.Location = new Point(311, 32);
            NombreFleteroLabel.Name = "NombreFleteroLabel";
            NombreFleteroLabel.Size = new Size(66, 20);
            NombreFleteroLabel.TabIndex = 4;
            NombreFleteroLabel.Text = "Nombre";
            // 
            // UsuarioRespuestaLabel
            // 
            UsuarioRespuestaLabel.AutoSize = true;
            UsuarioRespuestaLabel.Location = new Point(99, 21);
            UsuarioRespuestaLabel.Name = "UsuarioRespuestaLabel";
            UsuarioRespuestaLabel.Size = new Size(75, 20);
            UsuarioRespuestaLabel.TabIndex = 6;
            UsuarioRespuestaLabel.Text = "Usuario01";
            // 
            // AgenciaRespuestaLabel
            // 
            AgenciaRespuestaLabel.AutoSize = true;
            AgenciaRespuestaLabel.Location = new Point(290, 21);
            AgenciaRespuestaLabel.Name = "AgenciaRespuestaLabel";
            AgenciaRespuestaLabel.Size = new Size(159, 20);
            AgenciaRespuestaLabel.TabIndex = 7;
            AgenciaRespuestaLabel.Text = "Agencia Moron Centro";
            // 
            // NombreFleteroRespuestaLabel
            // 
            NombreFleteroRespuestaLabel.AutoSize = true;
            NombreFleteroRespuestaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreFleteroRespuestaLabel.Location = new Point(311, 58);
            NombreFleteroRespuestaLabel.Name = "NombreFleteroRespuestaLabel";
            NombreFleteroRespuestaLabel.Size = new Size(114, 20);
            NombreFleteroRespuestaLabel.TabIndex = 8;
            NombreFleteroRespuestaLabel.Text = "Nombre Fletero";
            // 
            // DNIFleteroBox
            // 
            DNIFleteroBox.Location = new Point(23, 55);
            DNIFleteroBox.Name = "DNIFleteroBox";
            DNIFleteroBox.Size = new Size(125, 27);
            DNIFleteroBox.TabIndex = 10;
            // 
            // BuscarFleteroBoton
            // 
            BuscarFleteroBoton.Location = new Point(190, 133);
            BuscarFleteroBoton.Name = "BuscarFleteroBoton";
            BuscarFleteroBoton.Size = new Size(117, 29);
            BuscarFleteroBoton.TabIndex = 11;
            BuscarFleteroBoton.Text = "Buscar Fletero";
            BuscarFleteroBoton.UseVisualStyleBackColor = true;
            BuscarFleteroBoton.Click += BuscarFleteroBoton_Click;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(622, 696);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(108, 29);
            CancelarBoton.TabIndex = 12;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // ConfirmarBoton
            // 
            ConfirmarBoton.Location = new Point(468, 696);
            ConfirmarBoton.Name = "ConfirmarBoton";
            ConfirmarBoton.Size = new Size(106, 29);
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
            BuscarFleteroGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarFleteroGroupBox.Location = new Point(30, 79);
            BuscarFleteroGroupBox.Name = "BuscarFleteroGroupBox";
            BuscarFleteroGroupBox.Size = new Size(763, 109);
            BuscarFleteroGroupBox.TabIndex = 14;
            BuscarFleteroGroupBox.TabStop = false;
            BuscarFleteroGroupBox.Text = "Buscar DNI";
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DNILabel.Location = new Point(23, 27);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(45, 20);
            DNILabel.TabIndex = 10;
            DNILabel.Text = "DNI *";
            // 
            // ApellidoRespuestaLabel
            // 
            ApellidoRespuestaLabel.AutoSize = true;
            ApellidoRespuestaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApellidoRespuestaLabel.Location = new Point(460, 58);
            ApellidoRespuestaLabel.Name = "ApellidoRespuestaLabel";
            ApellidoRespuestaLabel.Size = new Size(116, 20);
            ApellidoRespuestaLabel.TabIndex = 9;
            ApellidoRespuestaLabel.Text = "Apellido Fletero";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApellidoLabel.Location = new Point(460, 32);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(66, 20);
            ApellidoLabel.TabIndex = 5;
            ApellidoLabel.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 431);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NumeroHDRSuperiorLabel);
            groupBox1.Controls.Add(DetalleGuiasListView);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(31, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 252);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Hoja de ruta";
            // 
            // NumeroHDRSuperiorLabel
            // 
            NumeroHDRSuperiorLabel.AutoSize = true;
            NumeroHDRSuperiorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumeroHDRSuperiorLabel.Location = new Point(89, 23);
            NumeroHDRSuperiorLabel.Name = "NumeroHDRSuperiorLabel";
            NumeroHDRSuperiorLabel.Size = new Size(110, 20);
            NumeroHDRSuperiorLabel.TabIndex = 2;
            NumeroHDRSuperiorLabel.Text = "[HDR-Numero]";
            // 
            // DetalleGuiasListView
            // 
            DetalleGuiasListView.CheckBoxes = true;
            DetalleGuiasListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader2 });
            DetalleGuiasListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DetalleGuiasListView.Location = new Point(22, 56);
            DetalleGuiasListView.Margin = new Padding(3, 4, 3, 4);
            DetalleGuiasListView.Name = "DetalleGuiasListView";
            DetalleGuiasListView.Size = new Size(371, 179);
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
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "N° HDR";
            // 
            // RecepcionDespachoAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 737);
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
            Controls.Add(HojasdeRutaGroupBox);
            Controls.Add(BuscarFleteroGroupBox);
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