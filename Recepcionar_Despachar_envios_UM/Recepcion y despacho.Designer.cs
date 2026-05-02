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
            labelname = new Label();
            nombretxtbox = new TextBox();
            labelcd = new Label();
            labeldnifletero = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonbuscardnifletero = new Button();
            textBoxresultadofletero = new TextBox();
            paneltop.SuspendLayout();
            SuspendLayout();
            // 
            // paneltop
            // 
            paneltop.BackColor = SystemColors.ControlLight;
            paneltop.BackgroundImageLayout = ImageLayout.None;
            paneltop.BorderStyle = BorderStyle.FixedSingle;
            paneltop.Controls.Add(textBoxresultadofletero);
            paneltop.Controls.Add(buttonbuscardnifletero);
            paneltop.Controls.Add(textBox2);
            paneltop.Controls.Add(textBox1);
            paneltop.Controls.Add(labeldnifletero);
            paneltop.Controls.Add(labelcd);
            paneltop.Controls.Add(nombretxtbox);
            paneltop.Controls.Add(labelname);
            paneltop.Location = new Point(8, 21);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(855, 28);
            paneltop.TabIndex = 0;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(19, 8);
            labelname.Name = "labelname";
            labelname.Size = new Size(54, 15);
            labelname.TabIndex = 0;
            labelname.Text = "Nombre:";
            labelname.Click += label1_Click;
            // 
            // nombretxtbox
            // 
            nombretxtbox.BackColor = SystemColors.ControlLight;
            nombretxtbox.BorderStyle = BorderStyle.None;
            nombretxtbox.ForeColor = SystemColors.HotTrack;
            nombretxtbox.Location = new Point(79, 7);
            nombretxtbox.Name = "nombretxtbox";
            nombretxtbox.Size = new Size(101, 16);
            nombretxtbox.TabIndex = 1;
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
            // labeldnifletero
            // 
            labeldnifletero.AutoSize = true;
            labeldnifletero.Location = new Point(393, 5);
            labeldnifletero.Name = "labeldnifletero";
            labeldnifletero.Size = new Size(69, 15);
            labeldnifletero.TabIndex = 3;
            labeldnifletero.Text = "DNI Fletero:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(261, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 16);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.HotTrack;
            textBox2.Location = new Point(482, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 16);
            textBox2.TabIndex = 5;
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
            // Recepcion_y_despacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(875, 450);
            Controls.Add(paneltop);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Recepcion_y_despacho";
            Text = "Recepcion_y_despacho";
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltop;
        private Label labelname;
        private Label labelcd;
        private TextBox nombretxtbox;
        private Label labeldnifletero;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonbuscardnifletero;
        private TextBox textBoxresultadofletero;
    }
}