namespace GrupoE_Tutasa.Actualizar_HDR
{
    partial class ActualizarHDRForm
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
            GroupBox_BusquedaHDR = new GroupBox();
            Button_Buscar = new Button();
            TextBox_HojaRuta = new TextBox();
            Label_HojaRuta = new Label();
            GroupBox_DatosHDR = new GroupBox();
            Label_EstadoActualResultado = new Label();
            Label_EstadoActual = new Label();
            Label_DestinoResultado = new Label();
            Label_Destino = new Label();
            Label_OrigenResultado = new Label();
            Label_Origen = new Label();
            Label_TipoHDRResultado = new Label();
            Label_TipoHDR = new Label();
            Label_IDHojaRutaResultado = new Label();
            Label_IDHojaRuta = new Label();
            GroupBox_ActualizacionEstado = new GroupBox();
            ComboBox_NuevoEstado = new ComboBox();
            Label_NuevoEstado = new Label();
            Button_Cancelar = new Button();
            Button_ConfirmarActualizacion = new Button();
            GroupBox_BusquedaHDR.SuspendLayout();
            GroupBox_DatosHDR.SuspendLayout();
            GroupBox_ActualizacionEstado.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_BusquedaHDR
            // 
            GroupBox_BusquedaHDR.Controls.Add(Button_Buscar);
            GroupBox_BusquedaHDR.Controls.Add(TextBox_HojaRuta);
            GroupBox_BusquedaHDR.Controls.Add(Label_HojaRuta);
            GroupBox_BusquedaHDR.Location = new Point(38, 23);
            GroupBox_BusquedaHDR.Name = "GroupBox_BusquedaHDR";
            GroupBox_BusquedaHDR.Size = new Size(652, 99);
            GroupBox_BusquedaHDR.TabIndex = 0;
            GroupBox_BusquedaHDR.TabStop = false;
            GroupBox_BusquedaHDR.Text = "Búsqueda de Hoja de Ruta";
            // 
            // Button_Buscar
            // 
            Button_Buscar.Location = new Point(229, 31);
            Button_Buscar.Name = "Button_Buscar";
            Button_Buscar.Size = new Size(75, 23);
            Button_Buscar.TabIndex = 2;
            Button_Buscar.Text = "Buscar";
            Button_Buscar.UseVisualStyleBackColor = true;
            Button_Buscar.Click += Button_Buscar_Click;
            // 
            // TextBox_HojaRuta
            // 
            TextBox_HojaRuta.ForeColor = SystemColors.ControlDarkDark;
            TextBox_HojaRuta.Location = new Point(93, 31);
            TextBox_HojaRuta.Name = "TextBox_HojaRuta";
            TextBox_HojaRuta.Size = new Size(130, 23);
            TextBox_HojaRuta.TabIndex = 1;
            TextBox_HojaRuta.Text = "Ingrese id HDR";
            // 
            // Label_HojaRuta
            // 
            Label_HojaRuta.AutoSize = true;
            Label_HojaRuta.Location = new Point(6, 35);
            Label_HojaRuta.Name = "Label_HojaRuta";
            Label_HojaRuta.Size = new Size(78, 15);
            Label_HojaRuta.TabIndex = 0;
            Label_HojaRuta.Text = "Hoja de Ruta:";
            // 
            // GroupBox_DatosHDR
            // 
            GroupBox_DatosHDR.Controls.Add(Label_EstadoActualResultado);
            GroupBox_DatosHDR.Controls.Add(Label_EstadoActual);
            GroupBox_DatosHDR.Controls.Add(Label_DestinoResultado);
            GroupBox_DatosHDR.Controls.Add(Label_Destino);
            GroupBox_DatosHDR.Controls.Add(Label_OrigenResultado);
            GroupBox_DatosHDR.Controls.Add(Label_Origen);
            GroupBox_DatosHDR.Controls.Add(Label_TipoHDRResultado);
            GroupBox_DatosHDR.Controls.Add(Label_TipoHDR);
            GroupBox_DatosHDR.Controls.Add(Label_IDHojaRutaResultado);
            GroupBox_DatosHDR.Controls.Add(Label_IDHojaRuta);
            GroupBox_DatosHDR.Location = new Point(37, 128);
            GroupBox_DatosHDR.Name = "GroupBox_DatosHDR";
            GroupBox_DatosHDR.Size = new Size(653, 150);
            GroupBox_DatosHDR.TabIndex = 1;
            GroupBox_DatosHDR.TabStop = false;
            GroupBox_DatosHDR.Text = "Datos de la Hoja de Ruta";
            // 
            // Label_EstadoActualResultado
            // 
            Label_EstadoActualResultado.BorderStyle = BorderStyle.Fixed3D;
            Label_EstadoActualResultado.ForeColor = SystemColors.ControlDarkDark;
            Label_EstadoActualResultado.Location = new Point(409, 77);
            Label_EstadoActualResultado.Name = "Label_EstadoActualResultado";
            Label_EstadoActualResultado.Size = new Size(136, 29);
            Label_EstadoActualResultado.TabIndex = 9;
            Label_EstadoActualResultado.Text = "Estado Actual Resultado";
            // 
            // Label_EstadoActual
            // 
            Label_EstadoActual.AutoSize = true;
            Label_EstadoActual.Location = new Point(311, 77);
            Label_EstadoActual.Name = "Label_EstadoActual";
            Label_EstadoActual.Size = new Size(82, 15);
            Label_EstadoActual.TabIndex = 8;
            Label_EstadoActual.Text = "Estado Actual:";
            // 
            // Label_DestinoResultado
            // 
            Label_DestinoResultado.BorderStyle = BorderStyle.Fixed3D;
            Label_DestinoResultado.ForeColor = SystemColors.ControlDarkDark;
            Label_DestinoResultado.Location = new Point(409, 32);
            Label_DestinoResultado.Name = "Label_DestinoResultado";
            Label_DestinoResultado.Size = new Size(136, 27);
            Label_DestinoResultado.TabIndex = 7;
            Label_DestinoResultado.Text = "Destino Resultado   ";
            // 
            // Label_Destino
            // 
            Label_Destino.AutoSize = true;
            Label_Destino.Location = new Point(311, 32);
            Label_Destino.Name = "Label_Destino";
            Label_Destino.Size = new Size(50, 15);
            Label_Destino.TabIndex = 6;
            Label_Destino.Text = "Destino:";
            // 
            // Label_OrigenResultado
            // 
            Label_OrigenResultado.BorderStyle = BorderStyle.Fixed3D;
            Label_OrigenResultado.ForeColor = SystemColors.ControlDarkDark;
            Label_OrigenResultado.Location = new Point(111, 103);
            Label_OrigenResultado.Name = "Label_OrigenResultado";
            Label_OrigenResultado.Size = new Size(128, 26);
            Label_OrigenResultado.TabIndex = 5;
            Label_OrigenResultado.Text = "Origen Resultado    ";
            // 
            // Label_Origen
            // 
            Label_Origen.AutoSize = true;
            Label_Origen.Location = new Point(17, 103);
            Label_Origen.Name = "Label_Origen";
            Label_Origen.Size = new Size(46, 15);
            Label_Origen.TabIndex = 4;
            Label_Origen.Text = "Origen:";
            // 
            // Label_TipoHDRResultado
            // 
            Label_TipoHDRResultado.BorderStyle = BorderStyle.Fixed3D;
            Label_TipoHDRResultado.ForeColor = SystemColors.ControlDarkDark;
            Label_TipoHDRResultado.Location = new Point(111, 70);
            Label_TipoHDRResultado.Name = "Label_TipoHDRResultado";
            Label_TipoHDRResultado.Size = new Size(128, 22);
            Label_TipoHDRResultado.TabIndex = 3;
            Label_TipoHDRResultado.Text = "Tipo HDR Resultado";
            // 
            // Label_TipoHDR
            // 
            Label_TipoHDR.AutoSize = true;
            Label_TipoHDR.Location = new Point(17, 70);
            Label_TipoHDR.Name = "Label_TipoHDR";
            Label_TipoHDR.RightToLeft = RightToLeft.No;
            Label_TipoHDR.Size = new Size(33, 15);
            Label_TipoHDR.TabIndex = 2;
            Label_TipoHDR.Text = "Tipo:";
            // 
            // Label_IDHojaRutaResultado
            // 
            Label_IDHojaRutaResultado.BorderStyle = BorderStyle.Fixed3D;
            Label_IDHojaRutaResultado.ForeColor = SystemColors.ControlDarkDark;
            Label_IDHojaRutaResultado.Location = new Point(111, 33);
            Label_IDHojaRutaResultado.Name = "Label_IDHojaRutaResultado";
            Label_IDHojaRutaResultado.Size = new Size(128, 26);
            Label_IDHojaRutaResultado.TabIndex = 1;
            Label_IDHojaRutaResultado.Text = "ID HDR Resultado   ";
            // 
            // Label_IDHojaRuta
            // 
            Label_IDHojaRuta.AutoSize = true;
            Label_IDHojaRuta.Location = new Point(17, 32);
            Label_IDHojaRuta.Name = "Label_IDHojaRuta";
            Label_IDHojaRuta.Size = new Size(78, 15);
            Label_IDHojaRuta.TabIndex = 0;
            Label_IDHojaRuta.Text = "Hoja de Ruta:";
            // 
            // GroupBox_ActualizacionEstado
            // 
            GroupBox_ActualizacionEstado.Controls.Add(ComboBox_NuevoEstado);
            GroupBox_ActualizacionEstado.Controls.Add(Label_NuevoEstado);
            GroupBox_ActualizacionEstado.Location = new Point(39, 293);
            GroupBox_ActualizacionEstado.Name = "GroupBox_ActualizacionEstado";
            GroupBox_ActualizacionEstado.Size = new Size(651, 100);
            GroupBox_ActualizacionEstado.TabIndex = 2;
            GroupBox_ActualizacionEstado.TabStop = false;
            GroupBox_ActualizacionEstado.Text = "Actualizar Estado";
            // 
            // ComboBox_NuevoEstado
            // 
            ComboBox_NuevoEstado.FormattingEnabled = true;
            ComboBox_NuevoEstado.Location = new Point(109, 32);
            ComboBox_NuevoEstado.Name = "ComboBox_NuevoEstado";
            ComboBox_NuevoEstado.Size = new Size(194, 23);
            ComboBox_NuevoEstado.TabIndex = 1;
            ComboBox_NuevoEstado.Text = "Seleccione un estado:";
            // 
            // Label_NuevoEstado
            // 
            Label_NuevoEstado.AutoSize = true;
            Label_NuevoEstado.Location = new Point(15, 35);
            Label_NuevoEstado.Name = "Label_NuevoEstado";
            Label_NuevoEstado.Size = new Size(83, 15);
            Label_NuevoEstado.TabIndex = 0;
            Label_NuevoEstado.Text = "Nuevo Estado:";
            // 
            // Button_Cancelar
            // 
            Button_Cancelar.Location = new Point(490, 415);
            Button_Cancelar.Name = "Button_Cancelar";
            Button_Cancelar.Size = new Size(92, 23);
            Button_Cancelar.TabIndex = 3;
            Button_Cancelar.Text = "CANCELAR";
            Button_Cancelar.UseVisualStyleBackColor = true;
            Button_Cancelar.Click += Button_Cancelar_Click;
            // 
            // Button_ConfirmarActualizacion
            // 
            Button_ConfirmarActualizacion.Location = new Point(598, 415);
            Button_ConfirmarActualizacion.Name = "Button_ConfirmarActualizacion";
            Button_ConfirmarActualizacion.Size = new Size(92, 23);
            Button_ConfirmarActualizacion.TabIndex = 4;
            Button_ConfirmarActualizacion.Text = "CONFIRMAR";
            Button_ConfirmarActualizacion.UseVisualStyleBackColor = true;
            Button_ConfirmarActualizacion.Click += Button_ConfirmarActualizacion_Click;
            // 
            // ActualizarHDRForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_ConfirmarActualizacion);
            Controls.Add(Button_Cancelar);
            Controls.Add(GroupBox_ActualizacionEstado);
            Controls.Add(GroupBox_DatosHDR);
            Controls.Add(GroupBox_BusquedaHDR);
            Name = "ActualizarHDRForm";
            Text = "Actualizar HDR";
            GroupBox_BusquedaHDR.ResumeLayout(false);
            GroupBox_BusquedaHDR.PerformLayout();
            GroupBox_DatosHDR.ResumeLayout(false);
            GroupBox_DatosHDR.PerformLayout();
            GroupBox_ActualizacionEstado.ResumeLayout(false);
            GroupBox_ActualizacionEstado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_BusquedaHDR;
        private Label Label_HojaRuta;
        private Button Button_Buscar;
        private TextBox TextBox_HojaRuta;
        private GroupBox GroupBox_DatosHDR;
        private Label Label_IDHojaRuta;
        private Label Label_TipoHDR;
        private Label Label_IDHojaRutaResultado;
        private Label Label_Destino;
        private Label Label_OrigenResultado;
        private Label Label_Origen;
        private Label Label_TipoHDRResultado;
        private Label Label_EstadoActualResultado;
        private Label Label_EstadoActual;
        private Label Label_DestinoResultado;
        private GroupBox GroupBox_ActualizacionEstado;
        private ComboBox ComboBox_NuevoEstado;
        private Label Label_NuevoEstado;
        private Button Button_Cancelar;
        private Button Button_ConfirmarActualizacion;
    }
}