namespace GrupoE_Tutasa.FormularioPrincipal
{
    partial class FormularioPrincipal
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
            EmitirFacturasBoton = new Button();
            EstadoCCClientesBoton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(243, 25);
            label2.TabIndex = 19;
            label2.Text = "Administración y Finanzas";
            // 
            // EmitirFacturasBoton
            // 
            EmitirFacturasBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EmitirFacturasBoton.Location = new Point(12, 77);
            EmitirFacturasBoton.Name = "EmitirFacturasBoton";
            EmitirFacturasBoton.Size = new Size(165, 52);
            EmitirFacturasBoton.TabIndex = 20;
            EmitirFacturasBoton.Text = "Emitir Facturas";
            EmitirFacturasBoton.UseVisualStyleBackColor = true;
            EmitirFacturasBoton.Click += EmitirFacturasBoton_Click;
            // 
            // EstadoCCClientesBoton
            // 
            EstadoCCClientesBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EstadoCCClientesBoton.Location = new Point(273, 77);
            EstadoCCClientesBoton.Name = "EstadoCCClientesBoton";
            EstadoCCClientesBoton.Size = new Size(165, 52);
            EstadoCCClientesBoton.TabIndex = 21;
            EstadoCCClientesBoton.Text = "Cuenta Corriente Clientes";
            EstadoCCClientesBoton.UseVisualStyleBackColor = true;
            EstadoCCClientesBoton.Click += EstadoCCClientesBoton_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(EstadoCCClientesBoton);
            Controls.Add(EmitirFacturasBoton);
            Controls.Add(label2);
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            Load += FormularioPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button EmitirFacturasBoton;
        private Button EstadoCCClientesBoton;
    }
}