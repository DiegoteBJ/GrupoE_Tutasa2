namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    partial class Recepcion_y_despacho
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
            paneltop = new Panel();
            textBoxresultadofletero = new TextBox();
            buttonbuscardnifletero = new Button();
            textBoxDNIFletero = new TextBox();
            textBoxCD = new TextBox();
            labeldnifletero = new Label();
            labelcd = new Label();
            txtboxUsuario = new TextBox();
            labelname = new Label();
            tabControl1 = new TabControl();
            tabPageRecepcion = new TabPage();
            tabPageDespacho = new TabPage();
            paneltop.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // paneltop
            // 
            paneltop.BackColor = SystemColors.ControlLight;
            paneltop.BackgroundImageLayout = ImageLayout.None;
            paneltop.BorderStyle = BorderStyle.FixedSingle;
            paneltop.Controls.Add(textBoxresultadofletero);
            paneltop.Controls.Add(buttonbuscardnifletero);
            paneltop.Controls.Add(textBoxDNIFletero);
            paneltop.Controls.Add(textBoxCD);
            paneltop.Controls.Add(labeldnifletero);
            paneltop.Controls.Add(labelcd);
            paneltop.Controls.Add(txtboxUsuario);
            paneltop.Controls.Add(labelname);
            paneltop.Location = new Point(8, 21);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(855, 28);
            paneltop.TabIndex = 0;
            // 
            // textBoxresultadofletero
            // 
            textBoxresultadofletero.BackColor = SystemColors.ControlLight;
            textBoxresultadofletero.BorderStyle = BorderStyle.None;
            textBoxresultadofletero.ForeColor = SystemColors.HotTrack;
            textBoxresultadofletero.Location = new Point(713, 7);
            textBoxresultadofletero.Name = "textBoxresultadofletero";
            textBoxresultadofletero.Size = new Size(108, 16);
            textBoxresultadofletero.TabIndex = 6;
            // 
            // buttonbuscardnifletero
            // 
            buttonbuscardnifletero.Location = new Point(610, 4);
            buttonbuscardnifletero.Name = "buttonbuscardnifletero";
            buttonbuscardnifletero.Size = new Size(87, 20);
            buttonbuscardnifletero.TabIndex = 6;
            buttonbuscardnifletero.Text = "Buscar";
            buttonbuscardnifletero.UseVisualStyleBackColor = true;
            buttonbuscardnifletero.Click += buttonbuscardnifletero_Click;
            // 
            // textBoxDNIFletero
            // 
            textBoxDNIFletero.BackColor = SystemColors.ControlLight;
            textBoxDNIFletero.BorderStyle = BorderStyle.None;
            textBoxDNIFletero.ForeColor = SystemColors.HotTrack;
            textBoxDNIFletero.Location = new Point(482, 5);
            textBoxDNIFletero.Name = "textBoxDNIFletero";
            textBoxDNIFletero.Size = new Size(108, 16);
            textBoxDNIFletero.TabIndex = 5;
            textBoxDNIFletero.TextChanged += textBox2DNIFletero;
            // 
            // textBoxCD
            // 
            textBoxCD.BackColor = SystemColors.ControlLight;
            textBoxCD.BorderStyle = BorderStyle.None;
            textBoxCD.ForeColor = SystemColors.HotTrack;
            textBoxCD.Location = new Point(261, 7);
            textBoxCD.Name = "textBoxCD";
            textBoxCD.Size = new Size(114, 16);
            textBoxCD.TabIndex = 4;
            textBoxCD.TextChanged += textBox1_TextChanged;
            // 
            // labeldnifletero
            // 
            labeldnifletero.AutoSize = true;
            labeldnifletero.Location = new Point(393, 5);
            labeldnifletero.Name = "labeldnifletero";
            labeldnifletero.Size = new Size(69, 15);
            labeldnifletero.TabIndex = 3;
            labeldnifletero.Text = "DNI Fletero:";
            // 
            // labelcd
            // 
            labelcd.AutoSize = true;
            labelcd.Location = new Point(200, 5);
            labelcd.Name = "labelcd";
            labelcd.Size = new Size(26, 15);
            labelcd.TabIndex = 2;
            labelcd.Text = "CD:";
            labelcd.Click += label2_Click;
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.BackColor = SystemColors.ControlLight;
            txtboxUsuario.BorderStyle = BorderStyle.None;
            txtboxUsuario.ForeColor = SystemColors.HotTrack;
            txtboxUsuario.Location = new Point(79, 7);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(101, 16);
            txtboxUsuario.TabIndex = 1;
            txtboxUsuario.TextChanged += nombretxtbox_TextChanged;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(19, 8);
            labelname.Name = "labelname";
            labelname.Size = new Size(50, 15);
            labelname.TabIndex = 0;
            labelname.Text = "Usuario:";
            labelname.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRecepcion);
            tabControl1.Controls.Add(tabPageDespacho);
            tabControl1.Location = new Point(12, 78);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(613, 329);
            tabControl1.TabIndex = 1;
            // 
            // tabPageRecepcion
            // 
            tabPageRecepcion.BackColor = SystemColors.ControlLight;
            tabPageRecepcion.ForeColor = SystemColors.ActiveCaptionText;
            tabPageRecepcion.Location = new Point(4, 24);
            tabPageRecepcion.Name = "tabPageRecepcion";
            tabPageRecepcion.Padding = new Padding(3);
            tabPageRecepcion.Size = new Size(605, 301);
            tabPageRecepcion.TabIndex = 0;
            tabPageRecepcion.Text = "Recepción";
            // 
            // tabPageDespacho
            // 
            tabPageDespacho.BackColor = SystemColors.ControlLight;
            tabPageDespacho.Location = new Point(4, 24);
            tabPageDespacho.Name = "tabPageDespacho";
            tabPageDespacho.Padding = new Padding(3);
            tabPageDespacho.Size = new Size(605, 301);
            tabPageDespacho.TabIndex = 1;
            tabPageDespacho.Text = "Despacho";
            // 
            // Recepcion_y_despacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(875, 450);
            Controls.Add(tabControl1);
            Controls.Add(paneltop);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Recepcion_y_despacho";
            Text = "Recepcion y Despacho";
            Load += Recepcion_y_despacho_Load;
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltop;
        private Label labelname;
        private Label labelcd;
        private Label labeldnifletero;
        private Button buttonbuscardnifletero;
        private TabControl tabControl1;
        private TabPage tabPageRecepcion;
        private TabPage tabPageDespacho;
        private TextBox textBoxresultadofletero;
        private TextBox textBoxDNIFletero;
        private TextBox textBoxCD;
        private TextBox txtboxUsuario;
    }
}