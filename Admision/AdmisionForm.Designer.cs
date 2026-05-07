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
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(241, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el número de guía a buscar";
            // 
            // NumeroGuiaTextBox
            // 
            NumeroGuiaTextBox.Location = new Point(297, 49);
            NumeroGuiaTextBox.Name = "NumeroGuiaTextBox";
            NumeroGuiaTextBox.Size = new Size(125, 27);
            NumeroGuiaTextBox.TabIndex = 2;
            // 
            // BuscarGuiaBoton
            // 
            BuscarGuiaBoton.Location = new Point(297, 95);
            BuscarGuiaBoton.Name = "BuscarGuiaBoton";
            BuscarGuiaBoton.Size = new Size(125, 29);
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
            groupBox1.Location = new Point(469, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 178);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado búsqueda";
            // 
            // EstadoGuiaLabel
            // 
            EstadoGuiaLabel.AutoSize = true;
            EstadoGuiaLabel.Location = new Point(184, 145);
            EstadoGuiaLabel.Name = "EstadoGuiaLabel";
            EstadoGuiaLabel.Size = new Size(134, 20);
            EstadoGuiaLabel.TabIndex = 6;
            EstadoGuiaLabel.Text = "[Estado de la guia]";
            // 
            // CDDestinoGuiaLabel
            // 
            CDDestinoGuiaLabel.AutoSize = true;
            CDDestinoGuiaLabel.Location = new Point(184, 104);
            CDDestinoGuiaLabel.Name = "CDDestinoGuiaLabel";
            CDDestinoGuiaLabel.Size = new Size(94, 20);
            CDDestinoGuiaLabel.TabIndex = 6;
            CDDestinoGuiaLabel.Text = "[CD Destino]";
            // 
            // CDOrigenGuiaLabel
            // 
            CDOrigenGuiaLabel.AutoSize = true;
            CDOrigenGuiaLabel.Location = new Point(184, 67);
            CDOrigenGuiaLabel.Name = "CDOrigenGuiaLabel";
            CDOrigenGuiaLabel.Size = new Size(88, 20);
            CDOrigenGuiaLabel.TabIndex = 6;
            CDOrigenGuiaLabel.Text = "[CD Origen]";
            // 
            // FechaGuiaLabel
            // 
            FechaGuiaLabel.AutoSize = true;
            FechaGuiaLabel.Location = new Point(184, 28);
            FechaGuiaLabel.Name = "FechaGuiaLabel";
            FechaGuiaLabel.Size = new Size(127, 20);
            FechaGuiaLabel.TabIndex = 4;
            FechaGuiaLabel.Text = "[Fecha de la guia]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 145);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 3;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 104);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 2;
            label4.Text = "CD de Origen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 67);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "CD de Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 30);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 0;
            label3.Text = "Fecha de Imposición";
            // 
            // DatosGenerales
            // 
            DatosGenerales.Controls.Add(label2);
            DatosGenerales.Location = new Point(15, 13);
            DatosGenerales.Name = "DatosGenerales";
            DatosGenerales.Size = new Size(448, 178);
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
            ValidacionGroupBox.Location = new Point(16, 205);
            ValidacionGroupBox.Name = "ValidacionGroupBox";
            ValidacionGroupBox.Size = new Size(447, 125);
            ValidacionGroupBox.TabIndex = 6;
            ValidacionGroupBox.TabStop = false;
            ValidacionGroupBox.Text = "Validación";
            // 
            // TamañoIncorrectoBoton
            // 
            TamañoIncorrectoBoton.AutoSize = true;
            TamañoIncorrectoBoton.Location = new Point(266, 76);
            TamañoIncorrectoBoton.Name = "TamañoIncorrectoBoton";
            TamañoIncorrectoBoton.Size = new Size(153, 24);
            TamañoIncorrectoBoton.TabIndex = 3;
            TamañoIncorrectoBoton.Text = "Tamaño Incorrecto";
            TamañoIncorrectoBoton.UseVisualStyleBackColor = true;
            // 
            // TamañoCorrectoBoton
            // 
            TamañoCorrectoBoton.AutoSize = true;
            TamañoCorrectoBoton.Checked = true;
            TamañoCorrectoBoton.Location = new Point(266, 31);
            TamañoCorrectoBoton.Name = "TamañoCorrectoBoton";
            TamañoCorrectoBoton.Size = new Size(143, 24);
            TamañoCorrectoBoton.TabIndex = 2;
            TamañoCorrectoBoton.TabStop = true;
            TamañoCorrectoBoton.Text = "Tamaño Correcto";
            TamañoCorrectoBoton.UseVisualStyleBackColor = true;
            // 
            // TamañoDeclaradoLabel
            // 
            TamañoDeclaradoLabel.AutoSize = true;
            TamañoDeclaradoLabel.Location = new Point(151, 32);
            TamañoDeclaradoLabel.Name = "TamañoDeclaradoLabel";
            TamañoDeclaradoLabel.Size = new Size(71, 20);
            TamañoDeclaradoLabel.TabIndex = 1;
            TamañoDeclaradoLabel.Text = "[Tamaño]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 32);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 0;
            label6.Text = "Tamaño Declarado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CambiarTamañoBoton);
            groupBox2.Controls.Add(TamañoReclasificacionComboBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(469, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reclasificación Caja";
            // 
            // CambiarTamañoBoton
            // 
            CambiarTamañoBoton.Location = new Point(217, 69);
            CambiarTamañoBoton.Name = "CambiarTamañoBoton";
            CambiarTamañoBoton.Size = new Size(154, 29);
            CambiarTamañoBoton.TabIndex = 4;
            CambiarTamañoBoton.Text = "Cambiar tamaño";
            CambiarTamañoBoton.UseVisualStyleBackColor = true;
            // 
            // TamañoReclasificacionComboBox
            // 
            TamañoReclasificacionComboBox.Enabled = false;
            TamañoReclasificacionComboBox.FormattingEnabled = true;
            TamañoReclasificacionComboBox.Location = new Point(15, 70);
            TamañoReclasificacionComboBox.Name = "TamañoReclasificacionComboBox";
            TamañoReclasificacionComboBox.Size = new Size(151, 28);
            TamañoReclasificacionComboBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 36);
            label7.Name = "label7";
            label7.Size = new Size(187, 20);
            label7.TabIndex = 0;
            label7.Text = "Ingrese el tamaño correcto";
            // 
            // AdmitirBoton
            // 
            AdmitirBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AdmitirBoton.ForeColor = Color.Lime;
            AdmitirBoton.Location = new Point(746, 406);
            AdmitirBoton.Name = "AdmitirBoton";
            AdmitirBoton.Size = new Size(119, 53);
            AdmitirBoton.TabIndex = 8;
            AdmitirBoton.Text = "Admitir";
            AdmitirBoton.UseVisualStyleBackColor = true;
            AdmitirBoton.Click += AdmitirBoton_Click;
            // 
            // RechazarBoton
            // 
            RechazarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RechazarBoton.ForeColor = Color.Red;
            RechazarBoton.Location = new Point(606, 406);
            RechazarBoton.Name = "RechazarBoton";
            RechazarBoton.Size = new Size(126, 53);
            RechazarBoton.TabIndex = 9;
            RechazarBoton.Text = "Rechazar";
            RechazarBoton.UseVisualStyleBackColor = true;
            RechazarBoton.Click += RechazarBoton_Click;
            // 
            // ObservacionesTextBox
            // 
            ObservacionesTextBox.Location = new Point(11, 26);
            ObservacionesTextBox.Name = "ObservacionesTextBox";
            ObservacionesTextBox.Size = new Size(125, 27);
            ObservacionesTextBox.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ObservacionesTextBox);
            groupBox3.Location = new Point(16, 349);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(447, 110);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Observaciones";
            // 
            // AdmisionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 485);
            Controls.Add(groupBox3);
            Controls.Add(RechazarBoton);
            Controls.Add(AdmitirBoton);
            Controls.Add(groupBox2);
            Controls.Add(ValidacionGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(BuscarGuiaBoton);
            Controls.Add(NumeroGuiaTextBox);
            Controls.Add(DatosGenerales);
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