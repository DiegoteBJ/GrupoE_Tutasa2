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
            label1_numerodeguia = new Label();
            Button_Buscar = new Button();
            TextBox_numerodeguia = new TextBox();
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
            GroupBox_BusquedaGuia.Controls.Add(label1_numerodeguia);
            GroupBox_BusquedaGuia.Controls.Add(Button_Buscar);
            GroupBox_BusquedaGuia.Controls.Add(TextBox_numerodeguia);
            GroupBox_BusquedaGuia.Controls.Add(Label_NroGuia);
            GroupBox_BusquedaGuia.Controls.Add(Label_Instruccion);
            GroupBox_BusquedaGuia.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox_BusquedaGuia.Location = new Point(40, 42);
            GroupBox_BusquedaGuia.Margin = new Padding(4, 3, 4, 3);
            GroupBox_BusquedaGuia.Name = "GroupBox_BusquedaGuia";
            GroupBox_BusquedaGuia.Padding = new Padding(4, 3, 4, 3);
            GroupBox_BusquedaGuia.Size = new Size(662, 108);
            GroupBox_BusquedaGuia.TabIndex = 0;
            GroupBox_BusquedaGuia.TabStop = false;
            GroupBox_BusquedaGuia.Text = "Búsqueda de Encomienda";
            GroupBox_BusquedaGuia.Enter += GroupBox_BusquedaGuia_Enter;
            // 
            // label1_numerodeguia
            // 
            label1_numerodeguia.AutoSize = true;
            label1_numerodeguia.Location = new Point(10, 72);
            label1_numerodeguia.Margin = new Padding(4, 0, 4, 0);
            label1_numerodeguia.Name = "label1_numerodeguia";
            label1_numerodeguia.Size = new Size(100, 15);
            label1_numerodeguia.TabIndex = 4;
            label1_numerodeguia.Text = "Número de Guía:";
            // 
            // Button_Buscar
            // 
            Button_Buscar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Buscar.Location = new Point(276, 69);
            Button_Buscar.Margin = new Padding(4, 3, 4, 3);
            Button_Buscar.Name = "Button_Buscar";
            Button_Buscar.Size = new Size(75, 24);
            Button_Buscar.TabIndex = 3;
            Button_Buscar.Text = "Buscar";
            Button_Buscar.UseVisualStyleBackColor = true;
            Button_Buscar.Click += Button_Buscar_Click;
            // 
            // TextBox_numerodeguia
            // 
            TextBox_numerodeguia.ForeColor = SystemColors.ControlDarkDark;
            TextBox_numerodeguia.Location = new Point(117, 69);
            TextBox_numerodeguia.Margin = new Padding(4, 3, 4, 3);
            TextBox_numerodeguia.Name = "TextBox_numerodeguia";
            TextBox_numerodeguia.Size = new Size(153, 21);
            TextBox_numerodeguia.TabIndex = 2;
            // 
            // Label_NroGuia
            // 
            Label_NroGuia.AutoSize = true;
            Label_NroGuia.Location = new Point(10, 71);
            Label_NroGuia.Margin = new Padding(4, 0, 4, 0);
            Label_NroGuia.Name = "Label_NroGuia";
            Label_NroGuia.Size = new Size(0, 15);
            Label_NroGuia.TabIndex = 1;
            // 
            // Label_Instruccion
            // 
            Label_Instruccion.AutoSize = true;
            Label_Instruccion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Instruccion.Location = new Point(6, 31);
            Label_Instruccion.Margin = new Padding(4, 0, 4, 0);
            Label_Instruccion.Name = "Label_Instruccion";
            Label_Instruccion.Size = new Size(513, 19);
            Label_Instruccion.TabIndex = 0;
            Label_Instruccion.Text = "Ingrese el número de guía de la encomienda que desea consultar: ";
            Label_Instruccion.Click += Label_Instruccion_Click;
            // 
            // GroupBox_ResultadoBusqueda
            // 
            GroupBox_ResultadoBusqueda.Controls.Add(ListView_Resultado);
            GroupBox_ResultadoBusqueda.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox_ResultadoBusqueda.Location = new Point(44, 174);
            GroupBox_ResultadoBusqueda.Margin = new Padding(4, 3, 4, 3);
            GroupBox_ResultadoBusqueda.Name = "GroupBox_ResultadoBusqueda";
            GroupBox_ResultadoBusqueda.Padding = new Padding(4, 3, 4, 3);
            GroupBox_ResultadoBusqueda.Size = new Size(657, 214);
            GroupBox_ResultadoBusqueda.TabIndex = 1;
            GroupBox_ResultadoBusqueda.TabStop = false;
            GroupBox_ResultadoBusqueda.Text = "Resultado de la Búsqueda";
            // 
            // ListView_Resultado
            // 
            ListView_Resultado.Columns.AddRange(new ColumnHeader[] { column_Fecha, columnEstado, columnUbicacion });
            ListView_Resultado.ForeColor = SystemColors.HotTrack;
            ListView_Resultado.Location = new Point(14, 40);
            ListView_Resultado.Margin = new Padding(4, 3, 4, 3);
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
            Button_Borrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Borrar.Location = new Point(533, 409);
            Button_Borrar.Margin = new Padding(4, 3, 4, 3);
            Button_Borrar.Name = "Button_Borrar";
            Button_Borrar.Size = new Size(75, 24);
            Button_Borrar.TabIndex = 2;
            Button_Borrar.Text = "Borrar";
            Button_Borrar.UseVisualStyleBackColor = true;
            Button_Borrar.Click += Button_Borrar_Click;
            // 
            // Button_Cerrar
            // 
            Button_Cerrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Cerrar.Location = new Point(626, 409);
            Button_Cerrar.Margin = new Padding(4, 3, 4, 3);
            Button_Cerrar.Name = "Button_Cerrar";
            Button_Cerrar.Size = new Size(75, 24);
            Button_Cerrar.TabIndex = 3;
            Button_Cerrar.Text = "Cerrar";
            Button_Cerrar.UseVisualStyleBackColor = true;
            Button_Cerrar.Click += Button_Cerrar_Click;
            // 
            // EstadoDeEncomiendaForm
            // 
            AcceptButton = Button_Buscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(Button_Cerrar);
            Controls.Add(Button_Borrar);
            Controls.Add(GroupBox_ResultadoBusqueda);
            Controls.Add(GroupBox_BusquedaGuia);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
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
        private TextBox TextBox_numerodeguia;
        private Label Label_NroGuia;
        private Label Label_Instruccion;
        private GroupBox GroupBox_ResultadoBusqueda;
        private ListView ListView_Resultado;
        private ColumnHeader column_Fecha;
        private ColumnHeader columnEstado;
        private ColumnHeader columnUbicacion;
        private Button Button_Borrar;
        private Button Button_Cerrar;
        private Label label1_numerodeguia;
    }
}