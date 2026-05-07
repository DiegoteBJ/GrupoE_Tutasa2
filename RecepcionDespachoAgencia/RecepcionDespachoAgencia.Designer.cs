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
            GuiasAEntregarFleteroGroupBox = new GroupBox();
            GuiasEntregarAFleteroListView = new ListView();
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            GuiasRecibirGroupBox.SuspendLayout();
            GuiasAEntregarFleteroGroupBox.SuspendLayout();
            BuscarFleteroGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GuiasRecibirGroupBox
            // 
            GuiasRecibirGroupBox.Controls.Add(GuiasRecibirListView);
            GuiasRecibirGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuiasRecibirGroupBox.Location = new Point(30, 207);
            GuiasRecibirGroupBox.Name = "GuiasRecibirGroupBox";
            GuiasRecibirGroupBox.Size = new Size(277, 220);
            GuiasRecibirGroupBox.TabIndex = 0;
            GuiasRecibirGroupBox.TabStop = false;
            GuiasRecibirGroupBox.Text = "Hojas de ruta";
            // 
            // GuiasRecibirListView
            // 
            GuiasRecibirListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuiasRecibirListView.Location = new Point(23, 28);
            GuiasRecibirListView.Name = "GuiasRecibirListView";
            GuiasRecibirListView.Size = new Size(231, 175);
            GuiasRecibirListView.TabIndex = 0;
            GuiasRecibirListView.UseCompatibleStateImageBehavior = false;
            GuiasRecibirListView.View = View.Details;
            // 
            // GuiasAEntregarFleteroGroupBox
            // 
            GuiasAEntregarFleteroGroupBox.Controls.Add(label4);
            GuiasAEntregarFleteroGroupBox.Controls.Add(GuiasEntregarAFleteroListView);
            GuiasAEntregarFleteroGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuiasAEntregarFleteroGroupBox.Location = new Point(363, 207);
            GuiasAEntregarFleteroGroupBox.Name = "GuiasAEntregarFleteroGroupBox";
            GuiasAEntregarFleteroGroupBox.Size = new Size(430, 220);
            GuiasAEntregarFleteroGroupBox.TabIndex = 1;
            GuiasAEntregarFleteroGroupBox.TabStop = false;
            GuiasAEntregarFleteroGroupBox.Text = "Hojas de ruta a rendir";
            // 
            // GuiasEntregarAFleteroListView
            // 
            GuiasEntregarAFleteroListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuiasEntregarAFleteroListView.Location = new Point(21, 26);
            GuiasEntregarAFleteroListView.Name = "GuiasEntregarAFleteroListView";
            GuiasEntregarAFleteroListView.Size = new Size(388, 175);
            GuiasEntregarAFleteroListView.TabIndex = 0;
            GuiasEntregarAFleteroListView.UseCompatibleStateImageBehavior = false;
            GuiasEntregarAFleteroListView.View = View.Details;
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
            NombreFleteroLabel.Location = new Point(310, 111);
            NombreFleteroLabel.Name = "NombreFleteroLabel";
            NombreFleteroLabel.Size = new Size(66, 20);
            NombreFleteroLabel.TabIndex = 4;
            NombreFleteroLabel.Text = "Nombre";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApellidoLabel.Location = new Point(413, 32);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(66, 20);
            ApellidoLabel.TabIndex = 5;
            ApellidoLabel.Text = "Apellido";
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
            NombreFleteroRespuestaLabel.Location = new Point(280, 64);
            NombreFleteroRespuestaLabel.Name = "NombreFleteroRespuestaLabel";
            NombreFleteroRespuestaLabel.Size = new Size(114, 20);
            NombreFleteroRespuestaLabel.TabIndex = 8;
            NombreFleteroRespuestaLabel.Text = "Nombre Fletero";
            // 
            // ApellidoRespuestaLabel
            // 
            ApellidoRespuestaLabel.AutoSize = true;
            ApellidoRespuestaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApellidoRespuestaLabel.Location = new Point(413, 63);
            ApellidoRespuestaLabel.Name = "ApellidoRespuestaLabel";
            ApellidoRespuestaLabel.Size = new Size(116, 20);
            ApellidoRespuestaLabel.TabIndex = 9;
            ApellidoRespuestaLabel.Text = "Apellido Fletero";
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
            BuscarFleteroBoton.Size = new Size(94, 29);
            BuscarFleteroBoton.TabIndex = 11;
            BuscarFleteroBoton.Text = "Buscar";
            BuscarFleteroBoton.UseVisualStyleBackColor = true;
            BuscarFleteroBoton.Click += BuscarFleteroBoton_Click_1;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(699, 684);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(94, 29);
            CancelarBoton.TabIndex = 12;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click_1;
            // 
            // ConfirmarBoton
            // 
            ConfirmarBoton.Location = new Point(560, 684);
            ConfirmarBoton.Name = "ConfirmarBoton";
            ConfirmarBoton.Size = new Size(94, 29);
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
            BuscarFleteroGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarFleteroGroupBox.Location = new Point(30, 79);
            BuscarFleteroGroupBox.Name = "BuscarFleteroGroupBox";
            BuscarFleteroGroupBox.Size = new Size(763, 110);
            BuscarFleteroGroupBox.TabIndex = 14;
            BuscarFleteroGroupBox.TabStop = false;
            BuscarFleteroGroupBox.Text = "Buscar fletero por DNI";
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
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 251);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Hoja de ruta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "N° HDR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 23);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 2;
            label3.Text = "HDR-20250504-018";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 42);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 1;
            label4.Text = "HDR-20250504-018";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(22, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(430, 187);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Entregado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nro. Guia";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tipo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 140;
            // 
            // RecepcionDespachoAgencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 737);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(ConfirmarBoton);
            Controls.Add(CancelarBoton);
            Controls.Add(BuscarFleteroBoton);
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
            Load += RecepcionDespachoAgencia_Load;
            GuiasRecibirGroupBox.ResumeLayout(false);
            GuiasAEntregarFleteroGroupBox.ResumeLayout(false);
            GuiasAEntregarFleteroGroupBox.PerformLayout();
            BuscarFleteroGroupBox.ResumeLayout(false);
            BuscarFleteroGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ListView GuiasEntregarAFleteroListView;
        private GroupBox BuscarFleteroGroupBox;
        private Label DNILabel;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}