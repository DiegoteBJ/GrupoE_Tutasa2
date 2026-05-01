namespace GrupoE_Tutasa.EmitirFactura
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
            DetalleEnviosLabel = new Label();
            DetalleEnviosListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            TotalAFacturarLabel = new Label();
            CUITClienteLabel = new Label();
            DatosClienteLabel = new Label();
            DatosCLienteRespuestaLabel = new Label();
            CuitClienteBox = new TextBox();
            BuscarClienteBoton = new Button();
            label2 = new Label();
            CancelarBoton = new Button();
            EmitirFacturaBoton = new Button();
            SuspendLayout();
            // 
            // DetalleEnviosLabel
            // 
            DetalleEnviosLabel.AutoSize = true;
            DetalleEnviosLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DetalleEnviosLabel.Location = new Point(30, 138);
            DetalleEnviosLabel.Name = "DetalleEnviosLabel";
            DetalleEnviosLabel.Size = new Size(255, 25);
            DetalleEnviosLabel.TabIndex = 2;
            DetalleEnviosLabel.Text = "Detalle de Envíos a Facturar";
            // 
            // DetalleEnviosListView
            // 
            DetalleEnviosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            DetalleEnviosListView.GridLines = true;
            DetalleEnviosListView.Location = new Point(30, 183);
            DetalleEnviosListView.Name = "DetalleEnviosListView";
            DetalleEnviosListView.Size = new Size(728, 251);
            DetalleEnviosListView.TabIndex = 3;
            DetalleEnviosListView.UseCompatibleStateImageBehavior = false;
            DetalleEnviosListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro. Guia";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fecha Admision";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Origen";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Destino";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tamaño";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Importe";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(444, 450);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 4;
            label1.Text = "Total a Facturar $:";
            // 
            // TotalAFacturarLabel
            // 
            TotalAFacturarLabel.AutoSize = true;
            TotalAFacturarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TotalAFacturarLabel.Location = new Point(656, 450);
            TotalAFacturarLabel.Name = "TotalAFacturarLabel";
            TotalAFacturarLabel.Size = new Size(102, 20);
            TotalAFacturarLabel.TabIndex = 5;
            TotalAFacturarLabel.Text = "1.000.000,23";
            // 
            // CUITClienteLabel
            // 
            CUITClienteLabel.AutoSize = true;
            CUITClienteLabel.Location = new Point(30, 53);
            CUITClienteLabel.Name = "CUITClienteLabel";
            CUITClienteLabel.Size = new Size(115, 20);
            CUITClienteLabel.TabIndex = 0;
            CUITClienteLabel.Text = "CUIT del Cliente";
            // 
            // DatosClienteLabel
            // 
            DatosClienteLabel.AutoSize = true;
            DatosClienteLabel.Location = new Point(30, 89);
            DatosClienteLabel.Name = "DatosClienteLabel";
            DatosClienteLabel.Size = new Size(123, 20);
            DatosClienteLabel.TabIndex = 1;
            DatosClienteLabel.Text = "Datos del Cliente";
            // 
            // DatosCLienteRespuestaLabel
            // 
            DatosCLienteRespuestaLabel.AutoSize = true;
            DatosCLienteRespuestaLabel.Location = new Point(184, 89);
            DatosCLienteRespuestaLabel.Name = "DatosCLienteRespuestaLabel";
            DatosCLienteRespuestaLabel.Size = new Size(123, 20);
            DatosCLienteRespuestaLabel.TabIndex = 2;
            DatosCLienteRespuestaLabel.Text = "Datos del Cliente";
            // 
            // CuitClienteBox
            // 
            CuitClienteBox.Location = new Point(184, 47);
            CuitClienteBox.Name = "CuitClienteBox";
            CuitClienteBox.Size = new Size(207, 27);
            CuitClienteBox.TabIndex = 3;
            // 
            // BuscarClienteBoton
            // 
            BuscarClienteBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarClienteBoton.Location = new Point(593, 53);
            BuscarClienteBoton.Name = "BuscarClienteBoton";
            BuscarClienteBoton.Size = new Size(165, 52);
            BuscarClienteBoton.TabIndex = 4;
            BuscarClienteBoton.Text = "Buscar";
            BuscarClienteBoton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(30, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 6;
            label2.Text = "Seleccione el cliente";
            // 
            // CancelarBoton
            // 
            CancelarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelarBoton.ForeColor = Color.Red;
            CancelarBoton.Location = new Point(408, 522);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(165, 52);
            CancelarBoton.TabIndex = 7;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            // 
            // EmitirFacturaBoton
            // 
            EmitirFacturaBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EmitirFacturaBoton.ForeColor = Color.FromArgb(0, 192, 0);
            EmitirFacturaBoton.Location = new Point(593, 522);
            EmitirFacturaBoton.Name = "EmitirFacturaBoton";
            EmitirFacturaBoton.Size = new Size(165, 52);
            EmitirFacturaBoton.TabIndex = 8;
            EmitirFacturaBoton.Text = "Emitir Factura";
            EmitirFacturaBoton.UseVisualStyleBackColor = true;
            // 
            // EmitirFacturaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 596);
            Controls.Add(EmitirFacturaBoton);
            Controls.Add(CancelarBoton);
            Controls.Add(label2);
            Controls.Add(BuscarClienteBoton);
            Controls.Add(CuitClienteBox);
            Controls.Add(TotalAFacturarLabel);
            Controls.Add(DatosCLienteRespuestaLabel);
            Controls.Add(label1);
            Controls.Add(DatosClienteLabel);
            Controls.Add(CUITClienteLabel);
            Controls.Add(DetalleEnviosLabel);
            Controls.Add(DetalleEnviosListView);
            Name = "EmitirFacturaForm";
            Text = "Emitir Factura";
            Load += EmitirFacturaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DetalleEnviosLabel;
        private ListView DetalleEnviosListView;
        private Label label1;
        private Label TotalAFacturarLabel;
        private Label CUITClienteLabel;
        private Label DatosClienteLabel;
        private Label DatosCLienteRespuestaLabel;
        private TextBox CuitClienteBox;
        private Button BuscarClienteBoton;
        private Label label2;
        private Button CancelarBoton;
        private Button EmitirFacturaBoton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
