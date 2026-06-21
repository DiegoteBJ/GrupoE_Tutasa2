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
            columnHeader3 = new ColumnHeader();
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
            FacturarOtroBoton = new Button();
            SuspendLayout();
            // 
            // DetalleEnviosLabel
            // 
            DetalleEnviosLabel.AutoSize = true;
            DetalleEnviosLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetalleEnviosLabel.Location = new Point(26, 104);
            DetalleEnviosLabel.Name = "DetalleEnviosLabel";
            DetalleEnviosLabel.Size = new Size(208, 18);
            DetalleEnviosLabel.TabIndex = 2;
            DetalleEnviosLabel.Text = "Detalle de Envíos a Facturar";
            // 
            // DetalleEnviosListView
            // 
            DetalleEnviosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader5, columnHeader6 });
            DetalleEnviosListView.ForeColor = Color.Blue;
            DetalleEnviosListView.GridLines = true;
            DetalleEnviosListView.Location = new Point(71, 139);
            DetalleEnviosListView.Margin = new Padding(3, 2, 3, 2);
            DetalleEnviosListView.Name = "DetalleEnviosListView";
            DetalleEnviosListView.Size = new Size(549, 189);
            DetalleEnviosListView.TabIndex = 3;
            DetalleEnviosListView.UseCompatibleStateImageBehavior = false;
            DetalleEnviosListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro. Guia";
            columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha Entrega";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 160;
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
            columnHeader6.Width = 160;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(261, 345);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 4;
            label1.Text = "Total a Facturar $:";
            // 
            // TotalAFacturarLabel
            // 
            TotalAFacturarLabel.AutoSize = true;
            TotalAFacturarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TotalAFacturarLabel.Location = new Point(577, 345);
            TotalAFacturarLabel.Name = "TotalAFacturarLabel";
            TotalAFacturarLabel.Size = new Size(38, 15);
            TotalAFacturarLabel.TabIndex = 5;
            TotalAFacturarLabel.Text = "00,00";
            // 
            // CUITClienteLabel
            // 
            CUITClienteLabel.AutoSize = true;
            CUITClienteLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CUITClienteLabel.Location = new Point(26, 40);
            CUITClienteLabel.Name = "CUITClienteLabel";
            CUITClienteLabel.Size = new Size(95, 15);
            CUITClienteLabel.TabIndex = 0;
            CUITClienteLabel.Text = "CUIT del Cliente";
            // 
            // DatosClienteLabel
            // 
            DatosClienteLabel.AutoSize = true;
            DatosClienteLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatosClienteLabel.Location = new Point(26, 67);
            DatosClienteLabel.Name = "DatosClienteLabel";
            DatosClienteLabel.Size = new Size(102, 15);
            DatosClienteLabel.TabIndex = 1;
            DatosClienteLabel.Text = "Datos del Cliente";
            // 
            // DatosCLienteRespuestaLabel
            // 
            DatosCLienteRespuestaLabel.AutoSize = true;
            DatosCLienteRespuestaLabel.Location = new Point(161, 67);
            DatosCLienteRespuestaLabel.Name = "DatosCLienteRespuestaLabel";
            DatosCLienteRespuestaLabel.Size = new Size(102, 15);
            DatosCLienteRespuestaLabel.TabIndex = 2;
            DatosCLienteRespuestaLabel.Text = "Datos del Cliente";
            // 
            // CuitClienteBox
            // 
            CuitClienteBox.Location = new Point(161, 35);
            CuitClienteBox.Margin = new Padding(3, 2, 3, 2);
            CuitClienteBox.Name = "CuitClienteBox";
            CuitClienteBox.Size = new Size(182, 21);
            CuitClienteBox.TabIndex = 3;
            // 
            // BuscarClienteBoton
            // 
            BuscarClienteBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarClienteBoton.ForeColor = Color.Black;
            BuscarClienteBoton.Location = new Point(519, 40);
            BuscarClienteBoton.Margin = new Padding(3, 2, 3, 2);
            BuscarClienteBoton.Name = "BuscarClienteBoton";
            BuscarClienteBoton.Size = new Size(144, 39);
            BuscarClienteBoton.TabIndex = 4;
            BuscarClienteBoton.Text = "Buscar";
            BuscarClienteBoton.UseVisualStyleBackColor = true;
            BuscarClienteBoton.Click += BuscarClienteBoton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 7);
            label2.Name = "label2";
            label2.Size = new Size(156, 18);
            label2.TabIndex = 6;
            label2.Text = "Seleccione el cliente";
            // 
            // CancelarBoton
            // 
            CancelarBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarBoton.ForeColor = Color.Black;
            CancelarBoton.Location = new Point(357, 392);
            CancelarBoton.Margin = new Padding(3, 2, 3, 2);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(144, 39);
            CancelarBoton.TabIndex = 7;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // EmitirFacturaBoton
            // 
            EmitirFacturaBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmitirFacturaBoton.ForeColor = Color.Black;
            EmitirFacturaBoton.Location = new Point(519, 392);
            EmitirFacturaBoton.Margin = new Padding(3, 2, 3, 2);
            EmitirFacturaBoton.Name = "EmitirFacturaBoton";
            EmitirFacturaBoton.Size = new Size(144, 39);
            EmitirFacturaBoton.TabIndex = 8;
            EmitirFacturaBoton.Text = "Emitir Factura";
            EmitirFacturaBoton.UseVisualStyleBackColor = true;
            EmitirFacturaBoton.Click += EmitirFacturaBoton_Click;
            // 
            // FacturarOtroBoton
            // 
            FacturarOtroBoton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FacturarOtroBoton.ForeColor = Color.Black;
            FacturarOtroBoton.Location = new Point(26, 392);
            FacturarOtroBoton.Margin = new Padding(3, 2, 3, 2);
            FacturarOtroBoton.Name = "FacturarOtroBoton";
            FacturarOtroBoton.Size = new Size(144, 39);
            FacturarOtroBoton.TabIndex = 9;
            FacturarOtroBoton.Text = "Facturar otro Cliente";
            FacturarOtroBoton.UseVisualStyleBackColor = true;
            FacturarOtroBoton.Click += FacturarOtroBoton_Click;
            // 
            // EmitirFacturaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 447);
            Controls.Add(FacturarOtroBoton);
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
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
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
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button FacturarOtroBoton;
    }
}
