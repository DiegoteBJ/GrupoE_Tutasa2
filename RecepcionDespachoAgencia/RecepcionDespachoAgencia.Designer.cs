namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    partial class RecepcionDespachoAgencia
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
            GuiasRecibirGroupBox = new GroupBox();
            GuiasRecibirListView = new ListView();
            colNroGuia = new ColumnHeader();
            colTamaño = new ColumnHeader();
            GuiasAEntregarFleteroGroupBox = new GroupBox();
            GuiasEntregarAFleteroListView = new ListView();
            colNroGuiaD = new ColumnHeader();
            colTamañoD = new ColumnHeader();
            colDestino = new ColumnHeader();
            UsuarioLabel = new Label();
            AgenciaLabel = new Label();
            NombreFleteroLabel = new Label();
            ApellidoLabel = new Label();
            UsuarioRespuestaLabel = new Label();
            AgenciaRespuestaLabel = new Label();
            NombreFleteroRespuestaLabel = new Label();
            ApellidoRespuestaLabel = new Label();
            DNIFleteroBox = new TextBox();
            BuscarFleteroBoton = new Button();
            CancelarBoton = new Button();
            ConfirmarBoton = new Button();
            BuscarFleteroGroupBox = new GroupBox();
            DNILabel = new Label();
            GuiasRecibirGroupBox.SuspendLayout();
            GuiasAEntregarFleteroGroupBox.SuspendLayout();
            BuscarFleteroGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GuiasRecibirGroupBox
            // 
            GuiasRecibirGroupBox.Controls.Add(GuiasRecibirListView);
            GuiasRecibirGroupBox.Location = new Point(30, 217);
            GuiasRecibirGroupBox.Name = "GuiasRecibirGroupBox";
            GuiasRecibirGroupBox.Size = new Size(294, 220);
            GuiasRecibirGroupBox.TabIndex = 0;
            GuiasRecibirGroupBox.TabStop = false;
            GuiasRecibirGroupBox.Text = "Guías a recibir";
            // 
            // GuiasRecibirListView
            // 
            GuiasRecibirListView.Columns.AddRange(new ColumnHeader[] { colNroGuia, colTamaño });
            GuiasRecibirListView.Location = new Point(23, 28);
            GuiasRecibirListView.Name = "GuiasRecibirListView";
            GuiasRecibirListView.Size = new Size(247, 174);
            GuiasRecibirListView.TabIndex = 0;
            GuiasRecibirListView.UseCompatibleStateImageBehavior = false;
            GuiasRecibirListView.View = View.Details;
            // 
            // colNroGuia
            // 
            colNroGuia.Text = "Nro de guía";
            colNroGuia.Width = 120;
            // 
            // colTamaño
            // 
            colTamaño.Text = "Tamaño";
            colTamaño.Width = 120;
            // 
            // GuiasAEntregarFleteroGroupBox
            // 
            GuiasAEntregarFleteroGroupBox.Controls.Add(GuiasEntregarAFleteroListView);
            GuiasAEntregarFleteroGroupBox.Location = new Point(361, 217);
            GuiasAEntregarFleteroGroupBox.Name = "GuiasAEntregarFleteroGroupBox";
            GuiasAEntregarFleteroGroupBox.Size = new Size(453, 220);
            GuiasAEntregarFleteroGroupBox.TabIndex = 1;
            GuiasAEntregarFleteroGroupBox.TabStop = false;
            GuiasAEntregarFleteroGroupBox.Text = "Guías a entregar al fletero";
            // 
            // GuiasEntregarAFleteroListView
            // 
            GuiasEntregarAFleteroListView.Columns.AddRange(new ColumnHeader[] { colNroGuiaD, colTamañoD, colDestino });
            GuiasEntregarAFleteroListView.Location = new Point(20, 28);
            GuiasEntregarAFleteroListView.Name = "GuiasEntregarAFleteroListView";
            GuiasEntregarAFleteroListView.Size = new Size(415, 174);
            GuiasEntregarAFleteroListView.TabIndex = 0;
            GuiasEntregarAFleteroListView.UseCompatibleStateImageBehavior = false;
            GuiasEntregarAFleteroListView.View = View.Details;
            // 
            // colNroGuiaD
            // 
            colNroGuiaD.Text = "Nro de guía";
            colNroGuiaD.Width = 120;
            // 
            // colTamañoD
            // 
            colTamañoD.Text = "Tamaño";
            colTamañoD.Width = 120;
            // 
            // colDestino
            // 
            colDestino.Text = "Destino";
            colDestino.Width = 165;
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Location = new Point(31, 22);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new Size(62, 20);
            UsuarioLabel.TabIndex = 2;
            UsuarioLabel.Text = "Usuario:";
            // 
            // AgenciaLabel
            // 
            AgenciaLabel.AutoSize = true;
            AgenciaLabel.Location = new Point(218, 22);
            AgenciaLabel.Name = "AgenciaLabel";
            AgenciaLabel.Size = new Size(66, 20);
            AgenciaLabel.TabIndex = 3;
            AgenciaLabel.Text = "Agencia:";
            // 
            // NombreFleteroLabel
            // 
            NombreFleteroLabel.AutoSize = true;
            NombreFleteroLabel.Location = new Point(310, 111);
            NombreFleteroLabel.Name = "NombreFleteroLabel";
            NombreFleteroLabel.Size = new Size(64, 20);
            NombreFleteroLabel.TabIndex = 4;
            NombreFleteroLabel.Text = "Nombre";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Location = new Point(413, 32);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(66, 20);
            ApellidoLabel.TabIndex = 5;
            ApellidoLabel.Text = "Apellido";
            // 
            // UsuarioRespuestaLabel
            // 
            UsuarioRespuestaLabel.AutoSize = true;
            UsuarioRespuestaLabel.Location = new Point(99, 22);
            UsuarioRespuestaLabel.Name = "UsuarioRespuestaLabel";
            UsuarioRespuestaLabel.Size = new Size(75, 20);
            UsuarioRespuestaLabel.TabIndex = 6;
            UsuarioRespuestaLabel.Text = "Usuario01";
            // 
            // AgenciaRespuestaLabel
            // 
            AgenciaRespuestaLabel.AutoSize = true;
            AgenciaRespuestaLabel.Location = new Point(290, 22);
            AgenciaRespuestaLabel.Name = "AgenciaRespuestaLabel";
            AgenciaRespuestaLabel.Size = new Size(159, 20);
            AgenciaRespuestaLabel.TabIndex = 7;
            AgenciaRespuestaLabel.Text = "Agencia Moron Centro";
            // 
            // NombreFleteroRespuestaLabel
            // 
            NombreFleteroRespuestaLabel.AutoSize = true;
            NombreFleteroRespuestaLabel.Location = new Point(280, 64);
            NombreFleteroRespuestaLabel.Name = "NombreFleteroRespuestaLabel";
            NombreFleteroRespuestaLabel.Size = new Size(114, 20);
            NombreFleteroRespuestaLabel.TabIndex = 8;
            NombreFleteroRespuestaLabel.Text = "Nombre Fletero";
            // 
            // ApellidoRespuestaLabel
            // 
            ApellidoRespuestaLabel.AutoSize = true;
            ApellidoRespuestaLabel.Location = new Point(413, 63);
            ApellidoRespuestaLabel.Name = "ApellidoRespuestaLabel";
            ApellidoRespuestaLabel.Size = new Size(116, 20);
            ApellidoRespuestaLabel.TabIndex = 9;
            ApellidoRespuestaLabel.Text = "Apellido Fletero";
            // 
            // DNIFleteroBox
            // 
            DNIFleteroBox.Location = new Point(53, 135);
            DNIFleteroBox.Name = "DNIFleteroBox";
            DNIFleteroBox.Size = new Size(125, 27);
            DNIFleteroBox.TabIndex = 10;
            // 
            // BuscarFleteroBoton
            // 
            BuscarFleteroBoton.Location = new Point(190, 134);
            BuscarFleteroBoton.Name = "BuscarFleteroBoton";
            BuscarFleteroBoton.Size = new Size(94, 29);
            BuscarFleteroBoton.TabIndex = 11;
            BuscarFleteroBoton.Text = "Buscar";
            BuscarFleteroBoton.UseVisualStyleBackColor = true;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(720, 464);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(94, 29);
            CancelarBoton.TabIndex = 12;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarBoton
            // 
            ConfirmarBoton.Location = new Point(577, 464);
            ConfirmarBoton.Name = "ConfirmarBoton";
            ConfirmarBoton.Size = new Size(94, 29);
            ConfirmarBoton.TabIndex = 13;
            ConfirmarBoton.Text = "Confirmar";
            ConfirmarBoton.UseVisualStyleBackColor = true;
            // 
            // BuscarFleteroGroupBox
            // 
            BuscarFleteroGroupBox.Controls.Add(DNILabel);
            BuscarFleteroGroupBox.Controls.Add(NombreFleteroRespuestaLabel);
            BuscarFleteroGroupBox.Controls.Add(ApellidoRespuestaLabel);
            BuscarFleteroGroupBox.Controls.Add(ApellidoLabel);
            BuscarFleteroGroupBox.Location = new Point(30, 79);
            BuscarFleteroGroupBox.Name = "BuscarFleteroGroupBox";
            BuscarFleteroGroupBox.Size = new Size(784, 125);
            BuscarFleteroGroupBox.TabIndex = 14;
            BuscarFleteroGroupBox.TabStop = false;
            BuscarFleteroGroupBox.Text = "Buscar fletero por DNI";
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(23, 27);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(45, 20);
            DNILabel.TabIndex = 10;
            DNILabel.Text = "DNI *";
            // 
            // RecepcionDespachoAgencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 509);
            Controls.Add(ConfirmarBoton);
            Controls.Add(CancelarBoton);
            Controls.Add(BuscarFleteroBoton);
            Controls.Add(DNIFleteroBox);
            Controls.Add(AgenciaRespuestaLabel);
            Controls.Add(UsuarioRespuestaLabel);
            Controls.Add(NombreFleteroLabel);
            Controls.Add(AgenciaLabel);
            Controls.Add(UsuarioLabel);
            Controls.Add(GuiasAEntregarFleteroGroupBox);
            Controls.Add(GuiasRecibirGroupBox);
            Controls.Add(BuscarFleteroGroupBox);
            Name = "RecepcionDespachoAgencia";
            Text = "Recepción y despacho en agencia";
            GuiasRecibirGroupBox.ResumeLayout(false);
            GuiasAEntregarFleteroGroupBox.ResumeLayout(false);
            BuscarFleteroGroupBox.ResumeLayout(false);
            BuscarFleteroGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GuiasRecibirGroupBox;
        private GroupBox GuiasAEntregarFleteroGroupBox;
        private Label UsuarioLabel;
        private Label AgenciaLabel;
        private Label NombreFleteroLabel;
        private Label ApellidoLabel;
        private Label UsuarioRespuestaLabel;
        private Label AgenciaRespuestaLabel;
        private Label NombreFleteroRespuestaLabel;
        private Label ApellidoRespuestaLabel;
        private TextBox DNIFleteroBox;
        private Button BuscarFleteroBoton;
        private Button CancelarBoton;
        private Button ConfirmarBoton;
        private ListView GuiasRecibirListView;
        private ColumnHeader colNroGuia;
        private ColumnHeader colTamaño;
        private ListView GuiasEntregarAFleteroListView;
        private ColumnHeader colNroGuiaD;
        private ColumnHeader colTamañoD;
        private ColumnHeader colDestino;
        private GroupBox BuscarFleteroGroupBox;
        private Label DNILabel;
    }
}