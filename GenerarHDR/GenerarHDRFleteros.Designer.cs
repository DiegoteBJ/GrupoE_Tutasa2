namespace GrupoE_Tutasa.GenerarHDR
{
    partial class GenerarHDRFleteros
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
            labelfletero = new Label();
            textBox1 = new TextBox();
            labelusuario = new Label();
            labelnumusuario = new Label();
            labelcentrodistribucion = new Label();
            labelCD = new Label();
            labelnombre = new Label();
            labelnombrefletero = new Label();
            labelapellidofletero = new Label();
            labelapellido = new Label();
            buttonbuscar = new Button();
            labelencomiendaspendientes = new Label();
            SuspendLayout();
            // 
            // labelfletero
            // 
            labelfletero.AutoSize = true;
            labelfletero.Location = new Point(34, 41);
            labelfletero.Name = "labelfletero";
            labelfletero.Size = new Size(30, 15);
            labelfletero.TabIndex = 0;
            labelfletero.Text = "DNI:";
            labelfletero.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 1;
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.Location = new Point(34, 8);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(50, 15);
            labelusuario.TabIndex = 2;
            labelusuario.Text = "Usuario:";
            // 
            // labelnumusuario
            // 
            labelnumusuario.AutoSize = true;
            labelnumusuario.Location = new Point(94, 9);
            labelnumusuario.Name = "labelnumusuario";
            labelnumusuario.Size = new Size(25, 15);
            labelnumusuario.TabIndex = 3;
            labelnumusuario.Text = "003";
            // 
            // labelcentrodistribucion
            // 
            labelcentrodistribucion.AutoSize = true;
            labelcentrodistribucion.Location = new Point(209, 8);
            labelcentrodistribucion.Name = "labelcentrodistribucion";
            labelcentrodistribucion.Size = new Size(134, 15);
            labelcentrodistribucion.TabIndex = 5;
            labelcentrodistribucion.Text = "[Centro de Distribución]";
            // 
            // labelCD
            // 
            labelCD.AutoSize = true;
            labelCD.Location = new Point(172, 8);
            labelCD.Name = "labelCD";
            labelCD.Size = new Size(29, 15);
            labelCD.TabIndex = 4;
            labelCD.Text = "CD: ";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(34, 82);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(54, 15);
            labelnombre.TabIndex = 6;
            labelnombre.Text = "Nombre:";
            // 
            // labelnombrefletero
            // 
            labelnombrefletero.AutoSize = true;
            labelnombrefletero.Location = new Point(94, 82);
            labelnombrefletero.Name = "labelnombrefletero";
            labelnombrefletero.Size = new Size(98, 15);
            labelnombrefletero.TabIndex = 7;
            labelnombrefletero.Text = "[Nombre Fletero]";
            // 
            // labelapellidofletero
            // 
            labelapellidofletero.AutoSize = true;
            labelapellidofletero.Location = new Point(269, 82);
            labelapellidofletero.Name = "labelapellidofletero";
            labelapellidofletero.Size = new Size(98, 15);
            labelapellidofletero.TabIndex = 9;
            labelapellidofletero.Text = "[Apellido Fletero]";
            // 
            // labelapellido
            // 
            labelapellido.AutoSize = true;
            labelapellido.Location = new Point(209, 82);
            labelapellido.Name = "labelapellido";
            labelapellido.Size = new Size(54, 15);
            labelapellido.TabIndex = 8;
            labelapellido.Text = "Apellido:";
            // 
            // buttonbuscar
            // 
            buttonbuscar.Location = new Point(209, 31);
            buttonbuscar.Name = "buttonbuscar";
            buttonbuscar.Size = new Size(112, 25);
            buttonbuscar.TabIndex = 10;
            buttonbuscar.Text = "Buscar";
            buttonbuscar.UseVisualStyleBackColor = true;
            // 
            // labelencomiendaspendientes
            // 
            labelencomiendaspendientes.AutoSize = true;
            labelencomiendaspendientes.Location = new Point(34, 133);
            labelencomiendaspendientes.Name = "labelencomiendaspendientes";
            labelencomiendaspendientes.Size = new Size(139, 15);
            labelencomiendaspendientes.TabIndex = 11;
            labelencomiendaspendientes.Text = "Encomiendas Pendientes";
            // 
            // GenerarHDRFleteros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelencomiendaspendientes);
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
            Name = "GenerarHDRFleteros";
            Text = "Generar HDR Fleteros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelfletero;
        private TextBox textBox1;
        private Label labelusuario;
        private Label labelnumusuario;
        private Label labelcentrodistribucion;
        private Label labelCD;
        private Label labelnombre;
        private Label labelnombrefletero;
        private Label labelapellidofletero;
        private Label labelapellido;
        private Button buttonbuscar;
        private Label labelencomiendaspendientes;
    }
}