namespace GrupoE_Tutasa.RendicionHDR
{
    partial class RendicionHDRForm
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
            radioButton1 = new RadioButton();
            radioButton6 = new RadioButton();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            CantidadGuiasCumplidasLabel = new Label();
            label9 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            CambiarCumplidasBoton = new Button();
            CambiarNoCumplidasBoton = new Button();
            CantidadGuiasNoCumplidasLabel = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(19, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 111);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Búsqueda de Hoja de Ruta";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(435, 32);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(110, 24);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "Distribución";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(365, 32);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(70, 24);
            radioButton6.TabIndex = 25;
            radioButton6.TabStop = true;
            radioButton6.Text = "Retiro";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(6, 59);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(19, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del viaje";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(656, 76);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 7;
            label8.Text = "[Nro]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(566, 76);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 6;
            label7.Text = "Total guías:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(559, 37);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 5;
            label6.Text = "[Distribución/Retiro]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 37);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Tipo de HDR:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 37);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 3;
            label4.Text = "[FechaRendicion]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 37);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 37);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "[Apellido, Nombre]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Fletero:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CantidadGuiasNoCumplidasLabel);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(CambiarNoCumplidasBoton);
            groupBox3.Controls.Add(CambiarCumplidasBoton);
            groupBox3.Controls.Add(CantidadGuiasCumplidasLabel);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(listView1);
            groupBox3.Location = new Point(19, 279);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(751, 326);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de HDR";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // CantidadGuiasCumplidasLabel
            // 
            CantidadGuiasCumplidasLabel.AutoSize = true;
            CantidadGuiasCumplidasLabel.Location = new Point(632, 239);
            CantidadGuiasCumplidasLabel.Name = "CantidadGuiasCumplidasLabel";
            CantidadGuiasCumplidasLabel.Size = new Size(83, 20);
            CantidadGuiasCumplidasLabel.TabIndex = 2;
            CantidadGuiasCumplidasLabel.Text = "[Nro/Total]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(404, 239);
            label9.Name = "label9";
            label9.Size = new Size(180, 20);
            label9.TabIndex = 1;
            label9.Text = "Cantidad guías cumplidas";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(14, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(722, 193);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro. Guía";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Remitente";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Destinatario";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Domicilio";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tam.";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Intento";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Estado";
            columnHeader7.Width = 80;
            // 
            // button2
            // 
            button2.Location = new Point(588, 627);
            button2.Name = "button2";
            button2.Size = new Size(182, 32);
            button2.TabIndex = 3;
            button2.Text = "Confirmar Rendición";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(426, 627);
            button3.Name = "button3";
            button3.Size = new Size(135, 32);
            button3.TabIndex = 4;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // CambiarCumplidasBoton
            // 
            CambiarCumplidasBoton.Location = new Point(14, 235);
            CambiarCumplidasBoton.Name = "CambiarCumplidasBoton";
            CambiarCumplidasBoton.Size = new Size(213, 29);
            CambiarCumplidasBoton.TabIndex = 3;
            CambiarCumplidasBoton.Text = "Cambiar a Cumplidas";
            CambiarCumplidasBoton.UseVisualStyleBackColor = true;
            // 
            // CambiarNoCumplidasBoton
            // 
            CambiarNoCumplidasBoton.Location = new Point(14, 277);
            CambiarNoCumplidasBoton.Name = "CambiarNoCumplidasBoton";
            CambiarNoCumplidasBoton.Size = new Size(213, 29);
            CambiarNoCumplidasBoton.TabIndex = 4;
            CambiarNoCumplidasBoton.Text = "Cambiar a No Cumplidas";
            CambiarNoCumplidasBoton.UseVisualStyleBackColor = true;
            // 
            // CantidadGuiasNoCumplidasLabel
            // 
            CantidadGuiasNoCumplidasLabel.AutoSize = true;
            CantidadGuiasNoCumplidasLabel.Location = new Point(632, 281);
            CantidadGuiasNoCumplidasLabel.Name = "CantidadGuiasNoCumplidasLabel";
            CantidadGuiasNoCumplidasLabel.Size = new Size(83, 20);
            CantidadGuiasNoCumplidasLabel.TabIndex = 6;
            CantidadGuiasNoCumplidasLabel.Text = "[Nro/Total]";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(404, 281);
            label12.Name = "label12";
            label12.Size = new Size(201, 20);
            label12.TabIndex = 5;
            label12.Text = "Cantidad guías no cumplidas";
            // 
            // RendicionHDRForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 681);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RendicionHDRForm";
            Text = "Rendicion de HDR";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private GroupBox groupBox3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button2;
        private Label label9;
        private Button button3;
        private Label CantidadGuiasCumplidasLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private ColumnHeader columnHeader7;
        private Button CambiarNoCumplidasBoton;
        private Button CambiarCumplidasBoton;
        private Label CantidadGuiasNoCumplidasLabel;
        private Label label12;
    }
}