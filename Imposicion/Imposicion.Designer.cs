namespace GrupoE_Tutasa.Imposicion
{
    partial class Imposicion
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
            cuit = new Label();
            txt_cuit = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_cuit);
            groupBox1.Controls.Add(cuit);
            groupBox1.Location = new Point(38, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Remitente";
            groupBox1.UseWaitCursor = true;
            // 
            // cuit
            // 
            cuit.AutoSize = true;
            cuit.Location = new Point(14, 36);
            cuit.Name = "cuit";
            cuit.Size = new Size(32, 15);
            cuit.TabIndex = 0;
            cuit.Text = "CUIT";
            // 
            // txt_cuit
            // 
            txt_cuit.Location = new Point(82, 33);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(100, 23);
            txt_cuit.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(199, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 73);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Razon Social";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Ingrese razon social";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(35, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txt_cuit;
        private Label cuit;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
    }
}