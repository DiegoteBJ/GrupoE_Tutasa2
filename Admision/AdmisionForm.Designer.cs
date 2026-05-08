namespace GrupoE_Tutasa.Admision
{
    partial class AdmisionForm
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
            label2 = new Label();
            NumeroGuiaTextBox = new TextBox();
            BuscarGuiaBoton = new Button();
            groupBox1 = new GroupBox();
            EstadoGuiaLabel = new Label();
            CDDestinoGuiaLabel = new Label();
            CDOrigenGuiaLabel = new Label();
            FechaGuiaLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            DatosGenerales = new GroupBox();
            ValidacionGroupBox = new GroupBox();
            TamañoIncorrectoBoton = new RadioButton();
            TamañoCorrectoBoton = new RadioButton();
            TamañoDeclaradoLabel = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            CambiarTamañoBoton = new Button();
            TamañoReclasificacionComboBox = new ComboBox();
            label7 = new Label();
            AdmitirBoton = new Button();
            RechazarBoton = new Button();
            ObservacionesTextBox = new TextBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            DatosGenerales.SuspendLayout();
            ValidacionGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 29);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el número de guía a buscar";
            // 
            // NumeroGuiaTextBox
            // 
            NumeroGuiaTextBox.Location = new Point(260, 37);
            NumeroGuiaTextBox.Margin = new Padding(3, 2, 3, 2);
            NumeroGuiaTextBox.Name = "NumeroGuiaTextBox";
            NumeroGuiaTextBox.Size = new Size(110, 23);
            NumeroGuiaTextBox.TabIndex = 2;
            // 
            // BuscarGuiaBoton
            // 
            BuscarGuiaBoton.Location = new Point(260, 71);
            BuscarGuiaBoton.Margin = new Padding(3, 2, 3, 2);
            BuscarGuiaBoton.Name = "BuscarGuiaBoton";
            BuscarGuiaBoton.Size = new Size(109, 22);
            BuscarGuiaBoton.TabIndex = 3;
            BuscarGuiaBoton.Text = "Buscar Guía";
            BuscarGuiaBoton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EstadoGuiaLabel);
            groupBox1.Controls.Add(CDDestinoGuiaLabel);
            groupBox1.Controls.Add(CDOrigenGuiaLabel);
            groupBox1.Controls.Add(FechaGuiaLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(410, 10);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(346, 134);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado búsqueda";
            // 
            // EstadoGuiaLabel
            // 
            EstadoGuiaLabel.AutoSize = true;
            EstadoGuiaLabel.Location = new Point(161, 109);
            EstadoGuiaLabel.Name = "EstadoGuiaLabel";
            EstadoGuiaLabel.Size = new Size(104, 15);
            EstadoGuiaLabel.TabIndex = 6;
            EstadoGuiaLabel.Text = "[Estado de la guia]";
            // 
            // CDDestinoGuiaLabel
            // 
            CDDestinoGuiaLabel.AutoSize = true;
            CDDestinoGuiaLabel.Location = new Point(161, 78);
            CDDestinoGuiaLabel.Name = "CDDestinoGuiaLabel";
            CDDestinoGuiaLabel.Size = new Size(74, 15);
            CDDestinoGuiaLabel.TabIndex = 6;
            CDDestinoGuiaLabel.Text = "[CD Destino]";
            // 
            // CDOrigenGuiaLabel
            // 
            CDOrigenGuiaLabel.AutoSize = true;
            CDOrigenGuiaLabel.Location = new Point(161, 50);
            CDOrigenGuiaLabel.Name = "CDOrigenGuiaLabel";
            CDOrigenGuiaLabel.Size = new Size(70, 15);
            CDOrigenGuiaLabel.TabIndex = 6;
            CDOrigenGuiaLabel.Text = "[CD Origen]";
            // 
            // FechaGuiaLabel
            // 
            FechaGuiaLabel.AutoSize = true;
            FechaGuiaLabel.Location = new Point(161, 21);
            FechaGuiaLabel.Name = "FechaGuiaLabel";
            FechaGuiaLabel.Size = new Size(100, 15);
            FechaGuiaLabel.TabIndex = 4;
            FechaGuiaLabel.Text = "[Fecha de la guia]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 109);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 3;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 78);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 2;
            label4.Text = "CD de Origen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 50);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "CD de Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 22);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha de Imposición";
            // 
            // DatosGenerales
            // 
            DatosGenerales.Controls.Add(label2);
            DatosGenerales.Location = new Point(13, 10);
            DatosGenerales.Margin = new Padding(3, 2, 3, 2);
            DatosGenerales.Name = "DatosGenerales";
            DatosGenerales.Padding = new Padding(3, 2, 3, 2);
            DatosGenerales.Size = new Size(392, 134);
            DatosGenerales.TabIndex = 5;
            DatosGenerales.TabStop = false;
            DatosGenerales.Text = "Datos Generales";
            // 
            // ValidacionGroupBox
            // 
            ValidacionGroupBox.Controls.Add(TamañoIncorrectoBoton);
            ValidacionGroupBox.Controls.Add(TamañoCorrectoBoton);
            ValidacionGroupBox.Controls.Add(TamañoDeclaradoLabel);
            ValidacionGroupBox.Controls.Add(label6);
            ValidacionGroupBox.Location = new Point(14, 154);
            ValidacionGroupBox.Margin = new Padding(3, 2, 3, 2);
            ValidacionGroupBox.Name = "ValidacionGroupBox";
            ValidacionGroupBox.Padding = new Padding(3, 2, 3, 2);
            ValidacionGroupBox.Size = new Size(391, 94);
            ValidacionGroupBox.TabIndex = 6;
            ValidacionGroupBox.TabStop = false;
            ValidacionGroupBox.Text = "Validación";
            // 
            // TamañoIncorrectoBoton
            // 
            TamañoIncorrectoBoton.AutoSize = true;
            TamañoIncorrectoBoton.Location = new Point(233, 57);
            TamañoIncorrectoBoton.Margin = new Padding(3, 2, 3, 2);
            TamañoIncorrectoBoton.Name = "TamañoIncorrectoBoton";
            TamañoIncorrectoBoton.Size = new Size(125, 19);
            TamañoIncorrectoBoton.TabIndex = 3;
            TamañoIncorrectoBoton.Text = "Tamaño Incorrecto";
            TamañoIncorrectoBoton.UseVisualStyleBackColor = true;
            // 
            // TamañoCorrectoBoton
            // 
            TamañoCorrectoBoton.AutoSize = true;
            TamañoCorrectoBoton.Checked = true;
            TamañoCorrectoBoton.Location = new Point(233, 23);
            TamañoCorrectoBoton.Margin = new Padding(3, 2, 3, 2);
            TamañoCorrectoBoton.Name = "TamañoCorrectoBoton";
            TamañoCorrectoBoton.Size = new Size(117, 19);
            TamañoCorrectoBoton.TabIndex = 2;
            TamañoCorrectoBoton.TabStop = true;
            TamañoCorrectoBoton.Text = "Tamaño Correcto";
            TamañoCorrectoBoton.UseVisualStyleBackColor = true;
            // 
            // TamañoDeclaradoLabel
            // 
            TamañoDeclaradoLabel.AutoSize = true;
            TamañoDeclaradoLabel.Location = new Point(132, 24);
            TamañoDeclaradoLabel.Name = "TamañoDeclaradoLabel";
            TamañoDeclaradoLabel.Size = new Size(58, 15);
            TamañoDeclaradoLabel.TabIndex = 1;
            TamañoDeclaradoLabel.Text = "[Tamaño]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 24);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 0;
            label6.Text = "Tamaño Declarado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CambiarTamañoBoton);
            groupBox2.Controls.Add(TamañoReclasificacionComboBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(410, 154);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(346, 94);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reclasificación Caja";
            // 
            // CambiarTamañoBoton
            // 
            CambiarTamañoBoton.Location = new Point(190, 52);
            CambiarTamañoBoton.Margin = new Padding(3, 2, 3, 2);
            CambiarTamañoBoton.Name = "CambiarTamañoBoton";
            CambiarTamañoBoton.Size = new Size(135, 22);
            CambiarTamañoBoton.TabIndex = 4;
            CambiarTamañoBoton.Text = "Cambiar tamaño";
            CambiarTamañoBoton.UseVisualStyleBackColor = true;
            // 
            // TamañoReclasificacionComboBox
            // 
            TamañoReclasificacionComboBox.Enabled = false;
            TamañoReclasificacionComboBox.FormattingEnabled = true;
            TamañoReclasificacionComboBox.Location = new Point(13, 52);
            TamañoReclasificacionComboBox.Margin = new Padding(3, 2, 3, 2);
            TamañoReclasificacionComboBox.Name = "TamañoReclasificacionComboBox";
            TamañoReclasificacionComboBox.Size = new Size(133, 23);
            TamañoReclasificacionComboBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 27);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 0;
            label7.Text = "Ingrese el tamaño correcto";
            // 
            // AdmitirBoton
            // 
            AdmitirBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AdmitirBoton.ForeColor = Color.Lime;
            AdmitirBoton.Location = new Point(653, 304);
            AdmitirBoton.Margin = new Padding(3, 2, 3, 2);
            AdmitirBoton.Name = "AdmitirBoton";
            AdmitirBoton.Size = new Size(104, 40);
            AdmitirBoton.TabIndex = 8;
            AdmitirBoton.Text = "Admitir";
            AdmitirBoton.UseVisualStyleBackColor = true;
            AdmitirBoton.Click += AdmitirBoton_Click;
            // 
            // RechazarBoton
            // 
            RechazarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RechazarBoton.ForeColor = Color.Red;
            RechazarBoton.Location = new Point(530, 304);
            RechazarBoton.Margin = new Padding(3, 2, 3, 2);
            RechazarBoton.Name = "RechazarBoton";
            RechazarBoton.Size = new Size(110, 40);
            RechazarBoton.TabIndex = 9;
            RechazarBoton.Text = "Rechazar";
            RechazarBoton.UseVisualStyleBackColor = true;
            RechazarBoton.Click += RechazarBoton_Click;
            // 
            // ObservacionesTextBox
            // 
            ObservacionesTextBox.Location = new Point(10, 20);
            ObservacionesTextBox.Margin = new Padding(3, 2, 3, 2);
            ObservacionesTextBox.Name = "ObservacionesTextBox";
            ObservacionesTextBox.Size = new Size(362, 23);
            ObservacionesTextBox.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ObservacionesTextBox);
            groupBox3.Location = new Point(14, 262);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(391, 82);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Observaciones";
            // 
            // AdmisionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 364);
            Controls.Add(groupBox3);
            Controls.Add(RechazarBoton);
            Controls.Add(AdmitirBoton);
            Controls.Add(groupBox2);
            Controls.Add(ValidacionGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(BuscarGuiaBoton);
            Controls.Add(NumeroGuiaTextBox);
            Controls.Add(DatosGenerales);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdmisionForm";
            Text = "Admisión";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            DatosGenerales.ResumeLayout(false);
            DatosGenerales.PerformLayout();
            ValidacionGroupBox.ResumeLayout(false);
            ValidacionGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox NumeroGuiaTextBox;
        private Button BuscarGuiaBoton;
        private GroupBox groupBox1;
        private Label label3;
        private GroupBox DatosGenerales;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label EstadoGuiaLabel;
        private Label CDDestinoGuiaLabel;
        private Label CDOrigenGuiaLabel;
        private Label FechaGuiaLabel;
        private GroupBox ValidacionGroupBox;
        private RadioButton TamañoIncorrectoBoton;
        private RadioButton TamañoCorrectoBoton;
        private Label TamañoDeclaradoLabel;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private ComboBox TamañoReclasificacionComboBox;
        private Button AdmitirBoton;
        private Button RechazarBoton;
        private TextBox ObservacionesTextBox;
        private GroupBox groupBox3;
        private Button CambiarTamañoBoton;
    }
}