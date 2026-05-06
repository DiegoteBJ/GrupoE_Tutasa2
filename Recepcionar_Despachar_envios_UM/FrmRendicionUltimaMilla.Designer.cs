namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    partial class FrmRendicionUltimaMilla
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblCd = new Label();
            lblUsuarioValue = new Label();
            lblCdValue = new Label();
            lblDni = new Label();
            txtDniFletero = new MaskedTextBox();
            btnBuscar = new Button();
            lblFletero = new Label();
            lblFleteroValue = new Label();
            gbDistribucion = new GroupBox();
            dgvDistribucion = new DataGridView();
            gbRetiro = new GroupBox();
            dgvRetiro = new DataGridView();
            btnConfirmarRendicion = new Button();
            btnCancelar = new Button();
            gbDistribucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).BeginInit();
            gbRetiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRetiro).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 15);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblCd
            // 
            lblCd.AutoSize = true;
            lblCd.Location = new Point(12, 38);
            lblCd.Name = "lblCd";
            lblCd.Size = new Size(129, 15);
            lblCd.TabIndex = 1;
            lblCd.Text = "Centro de Distribución:";
            // 
            // lblUsuarioValue
            // 
            lblUsuarioValue.AutoSize = true;
            lblUsuarioValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValue.Location = new Point(70, 15);
            lblUsuarioValue.Name = "lblUsuarioValue";
            lblUsuarioValue.Size = new Size(56, 15);
            lblUsuarioValue.TabIndex = 2;
            lblUsuarioValue.Text = "Operario";
            // 
            // lblCdValue
            // 
            lblCdValue.AutoSize = true;
            lblCdValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCdValue.Location = new Point(150, 38);
            lblCdValue.Name = "lblCdValue";
            lblCdValue.Size = new Size(48, 15);
            lblCdValue.TabIndex = 3;
            lblCdValue.Text = "CD XYZ";
            lblCdValue.Click += lblCdValue_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 78);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(69, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI Fletero:";
            // 
            // txtDniFletero
            // 
            txtDniFletero.Location = new Point(88, 75);
            txtDniFletero.Name = "txtDniFletero";
            txtDniFletero.Size = new Size(160, 23);
            txtDniFletero.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(254, 74);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 25);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(12, 110);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(46, 15);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Fletero:";
            // 
            // lblFleteroValue
            // 
            lblFleteroValue.AutoSize = true;
            lblFleteroValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFleteroValue.Location = new Point(63, 110);
            lblFleteroValue.Name = "lblFleteroValue";
            lblFleteroValue.Size = new Size(12, 15);
            lblFleteroValue.TabIndex = 8;
            lblFleteroValue.Text = "-";
            // 
            // gbDistribucion
            // 
            gbDistribucion.Controls.Add(dgvDistribucion);
            gbDistribucion.Location = new Point(12, 140);
            gbDistribucion.Name = "gbDistribucion";
            gbDistribucion.Size = new Size(760, 140);
            gbDistribucion.TabIndex = 9;
            gbDistribucion.TabStop = false;
            gbDistribucion.Text = "HDR de Distribución Pendientes";
            // 
            // dgvDistribucion
            // 
            dgvDistribucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribucion.Dock = DockStyle.Fill;
            dgvDistribucion.Location = new Point(3, 19);
            dgvDistribucion.Name = "dgvDistribucion";
            dgvDistribucion.Size = new Size(754, 118);
            dgvDistribucion.TabIndex = 0;
            // 
            // gbRetiro
            // 
            gbRetiro.Controls.Add(dgvRetiro);
            gbRetiro.Location = new Point(12, 286);
            gbRetiro.Name = "gbRetiro";
            gbRetiro.Size = new Size(760, 140);
            gbRetiro.TabIndex = 10;
            gbRetiro.TabStop = false;
            gbRetiro.Text = "HDR de Retiro Pendientes";
            // 
            // dgvRetiro
            // 
            dgvRetiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRetiro.Dock = DockStyle.Fill;
            dgvRetiro.Location = new Point(3, 19);
            dgvRetiro.Name = "dgvRetiro";
            dgvRetiro.Size = new Size(754, 118);
            dgvRetiro.TabIndex = 0;
            // 
            // btnConfirmarRendicion
            // 
            btnConfirmarRendicion.Location = new Point(12, 438);
            btnConfirmarRendicion.Name = "btnConfirmarRendicion";
            btnConfirmarRendicion.Size = new Size(160, 30);
            btnConfirmarRendicion.TabIndex = 11;
            btnConfirmarRendicion.Text = "Confirmar Rendición";
            btnConfirmarRendicion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(178, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmRendicionUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 481);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarRendicion);
            Controls.Add(gbRetiro);
            Controls.Add(gbDistribucion);
            Controls.Add(lblFleteroValue);
            Controls.Add(lblFletero);
            Controls.Add(btnBuscar);
            Controls.Add(txtDniFletero);
            Controls.Add(lblDni);
            Controls.Add(lblCdValue);
            Controls.Add(lblUsuarioValue);
            Controls.Add(lblCd);
            Controls.Add(lblUsuario);
            Name = "FrmRendicionUltimaMilla";
            Text = "Rendición HDR Última Milla";
            gbDistribucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).EndInit();
            gbRetiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRetiro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCd;
        private System.Windows.Forms.Label lblUsuarioValue;
        private System.Windows.Forms.Label lblCdValue;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.MaskedTextBox txtDniFletero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFletero;
        private System.Windows.Forms.Label lblFleteroValue;
        private System.Windows.Forms.GroupBox gbDistribucion;
        private System.Windows.Forms.DataGridView dgvDistribucion;
        private System.Windows.Forms.GroupBox gbRetiro;
        private System.Windows.Forms.DataGridView dgvRetiro;
        private System.Windows.Forms.Button btnConfirmarRendicion;
        private System.Windows.Forms.Button btnCancelar;
    }
}