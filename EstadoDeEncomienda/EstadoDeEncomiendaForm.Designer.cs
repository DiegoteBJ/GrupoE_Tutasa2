namespace GrupoE_Tutasa.EstadoDeEncomienda
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
            label1 = new Label();
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
            GroupBox_BusquedaGuia.Controls.Add(label1);
            GroupBox_BusquedaGuia.Controls.Add(Button_Buscar);
            GroupBox_BusquedaGuia.Controls.Add(TextBox_NroGuia);
            GroupBox_BusquedaGuia.Controls.Add(Label_NroGuia);
            GroupBox_BusquedaGuia.Controls.Add(Label_Instruccion);
            GroupBox_BusquedaGuia.Location = new Point(46, 56);
            GroupBox_BusquedaGuia.Margin = new Padding(3, 4, 3, 4);
            GroupBox_BusquedaGuia.Name = "GroupBox_BusquedaGuia";
            GroupBox_BusquedaGuia.Padding = new Padding(3, 4, 3, 4);
            GroupBox_BusquedaGuia.Size = new Size(755, 144);
            GroupBox_BusquedaGuia.TabIndex = 0;
            GroupBox_BusquedaGuia.TabStop = false;
            GroupBox_BusquedaGuia.Text = "Búsqueda de Encomienda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 96);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 4;
            label1.Text = "Número de Guía:";
            // 
            // Button_Buscar
            // 
            Button_Buscar.Location = new Point(315, 91);
            Button_Buscar.Margin = new Padding(3, 4, 3, 4);
            Button_Buscar.Name = "Button_Buscar";
            Button_Buscar.Size = new Size(86, 31);
            Button_Buscar.TabIndex = 3;
            Button_Buscar.Text = "Buscar";
            Button_Buscar.UseVisualStyleBackColor = true;
            Button_Buscar.Click += Button_Buscar_Click;
            // 
            // TextBox_NroGuia
            // 
            TextBox_NroGuia.ForeColor = SystemColors.ControlDarkDark;
            TextBox_NroGuia.Location = new Point(134, 91);
            TextBox_NroGuia.Margin = new Padding(3, 4, 3, 4);
            TextBox_NroGuia.Name = "TextBox_NroGuia";
            TextBox_NroGuia.Size = new Size(174, 27);
            TextBox_NroGuia.TabIndex = 2;
            TextBox_NroGuia.Text = "ej: 123456789";
            // 
            // Label_NroGuia
            // 
            Label_NroGuia.AutoSize = true;
            Label_NroGuia.Location = new Point(13, 95);
            Label_NroGuia.Name = "Label_NroGuia";
            Label_NroGuia.Size = new Size(0, 20);
            Label_NroGuia.TabIndex = 1;
            // 
            // Label_Instruccion
            // 
            Label_Instruccion.AutoSize = true;
            Label_Instruccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Instruccion.Location = new Point(7, 41);
            Label_Instruccion.Name = "Label_Instruccion";
            Label_Instruccion.Size = new Size(623, 28);
            Label_Instruccion.TabIndex = 0;
            Label_Instruccion.Text = "Ingrese el número de guía de la encomienda que desea consultar: ";
            Label_Instruccion.Click += Label_Instruccion_Click;
            // 
            // GroupBox_ResultadoBusqueda
            // 
            GroupBox_ResultadoBusqueda.Controls.Add(ListView_Resultado);
            GroupBox_ResultadoBusqueda.Location = new Point(50, 231);
            GroupBox_ResultadoBusqueda.Margin = new Padding(3, 4, 3, 4);
            GroupBox_ResultadoBusqueda.Name = "GroupBox_ResultadoBusqueda";
            GroupBox_ResultadoBusqueda.Padding = new Padding(3, 4, 3, 4);
            GroupBox_ResultadoBusqueda.Size = new Size(751, 285);
            GroupBox_ResultadoBusqueda.TabIndex = 1;
            GroupBox_ResultadoBusqueda.TabStop = false;
            GroupBox_ResultadoBusqueda.Text = "Resultado de la Búsqueda";
            // 
            // ListView_Resultado
            // 
            ListView_Resultado.Columns.AddRange(new ColumnHeader[] { column_Fecha, columnEstado, columnUbicacion });
            ListView_Resultado.Location = new Point(16, 52);
            ListView_Resultado.Margin = new Padding(3, 4, 3, 4);
            ListView_Resultado.Name = "ListView_Resultado";
            ListView_Resultado.Size = new Size(518, 203);
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
            Button_Borrar.Location = new Point(609, 545);
            Button_Borrar.Margin = new Padding(3, 4, 3, 4);
            Button_Borrar.Name = "Button_Borrar";
            Button_Borrar.Size = new Size(86, 31);
            Button_Borrar.TabIndex = 2;
            Button_Borrar.Text = "BORRAR";
            Button_Borrar.UseVisualStyleBackColor = true;
            Button_Borrar.Click += Button_Borrar_Click;
            // 
            // Button_Cerrar
            // 
            Button_Cerrar.Location = new Point(715, 545);
            Button_Cerrar.Margin = new Padding(3, 4, 3, 4);
            Button_Cerrar.Name = "Button_Cerrar";
            Button_Cerrar.Size = new Size(86, 31);
            Button_Cerrar.TabIndex = 3;
            Button_Cerrar.Text = "CERRAR";
            Button_Cerrar.UseVisualStyleBackColor = true;
            Button_Cerrar.Click += Button_Cerrar_Click;
            // 
            // EstadoDeEncomiendaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Button_Cerrar);
            Controls.Add(Button_Borrar);
            Controls.Add(GroupBox_ResultadoBusqueda);
            Controls.Add(GroupBox_BusquedaGuia);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EstadoDeEncomiendaForm";
            Text = "Consultar Estado de Encomienda";
            //Load += this.EstadoDeEncomiendaForm_Load;
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
        private Label label1;
    }
}