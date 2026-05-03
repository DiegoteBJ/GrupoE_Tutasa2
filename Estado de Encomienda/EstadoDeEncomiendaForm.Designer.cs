namespace GrupoE_Tutasa.Estado_de_Encomienda
{
    partial class EstadoDeEncomiendaForm
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
            GroupBox_BusquedaGuia = new GroupBox();
            Button_Buscar = new Button();
            TextBox_NroGuia = new TextBox();
            Label_NroGuia = new Label();
            Label_Instruccion = new Label();
            GroupBox_ResultadoBusqueda = new GroupBox();
            ListView_Resultado = new ListView();
            column_Fecha = new ColumnHeader();
            columnEstado = new ColumnHeader();
            columnUbicacion = new ColumnHeader();
            Button_Borrar = new Button();
            Button_Cerrar = new Button();
            GroupBox_BusquedaGuia.SuspendLayout();
            GroupBox_ResultadoBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_BusquedaGuia
            // 
            GroupBox_BusquedaGuia.Controls.Add(Button_Buscar);
            GroupBox_BusquedaGuia.Controls.Add(TextBox_NroGuia);
            GroupBox_BusquedaGuia.Controls.Add(Label_NroGuia);
            GroupBox_BusquedaGuia.Controls.Add(Label_Instruccion);
            GroupBox_BusquedaGuia.Location = new Point(40, 42);
            GroupBox_BusquedaGuia.Name = "GroupBox_BusquedaGuia";
            GroupBox_BusquedaGuia.Size = new Size(661, 108);
            GroupBox_BusquedaGuia.TabIndex = 0;
            GroupBox_BusquedaGuia.TabStop = false;
            GroupBox_BusquedaGuia.Text = "Búsqueda de Encomienda";
            // 
            // Button_Buscar
            // 
            Button_Buscar.Location = new Point(276, 68);
            Button_Buscar.Name = "Button_Buscar";
            Button_Buscar.Size = new Size(75, 23);
            Button_Buscar.TabIndex = 3;
            Button_Buscar.Text = "Buscar";
            Button_Buscar.UseVisualStyleBackColor = true;
            Button_Buscar.Click += Button_Buscar_Click;
            // 
            // TextBox_NroGuia
            // 
            TextBox_NroGuia.ForeColor = SystemColors.ControlDarkDark;
            TextBox_NroGuia.Location = new Point(117, 68);
            TextBox_NroGuia.Name = "TextBox_NroGuia";
            TextBox_NroGuia.Size = new Size(153, 23);
            TextBox_NroGuia.TabIndex = 2;
            TextBox_NroGuia.Text = "ej: 123456789";
            // 
            // Label_NroGuia
            // 
            Label_NroGuia.AutoSize = true;
            Label_NroGuia.Location = new Point(11, 71);
            Label_NroGuia.Name = "Label_NroGuia";
            Label_NroGuia.Size = new Size(100, 15);
            Label_NroGuia.TabIndex = 1;
            Label_NroGuia.Text = "Número de Guía: ";
            // 
            // Label_Instruccion
            // 
            Label_Instruccion.AutoSize = true;
            Label_Instruccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Instruccion.Location = new Point(6, 31);
            Label_Instruccion.Name = "Label_Instruccion";
            Label_Instruccion.Size = new Size(489, 21);
            Label_Instruccion.TabIndex = 0;
            Label_Instruccion.Text = "Ingrese el número de guía de la encomienda que desea consultar:";
            // 
            // GroupBox_ResultadoBusqueda
            // 
            GroupBox_ResultadoBusqueda.Controls.Add(ListView_Resultado);
            GroupBox_ResultadoBusqueda.Location = new Point(44, 173);
            GroupBox_ResultadoBusqueda.Name = "GroupBox_ResultadoBusqueda";
            GroupBox_ResultadoBusqueda.Size = new Size(657, 214);
            GroupBox_ResultadoBusqueda.TabIndex = 1;
            GroupBox_ResultadoBusqueda.TabStop = false;
            GroupBox_ResultadoBusqueda.Text = "Resultado de la Búsqueda";
            // 
            // ListView_Resultado
            // 
            ListView_Resultado.Columns.AddRange(new ColumnHeader[] { column_Fecha, columnEstado, columnUbicacion });
            ListView_Resultado.Location = new Point(14, 39);
            ListView_Resultado.Name = "ListView_Resultado";
            ListView_Resultado.Size = new Size(454, 153);
            ListView_Resultado.TabIndex = 0;
            ListView_Resultado.UseCompatibleStateImageBehavior = false;
            ListView_Resultado.View = View.Details;
            // 
            // column_Fecha
            // 
            column_Fecha.Text = "Fecha";
            column_Fecha.Width = 90;
            // 
            // columnEstado
            // 
            columnEstado.Text = "Estado";
            columnEstado.TextAlign = HorizontalAlignment.Center;
            columnEstado.Width = 120;
            // 
            // columnUbicacion
            // 
            columnUbicacion.Text = "Ubicación";
            columnUbicacion.TextAlign = HorizontalAlignment.Center;
            columnUbicacion.Width = 120;
            // 
            // Button_Borrar
            // 
            Button_Borrar.Location = new Point(533, 409);
            Button_Borrar.Name = "Button_Borrar";
            Button_Borrar.Size = new Size(75, 23);
            Button_Borrar.TabIndex = 2;
            Button_Borrar.Text = "BORRAR";
            Button_Borrar.UseVisualStyleBackColor = true;
            Button_Borrar.Click += Button_Borrar_Click;
            // 
            // Button_Cerrar
            // 
            Button_Cerrar.Location = new Point(626, 409);
            Button_Cerrar.Name = "Button_Cerrar";
            Button_Cerrar.Size = new Size(75, 23);
            Button_Cerrar.TabIndex = 3;
            Button_Cerrar.Text = "CERRAR";
            Button_Cerrar.UseVisualStyleBackColor = true;
            Button_Cerrar.Click += Button_Cerrar_Click;
            // 
            // EstadoDeEncomiendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Cerrar);
            Controls.Add(Button_Borrar);
            Controls.Add(GroupBox_ResultadoBusqueda);
            Controls.Add(GroupBox_BusquedaGuia);
            Name = "EstadoDeEncomiendaForm";
            Text = "Consultar Estado de Encomienda";
            GroupBox_BusquedaGuia.ResumeLayout(false);
            GroupBox_BusquedaGuia.PerformLayout();
            GroupBox_ResultadoBusqueda.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_BusquedaGuia;
        private Button Button_Buscar;
        private TextBox TextBox_NroGuia;
        private Label Label_NroGuia;
        private Label Label_Instruccion;
        private GroupBox GroupBox_ResultadoBusqueda;
        private ListView ListView_Resultado;
        private ColumnHeader column_Fecha;
        private ColumnHeader columnEstado;
        private ColumnHeader columnUbicacion;
        private Button Button_Borrar;
        private Button Button_Cerrar;
    }
}