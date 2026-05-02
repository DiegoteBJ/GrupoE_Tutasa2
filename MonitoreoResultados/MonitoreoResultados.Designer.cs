namespace GrupoE_Tutasa.MonitoreoResultados
{
    partial class MonitoreoResultadosForm
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
            label3 = new Label();
            label1 = new Label();
            MesUpDown = new NumericUpDown();
            Mes = new Label();
            label2 = new Label();
            AñoUpDown = new NumericUpDown();
            label4 = new Label();
            BuscarBoton = new Button();
            label5 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ResultadoMensualLabel = new Label();
            label6 = new Label();
            SalirBoton = new Button();
            VerOtroBoton = new Button();
            ((System.ComponentModel.ISupportInitialize)MesUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AñoUpDown).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(301, 25);
            label3.TabIndex = 22;
            label3.Text = "Ingrese el período de la consulta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 78);
            label1.Name = "label1";
            label1.Size = new Size(368, 20);
            label1.TabIndex = 23;
            label1.Text = "Ingrese el mes y año cuyos resultados desee visualizar:";
            // 
            // MesUpDown
            // 
            MesUpDown.Location = new Point(412, 76);
            MesUpDown.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            MesUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MesUpDown.Name = "MesUpDown";
            MesUpDown.Size = new Size(73, 27);
            MesUpDown.TabIndex = 24;
            MesUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Mes
            // 
            Mes.AutoSize = true;
            Mes.Location = new Point(432, 53);
            Mes.Name = "Mes";
            Mes.Size = new Size(36, 20);
            Mes.TabIndex = 25;
            Mes.Text = "Mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 53);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 27;
            label2.Text = "Año";
            // 
            // AñoUpDown
            // 
            AñoUpDown.Location = new Point(535, 76);
            AñoUpDown.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            AñoUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            AñoUpDown.Name = "AñoUpDown";
            AñoUpDown.Size = new Size(73, 27);
            AñoUpDown.TabIndex = 26;
            AñoUpDown.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(501, 73);
            label4.Name = "label4";
            label4.Size = new Size(19, 25);
            label4.TabIndex = 28;
            label4.Text = "/";
            // 
            // BuscarBoton
            // 
            BuscarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarBoton.Location = new Point(642, 53);
            BuscarBoton.Name = "BuscarBoton";
            BuscarBoton.Size = new Size(111, 50);
            BuscarBoton.TabIndex = 29;
            BuscarBoton.Text = "Buscar";
            BuscarBoton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(12, 139);
            label5.Name = "label5";
            label5.Size = new Size(205, 25);
            label5.TabIndex = 30;
            label5.Text = "Resultados Obtenidos";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Location = new Point(19, 182);
            listView1.Name = "listView1";
            listView1.Size = new Size(748, 176);
            listView1.TabIndex = 31;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Empresa de Transporte";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Venta Mensual";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Costo Mensual";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Resultado Mensual";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 180;
            // 
            // ResultadoMensualLabel
            // 
            ResultadoMensualLabel.AutoSize = true;
            ResultadoMensualLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResultadoMensualLabel.Location = new Point(645, 383);
            ResultadoMensualLabel.Name = "ResultadoMensualLabel";
            ResultadoMensualLabel.Size = new Size(102, 20);
            ResultadoMensualLabel.TabIndex = 33;
            ResultadoMensualLabel.Text = "1.000.000,23";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(19, 383);
            label6.Name = "label6";
            label6.Size = new Size(376, 23);
            label6.TabIndex = 32;
            label6.Text = "Resultado Mensual Empresas de Transporte $:";
            // 
            // SalirBoton
            // 
            SalirBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SalirBoton.Location = new Point(642, 471);
            SalirBoton.Name = "SalirBoton";
            SalirBoton.Size = new Size(111, 50);
            SalirBoton.TabIndex = 34;
            SalirBoton.Text = "Salir";
            SalirBoton.UseVisualStyleBackColor = true;
            // 
            // VerOtroBoton
            // 
            VerOtroBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            VerOtroBoton.Location = new Point(497, 471);
            VerOtroBoton.Name = "VerOtroBoton";
            VerOtroBoton.Size = new Size(111, 50);
            VerOtroBoton.TabIndex = 35;
            VerOtroBoton.Text = "Ver otro período";
            VerOtroBoton.UseVisualStyleBackColor = true;
            // 
            // MonitoreoResultadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 537);
            Controls.Add(VerOtroBoton);
            Controls.Add(SalirBoton);
            Controls.Add(ResultadoMensualLabel);
            Controls.Add(label6);
            Controls.Add(listView1);
            Controls.Add(label5);
            Controls.Add(BuscarBoton);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(AñoUpDown);
            Controls.Add(Mes);
            Controls.Add(MesUpDown);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "MonitoreoResultadosForm";
            Text = "Monitoreo Resultados Empresas de Transporte";
            ((System.ComponentModel.ISupportInitialize)MesUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AñoUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private NumericUpDown MesUpDown;
        private Label Mes;
        private Label label2;
        private NumericUpDown AñoUpDown;
        private Label label4;
        private Button BuscarBoton;
        private Label label5;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label ResultadoMensualLabel;
        private Label label6;
        private Button SalirBoton;
        private Button VerOtroBoton;
    }
}