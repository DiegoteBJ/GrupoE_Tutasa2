namespace GrupoE_Tutasa.GenerarHDR
{
    partial class GenerarHDRFleteros1
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
            buttonbuscar = new Button();
            labelapellidofletero = new Label();
            labelapellido = new Label();
            labelnombrefletero = new Label();
            labelnombre = new Label();
            labelcentrodistribucion = new Label();
            labelCD = new Label();
            labelnumusuario = new Label();
            labelusuario = new Label();
            textBox1 = new TextBox();
            labelfletero = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBoxresumenhdr = new GroupBox();
            listViewresumenhdr = new ListView();
            Guíaresumenhdr = new ColumnHeader();
            Tiporesumenhdr = new ColumnHeader();
            Domicilioresumenhdr = new ColumnHeader();
            labelcantidadbultos = new Label();
            labeltotalasignados = new Label();
            Nombreresumenhdr = new ColumnHeader();
            Telefonoresumenhdr = new ColumnHeader();
            groupBoxresumenhdr.SuspendLayout();
            SuspendLayout();
            // 
            // buttonbuscar
            // 
            buttonbuscar.Location = new Point(194, 36);
            buttonbuscar.Name = "buttonbuscar";
            buttonbuscar.Size = new Size(112, 25);
            buttonbuscar.TabIndex = 21;
            buttonbuscar.Text = "Buscar";
            buttonbuscar.UseVisualStyleBackColor = true;
            // 
            // labelapellidofletero
            // 
            labelapellidofletero.AutoSize = true;
            labelapellidofletero.Location = new Point(270, 87);
            labelapellidofletero.Name = "labelapellidofletero";
            labelapellidofletero.Size = new Size(98, 15);
            labelapellidofletero.TabIndex = 20;
            labelapellidofletero.Text = "[Apellido Fletero]";
            // 
            // labelapellido
            // 
            labelapellido.AutoSize = true;
            labelapellido.Location = new Point(210, 87);
            labelapellido.Name = "labelapellido";
            labelapellido.Size = new Size(54, 15);
            labelapellido.TabIndex = 19;
            labelapellido.Text = "Apellido:";
            // 
            // labelnombrefletero
            // 
            labelnombrefletero.AutoSize = true;
            labelnombrefletero.Location = new Point(79, 87);
            labelnombrefletero.Name = "labelnombrefletero";
            labelnombrefletero.Size = new Size(98, 15);
            labelnombrefletero.TabIndex = 18;
            labelnombrefletero.Text = "[Nombre Fletero]";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(19, 87);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(54, 15);
            labelnombre.TabIndex = 17;
            labelnombre.Text = "Nombre:";
            // 
            // labelcentrodistribucion
            // 
            labelcentrodistribucion.AutoSize = true;
            labelcentrodistribucion.Location = new Point(194, 13);
            labelcentrodistribucion.Name = "labelcentrodistribucion";
            labelcentrodistribucion.Size = new Size(134, 15);
            labelcentrodistribucion.TabIndex = 16;
            labelcentrodistribucion.Text = "[Centro de Distribución]";
            // 
            // labelCD
            // 
            labelCD.AutoSize = true;
            labelCD.Location = new Point(157, 13);
            labelCD.Name = "labelCD";
            labelCD.Size = new Size(29, 15);
            labelCD.TabIndex = 15;
            labelCD.Text = "CD: ";
            // 
            // labelnumusuario
            // 
            labelnumusuario.AutoSize = true;
            labelnumusuario.Location = new Point(79, 14);
            labelnumusuario.Name = "labelnumusuario";
            labelnumusuario.Size = new Size(25, 15);
            labelnumusuario.TabIndex = 14;
            labelnumusuario.Text = "003";
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.Location = new Point(19, 13);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(50, 15);
            labelusuario.TabIndex = 13;
            labelusuario.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 12;
            // 
            // labelfletero
            // 
            labelfletero.AutoSize = true;
            labelfletero.Location = new Point(19, 46);
            labelfletero.Name = "labelfletero";
            labelfletero.Size = new Size(30, 15);
            labelfletero.TabIndex = 11;
            labelfletero.Text = "DNI:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(23, 130);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(57, 19);
            radioButton4.TabIndex = 22;
            radioButton4.TabStop = true;
            radioButton4.Text = "Todos";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(97, 130);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(56, 19);
            radioButton5.TabIndex = 23;
            radioButton5.TabStop = true;
            radioButton5.Text = "Retiro";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(159, 130);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(89, 19);
            radioButton6.TabIndex = 24;
            radioButton6.TabStop = true;
            radioButton6.Text = "Distribución";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBoxresumenhdr
            // 
            groupBoxresumenhdr.Controls.Add(listViewresumenhdr);
            groupBoxresumenhdr.Controls.Add(labelcantidadbultos);
            groupBoxresumenhdr.Controls.Add(labeltotalasignados);
            groupBoxresumenhdr.Location = new Point(394, 14);
            groupBoxresumenhdr.Name = "groupBoxresumenhdr";
            groupBoxresumenhdr.Size = new Size(384, 367);
            groupBoxresumenhdr.TabIndex = 25;
            groupBoxresumenhdr.TabStop = false;
            groupBoxresumenhdr.Text = "Resumen HDR";
            // 
            // listViewresumenhdr
            // 
            listViewresumenhdr.Columns.AddRange(new ColumnHeader[] { Guíaresumenhdr, Tiporesumenhdr, Domicilioresumenhdr, Nombreresumenhdr, Telefonoresumenhdr });
            listViewresumenhdr.Location = new Point(14, 22);
            listViewresumenhdr.Name = "listViewresumenhdr";
            listViewresumenhdr.Size = new Size(360, 317);
            listViewresumenhdr.TabIndex = 15;
            listViewresumenhdr.UseCompatibleStateImageBehavior = false;
            listViewresumenhdr.View = View.Details;
            // 
            // Guíaresumenhdr
            // 
            Guíaresumenhdr.Text = "Guía";
            // 
            // Tiporesumenhdr
            // 
            Tiporesumenhdr.Text = "Tipo";
            // 
            // Domicilioresumenhdr
            // 
            Domicilioresumenhdr.Text = "Domicilio";
            Domicilioresumenhdr.Width = 70;
            // 
            // labelcantidadbultos
            // 
            labelcantidadbultos.AutoSize = true;
            labelcantidadbultos.Location = new Point(121, 340);
            labelcantidadbultos.Name = "labelcantidadbultos";
            labelcantidadbultos.Size = new Size(55, 15);
            labelcantidadbultos.TabIndex = 14;
            labelcantidadbultos.Text = "25 bultos";
            // 
            // labeltotalasignados
            // 
            labeltotalasignados.AutoSize = true;
            labeltotalasignados.Location = new Point(14, 340);
            labeltotalasignados.Name = "labeltotalasignados";
            labeltotalasignados.Size = new Size(92, 15);
            labeltotalasignados.TabIndex = 13;
            labeltotalasignados.Text = "Total asignados:";
            // 
            // Nombreresumenhdr
            // 
            Nombreresumenhdr.Text = "Nombre";
            // 
            // Telefonoresumenhdr
            // 
            Telefonoresumenhdr.Text = "Teléfono";
            // 
            // GenerarHDRFleteros1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxresumenhdr);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(buttonbuscar);
            Controls.Add(labelapellidofletero);
            Controls.Add(labelapellido);
            Controls.Add(labelnombrefletero);
            Controls.Add(labelnombre);
            Controls.Add(labelcentrodistribucion);
            Controls.Add(labelCD);
            Controls.Add(labelnumusuario);
            Controls.Add(labelusuario);
            Controls.Add(textBox1);
            Controls.Add(labelfletero);
            Name = "GenerarHDRFleteros1";
            Text = "GenerarHDRFleteros1";
            groupBoxresumenhdr.ResumeLayout(false);
            groupBoxresumenhdr.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonbuscar;
        private Label labelapellidofletero;
        private Label labelapellido;
        private Label labelnombrefletero;
        private Label labelnombre;
        private Label labelcentrodistribucion;
        private Label labelCD;
        private Label labelnumusuario;
        private Label labelusuario;
        private TextBox textBox1;
        private Label labelfletero;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBoxresumenhdr;
        private ListView listViewresumenhdr;
        private ColumnHeader Guíaresumenhdr;
        private ColumnHeader Tiporesumenhdr;
        private ColumnHeader Domicilioresumenhdr;
        private ColumnHeader Nombreresumenhdr;
        private ColumnHeader Telefonoresumenhdr;
        private Label labelcantidadbultos;
        private Label labeltotalasignados;
    }
}