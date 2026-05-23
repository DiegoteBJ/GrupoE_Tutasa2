namespace GrupoE_Tutasa.EntregaEnAgencia
{
    partial class EntregaEnAgenciaForm
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
            GroupBox_BusquedaDestinatario = new GroupBox();
            Label_ApellidoResultado = new Label();
            Label_Apellido = new Label();
            Label_NombreResultado = new Label();
            Label_Nombre = new Label();
            Button_Buscar = new Button();
            TextBox_DniDestinatario = new TextBox();
            label_Dni = new Label();
            GroupBox_GuiasPendientes = new GroupBox();
            ListView_GuiasPendientes = new ListView();
            columnHeader1_nrodeguia = new ColumnHeader();
            columnHeader2_tamaño = new ColumnHeader();
            columnHeader3_estado = new ColumnHeader();
            Button_Cancelar = new Button();
            Button_ConfirmarEntrega = new Button();
            GroupBox_BusquedaDestinatario.SuspendLayout();
            GroupBox_GuiasPendientes.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_BusquedaDestinatario
            // 
            GroupBox_BusquedaDestinatario.Controls.Add(Label_ApellidoResultado);
            GroupBox_BusquedaDestinatario.Controls.Add(Label_Apellido);
            GroupBox_BusquedaDestinatario.Controls.Add(Label_NombreResultado);
            GroupBox_BusquedaDestinatario.Controls.Add(Label_Nombre);
            GroupBox_BusquedaDestinatario.Controls.Add(Button_Buscar);
            GroupBox_BusquedaDestinatario.Controls.Add(TextBox_DniDestinatario);
            GroupBox_BusquedaDestinatario.Controls.Add(label_Dni);
            GroupBox_BusquedaDestinatario.Location = new Point(26, 32);
            GroupBox_BusquedaDestinatario.Margin = new Padding(3, 4, 3, 4);
            GroupBox_BusquedaDestinatario.Name = "GroupBox_BusquedaDestinatario";
            GroupBox_BusquedaDestinatario.Padding = new Padding(3, 4, 3, 4);
            GroupBox_BusquedaDestinatario.Size = new Size(761, 157);
            GroupBox_BusquedaDestinatario.TabIndex = 0;
            GroupBox_BusquedaDestinatario.TabStop = false;
            GroupBox_BusquedaDestinatario.Text = "Buscar Destinatario";
            // 
            // Label_ApellidoResultado
            // 
            Label_ApellidoResultado.AutoSize = true;
            Label_ApellidoResultado.BorderStyle = BorderStyle.Fixed3D;
            Label_ApellidoResultado.ForeColor = SystemColors.ControlDarkDark;
            Label_ApellidoResultado.Location = new Point(286, 120);
            Label_ApellidoResultado.Name = "Label_ApellidoResultado";
            Label_ApellidoResultado.Size = new Size(134, 22);
            Label_ApellidoResultado.TabIndex = 6;
            Label_ApellidoResultado.Text = "ApellidoResultado";
            // 
            // Label_Apellido
            // 
            Label_Apellido.AutoSize = true;
            Label_Apellido.Location = new Point(214, 117);
            Label_Apellido.Name = "Label_Apellido";
            Label_Apellido.Size = new Size(69, 20);
            Label_Apellido.TabIndex = 5;
            Label_Apellido.Text = "Apellido:";
            // 
            // Label_NombreResultado
            // 
            Label_NombreResultado.AutoSize = true;
            Label_NombreResultado.BackColor = SystemColors.Control;
            Label_NombreResultado.BorderStyle = BorderStyle.Fixed3D;
            Label_NombreResultado.FlatStyle = FlatStyle.System;
            Label_NombreResultado.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_NombreResultado.ForeColor = SystemColors.GrayText;
            Label_NombreResultado.Location = new Point(75, 120);
            Label_NombreResultado.Name = "Label_NombreResultado";
            Label_NombreResultado.Size = new Size(121, 21);
            Label_NombreResultado.TabIndex = 6;
            Label_NombreResultado.Text = "NombreResultado";
            // 
            // Label_Nombre
            // 
            Label_Nombre.AutoSize = true;
            Label_Nombre.Location = new Point(7, 117);
            Label_Nombre.Name = "Label_Nombre";
            Label_Nombre.Size = new Size(67, 20);
            Label_Nombre.TabIndex = 3;
            Label_Nombre.Text = "Nombre:";
            // 
            // Button_Buscar
            // 
            Button_Buscar.Location = new Point(227, 39);
            Button_Buscar.Margin = new Padding(3, 4, 3, 4);
            Button_Buscar.Name = "Button_Buscar";
            Button_Buscar.Size = new Size(86, 31);
            Button_Buscar.TabIndex = 2;
            Button_Buscar.Text = "Buscar";
            Button_Buscar.UseVisualStyleBackColor = true;
            Button_Buscar.Click += Button_Buscar_Click;
            // 
            // TextBox_DniDestinatario
            // 
            TextBox_DniDestinatario.Location = new Point(56, 43);
            TextBox_DniDestinatario.Margin = new Padding(3, 4, 3, 4);
            TextBox_DniDestinatario.Name = "TextBox_DniDestinatario";
            TextBox_DniDestinatario.Size = new Size(150, 27);
            TextBox_DniDestinatario.TabIndex = 1;
            // 
            // label_Dni
            // 
            label_Dni.AutoSize = true;
            label_Dni.Location = new Point(11, 44);
            label_Dni.Name = "label_Dni";
            label_Dni.Size = new Size(38, 20);
            label_Dni.TabIndex = 0;
            label_Dni.Text = "DNI:";
            // 
            // GroupBox_GuiasPendientes
            // 
            GroupBox_GuiasPendientes.Controls.Add(ListView_GuiasPendientes);
            GroupBox_GuiasPendientes.Location = new Point(30, 215);
            GroupBox_GuiasPendientes.Margin = new Padding(3, 4, 3, 4);
            GroupBox_GuiasPendientes.Name = "GroupBox_GuiasPendientes";
            GroupBox_GuiasPendientes.Padding = new Padding(3, 4, 3, 4);
            GroupBox_GuiasPendientes.Size = new Size(758, 192);
            GroupBox_GuiasPendientes.TabIndex = 1;
            GroupBox_GuiasPendientes.TabStop = false;
            GroupBox_GuiasPendientes.Text = "Encomiendas Pendientes:";
            // 
            // ListView_GuiasPendientes
            // 
            ListView_GuiasPendientes.Columns.AddRange(new ColumnHeader[] { columnHeader1_nrodeguia, columnHeader2_tamaño, columnHeader3_estado });
            ListView_GuiasPendientes.Location = new Point(19, 29);
            ListView_GuiasPendientes.Margin = new Padding(3, 4, 3, 4);
            ListView_GuiasPendientes.Name = "ListView_GuiasPendientes";
            ListView_GuiasPendientes.Size = new Size(476, 143);
            ListView_GuiasPendientes.TabIndex = 0;
            ListView_GuiasPendientes.UseCompatibleStateImageBehavior = false;
            ListView_GuiasPendientes.View = View.Details;
            // 
            // columnHeader1_nrodeguia
            // 
            columnHeader1_nrodeguia.Text = "Nro de Guía";
            columnHeader1_nrodeguia.Width = 120;
            // 
            // columnHeader2_tamaño
            // 
            columnHeader2_tamaño.Text = "Tamaño";
            columnHeader2_tamaño.TextAlign = HorizontalAlignment.Center;
            columnHeader2_tamaño.Width = 120;
            // 
            // columnHeader3_estado
            // 
            columnHeader3_estado.Text = "Estado";
            columnHeader3_estado.TextAlign = HorizontalAlignment.Center;
            columnHeader3_estado.Width = 120;
            // 
            // Button_Cancelar
            // 
            Button_Cancelar.Location = new Point(452, 503);
            Button_Cancelar.Margin = new Padding(3, 4, 3, 4);
            Button_Cancelar.Name = "Button_Cancelar";
            Button_Cancelar.Size = new Size(165, 31);
            Button_Cancelar.TabIndex = 2;
            Button_Cancelar.Text = "CANCELAR";
            Button_Cancelar.UseVisualStyleBackColor = true;
            Button_Cancelar.Click += Button_Cancelar_Click;
            // 
            // Button_ConfirmarEntrega
            // 
            Button_ConfirmarEntrega.Location = new Point(623, 503);
            Button_ConfirmarEntrega.Margin = new Padding(3, 4, 3, 4);
            Button_ConfirmarEntrega.Name = "Button_ConfirmarEntrega";
            Button_ConfirmarEntrega.Size = new Size(165, 31);
            Button_ConfirmarEntrega.TabIndex = 3;
            Button_ConfirmarEntrega.Text = "CONFIRMAR ENTREGA";
            Button_ConfirmarEntrega.UseVisualStyleBackColor = true;
            Button_ConfirmarEntrega.Click += Button_ConfirmarEntrega_Click;
            // 
            // EntregaEnAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 600);
            Controls.Add(Button_ConfirmarEntrega);
            Controls.Add(Button_Cancelar);
            Controls.Add(GroupBox_GuiasPendientes);
            Controls.Add(GroupBox_BusquedaDestinatario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EntregaEnAgenciaForm";
            Text = "Entregar Encomienda en Agencia";
            Load += Form1_Load;
            GroupBox_BusquedaDestinatario.ResumeLayout(false);
            GroupBox_BusquedaDestinatario.PerformLayout();
            GroupBox_GuiasPendientes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_BusquedaDestinatario;
        private Label label_Dni;
        private Label Label_Nombre;
        private Button Button_Buscar;
        private TextBox TextBox_DniDestinatario;
        private Label Label_Apellido;
        private Label Label_NombreResultado;
        private Label Label_ApellidoResultado;
        private GroupBox GroupBox_GuiasPendientes;
        private ListView ListView_GuiasPendientes;
        private ColumnHeader columnHeader1_nrodeguia;
        private ColumnHeader columnHeader2_tamaño;
        private ColumnHeader columnHeader3_estado;
        private Button Button_Cancelar;
        private Button Button_ConfirmarEntrega;
    }
}