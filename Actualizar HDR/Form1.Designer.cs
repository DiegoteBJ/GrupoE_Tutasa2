namespace GrupoE_Tutasa.Actualizar_HDR
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbox_id_hdr = new TextBox();
            textBox_estado_actual = new TextBox();
            cmb_nuevo_estado = new ComboBox();
            boton_Buscar = new Button();
            boton_Confirmar = new Button();
            boton_Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 85);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro de HDR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Estado Actual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 162);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Nuevo Estado:";
            // 
            // txtbox_id_hdr
            // 
            txtbox_id_hdr.Location = new Point(143, 83);
            txtbox_id_hdr.Name = "txtbox_id_hdr";
            txtbox_id_hdr.Size = new Size(124, 23);
            txtbox_id_hdr.TabIndex = 3;
            // 
            // textBox_estado_actual
            // 
            textBox_estado_actual.Location = new Point(144, 117);
            textBox_estado_actual.Name = "textBox_estado_actual";
            textBox_estado_actual.Size = new Size(123, 23);
            textBox_estado_actual.TabIndex = 4;
            // 
            // cmb_nuevo_estado
            // 
            cmb_nuevo_estado.FormattingEnabled = true;
            cmb_nuevo_estado.Items.AddRange(new object[] { "", "Asignada", "En Curso", "Finalizada" });
            cmb_nuevo_estado.Location = new Point(146, 154);
            cmb_nuevo_estado.Name = "cmb_nuevo_estado";
            cmb_nuevo_estado.Size = new Size(121, 23);
            cmb_nuevo_estado.TabIndex = 5;
            // 
            // boton_Buscar
            // 
            boton_Buscar.BackColor = SystemColors.ControlLight;
            boton_Buscar.Location = new Point(284, 83);
            boton_Buscar.Name = "boton_Buscar";
            boton_Buscar.Size = new Size(75, 23);
            boton_Buscar.TabIndex = 6;
            boton_Buscar.Text = "Buscar";
            boton_Buscar.UseVisualStyleBackColor = false;
            // 
            // boton_Confirmar
            // 
            boton_Confirmar.BackColor = SystemColors.ActiveCaption;
            boton_Confirmar.Location = new Point(531, 309);
            boton_Confirmar.Name = "boton_Confirmar";
            boton_Confirmar.Size = new Size(80, 30);
            boton_Confirmar.TabIndex = 7;
            boton_Confirmar.Text = "Confirmar";
            boton_Confirmar.UseVisualStyleBackColor = false;
            // 
            // boton_Cancelar
            // 
            boton_Cancelar.Location = new Point(627, 309);
            boton_Cancelar.Name = "boton_Cancelar";
            boton_Cancelar.Size = new Size(80, 30);
            boton_Cancelar.TabIndex = 8;
            boton_Cancelar.Text = "Cancelar";
            boton_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boton_Cancelar);
            Controls.Add(boton_Confirmar);
            Controls.Add(boton_Buscar);
            Controls.Add(cmb_nuevo_estado);
            Controls.Add(textBox_estado_actual);
            Controls.Add(txtbox_id_hdr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Actualizar HDR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbox_id_hdr;
        private TextBox textBox_estado_actual;
        private ComboBox cmb_nuevo_estado;
        private Button boton_Buscar;
        private Button boton_Confirmar;
        private Button boton_Cancelar;
    }
}