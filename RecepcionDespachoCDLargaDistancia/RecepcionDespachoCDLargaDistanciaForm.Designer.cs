namespace GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia
{
    partial class RecepcionDespachoCDLargaDistanciaForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            NrodeTransportelabel = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            listView1 = new ListView();
            groupBox4 = new GroupBox();
            listView2 = new ListView();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(NrodeTransportelabel);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(40, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 109);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese en Nro de Transporte";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(570, 47);
            button1.Name = "button1";
            button1.Size = new Size(137, 37);
            button1.TabIndex = 2;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // NrodeTransportelabel
            // 
            NrodeTransportelabel.AutoSize = true;
            NrodeTransportelabel.Location = new Point(29, 47);
            NrodeTransportelabel.Name = "NrodeTransportelabel";
            NrodeTransportelabel.Size = new Size(272, 25);
            NrodeTransportelabel.TabIndex = 0;
            NrodeTransportelabel.Text = "Nro. de Servicio de Transporte";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(40, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(731, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Empresa de Transporte";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(193, 85);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 3;
            label5.Text = "Resultado HDR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(193, 40);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 2;
            label4.Text = "Resultado Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 85);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 1;
            label3.Text = "HDR:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 43);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre Transporte:";
            label2.Click += label2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView1);
            groupBox3.Location = new Point(42, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(322, 215);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hojas de ruta a recibir";
            // 
            // listView1
            // 
            listView1.Location = new Point(11, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(301, 169);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listView2);
            groupBox4.Location = new Point(429, 320);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(335, 211);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hojas de ruta a despachar";
            // 
            // listView2
            // 
            listView2.Location = new Point(8, 29);
            listView2.Name = "listView2";
            listView2.Size = new Size(310, 168);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // button2
            // 
            button2.Location = new Point(130, 613);
            button2.Name = "button2";
            button2.Size = new Size(139, 36);
            button2.TabIndex = 4;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(504, 613);
            button3.Name = "button3";
            button3.Size = new Size(145, 36);
            button3.TabIndex = 5;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 13);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 6;
            label1.Text = "Usuario: ";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 13);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 7;
            label6.Text = "Usuario 11";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(233, 13);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 8;
            label7.Text = "CD: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(273, 13);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 9;
            label8.Text = "Buenos Aires";
            // 
            // RecepcionDespachoCDLargaDistanciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 712);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RecepcionDespachoCDLargaDistanciaForm";
            Text = "RecepcionYDespachoLargaDistanciaForm1";
            Load += RecepcionYDespachoLargaDistanciaForm1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label NrodeTransportelabel;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ListView listView1;
        private Button button2;
        private Button button3;
        private ListView listView2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}