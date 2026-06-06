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
            labelUsuario = new Label();
            labelUsuarioResultado = new Label();
            labelCD = new Label();
            labelResultadoCD = new Label();
            groupBoxIngreseNroTransporte = new GroupBox();
            labelResultadoFechaHoraSalida = new Label();
            labelFechaSalida = new Label();
            labelResultadoRutadelTransporte = new Label();
            labelRutadelTransporte = new Label();
            labelResultadoEmpresaTransporte = new Label();
            labelEmpresaTransporte = new Label();
            botonBuscar = new Button();
            textBoxNrodeServicioTransporte = new TextBox();
            labelNrodeServicioTransporte = new Label();
            labelResultadoFechaEmision = new Label();
            labelFechaEmision = new Label();
            groupBoxEncomiendasPendientes = new GroupBox();
            botonAgregarTodo = new Button();
            botonAgregar = new Button();
            listViewEncomiendasPendientes = new ListView();
            columnaguia = new ColumnHeader();
            columnatamaño = new ColumnHeader();
            columnadestino = new ColumnHeader();
            groupBoxEncomiendasAsignadas = new GroupBox();
            botonEliminarTodo = new Button();
            botonEliminar = new Button();
            listViewEncomiendasAsignadas = new ListView();
            columnaguia2 = new ColumnHeader();
            columnatamaño2 = new ColumnHeader();
            columndestino2 = new ColumnHeader();
            botonCancelar = new Button();
            botonGenerarHDR = new Button();
            groupBoxIngreseNroTransporte.SuspendLayout();
            groupBoxEncomiendasPendientes.SuspendLayout();
            groupBoxEncomiendasAsignadas.SuspendLayout();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(14, 20);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 20);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario: ";
            // 
            // labelUsuarioResultado
            // 
            labelUsuarioResultado.AutoSize = true;
            labelUsuarioResultado.Location = new Point(109, 20);
            labelUsuarioResultado.Name = "labelUsuarioResultado";
            labelUsuarioResultado.Size = new Size(33, 20);
            labelUsuarioResultado.TabIndex = 1;
            labelUsuarioResultado.Text = "002";
            // 
            // labelCD
            // 
            labelCD.AutoSize = true;
            labelCD.Location = new Point(209, 22);
            labelCD.Name = "labelCD";
            labelCD.Size = new Size(36, 20);
            labelCD.TabIndex = 2;
            labelCD.Text = "CD: ";
            // 
            // labelResultadoCD
            // 
            labelResultadoCD.AutoSize = true;
            labelResultadoCD.Location = new Point(251, 22);
            labelResultadoCD.Name = "labelResultadoCD";
            labelResultadoCD.Size = new Size(168, 20);
            labelResultadoCD.TabIndex = 3;
            labelResultadoCD.Text = "[Centro de Distribución]";
            // 
            // groupBoxIngreseNroTransporte
            // 
            groupBoxIngreseNroTransporte.Controls.Add(labelResultadoFechaHoraSalida);
            groupBoxIngreseNroTransporte.Controls.Add(labelFechaSalida);
            groupBoxIngreseNroTransporte.Controls.Add(labelResultadoRutadelTransporte);
            groupBoxIngreseNroTransporte.Controls.Add(labelRutadelTransporte);
            groupBoxIngreseNroTransporte.Controls.Add(labelResultadoEmpresaTransporte);
            groupBoxIngreseNroTransporte.Controls.Add(labelEmpresaTransporte);
            groupBoxIngreseNroTransporte.Controls.Add(botonBuscar);
            groupBoxIngreseNroTransporte.Controls.Add(textBoxNrodeServicioTransporte);
            groupBoxIngreseNroTransporte.Controls.Add(labelNrodeServicioTransporte);
            groupBoxIngreseNroTransporte.Location = new Point(26, 57);
            groupBoxIngreseNroTransporte.Name = "groupBoxIngreseNroTransporte";
            groupBoxIngreseNroTransporte.Size = new Size(762, 203);
            groupBoxIngreseNroTransporte.TabIndex = 4;
            groupBoxIngreseNroTransporte.TabStop = false;
            groupBoxIngreseNroTransporte.Text = "Ingrese Nro del Transporte";
            // 
            // labelResultadoFechaHoraSalida
            // 
            labelResultadoFechaHoraSalida.AutoSize = true;
            labelResultadoFechaHoraSalida.Location = new Point(314, 114);
            labelResultadoFechaHoraSalida.Name = "labelResultadoFechaHoraSalida";
            labelResultadoFechaHoraSalida.Size = new Size(175, 20);
            labelResultadoFechaHoraSalida.TabIndex = 11;
            labelResultadoFechaHoraSalida.Text = "[Resultado Fecha y Hora]";
            // 
            // labelFechaSalida
            // 
            labelFechaSalida.AutoSize = true;
            labelFechaSalida.Location = new Point(325, 91);
            labelFechaSalida.Name = "labelFechaSalida";
            labelFechaSalida.Size = new Size(164, 20);
            labelFechaSalida.TabIndex = 9;
            labelFechaSalida.Text = "Fecha y Hora de Salida:";
            labelFechaSalida.Click += label1_Click;
            // 
            // labelResultadoRutadelTransporte
            // 
            labelResultadoRutadelTransporte.AutoSize = true;
            labelResultadoRutadelTransporte.Location = new Point(577, 114);
            labelResultadoRutadelTransporte.Name = "labelResultadoRutadelTransporte";
            labelResultadoRutadelTransporte.Size = new Size(169, 20);
            labelResultadoRutadelTransporte.TabIndex = 8;
            labelResultadoRutadelTransporte.Text = "[CD Origen/CD DEstino]";
            labelResultadoRutadelTransporte.Click += labelResultadoRutadelTransporte_Click;
            // 
            // labelRutadelTransporte
            // 
            labelRutadelTransporte.AutoSize = true;
            labelRutadelTransporte.Location = new Point(599, 86);
            labelRutadelTransporte.Name = "labelRutadelTransporte";
            labelRutadelTransporte.Size = new Size(138, 20);
            labelRutadelTransporte.TabIndex = 7;
            labelRutadelTransporte.Text = "Ruta del Transporte";
            // 
            // labelResultadoEmpresaTransporte
            // 
            labelResultadoEmpresaTransporte.AutoSize = true;
            labelResultadoEmpresaTransporte.Location = new Point(28, 114);
            labelResultadoEmpresaTransporte.Name = "labelResultadoEmpresaTransporte";
            labelResultadoEmpresaTransporte.Size = new Size(171, 20);
            labelResultadoEmpresaTransporte.TabIndex = 4;
            labelResultadoEmpresaTransporte.Text = "[Empresa de Transporte]";
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
            botonBuscar.Click += botonBuscar_Click;
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
            // labelResultadoFechaEmision
            // 
            labelResultadoFechaEmision.AutoSize = true;
            labelResultadoFechaEmision.Location = new Point(578, 22);
            labelResultadoFechaEmision.Name = "labelResultadoFechaEmision";
            labelResultadoFechaEmision.Size = new Size(140, 20);
            labelResultadoFechaEmision.TabIndex = 6;
            labelResultadoFechaEmision.Text = "[Fecha de Creación]";
            labelResultadoFechaEmision.Click += labelResultadoFecha_Click;
            // 
            // labelFechaEmision
            // 
            labelFechaEmision.AutoSize = true;
            labelFechaEmision.Location = new Point(525, 22);
            labelFechaEmision.Name = "labelFechaEmision";
            labelFechaEmision.Size = new Size(47, 20);
            labelFechaEmision.TabIndex = 5;
            labelFechaEmision.Text = "Fecha";
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
            botonAgregarTodo.Click += botonAgregarTodo_Click;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(16, 181);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(143, 30);
            botonAgregar.TabIndex = 1;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // listViewEncomiendasPendientes
            // 
            listViewEncomiendasPendientes.Columns.AddRange(new ColumnHeader[] { columnaguia, columnatamaño, columnadestino });
            listViewEncomiendasPendientes.FullRowSelect = true;
            listViewEncomiendasPendientes.Location = new Point(13, 31);
            listViewEncomiendasPendientes.MultiSelect = false;
            listViewEncomiendasPendientes.Name = "listViewEncomiendasPendientes";
            listViewEncomiendasPendientes.Size = new Size(320, 135);
            listViewEncomiendasPendientes.TabIndex = 0;
            listViewEncomiendasPendientes.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasPendientes.View = View.Details;
            // 
            // columnaguia
            // 
            columnaguia.Text = "Nro. de Guia";
            columnaguia.Width = 100;
            // 
            // columnatamaño
            // 
            columnatamaño.Text = "Tamaño";
            columnatamaño.Width = 70;
            // 
            // columnadestino
            // 
            columnadestino.Text = "Destino";
            columnadestino.Width = 70;
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
            botonEliminarTodo.Click += botonEliminarTodo_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(21, 184);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(140, 31);
            botonEliminar.TabIndex = 1;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // listViewEncomiendasAsignadas
            // 
            listViewEncomiendasAsignadas.Columns.AddRange(new ColumnHeader[] { columnaguia2, columnatamaño2, columndestino2 });
            listViewEncomiendasAsignadas.Location = new Point(11, 29);
            listViewEncomiendasAsignadas.Name = "listViewEncomiendasAsignadas";
            listViewEncomiendasAsignadas.Size = new Size(358, 141);
            listViewEncomiendasAsignadas.TabIndex = 0;
            listViewEncomiendasAsignadas.UseCompatibleStateImageBehavior = false;
            listViewEncomiendasAsignadas.View = View.Details;
            // 
            // columnaguia2
            // 
            columnaguia2.Text = "Nro. de Guia";
            columnaguia2.Width = 100;
            // 
            // columnatamaño2
            // 
            columnatamaño2.Text = "Tamaño";
            columnatamaño2.Width = 70;
            // 
            // columndestino2
            // 
            columndestino2.Text = "Destino";
            columndestino2.Width = 70;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(448, 543);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(139, 36);
            botonCancelar.TabIndex = 7;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // botonGenerarHDR
            // 
            botonGenerarHDR.Location = new Point(626, 544);
            botonGenerarHDR.Name = "botonGenerarHDR";
            botonGenerarHDR.Size = new Size(142, 36);
            botonGenerarHDR.TabIndex = 8;
            botonGenerarHDR.Text = "Generar HDR";
            botonGenerarHDR.UseVisualStyleBackColor = true;
            botonGenerarHDR.Click += botonGenerarHDR_Click;
            // 
            // GenerarHDRTransporteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(botonGenerarHDR);
            Controls.Add(botonCancelar);
            Controls.Add(labelResultadoFechaEmision);
            Controls.Add(groupBoxEncomiendasAsignadas);
            Controls.Add(labelFechaEmision);
            Controls.Add(groupBoxEncomiendasPendientes);
            Controls.Add(groupBoxIngreseNroTransporte);
            Controls.Add(labelResultadoCD);
            Controls.Add(labelCD);
            Controls.Add(labelUsuarioResultado);
            Controls.Add(labelUsuario);
            Name = "GenerarHDRTransporteForm";
            Text = "Generar HDR Transporte";
            Load += GenerarHDRTransporteForm_Load;
            groupBoxIngreseNroTransporte.ResumeLayout(false);
            groupBoxIngreseNroTransporte.PerformLayout();
            groupBoxEncomiendasPendientes.ResumeLayout(false);
            groupBoxEncomiendasAsignadas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private Label labelUsuarioResultado;
        private Label labelCD;
        private Label labelResultadoCD;
        private GroupBox groupBoxIngreseNroTransporte;
        private Label labelResultadoEmpresaTransporte;
        private Label labelEmpresaTransporte;
        private Button botonBuscar;
        private TextBox textBoxNrodeServicioTransporte;
        private Label labelNrodeServicioTransporte;
        private Label labelFechaEmision;
        private Label labelRutadelTransporte;
        private Label labelResultadoFechaEmision;
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
        private ColumnHeader columnaguia;
        private ColumnHeader columnatamaño;
        private ColumnHeader columnadestino;
        private ColumnHeader columnaguia2;
        private ColumnHeader columnatamaño2;
        private ColumnHeader columndestino2;
        private Label labelFechaSalida;
        private Label labelResultadoFechaHoraSalida;
    }
}