namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioValue = new System.Windows.Forms.Label();
            this.lblCd = new System.Windows.Forms.Label();
            this.lblCdValue = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.lblFleteroValue = new System.Windows.Forms.Label();
            this.lblFletero = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.gbDistribucionAsignada = new System.Windows.Forms.GroupBox();
            this.lvDistribucionAsignada = new System.Windows.Forms.ListView();
            this.gbRetiroAsignado = new System.Windows.Forms.GroupBox();
            this.lvRetiroAsignado = new System.Windows.Forms.ListView();
            this.gbNuevaDistribucion = new System.Windows.Forms.GroupBox();
            this.lvNuevaDistribucion = new System.Windows.Forms.ListView();
            this.gbNuevaRetiro = new System.Windows.Forms.GroupBox();
            this.lvNuevaRetiro = new System.Windows.Forms.ListView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbBuscar.SuspendLayout();
            this.gbDistribucionAsignada.SuspendLayout();
            this.gbRetiroAsignado.SuspendLayout();
            this.gbNuevaDistribucion.SuspendLayout();
            this.gbNuevaRetiro.SuspendLayout();
            this.SuspendLayout();
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            //
            // lblUsuarioValue
            //
            this.lblUsuarioValue.AutoSize = true;
            this.lblUsuarioValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioValue.Location = new System.Drawing.Point(70, 12);
            this.lblUsuarioValue.Name = "lblUsuarioValue";
            this.lblUsuarioValue.Size = new System.Drawing.Size(64, 15);
            this.lblUsuarioValue.TabIndex = 1;
            this.lblUsuarioValue.Text = "Operario";
            //
            // lblCd
            //
            this.lblCd.AutoSize = true;
            this.lblCd.Location = new System.Drawing.Point(260, 12);
            this.lblCd.Name = "lblCd";
            this.lblCd.Size = new System.Drawing.Size(132, 15);
            this.lblCd.TabIndex = 2;
            this.lblCd.Text = "Centro de Distribución:";
            //
            // lblCdValue
            //
            this.lblCdValue.AutoSize = true;
            this.lblCdValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCdValue.Location = new System.Drawing.Point(398, 12);
            this.lblCdValue.Name = "lblCdValue";
            this.lblCdValue.Size = new System.Drawing.Size(55, 15);
            this.lblCdValue.TabIndex = 3;
            this.lblCdValue.Text = "CD XYZ";
            //
            // gbBuscar
            //
            this.gbBuscar.Controls.Add(this.lblFleteroValue);
            this.gbBuscar.Controls.Add(this.lblFletero);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtDni);
            this.gbBuscar.Controls.Add(this.lblDni);
            this.gbBuscar.Location = new System.Drawing.Point(12, 40);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(860, 80);
            this.gbBuscar.TabIndex = 4;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar fletero por DNI";
            //
            // lblFleteroValue
            //
            this.lblFleteroValue.AutoSize = true;
            this.lblFleteroValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFleteroValue.Location = new System.Drawing.Point(391, 34);
            this.lblFleteroValue.Name = "lblFleteroValue";
            this.lblFleteroValue.Size = new System.Drawing.Size(12, 15);
            this.lblFleteroValue.TabIndex = 4;
            this.lblFleteroValue.Text = "-";
            //
            // lblFletero
            //
            this.lblFletero.AutoSize = true;
            this.lblFletero.Location = new System.Drawing.Point(340, 34);
            this.lblFletero.Name = "lblFletero";
            this.lblFletero.Size = new System.Drawing.Size(45, 15);
            this.lblFletero.TabIndex = 3;
            this.lblFletero.Text = "Fletero:";
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(222, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            //
            // txtDni
            //
            this.txtDni.Location = new System.Drawing.Point(56, 31);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(160, 23);
            this.txtDni.TabIndex = 1;
            //
            // lblDni
            //
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(16, 34);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(34, 15);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI*";
            //
            // gbDistribucionAsignada
            //
            this.gbDistribucionAsignada.Controls.Add(this.lvDistribucionAsignada);
            this.gbDistribucionAsignada.Location = new System.Drawing.Point(12, 130);
            this.gbDistribucionAsignada.Name = "gbDistribucionAsignada";
            this.gbDistribucionAsignada.Size = new System.Drawing.Size(425, 170);
            this.gbDistribucionAsignada.TabIndex = 5;
            this.gbDistribucionAsignada.TabStop = false;
            this.gbDistribucionAsignada.Text = "Detalle de guías de HDR de distribución asignadas";
            //
            // lvDistribucionAsignada
            //
            this.lvDistribucionAsignada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDistribucionAsignada.Location = new System.Drawing.Point(3, 19);
            this.lvDistribucionAsignada.Name = "lvDistribucionAsignada";
            this.lvDistribucionAsignada.Size = new System.Drawing.Size(419, 148);
            this.lvDistribucionAsignada.TabIndex = 0;
            this.lvDistribucionAsignada.UseCompatibleStateImageBehavior = false;
            //
            // gbRetiroAsignado
            //
            this.gbRetiroAsignado.Controls.Add(this.lvRetiroAsignado);
            this.gbRetiroAsignado.Location = new System.Drawing.Point(447, 130);
            this.gbRetiroAsignado.Name = "gbRetiroAsignado";
            this.gbRetiroAsignado.Size = new System.Drawing.Size(425, 170);
            this.gbRetiroAsignado.TabIndex = 6;
            this.gbRetiroAsignado.TabStop = false;
            this.gbRetiroAsignado.Text = "Detalle de guías de HDR de retiro asignadas";
            //
            // lvRetiroAsignado
            //
            this.lvRetiroAsignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRetiroAsignado.Location = new System.Drawing.Point(3, 19);
            this.lvRetiroAsignado.Name = "lvRetiroAsignado";
            this.lvRetiroAsignado.Size = new System.Drawing.Size(419, 148);
            this.lvRetiroAsignado.TabIndex = 0;
            this.lvRetiroAsignado.UseCompatibleStateImageBehavior = false;
            //
            // gbNuevaDistribucion
            //
            this.gbNuevaDistribucion.Controls.Add(this.lvNuevaDistribucion);
            this.gbNuevaDistribucion.Location = new System.Drawing.Point(12, 310);
            this.gbNuevaDistribucion.Name = "gbNuevaDistribucion";
            this.gbNuevaDistribucion.Size = new System.Drawing.Size(425, 170);
            this.gbNuevaDistribucion.TabIndex = 7;
            this.gbNuevaDistribucion.TabStop = false;
            this.gbNuevaDistribucion.Text = "Nueva hoja de ruta de distribución asignada al fletero";
            //
            // lvNuevaDistribucion
            //
            this.lvNuevaDistribucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNuevaDistribucion.Location = new System.Drawing.Point(3, 19);
            this.lvNuevaDistribucion.Name = "lvNuevaDistribucion";
            this.lvNuevaDistribucion.Size = new System.Drawing.Size(419, 148);
            this.lvNuevaDistribucion.TabIndex = 0;
            this.lvNuevaDistribucion.UseCompatibleStateImageBehavior = false;
            //
            // gbNuevaRetiro
            //
            this.gbNuevaRetiro.Controls.Add(this.lvNuevaRetiro);
            this.gbNuevaRetiro.Location = new System.Drawing.Point(447, 310);
            this.gbNuevaRetiro.Name = "gbNuevaRetiro";
            this.gbNuevaRetiro.Size = new System.Drawing.Size(425, 170);
            this.gbNuevaRetiro.TabIndex = 8;
            this.gbNuevaRetiro.TabStop = false;
            this.gbNuevaRetiro.Text = "Nueva hoja de ruta de retiro asignada al fletero";
            //
            // lvNuevaRetiro
            //
            this.lvNuevaRetiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNuevaRetiro.Location = new System.Drawing.Point(3, 19);
            this.lvNuevaRetiro.Name = "lvNuevaRetiro";
            this.lvNuevaRetiro.Size = new System.Drawing.Size(419, 148);
            this.lvNuevaRetiro.TabIndex = 0;
            this.lvNuevaRetiro.UseCompatibleStateImageBehavior = false;
            //
            // btnConfirmar
            //
            this.btnConfirmar.Location = new System.Drawing.Point(666, 490);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(772, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            //
            // Form1
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 532);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbNuevaRetiro);
            this.Controls.Add(this.gbNuevaDistribucion);
            this.Controls.Add(this.gbRetiroAsignado);
            this.Controls.Add(this.gbDistribucionAsignada);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.lblCdValue);
            this.Controls.Add(this.lblCd);
            this.Controls.Add(this.lblUsuarioValue);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form1";
            this.Text = "Recepción y despacho de encomiendas - Última Milla (CD)";
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbDistribucionAsignada.ResumeLayout(false);
            this.gbRetiroAsignado.ResumeLayout(false);
            this.gbNuevaDistribucion.ResumeLayout(false);
            this.gbNuevaRetiro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsuarioValue;
        private System.Windows.Forms.Label lblCd;
        private System.Windows.Forms.Label lblCdValue;

        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFletero;
        private System.Windows.Forms.Label lblFleteroValue;

        private System.Windows.Forms.GroupBox gbDistribucionAsignada;
        private System.Windows.Forms.ListView lvDistribucionAsignada;

        private System.Windows.Forms.GroupBox gbRetiroAsignado;
        private System.Windows.Forms.ListView lvRetiroAsignado;

        private System.Windows.Forms.GroupBox gbNuevaDistribucion;
        private System.Windows.Forms.ListView lvNuevaDistribucion;

        private System.Windows.Forms.GroupBox gbNuevaRetiro;
        private System.Windows.Forms.ListView lvNuevaRetiro;

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}