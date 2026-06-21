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
            listViewHDRaRecibir = new ListView();
            columnHeaderNroGuias = new ColumnHeader();
            columnHeaderDestino = new ColumnHeader();
            columnHeaderTamaño = new ColumnHeader();
            groupBoxHDRaDespachar = new GroupBox();
            listViewHDRaDespachar = new ListView();
            columnaNrodeGuia = new ColumnHeader();
            columnaDestinoDespachar = new ColumnHeader();
            columnaTamañoDespachar = new ColumnHeader();
            botonConfirmar = new Button();
            botonCancelar = new Button();
            labelUsuario = new Label();
            labelRespuestaUsuario = new Label();
            label7 = new Label();
            labelResultadoCD = new Label();
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
            groupBoxIngreseNrodeTransporte.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxIngreseNrodeTransporte.Location = new Point(35, 45);
            groupBoxIngreseNrodeTransporte.Margin = new Padding(3, 2, 3, 2);
            groupBoxIngreseNrodeTransporte.Name = "groupBoxIngreseNrodeTransporte";
            groupBoxIngreseNrodeTransporte.Padding = new Padding(3, 2, 3, 2);
            groupBoxIngreseNrodeTransporte.Size = new Size(637, 82);
            groupBoxIngreseNrodeTransporte.TabIndex = 0;
            groupBoxIngreseNrodeTransporte.TabStop = false;
            groupBoxIngreseNrodeTransporte.Text = "Ingrese en Nro de Transporte";
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(499, 35);
            botonBuscar.Margin = new Padding(3, 2, 3, 2);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(120, 28);
            botonBuscar.TabIndex = 2;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // textBoxNrodeservicioTransporte
            // 
            textBoxNrodeservicioTransporte.Location = new Point(270, 38);
            textBoxNrodeservicioTransporte.Margin = new Padding(3, 2, 3, 2);
            textBoxNrodeservicioTransporte.Name = "textBoxNrodeservicioTransporte";
            textBoxNrodeservicioTransporte.Size = new Size(211, 21);
            textBoxNrodeservicioTransporte.TabIndex = 1;
            // 
            // labelNrodeServicioTransporte
            // 
            labelNrodeServicioTransporte.AutoSize = true;
            labelNrodeServicioTransporte.Location = new Point(25, 35);
            labelNrodeServicioTransporte.Name = "labelNrodeServicioTransporte";
            labelNrodeServicioTransporte.Size = new Size(178, 15);
            labelNrodeServicioTransporte.TabIndex = 0;
            labelNrodeServicioTransporte.Text = "Nro. de Servicio de Transporte";
            // 
            // groupBoxDatosdeEmpresaTransporte
            // 
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelResultadoFecha);
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelResultadoNombreTransporte);
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelFecha);
            groupBoxDatosdeEmpresaTransporte.Controls.Add(labelNombreTransporte);
            groupBoxDatosdeEmpresaTransporte.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDatosdeEmpresaTransporte.Location = new Point(35, 139);
            groupBoxDatosdeEmpresaTransporte.Margin = new Padding(3, 2, 3, 2);
            groupBoxDatosdeEmpresaTransporte.Name = "groupBoxDatosdeEmpresaTransporte";
            groupBoxDatosdeEmpresaTransporte.Padding = new Padding(3, 2, 3, 2);
            groupBoxDatosdeEmpresaTransporte.Size = new Size(640, 97);
            groupBoxDatosdeEmpresaTransporte.TabIndex = 1;
            groupBoxDatosdeEmpresaTransporte.TabStop = false;
            groupBoxDatosdeEmpresaTransporte.Text = "Datos de la Empresa de Transporte";
            // 
            // labelResultadoFecha
            // 
            labelResultadoFecha.AutoSize = true;
            labelResultadoFecha.BackColor = SystemColors.ControlLightLight;
            labelResultadoFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultadoFecha.ForeColor = SystemColors.ControlDark;
            labelResultadoFecha.Location = new Point(169, 64);
            labelResultadoFecha.Name = "labelResultadoFecha";
            labelResultadoFecha.Size = new Size(93, 15);
            labelResultadoFecha.TabIndex = 3;
            labelResultadoFecha.Text = "Resultado Fecha";
            // 
            // labelResultadoNombreTransporte
            // 
            labelResultadoNombreTransporte.AutoSize = true;
            labelResultadoNombreTransporte.BackColor = SystemColors.ControlLightLight;
            labelResultadoNombreTransporte.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultadoNombreTransporte.ForeColor = SystemColors.ButtonShadow;
            labelResultadoNombreTransporte.Location = new Point(169, 30);
            labelResultadoNombreTransporte.Name = "labelResultadoNombreTransporte";
            labelResultadoNombreTransporte.Size = new Size(106, 15);
            labelResultadoNombreTransporte.TabIndex = 2;
            labelResultadoNombreTransporte.Text = "Resultado Nombre";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(24, 64);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(44, 15);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha:";
            // 
            // labelNombreTransporte
            // 
            labelNombreTransporte.AutoSize = true;
            labelNombreTransporte.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreTransporte.Location = new Point(24, 32);
            labelNombreTransporte.Name = "labelNombreTransporte";
            labelNombreTransporte.Size = new Size(120, 15);
            labelNombreTransporte.TabIndex = 0;
            labelNombreTransporte.Text = "Nombre Transporte:";
            // 
            // groupBoxHDRaRecibir
            // 
            groupBoxHDRaRecibir.Controls.Add(listViewHDRaRecibir);
            groupBoxHDRaRecibir.Location = new Point(37, 240);
            groupBoxHDRaRecibir.Margin = new Padding(3, 2, 3, 2);
            groupBoxHDRaRecibir.Name = "groupBoxHDRaRecibir";
            groupBoxHDRaRecibir.Padding = new Padding(3, 2, 3, 2);
            groupBoxHDRaRecibir.Size = new Size(282, 161);
            groupBoxHDRaRecibir.TabIndex = 2;
            groupBoxHDRaRecibir.TabStop = false;
            groupBoxHDRaRecibir.Text = "Hojas de ruta a recibir";
            // 
            // listViewHDRaRecibir
            // 
            listViewHDRaRecibir.Columns.AddRange(new ColumnHeader[] { columnHeaderNroGuias, columnHeaderDestino, columnHeaderTamaño });
            listViewHDRaRecibir.ForeColor = Color.Blue;
            listViewHDRaRecibir.Location = new Point(10, 22);
            listViewHDRaRecibir.Margin = new Padding(3, 2, 3, 2);
            listViewHDRaRecibir.Name = "listViewHDRaRecibir";
            listViewHDRaRecibir.Size = new Size(264, 128);
            listViewHDRaRecibir.TabIndex = 0;
            listViewHDRaRecibir.UseCompatibleStateImageBehavior = false;
            listViewHDRaRecibir.View = View.Details;
            // 
            // columnHeaderNroGuias
            // 
            columnHeaderNroGuias.Text = "Nro de Guias";
            columnHeaderNroGuias.Width = 110;
            // 
            // columnHeaderDestino
            // 
            columnHeaderDestino.Text = "Destino";
            columnHeaderDestino.Width = 90;
            // 
            // columnHeaderTamaño
            // 
            columnHeaderTamaño.Text = "Tamaño";
            columnHeaderTamaño.Width = 80;
            // 
            // groupBoxHDRaDespachar
            // 
            groupBoxHDRaDespachar.Controls.Add(listViewHDRaDespachar);
            groupBoxHDRaDespachar.Location = new Point(375, 240);
            groupBoxHDRaDespachar.Margin = new Padding(3, 2, 3, 2);
            groupBoxHDRaDespachar.Name = "groupBoxHDRaDespachar";
            groupBoxHDRaDespachar.Padding = new Padding(3, 2, 3, 2);
            groupBoxHDRaDespachar.Size = new Size(293, 158);
            groupBoxHDRaDespachar.TabIndex = 3;
            groupBoxHDRaDespachar.TabStop = false;
            groupBoxHDRaDespachar.Text = "Hojas de ruta a despachar";
            // 
            // listViewHDRaDespachar
            // 
            listViewHDRaDespachar.Columns.AddRange(new ColumnHeader[] { columnaNrodeGuia, columnaDestinoDespachar, columnaTamañoDespachar });
            listViewHDRaDespachar.ForeColor = Color.Blue;
            listViewHDRaDespachar.Location = new Point(7, 22);
            listViewHDRaDespachar.Margin = new Padding(3, 2, 3, 2);
            listViewHDRaDespachar.Name = "listViewHDRaDespachar";
            listViewHDRaDespachar.Size = new Size(272, 127);
            listViewHDRaDespachar.TabIndex = 0;
            listViewHDRaDespachar.UseCompatibleStateImageBehavior = false;
            listViewHDRaDespachar.View = View.Details;
            // 
            // columnaNrodeGuia
            // 
            columnaNrodeGuia.Text = "Nro de Guias";
            columnaNrodeGuia.Width = 110;
            // 
            // columnaDestinoDespachar
            // 
            columnaDestinoDespachar.Text = "Destino";
            columnaDestinoDespachar.Width = 80;
            // 
            // columnaTamañoDespachar
            // 
            columnaTamañoDespachar.Text = "Tamaño";
            columnaTamañoDespachar.Width = 80;
            // 
            // botonConfirmar
            // 
            botonConfirmar.Location = new Point(114, 460);
            botonConfirmar.Margin = new Padding(3, 2, 3, 2);
            botonConfirmar.Name = "botonConfirmar";
            botonConfirmar.Size = new Size(122, 27);
            botonConfirmar.TabIndex = 4;
            botonConfirmar.Text = "Confirmar";
            botonConfirmar.UseVisualStyleBackColor = true;
            botonConfirmar.Click += botonConfirmar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(441, 460);
            botonCancelar.Margin = new Padding(3, 2, 3, 2);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(127, 27);
            botonCancelar.TabIndex = 5;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(20, 10);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(57, 15);
            labelUsuario.TabIndex = 6;
            labelUsuario.Text = "Usuario: ";
            // 
            // labelRespuestaUsuario
            // 
            labelRespuestaUsuario.AutoSize = true;
            labelRespuestaUsuario.Location = new Point(83, 10);
            labelRespuestaUsuario.Name = "labelRespuestaUsuario";
            labelRespuestaUsuario.Size = new Size(67, 15);
            labelRespuestaUsuario.TabIndex = 7;
            labelRespuestaUsuario.Text = "Usuario 11";
            labelRespuestaUsuario.Click += labelRespuestaUsuario_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 10);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 8;
            label7.Text = "CD: ";
            // 
            // labelResultadoCD
            // 
            labelResultadoCD.AutoSize = true;
            labelResultadoCD.Location = new Point(239, 10);
            labelResultadoCD.Name = "labelResultadoCD";
            labelResultadoCD.Size = new Size(83, 15);
            labelResultadoCD.TabIndex = 9;
            labelResultadoCD.Text = "Buenos Aires";
            // 
            // RecepcionDespachoCDLargaDistanciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 534);
            Controls.Add(labelResultadoCD);
            Controls.Add(label7);
            Controls.Add(labelRespuestaUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(botonCancelar);
            Controls.Add(botonConfirmar);
            Controls.Add(groupBoxHDRaDespachar);
            Controls.Add(groupBoxHDRaRecibir);
            Controls.Add(groupBoxDatosdeEmpresaTransporte);
            Controls.Add(groupBoxIngreseNrodeTransporte);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RecepcionDespachoCDLargaDistanciaForm";
            Text = "RecepcionYDespachoLargaDistanciaForm1";
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
        private ListView listViewHDRaRecibir;
        private Button botonConfirmar;
        private Button botonCancelar;
        private ListView listViewHDRaDespachar;
        private Label labelUsuario;
        private Label labelRespuestaUsuario;
        private Label label7;
        private Label labelResultadoCD;
        private ColumnHeader columnHeaderNroGuias;
        private ColumnHeader columnaNrodeGuia;
        private ColumnHeader columnHeaderDestino;
        private ColumnHeader columnHeaderTamaño;
        private ColumnHeader columnaDestinoDespachar;
        private ColumnHeader columnaTamañoDespachar;
      
    }
}