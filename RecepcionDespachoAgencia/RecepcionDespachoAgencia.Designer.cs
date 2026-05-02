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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            colNroGuia = new ColumnHeader();
            colTamaño = new ColumnHeader();
            listView2 = new ListView();
            colNroGuiaD = new ColumnHeader();
            colTamañoD = new ColumnHeader();
            colDestino = new ColumnHeader();
            groupBox3 = new GroupBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(30, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guías a recibir";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Location = new Point(361, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guías a entregar al fletero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 22);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Agencia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 111);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 111);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 22);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 22);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 64);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(381, 64);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(190, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(702, 464);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(563, 464);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colNroGuia, colTamaño });
            listView1.Location = new Point(23, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(247, 174);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { colNroGuiaD, colTamañoD, colDestino });
            listView2.Location = new Point(20, 28);
            listView2.Name = "listView2";
            listView2.Size = new Size(415, 174);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(30, 79);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(784, 125);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar fletero por DNI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 27);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 10;
            label9.Text = "DNI *";
            // 
            // RecepcionDespachoAgencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 509);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "RecepcionDespachoAgencia";
            Text = "Recepción y despacho en agencia";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListView listView1;
        private ColumnHeader colNroGuia;
        private ColumnHeader colTamaño;
        private ListView listView2;
        private ColumnHeader colNroGuiaD;
        private ColumnHeader colTamañoD;
        private ColumnHeader colDestino;
        private GroupBox groupBox3;
        private Label label9;
    }
}