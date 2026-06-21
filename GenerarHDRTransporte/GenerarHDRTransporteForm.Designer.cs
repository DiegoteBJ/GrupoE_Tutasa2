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
            labelUsuario.Location = new Point(12, 15);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(57, 15);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario: ";
            // 
            // labelUsuarioResultado
            // 
            labelUsuarioResultado.AutoSize = true;
            labelUsuarioResultado.Location = new Point(95, 15);
            labelUsuarioResultado.Name = "labelUsuarioResultado";
            labelUsuarioResultado.Size = new Size(14, 15);
            labelUsuarioResultado.TabIndex = 1;
            labelUsuarioResultado.Text = "2";
            // 
            // labelCD
            // 
            labelCD.AutoSize = true;
            labelCD.Location = new Point(183, 16);
            labelCD.Name = "labelCD";
            labelCD.Size = new Size(29, 15);
            labelCD.TabIndex = 2;
            labelCD.Text = "CD: ";
            // 
            // labelResultadoCD
            // 
            labelResultadoCD.AutoSize = true;
            labelResultadoCD.Location = new Point(220, 16);
            labelResultadoCD.Name = "labelResultadoCD";
            labelResultadoCD.Size = new Size(141, 15);
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
            groupBoxIngreseNroTransporte.Location = new Point(23, 43);
            groupBoxIngreseNroTransporte.Margin = new Padding(3, 2, 3, 2);
            groupBoxIngreseNroTransporte.Name = "groupBoxIngreseNroTransporte";
            groupBoxIngreseNroTransporte.Padding = new Padding(3, 2, 3, 2);
            groupBoxIngreseNroTransporte.Size = new Size(667, 152);
            groupBoxIngreseNroTransporte.TabIndex = 4;
            groupBoxIngreseNroTransporte.TabStop = false;
            groupBoxIngreseNroTransporte.Text = "Ingrese Nro del Transporte";
            // 
            // labelResultadoFechaHoraSalida
            // 
            labelResultadoFechaHoraSalida.AutoSize = true;
            labelResultadoFechaHoraSalida.Location = new Point(275, 86);
            labelResultadoFechaHoraSalida.Name = "labelResultadoFechaHoraSalida";
            labelResultadoFechaHoraSalida.Size = new Size(148, 15);
            labelResultadoFechaHoraSalida.TabIndex = 11;
            labelResultadoFechaHoraSalida.Text = "[Resultado Fecha y Hora]";
            // 
            // labelFechaSalida
            // 
            labelFechaSalida.AutoSize = true;
            labelFechaSalida.Location = new Point(284, 68);
            labelFechaSalida.Name = "labelFechaSalida";
            labelFechaSalida.Size = new Size(138, 15);
            labelFechaSalida.TabIndex = 9;
            labelFechaSalida.Text = "Fecha y Hora de Salida:";
            labelFechaSalida.Click += label1_Click;
            // 
            // labelResultadoRutadelTransporte
            // 
            labelResultadoRutadelTransporte.AutoSize = true;
            labelResultadoRutadelTransporte.Location = new Point(505, 86);
            labelResultadoRutadelTransporte.Name = "labelResultadoRutadelTransporte";
            labelResultadoRutadelTransporte.Size = new Size(137, 15);
            labelResultadoRutadelTransporte.TabIndex = 8;
            labelResultadoRutadelTransporte.Text = "[CD Origen/CD DEstino]";
            labelResultadoRutadelTransporte.Click += labelResultadoRutadelTransporte_Click;
            // 
            // labelRutadelTransporte
            // 
            labelRutadelTransporte.AutoSize = true;
            labelRutadelTransporte.Location = new Point(524, 64);
            labelRutadelTransporte.Name = "labelRutadelTransporte";
            labelRutadelTransporte.Size = new Size(118, 15);
            labelRutadelTransporte.TabIndex = 7;
            labelRutadelTransporte.Text = "Ruta del Transporte";
            // 
            // labelResultadoEmpresaTransporte
            // 
            labelResultadoEmpresaTransporte.AutoSize = true;
            labelResultadoEmpresaTransporte.Location = new Point(24, 86);
            labelResultadoEmpresaTransporte.Name = "labelResultadoEmpresaTransporte";
            labelResultadoEmpresaTransporte.Size = new Size(148, 15);
            labelResultadoEmpresaTransporte.TabIndex = 4;
            labelResultadoEmpresaTransporte.Text = "[Empresa de Transporte]";
            // 
            // labelEmpresaTransporte
            // 
            labelEmpresaTransporte.AutoSize = true;
            labelEmpresaTransporte.Location = new Point(24, 62);
            labelEmpresaTransporte.Name = "labelEmpresaTransporte";
            labelEmpresaTransporte.Size = new Size(140, 15);
            labelEmpresaTransporte.TabIndex = 3;
            labelEmpresaTransporte.Text = "Empresa de Transporte";
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(476, 24);
            botonBuscar.Margin = new Padding(3, 2, 3, 2);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(154, 22);
            botonBuscar.TabIndex = 2;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // textBoxNrodeServicioTransporte
            // 
            textBoxNrodeServicioTransporte.Location = new Point(192, 26);
            textBoxNrodeServicioTransporte.Margin = new Padding(3, 2, 3, 2);
            textBoxNrodeServicioTransporte.Name = "textBoxNrodeServicioTransporte";
            textBoxNrodeServicioTransporte.Size = new Size(260, 21);
            textBoxNrodeServicioTransporte.TabIndex = 1;
            // 
            // labelNrodeServicioTransporte
            // 
            labelNrodeServicioTransporte.AutoSize = true;
            labelNrodeServicioTransporte.Location = new Point(18, 26);
            labelNrodeServicioTransporte.Name = "labelNrodeServicioTransporte";
            labelNrodeServicioTransporte.Size = new Size(164, 15);
            labelNrodeServicioTransporte.TabIndex = 0;
            labelNrodeServicioTransporte.Text = "Nro. de Servicio Transporte ";
            // 
            // labelResultadoFechaEmision
            // 
            labelResultadoFechaEmision.AutoSize = true;
            labelResultadoFechaEmision.Location = new Point(506, 16);
            labelResultadoFechaEmision.Name = "labelResultadoFechaEmision";
            labelResultadoFechaEmision.Size = new Size(120, 15);
            labelResultadoFechaEmision.TabIndex = 6;
            labelResultadoFechaEmision.Text = "[Fecha de Creación]";
            labelResultadoFechaEmision.Click += labelResultadoFecha_Click;
            // 
            // labelFechaEmision
            // 
            labelFechaEmision.AutoSize = true;
            labelFechaEmision.Location = new Point(459, 16);
            labelFechaEmision.Name = "labelFechaEmision";
            labelFechaEmision.Size = new Size(41, 15);
            labelFechaEmision.TabIndex = 5;
            labelFechaEmision.Text = "Fecha";
            // 
            // groupBoxEncomiendasPendientes
            // 
            groupBoxEncomiendasPendientes.Controls.Add(botonAgregarTodo);
            groupBoxEncomiendasPendientes.Controls.Add(botonAgregar);
            groupBoxEncomiendasPendientes.Controls.Add(listViewEncomiendasPendientes);
            groupBoxEncomiendasPendientes.Location = new Point(23, 207);
            groupBoxEncomiendasPendientes.Margin = new Padding(3, 2, 3, 2);
            groupBoxEncomiendasPendientes.Name = "groupBoxEncomiendasPendientes";
            groupBoxEncomiendasPendientes.Padding = new Padding(3, 2, 3, 2);
            groupBoxEncomiendasPendientes.Size = new Size(301, 170);
            groupBoxEncomiendasPendientes.TabIndex = 5;
            groupBoxEncomiendasPendientes.TabStop = false;
            groupBoxEncomiendasPendientes.Text = "Encomiendas pendientes";
            // 
            // botonAgregarTodo
            // 
            botonAgregarTodo.Location = new Point(173, 136);
            botonAgregarTodo.Margin = new Padding(3, 2, 3, 2);
            botonAgregarTodo.Name = "botonAgregarTodo";
            botonAgregarTodo.Size = new Size(116, 28);
            botonAgregarTodo.TabIndex = 2;
            botonAgregarTodo.Text = "Agregar todo";
            botonAgregarTodo.UseVisualStyleBackColor = true;
            botonAgregarTodo.Click += botonAgregarTodo_Click;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(14, 136);
            botonAgregar.Margin = new Padding(3, 2, 3, 2);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(125, 22);
            botonAgregar.TabIndex = 1;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // listViewEncomiendasPendientes
            // 
            listViewEncomiendasPendientes.Columns.AddRange(new ColumnHeader[] { columnaguia, columnatamaño, columnadestino });
            listViewEncomiendasPendientes.ForeColor = Color.Blue;
            listViewEncomiendasPendientes.FullRowSelect = true;
            listViewEncomiendasPendientes.Location = new Point(11, 23);
            listViewEncomiendasPendientes.Margin = new Padding(3, 2, 3, 2);
            listViewEncomiendasPendientes.MultiSelect = false;
            listViewEncomiendasPendientes.Name = "listViewEncomiendasPendientes";
            listViewEncomiendasPendientes.Size = new Size(280, 102);
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
            groupBoxEncomiendasAsignadas.Location = new Point(345, 207);
            groupBoxEncomiendasAsignadas.Margin = new Padding(3, 2, 3, 2);
            groupBoxEncomiendasAsignadas.Name = "groupBoxEncomiendasAsignadas";
            groupBoxEncomiendasAsignadas.Padding = new Padding(3, 2, 3, 2);
            groupBoxEncomiendasAsignadas.Size = new Size(331, 170);
            groupBoxEncomiendasAsignadas.TabIndex = 6;
            groupBoxEncomiendasAsignadas.TabStop = false;
            groupBoxEncomiendasAsignadas.Text = "Encomiendas asignadas a este HDR";
            // 
            // botonEliminarTodo
            // 
            botonEliminarTodo.Location = new Point(189, 139);
            botonEliminarTodo.Margin = new Padding(3, 2, 3, 2);
            botonEliminarTodo.Name = "botonEliminarTodo";
            botonEliminarTodo.Size = new Size(134, 25);
            botonEliminarTodo.TabIndex = 2;
            botonEliminarTodo.Text = "Eliminar todo";
            botonEliminarTodo.UseVisualStyleBackColor = true;
            botonEliminarTodo.Click += botonEliminarTodo_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(18, 138);
            botonEliminar.Margin = new Padding(3, 2, 3, 2);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(122, 23);
            botonEliminar.TabIndex = 1;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // listViewEncomiendasAsignadas
            // 
            listViewEncomiendasAsignadas.Columns.AddRange(new ColumnHeader[] { columnaguia2, columnatamaño2, columndestino2 });
            listViewEncomiendasAsignadas.ForeColor = Color.Blue;
            listViewEncomiendasAsignadas.FullRowSelect = true;
            listViewEncomiendasAsignadas.Location = new Point(10, 22);
            listViewEncomiendasAsignadas.Margin = new Padding(3, 2, 3, 2);
            listViewEncomiendasAsignadas.Name = "listViewEncomiendasAsignadas";
            listViewEncomiendasAsignadas.Size = new Size(314, 107);
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
            botonCancelar.Location = new Point(392, 407);
            botonCancelar.Margin = new Padding(3, 2, 3, 2);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(122, 27);
            botonCancelar.TabIndex = 7;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // botonGenerarHDR
            // 
            botonGenerarHDR.Location = new Point(548, 408);
            botonGenerarHDR.Margin = new Padding(3, 2, 3, 2);
            botonGenerarHDR.Name = "botonGenerarHDR";
            botonGenerarHDR.Size = new Size(124, 27);
            botonGenerarHDR.TabIndex = 8;
            botonGenerarHDR.Text = "Generar HDR";
            botonGenerarHDR.UseVisualStyleBackColor = true;
            botonGenerarHDR.Click += botonGenerarHDR_Click;
            // 
            // GenerarHDRTransporteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 460);
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
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
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