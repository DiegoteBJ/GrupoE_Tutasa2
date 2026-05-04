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
            labeldnifletero = new Label();
            labelcd = new Label();
            labelname = new Label();
            groupBoxRecepcion = new GroupBox();
            listView1 = new ListView();
            ColumnCumplida = new ColumnHeader();
            ColumnGuia = new ColumnHeader();
            ColumnHDR = new ColumnHeader();
            columndestino = new ColumnHeader();
            columntamaño = new ColumnHeader();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnagregarrecepcion = new Button();
            btnagregardespacho = new Button();
            btnaceptarrecepcion = new Button();
            btnaceptardespacho = new Button();
            btncancelarrecepcion = new Button();
            btncancelardespacho = new Button();
            paneltop.SuspendLayout();
            groupBoxRecepcion.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // paneltop
            // 
            paneltop.BackColor = SystemColors.ControlLight;
            paneltop.BackgroundImageLayout = ImageLayout.None;
            paneltop.BorderStyle = BorderStyle.FixedSingle;
            paneltop.Controls.Add(label2);
            paneltop.Controls.Add(label1);
            paneltop.Controls.Add(textBoxresultadofletero);
            paneltop.Controls.Add(buttonbuscardnifletero);
            paneltop.Controls.Add(textBoxDNIFletero);
            paneltop.Controls.Add(labeldnifletero);
            paneltop.Controls.Add(labelcd);
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
            buttonbuscardnifletero.Location = new Point(596, 2);
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
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(19, 4);
            labelname.Name = "labelname";
            labelname.Size = new Size(50, 15);
            labelname.TabIndex = 0;
            labelname.Text = "Usuario:";
            labelname.Click += label1_Click;
            // 
            // groupBoxRecepcion
            // 
            groupBoxRecepcion.Controls.Add(btncancelarrecepcion);
            groupBoxRecepcion.Controls.Add(btnaceptarrecepcion);
            groupBoxRecepcion.Controls.Add(btnagregarrecepcion);
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
            listView1.Location = new Point(0, 22);
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
            // listView2
            // 
            listView2.CheckBoxes = true;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView2.Location = new Point(0, 22);
            listView2.Name = "listView2";
            listView2.Size = new Size(350, 141);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cumplida";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nro. Guía";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "HDR";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Destino";
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tamaño";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btncancelardespacho);
            groupBox1.Controls.Add(btnaceptardespacho);
            groupBox1.Controls.Add(btnagregardespacho);
            groupBox1.Controls.Add(listView2);
            groupBox1.Location = new Point(390, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 228);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despacho";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(87, 4);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 7;
            label1.Text = "Juan Perez";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(232, 4);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 8;
            label2.Text = "Buenos Aires";
            // 
            // btnagregarrecepcion
            // 
            btnagregarrecepcion.Location = new Point(6, 187);
            btnagregarrecepcion.Name = "btnagregarrecepcion";
            btnagregarrecepcion.Size = new Size(97, 23);
            btnagregarrecepcion.TabIndex = 1;
            btnagregarrecepcion.Text = "Agregar";
            btnagregarrecepcion.UseVisualStyleBackColor = true;
            btnagregarrecepcion.Click += button1_Click;
            // 
            // btnagregardespacho
            // 
            btnagregardespacho.Location = new Point(12, 187);
            btnagregardespacho.Name = "btnagregardespacho";
            btnagregardespacho.Size = new Size(97, 23);
            btnagregardespacho.TabIndex = 2;
            btnagregardespacho.Text = "Agregar";
            btnagregardespacho.UseVisualStyleBackColor = true;
            // 
            // btnaceptarrecepcion
            // 
            btnaceptarrecepcion.Location = new Point(121, 187);
            btnaceptarrecepcion.Name = "btnaceptarrecepcion";
            btnaceptarrecepcion.Size = new Size(97, 23);
            btnaceptarrecepcion.TabIndex = 2;
            btnaceptarrecepcion.Text = "Aceptar";
            btnaceptarrecepcion.UseVisualStyleBackColor = true;
            // 
            // btnaceptardespacho
            // 
            btnaceptardespacho.Location = new Point(134, 187);
            btnaceptardespacho.Name = "btnaceptardespacho";
            btnaceptardespacho.Size = new Size(97, 23);
            btnaceptardespacho.TabIndex = 3;
            btnaceptardespacho.Text = "Aceptar";
            btnaceptardespacho.UseVisualStyleBackColor = true;
            // 
            // btncancelarrecepcion
            // 
            btncancelarrecepcion.Location = new Point(241, 187);
            btncancelarrecepcion.Name = "btncancelarrecepcion";
            btncancelarrecepcion.Size = new Size(97, 23);
            btncancelarrecepcion.TabIndex = 4;
            btncancelarrecepcion.Text = "Cancelar";
            btncancelarrecepcion.UseVisualStyleBackColor = true;
            // 
            // btncancelardespacho
            // 
            btncancelardespacho.Location = new Point(253, 187);
            btncancelardespacho.Name = "btncancelardespacho";
            btncancelardespacho.Size = new Size(97, 23);
            btncancelardespacho.TabIndex = 4;
            btncancelardespacho.Text = "Cancelar";
            btncancelardespacho.UseVisualStyleBackColor = true;
            // 
            // Recepcion_y_despacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(875, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxRecepcion);
            Controls.Add(paneltop);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Recepcion_y_despacho";
            Text = "Recepcion y Despacho";
            Load += Recepcion_y_despacho_Load;
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            groupBoxRecepcion.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBoxRecepcion;
        private ListView listView1;
        private ColumnHeader ColumnCumplida;
        private ColumnHeader ColumnGuia;
        private ColumnHeader ColumnHDR;
        private ColumnHeader columndestino;
        private ColumnHeader columntamaño;
        private Label label1;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private Label label2;
        private Button btncancelarrecepcion;
        private Button btnaceptarrecepcion;
        private Button btnagregarrecepcion;
        private Button btncancelardespacho;
        private Button btnaceptardespacho;
        private Button btnagregardespacho;
    }
}