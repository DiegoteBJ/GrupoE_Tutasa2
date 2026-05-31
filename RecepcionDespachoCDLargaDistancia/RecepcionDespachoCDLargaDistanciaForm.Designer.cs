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
            groupBoxIngreseNrodeTransporte = new GroupBox();
            botonBuscar = new Button();
            textBoxNrodeservicioTransporte = new TextBox();
            labelNrodeServicioTransporte = new Label();
            groupBoxDatosdeEmpresaTransporte = new GroupBox();
            labelResultadoFecha = new Label();
            labelResultadoNombreTransporte = new Label();
            labelFecha = new Label();
            labelNombreTransporte = new Label();
            groupBoxHDRaRecibir = new GroupBox();
            listView1 = new ListView();
            groupBoxHDRaDespachar = new GroupBox();
            listView2 = new ListView();
            botonConfirmar = new Button();
            botonCancelar = new Button();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBoxIngreseNrodeTransporte.SuspendLayout();
            groupBoxDatosdeEmpresaTransporte.SuspendLayout();
            groupBoxHDRaRecibir.SuspendLayout();
            groupBoxHDRaDespachar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIngreseNrodeTransporte
            // 
            groupBoxIngreseNrodeTransporte.Controls.Add(botonBuscar);
            groupBoxIngreseNrodeTransporte.Controls.Add(textBoxNrodeservicioTransporte);
            groupBoxIngreseNrodeTransporte.Controls.Add(labelNrodeServicioTransporte);
            groupBoxIngreseNrodeTransporte.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxIngreseNrodeTransporte.Location = new Point(40, 60);
            groupBoxIngreseNrodeTransporte.Name = "groupBoxIngreseNrodeTransporte";
            groupBoxIngreseNrodeTransporte.Size = new Size(728, 109);
            groupBoxIngreseNrodeTransporte.TabIndex = 0;
            groupBoxIngreseNrodeTransporte.TabStop = false;
            groupBoxIngreseNrodeTransporte.Text = "Ingrese en Nro de Transporte";
            groupBoxIngreseNrodeTransporte.Enter += groupBox1_Enter;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(570, 47);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(137, 37);
            botonBuscar.TabIndex = 2;
            botonBuscar.Text = "BUSCAR";
            botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxNrodeservicioTransporte
            // 
            textBoxNrodeservicioTransporte.Location = new Point(308, 50);
            textBoxNrodeservicioTransporte.Name = "textBoxNrodeservicioTransporte";
            textBoxNrodeservicioTransporte.Size = new Size(241, 31);
            textBoxNrodeservicioTransporte.TabIndex = 1;
            textBoxNrodeservicioTransporte.TextChanged += textBox1_TextChanged;
            // 
            // labelNrodeServicioTransporte
            // 
            labelNrodeServicioTransporte.AutoSize = true;
            labelNrodeServicioTransporte.Location = new Point(29, 47);
            labelNrodeServicioTransporte.Name = "labelNrodeServicioTransporte";
            labelNrodeServicioTransporte.Size = new Size(272, 25);
            labelNrodeServicioTransporte.TabIndex = 0;
            labelNrodeServicioTransporte.Text = "Nro. de Servicio de Transporte";
            // 
            // groupBoxDatosdeEmpresaTransporte
            // 
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelResultadoFecha);
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelResultadoNombreTransporte);
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelFecha);
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelNombreTransporte);
            groupBoxDatosdeEmpresaTransporte.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDatosdeEmpresaTransporte.Location = new Point(40, 185);
            groupBoxDatosdeEmpresaTransporte.Name = "groupBoxDatosdeEmpresaTransporte";
            groupBoxDatosdeEmpresaTransporte.Size = new Size(731, 129);
            groupBoxDatosdeEmpresaTransporte.TabIndex = 1;
            groupBoxDatosdeEmpresaTransporte.TabStop = false;
            groupBoxDatosdeEmpresaTransporte.Text = "Datos de la Empresa de Transporte";
            groupBoxDatosdeEmpresaTransporte.Enter += groupBox2_Enter;
            // 
            // labelResultadoFecha
            // 
            labelResultadoFecha.AutoSize = true;
            labelResultadoFecha.BackColor = SystemColors.ControlLightLight;
            labelResultadoFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultadoFecha.ForeColor = SystemColors.ControlDark;
            labelResultadoFecha.Location = new Point(193, 85);
            labelResultadoFecha.Name = "labelResultadoFecha";
            labelResultadoFecha.Size = new Size(117, 20);
            labelResultadoFecha.TabIndex = 3;
            labelResultadoFecha.Text = "Resultado Fecha";
            // 
            // labelResultadoNombreTransporte
            // 
            labelResultadoNombreTransporte.AutoSize = true;
            labelResultadoNombreTransporte.BackColor = SystemColors.ControlLightLight;
            labelResultadoNombreTransporte.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultadoNombreTransporte.ForeColor = SystemColors.ButtonShadow;
            labelResultadoNombreTransporte.Location = new Point(193, 40);
            labelResultadoNombreTransporte.Name = "labelResultadoNombreTransporte";
            labelResultadoNombreTransporte.Size = new Size(134, 20);
            labelResultadoNombreTransporte.TabIndex = 2;
            labelResultadoNombreTransporte.Text = "Resultado Nombre";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(27, 85);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(50, 20);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha:";
            labelFecha.Click += label3_Click;
            // 
            // labelNombreTransporte
            // 
            labelNombreTransporte.AutoSize = true;
            labelNombreTransporte.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreTransporte.Location = new Point(27, 43);
            labelNombreTransporte.Name = "labelNombreTransporte";
            labelNombreTransporte.Size = new Size(147, 20);
            labelNombreTransporte.TabIndex = 0;
            labelNombreTransporte.Text = "Nombre Transporte:";
            labelNombreTransporte.Click += label2_Click;
            // 
            // groupBoxHDRaRecibir
            // 
            groupBoxHDRaRecibir.Controls.Add(listView1);
            groupBoxHDRaRecibir.Location = new Point(42, 320);
            groupBoxHDRaRecibir.Name = "groupBoxHDRaRecibir";
            groupBoxHDRaRecibir.Size = new Size(322, 215);
            groupBoxHDRaRecibir.TabIndex = 2;
            groupBoxHDRaRecibir.TabStop = false;
            groupBoxHDRaRecibir.Text = "Hojas de ruta a recibir";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Location = new Point(11, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(301, 169);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // groupBoxHDRaDespachar
            // 
            groupBoxHDRaDespachar.Controls.Add(listView2);
            groupBoxHDRaDespachar.Location = new Point(429, 320);
            groupBoxHDRaDespachar.Name = "groupBoxHDRaDespachar";
            groupBoxHDRaDespachar.Size = new Size(335, 211);
            groupBoxHDRaDespachar.TabIndex = 3;
            groupBoxHDRaDespachar.TabStop = false;
            groupBoxHDRaDespachar.Text = "Hojas de ruta a despachar";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView2.Location = new Point(8, 29);
            listView2.Name = "listView2";
            listView2.Size = new Size(310, 168);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // botonConfirmar
            // 
            botonConfirmar.Location = new Point(130, 613);
            botonConfirmar.Name = "botonConfirmar";
            botonConfirmar.Size = new Size(139, 36);
            botonConfirmar.TabIndex = 4;
            botonConfirmar.Text = "Confirmar";
            botonConfirmar.UseVisualStyleBackColor = true;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(504, 613);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(145, 36);
            botonCancelar.TabIndex = 5;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
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
            // columnHeader1
            // 
            columnHeader1.Text = "Nro de Guias";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nro de Guias";
            columnHeader2.Width = 110;
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
            Controls.Add(botonCancelar);
            Controls.Add(botonConfirmar);
            Controls.Add(groupBoxHDRaDespachar);
            Controls.Add(groupBoxHDRaRecibir);
            Controls.Add(groupBoxDatosdeEmpresaTransporte);
            Controls.Add(groupBoxIngreseNrodeTransporte);
            Name = "RecepcionDespachoCDLargaDistanciaForm";
            Text = "RecepcionYDespachoLargaDistanciaForm1";
            Load += RecepcionYDespachoLargaDistanciaForm1_Load;
            groupBoxIngreseNrodeTransporte.ResumeLayout(false);
            groupBoxIngreseNrodeTransporte.PerformLayout();
            groupBoxDatosdeEmpresaTransporte.ResumeLayout(false);
            groupBoxDatosdeEmpresaTransporte.PerformLayout();
            groupBoxHDRaRecibir.ResumeLayout(false);
            groupBoxHDRaDespachar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxIngreseNrodeTransporte;
        private Button botonBuscar;
        private TextBox textBoxNrodeservicioTransporte;
        private Label labelNrodeServicioTransporte;
        private GroupBox groupBoxDatosdeEmpresaTransporte;
        private Label labelNombreTransporte;
        private Label labelFecha;
        private Label labelResultadoNombreTransporte;
        private Label labelResultadoFecha;
        private GroupBox groupBoxHDRaRecibir;
        private GroupBox groupBoxHDRaDespachar;
        private ListView listView1;
        private Button botonConfirmar;
        private Button botonCancelar;
        private ListView listView2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}