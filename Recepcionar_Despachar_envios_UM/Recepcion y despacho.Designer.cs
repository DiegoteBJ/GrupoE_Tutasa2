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
            groupBoxRecepcion = new GroupBox();
            listView1 = new ListView();
            ColumnCumplida = new ColumnHeader();
            ColumnGuia = new ColumnHeader();
            ColumnHDR = new ColumnHeader();
            columndestino = new ColumnHeader();
            columntamaño = new ColumnHeader();
            paneltop.SuspendLayout();
            groupBoxRecepcion.SuspendLayout();
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
            // groupBoxRecepcion
            // 
            groupBoxRecepcion.Controls.Add(listView1);
            groupBoxRecepcion.Location = new Point(28, 99);
            groupBoxRecepcion.Name = "groupBoxRecepcion";
            groupBoxRecepcion.Size = new Size(356, 228);
            groupBoxRecepcion.TabIndex = 1;
            groupBoxRecepcion.TabStop = false;
            groupBoxRecepcion.Text = "Recepción";
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnCumplida, ColumnGuia, ColumnHDR, columndestino, columntamaño });
            listView1.Location = new Point(6, 24);
            listView1.Name = "listView1";
            listView1.Size = new Size(350, 141);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemChecked += listView1_ItemChecked;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // ColumnCumplida
            // 
            ColumnCumplida.Text = "Cumplida";
            ColumnCumplida.Width = 70;
            // 
            // ColumnGuia
            // 
            ColumnGuia.Text = "Nro. Guía";
            ColumnGuia.Width = 70;
            // 
            // ColumnHDR
            // 
            ColumnHDR.Text = "HDR";
            ColumnHDR.Width = 70;
            // 
            // columndestino
            // 
            columndestino.Text = "Destino";
            columndestino.Width = 70;
            // 
            // columntamaño
            // 
            columntamaño.Text = "Tamaño";
            // 
            // Recepcion_y_despacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(875, 450);
            Controls.Add(groupBoxRecepcion);
            Controls.Add(paneltop);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Recepcion_y_despacho";
            Text = "Recepcion y Despacho";
            Load += Recepcion_y_despacho_Load;
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            groupBoxRecepcion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltop;
        private Label labelname;
        private Label labelcd;
        private Label labeldnifletero;
        private Button buttonbuscardnifletero;
        private TextBox textBoxresultadofletero;
        private TextBox textBoxDNIFletero;
        private TextBox textBoxCD;
        private TextBox txtboxUsuario;
        private GroupBox groupBoxRecepcion;
        private ListView listView1;
        private ColumnHeader ColumnCumplida;
        private ColumnHeader ColumnGuia;
        private ColumnHeader ColumnHDR;
        private ColumnHeader columndestino;
        private ColumnHeader columntamaño;
    }
}