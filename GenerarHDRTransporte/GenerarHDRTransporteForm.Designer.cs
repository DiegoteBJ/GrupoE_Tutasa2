namespace GrupoE_Tutasa.GenerarHDRTransporte
{
    partial class GenerarHDRTransporteForm
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
            CentroDistribucionLabel = new Label();
            groupBox1 = new GroupBox();
            labelResultadoRutadelTransporte = new Label();
            labelRutadelTransporte = new Label();
            labelResultadoFechaHDR = new Label();
            labelFecha = new Label();
            LabelResultadoEmpresaTransporte = new Label();
            labelEmpresaTransporte = new Label();
            botonBuscar = new Button();
            textBoxNrodeServicioTransporte = new TextBox();
            labelNrodeServicioTransporte = new Label();
            groupBoxEncomiendasPendientes = new GroupBox();
            botonAgregarTodo = new Button();
            botonAgregar = new Button();
            listViewEncomiendasPendientes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBoxEncomiendasAsignadas = new GroupBox();
            botonEliminarTodo = new Button();
            botonEliminar = new Button();
            listViewEncomiendasAsignadas = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            botonCancelar = new Button();
            botonGenerarHDR = new Button();
            groupBox1.SuspendLayout();
            groupBoxEncomiendasPendientes.SuspendLayout();
            groupBoxEncomiendasAsignadas.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 20);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "002";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 22);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "CD: ";
            // 
            // CentroDistribucionLabel
            // 
            CentroDistribucionLabel.AutoSize = true;
            CentroDistribucionLabel.Location = new Point(251, 22);
            CentroDistribucionLabel.Name = "CentroDistribucionLabel";
            CentroDistribucionLabel.Size = new Size(168, 20);
            CentroDistribucionLabel.TabIndex = 3;
            CentroDistribucionLabel.Text = "[Centro de Distribución]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelResultadoRutadelTransporte);
            groupBox1.Controls.Add(labelRutadelTransporte);
            groupBox1.Controls.Add(labelResultadoFechaHDR);
            groupBox1.Controls.Add(labelFecha);
            groupBox1.Controls.Add(LabelResultadoEmpresaTransporte);
            groupBox1.Controls.Add(labelEmpresaTransporte);
            groupBox1.Controls.Add(botonBuscar);
            groupBox1.Controls.Add(textBoxNrodeServicioTransporte);
            groupBox1.Controls.Add(labelNrodeServicioTransporte);
            groupBox1.Location = new Point(17, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 166);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Nro del Transporte";
            // 
            // labelResultadoRutadelTransporte
            // 
            labelResultadoRutadelTransporte.AutoSize = true;
            labelResultadoRutadelTransporte.Location = new Point(499, 114);
            labelResultadoRutadelTransporte.Name = "labelResultadoRutadelTransporte";
            labelResultadoRutadelTransporte.Size = new Size(144, 20);
            labelResultadoRutadelTransporte.TabIndex = 8;
            labelResultadoRutadelTransporte.Text = "[Ruta de Transporte]";
            // 
            // labelRutadelTransporte
            // 
            labelRutadelTransporte.AutoSize = true;
            labelRutadelTransporte.Location = new Point(499, 86);
            labelRutadelTransporte.Name = "labelRutadelTransporte";
            labelRutadelTransporte.Size = new Size(138, 20);
            labelRutadelTransporte.TabIndex = 7;
            labelRutadelTransporte.Text = "Ruta del Transporte";
            // 
            // labelResultadoFechaHDR
            // 
            labelResultadoFechaHDR.AutoSize = true;
            labelResultadoFechaHDR.Location = new Point(292, 114);
            labelResultadoFechaHDR.Name = "labelResultadoFechaHDR";
            labelResultadoFechaHDR.Size = new Size(140, 20);
            labelResultadoFechaHDR.TabIndex = 6;
            labelResultadoFechaHDR.Text = "[Fecha de Creación]";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(291, 82);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(47, 20);
            labelFecha.TabIndex = 5;
            labelFecha.Text = "Fecha";
            labelFecha.Click += label8_Click;
            // 
            // LabelResultadoEmpresaTransporte
            // 
            LabelResultadoEmpresaTransporte.AutoSize = true;
            LabelResultadoEmpresaTransporte.Location = new Point(28, 114);
            LabelResultadoEmpresaTransporte.Name = "LabelResultadoEmpresaTransporte";
            LabelResultadoEmpresaTransporte.Size = new Size(171, 20);
            LabelResultadoEmpresaTransporte.TabIndex = 4;
            LabelResultadoEmpresaTransporte.Text = "[Empresa de Transporte]";
            LabelResultadoEmpresaTransporte.Click += label7_Click;
            // 
            // labelEmpresaTransporte
            // 
            labelEmpresaTransporte.AutoSize = true;
            labelEmpresaTransporte.Location = new Point(28, 82);
            labelEmpresaTransporte.Name = "labelEmpresaTransporte";
            labelEmpresaTransporte.Size = new Size(161, 20);
            labelEmpresaTransporte.TabIndex = 3;
            labelEmpresaTransporte.Text = "Empresa de Transporte";
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(544, 32);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(176, 30);
            botonBuscar.TabIndex = 2;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxNrodeServicioTransporte
            // 
            textBoxNrodeServicioTransporte.Location = new Point(219, 35);
            textBoxNrodeServicioTransporte.Name = "textBoxNrodeServicioTransporte";
            textBoxNrodeServicioTransporte.Size = new Size(297, 27);
            textBoxNrodeServicioTransporte.TabIndex = 1;
            // 
            // labelNrodeServicioTransporte
            // 
            labelNrodeServicioTransporte.AutoSize = true;
            labelNrodeServicioTransporte.Location = new Point(21, 35);
            labelNrodeServicioTransporte.Name = "labelNrodeServicioTransporte";
            labelNrodeServicioTransporte.Size = new Size(192, 20);
            labelNrodeServicioTransporte.TabIndex = 0;
            labelNrodeServicioTransporte.Text = "Nro. de Servicio Transporte ";
            // 
            // groupBoxEncomiendasPendientes
            // 
            groupBoxEncomiendasPendientes.Controls.Add(botonAgregarTodo);
            groupBoxEncomiendasPendientes.Controls.Add(botonAgregar);
            groupBoxEncomiendasPendientes.Controls.Add(listViewEncomiendasPendientes);
            groupBoxEncomiendasPendientes.Location = new Point(26, 276);
            groupBoxEncomiendasPendientes.Name = "groupBoxEncomiendasPendientes";
            groupBoxEncomiendasPendientes.Size = new Size(344, 227);
            groupBoxEncomiendasPendientes.TabIndex = 5;
            groupBoxEncomiendasPendientes.TabStop = false;
            groupBoxEncomiendasPendientes.Text = "Encomiendas pendientes";
            // 
            // botonAgregarTodo
            // 
            botonAgregarTodo.Location = new Point(198, 181);
            botonAgregarTodo.Name = "botonAgregarTodo";
            botonAgregarTodo.Size = new Size(132, 37);
            botonAgregarTodo.TabIndex = 2;
            botonAgregarTodo.Text = "Agregar todo";
            botonAgregarTodo.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(16, 181);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(143, 30);
            botonAgregar.TabIndex = 1;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            // 
            // listViewEncomiendasPendientes
            // 
            listViewEncomiendasPendientes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4 });
            listViewEncomiendasPendientes.Location = new Point(13, 31);
            listViewEncomiendasPendientes.Name = "listViewEncomiendasPendientes";
            listViewEncomiendasPendientes.Size = new Size(320, 135);
            listViewEncomiendasPendientes.TabIndex = 0;
            listViewEncomiendasPendientes.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasPendientes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro. de Guia";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tamaño";
            columnHeader2.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Destino";
            columnHeader4.Width = 70;
            // 
            // groupBoxEncomiendasAsignadas
            // 
            groupBoxEncomiendasAsignadas.Controls.Add(botonEliminarTodo);
            groupBoxEncomiendasAsignadas.Controls.Add(botonEliminar);
            groupBoxEncomiendasAsignadas.Controls.Add(listViewEncomiendasAsignadas);
            groupBoxEncomiendasAsignadas.Location = new Point(394, 276);
            groupBoxEncomiendasAsignadas.Name = "groupBoxEncomiendasAsignadas";
            groupBoxEncomiendasAsignadas.Size = new Size(378, 227);
            groupBoxEncomiendasAsignadas.TabIndex = 6;
            groupBoxEncomiendasAsignadas.TabStop = false;
            groupBoxEncomiendasAsignadas.Text = "Encomiendas asignadas a este HDR";
            // 
            // botonEliminarTodo
            // 
            botonEliminarTodo.Location = new Point(216, 185);
            botonEliminarTodo.Name = "botonEliminarTodo";
            botonEliminarTodo.Size = new Size(153, 33);
            botonEliminarTodo.TabIndex = 2;
            botonEliminarTodo.Text = "Eliminar todo";
            botonEliminarTodo.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(21, 184);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(140, 31);
            botonEliminar.TabIndex = 1;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            // 
            // listViewEncomiendasAsignadas
            // 
            listViewEncomiendasAsignadas.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader8 });
            listViewEncomiendasAsignadas.Location = new Point(11, 29);
            listViewEncomiendasAsignadas.Name = "listViewEncomiendasAsignadas";
            listViewEncomiendasAsignadas.Size = new Size(358, 141);
            listViewEncomiendasAsignadas.TabIndex = 0;
            listViewEncomiendasAsignadas.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasAsignadas.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nro. de Guia";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tamaño";
            columnHeader6.Width = 70;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Destino";
            columnHeader8.Width = 70;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(448, 543);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(139, 36);
            botonCancelar.TabIndex = 7;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonGenerarHDR
            // 
            botonGenerarHDR.Location = new Point(626, 544);
            botonGenerarHDR.Name = "botonGenerarHDR";
            botonGenerarHDR.Size = new Size(142, 36);
            botonGenerarHDR.TabIndex = 8;
            botonGenerarHDR.Text = "Generar HDR";
            botonGenerarHDR.UseVisualStyleBackColor = true;
            // 
            // GenerarHDRTransporteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(botonGenerarHDR);
            Controls.Add(botonCancelar);
            Controls.Add(groupBoxEncomiendasAsignadas);
            Controls.Add(groupBoxEncomiendasPendientes);
            Controls.Add(groupBox1);
            Controls.Add(CentroDistribucionLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GenerarHDRTransporteForm";
            Text = "Generar HDR Transporte";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxEncomiendasPendientes.ResumeLayout(false);
            groupBoxEncomiendasAsignadas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label CentroDistribucionLabel;
        private GroupBox groupBox1;
        private Label LabelResultadoEmpresaTransporte;
        private Label labelEmpresaTransporte;
        private Button botonBuscar;
        private TextBox textBoxNrodeServicioTransporte;
        private Label labelNrodeServicioTransporte;
        private Label labelFecha;
        private Label labelRutadelTransporte;
        private Label labelResultadoFechaHDR;
        private Label labelResultadoRutadelTransporte;
        private GroupBox groupBoxEncomiendasPendientes;
        private Button botonAgregar;
        private ListView listViewEncomiendasPendientes;
        private GroupBox groupBoxEncomiendasAsignadas;
        private ListView listViewEncomiendasAsignadas;
        private Button botonAgregarTodo;
        private Button botonEliminarTodo;
        private Button botonEliminar;
        private Button botonCancelar;
        private Button botonGenerarHDR;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
    }
}