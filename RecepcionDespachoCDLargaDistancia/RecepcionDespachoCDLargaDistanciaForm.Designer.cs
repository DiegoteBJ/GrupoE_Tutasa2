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
            groupBoxIngreseNrodeTransporte.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxIngreseNrodeTransporte.Location = new Point(40, 60);
            groupBoxIngreseNrodeTransporte.Name = "groupBoxIngreseNrodeTransporte";
            groupBoxIngreseNrodeTransporte.Size = new Size(728, 109);
            groupBoxIngreseNrodeTransporte.TabIndex = 0;
            groupBoxIngreseNrodeTransporte.TabStop = false;
            groupBoxIngreseNrodeTransporte.Text = "Ingrese en Nro de Transporte";
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(570, 47);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(137, 37);
            botonBuscar.TabIndex = 2;
            botonBuscar.Text = "BUSCAR";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // textBoxNrodeservicioTransporte
            // 
            textBoxNrodeservicioTransporte.Location = new Point(308, 50);
            textBoxNrodeservicioTransporte.Name = "textBoxNrodeservicioTransporte";
            textBoxNrodeservicioTransporte.Size = new Size(241, 31);
            textBoxNrodeservicioTransporte.TabIndex = 1;
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
            // 
            // groupBoxHDRaRecibir
            // 
            groupBoxHDRaRecibir.Controls.Add(listViewHDRaRecibir);
            groupBoxHDRaRecibir.Location = new Point(42, 320);
            groupBoxHDRaRecibir.Name = "groupBoxHDRaRecibir";
            groupBoxHDRaRecibir.Size = new Size(322, 215);
            groupBoxHDRaRecibir.TabIndex = 2;
            groupBoxHDRaRecibir.TabStop = false;
            groupBoxHDRaRecibir.Text = "Hojas de ruta a recibir";
            // 
            // listViewHDRaRecibir
            // 
            listViewHDRaRecibir.Columns.AddRange(new ColumnHeader[] { columnHeaderNroGuias, columnHeaderDestino, columnHeaderTamaño });
            listViewHDRaRecibir.Location = new Point(11, 29);
            listViewHDRaRecibir.Name = "listViewHDRaRecibir";
            listViewHDRaRecibir.Size = new Size(301, 169);
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
            groupBoxHDRaDespachar.Location = new Point(429, 320);
            groupBoxHDRaDespachar.Name = "groupBoxHDRaDespachar";
            groupBoxHDRaDespachar.Size = new Size(335, 211);
            groupBoxHDRaDespachar.TabIndex = 3;
            groupBoxHDRaDespachar.TabStop = false;
            groupBoxHDRaDespachar.Text = "Hojas de ruta a despachar";
            // 
            // listViewHDRaDespachar
            // 
            listViewHDRaDespachar.Columns.AddRange(new ColumnHeader[] { columnaNrodeGuia, columnaDestinoDespachar, columnaTamañoDespachar });
            listViewHDRaDespachar.Location = new Point(8, 29);
            listViewHDRaDespachar.Name = "listViewHDRaDespachar";
            listViewHDRaDespachar.Size = new Size(310, 168);
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
            botonConfirmar.Location = new Point(130, 613);
            botonConfirmar.Name = "botonConfirmar";
            botonConfirmar.Size = new Size(139, 36);
            botonConfirmar.TabIndex = 4;
            botonConfirmar.Text = "Confirmar";
            botonConfirmar.UseVisualStyleBackColor = true;
            botonConfirmar.Click += botonConfirmar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(504, 613);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(145, 36);
            botonCancelar.TabIndex = 5;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(23, 13);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 20);
            labelUsuario.TabIndex = 6;
            labelUsuario.Text = "Usuario: ";
            // 
            // labelRespuestaUsuario
            // 
            labelRespuestaUsuario.AutoSize = true;
            labelRespuestaUsuario.Location = new Point(95, 13);
            labelRespuestaUsuario.Name = "labelRespuestaUsuario";
            labelRespuestaUsuario.Size = new Size(79, 20);
            labelRespuestaUsuario.TabIndex = 7;
            labelRespuestaUsuario.Text = "Usuario 11";
            labelRespuestaUsuario.Click += labelRespuestaUsuario_Click;
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
            // labelResultadoCD
            // 
            labelResultadoCD.AutoSize = true;
            labelResultadoCD.Location = new Point(273, 13);
            labelResultadoCD.Name = "labelResultadoCD";
            labelResultadoCD.Size = new Size(94, 20);
            labelResultadoCD.TabIndex = 9;
            labelResultadoCD.Text = "Buenos Aires";
            // 
            // RecepcionDespachoCDLargaDistanciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 712);
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