namespace GrupoE_Tutasa
{
    partial class EmitirFacturaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SeleccioneClienteBox = new GroupBox();
            CUITClienteLabel = new Label();
            DatosClienteLabel = new Label();
            DatosCLienteRespuestaLabel = new Label();
            CuitClienteBox = new TextBox();
            BuscarClienteBoton = new Button();
            SeleccioneClienteBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeleccioneClienteBox
            // 
            SeleccioneClienteBox.Controls.Add(BuscarClienteBoton);
            SeleccioneClienteBox.Controls.Add(CuitClienteBox);
            SeleccioneClienteBox.Controls.Add(DatosCLienteRespuestaLabel);
            SeleccioneClienteBox.Controls.Add(DatosClienteLabel);
            SeleccioneClienteBox.Controls.Add(CUITClienteLabel);
            SeleccioneClienteBox.Location = new Point(18, 18);
            SeleccioneClienteBox.Name = "SeleccioneClienteBox";
            SeleccioneClienteBox.Size = new Size(770, 110);
            SeleccioneClienteBox.TabIndex = 0;
            SeleccioneClienteBox.TabStop = false;
            SeleccioneClienteBox.Text = "Seleccione cliente";
            SeleccioneClienteBox.Enter += this.groupBox1_Enter;
            // 
            // CUITClienteLabel
            // 
            CUITClienteLabel.AutoSize = true;
            CUITClienteLabel.Location = new Point(11, 33);
            CUITClienteLabel.Name = "CUITClienteLabel";
            CUITClienteLabel.Size = new Size(115, 20);
            CUITClienteLabel.TabIndex = 0;
            CUITClienteLabel.Text = "CUIT del Cliente";
            // 
            // DatosClienteLabel
            // 
            DatosClienteLabel.AutoSize = true;
            DatosClienteLabel.Location = new Point(11, 72);
            DatosClienteLabel.Name = "DatosClienteLabel";
            DatosClienteLabel.Size = new Size(123, 20);
            DatosClienteLabel.TabIndex = 1;
            DatosClienteLabel.Text = "Datos del Cliente";
            // 
            // DatosCLienteRespuestaLabel
            // 
            DatosCLienteRespuestaLabel.AutoSize = true;
            DatosCLienteRespuestaLabel.Location = new Point(165, 72);
            DatosCLienteRespuestaLabel.Name = "DatosCLienteRespuestaLabel";
            DatosCLienteRespuestaLabel.Size = new Size(123, 20);
            DatosCLienteRespuestaLabel.TabIndex = 2;
            DatosCLienteRespuestaLabel.Text = "Datos del Cliente";
            // 
            // CuitClienteBox
            // 
            CuitClienteBox.Location = new Point(165, 30);
            CuitClienteBox.Name = "CuitClienteBox";
            CuitClienteBox.Size = new Size(207, 27);
            CuitClienteBox.TabIndex = 3;
            // 
            // BuscarClienteBoton
            // 
            BuscarClienteBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarClienteBoton.Location = new Point(574, 36);
            BuscarClienteBoton.Name = "BuscarClienteBoton";
            BuscarClienteBoton.Size = new Size(165, 52);
            BuscarClienteBoton.TabIndex = 4;
            BuscarClienteBoton.Text = "Buscar";
            BuscarClienteBoton.UseVisualStyleBackColor = true;
            // 
            // EmitirFacturaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
            Controls.Add(SeleccioneClienteBox);
            Name = "EmitirFacturaForm";
            Text = "Emitir Factura";
            SeleccioneClienteBox.ResumeLayout(false);
            SeleccioneClienteBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeleccioneClienteBox;
        private TextBox CuitClienteBox;
        private Label DatosCLienteRespuestaLabel;
        private Label DatosClienteLabel;
        private Label CUITClienteLabel;
        private Button BuscarClienteBoton;
    }
}
