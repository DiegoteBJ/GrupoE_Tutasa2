using System;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    public partial class FrmDespachoUltimaMilla : Form
    {
        public FrmDespachoUltimaMilla()
        {
            InitializeComponent();
            WireEvents();
            SetupGrids();
            ResetUI();
        }

        private void WireEvents()
        {
            btnBuscar.Click += btnBuscar_Click;
            btnConfirmarAsignacion.Click += btnConfirmarAsignacion_Click;
            btnCancelar.Click += (s, e) => this.Close();
        }

        private void SetupGrids()
        {
            ConfigureGrid(dgvHdrDistribucion);
            ConfigureGrid(dgvHdrRetiro);

            dgvHdrDistribucion.Columns.Add("colHdr", "Nro HDR");
            dgvHdrDistribucion.Columns.Add("colCant", "Cant. Guías");
            dgvHdrDistribucion.Columns.Add("colZona", "Zona / Destino");

            dgvHdrRetiro.Columns.Add("colHdr", "Nro HDR");
            dgvHdrRetiro.Columns.Add("colCant", "Cant. Guías");
            dgvHdrRetiro.Columns.Add("colOrigen", "Origen");
        }

        private void ConfigureGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = System.Drawing.Color.White;
        }

        private void ResetUI()
        {
            lblUsuarioValue.Text = "Operario123";
            lblCdValue.Text = "CD Norte";
            lblFleteroValue.Text = "-";

            dgvHdrDistribucion.Rows.Clear();
            dgvHdrRetiro.Rows.Clear();

            btnConfirmarAsignacion.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniFletero.Text.Trim();

            if (!IsValidDni(dni, out string error))
            {
                MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDniFletero.Focus();
                return;
            }

            // TODO: búsqueda real fletero habilitado
            if (dni != "12345678")
            {
                MessageBox.Show("No existe el fletero. Vuelva a intentarlo.", "Fletero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblFleteroValue.Text = "-";
                dgvHdrDistribucion.Rows.Clear();
                dgvHdrRetiro.Rows.Clear();
                btnConfirmarAsignacion.Enabled = false;
                return;
            }

            lblFleteroValue.Text = "Juan Pérez";

            // TODO: Generar HDR reales (agrupación/ruteo)
            // Simulación:
            dgvHdrDistribucion.Rows.Clear();
            dgvHdrDistribucion.Rows.Add("HDR-531", "7", "CP 1600");
            dgvHdrDistribucion.Rows.Add("HDR-532", "7", "CP 1700");

            dgvHdrRetiro.Rows.Clear();
            dgvHdrRetiro.Rows.Add("HDR-503", "4", "CP 1602");

            btnConfirmarAsignacion.Enabled = dgvHdrDistribucion.Rows.Count > 0 || dgvHdrRetiro.Rows.Count > 0;
        }

        private void btnConfirmarAsignacion_Click(object sender, EventArgs e)
        {
            if (lblFleteroValue.Text == "-" || string.IsNullOrWhiteSpace(lblFleteroValue.Text))
            {
                MessageBox.Show("Debe seleccionar un transportista primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: persistir nuevas HDR + actualizar estados guías
            MessageBox.Show("Operación exitosa. HDR asignadas al fletero.", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetUI();
            txtDniFletero.Clear();
        }

        private bool IsValidDni(string dni, out string error)
        {
            error = null;

            if (string.IsNullOrWhiteSpace(dni))
            {
                error = "Debe ingresar un DNI.";
                return false;
            }

            if (!long.TryParse(dni, out var n) || n <= 0)
            {
                error = "Debe ingresar un número entero positivo.";
                return false;
            }

            if (dni.Length < 7 || dni.Length > 8)
            {
                error = "Debe ingresar un número que contenga entre 7 y 8 caracteres.";
                return false;
            }

            return true;
        }
    }
}
