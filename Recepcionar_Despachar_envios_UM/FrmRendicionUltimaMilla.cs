using System;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    public partial class FrmRendicionUltimaMilla : Form
    {
        public FrmRendicionUltimaMilla()
        {
            InitializeComponent();
            WireEvents();
            SetupGrids();
            ResetUI();
        }

        private void WireEvents()
        {
            btnBuscar.Click += btnBuscar_Click;
            btnConfirmarRendicion.Click += btnConfirmarRendicion_Click;
            btnCancelar.Click += (s, e) => this.Close();
        }

        private void SetupGrids()
        {
            // Config general
            ConfigureGrid(dgvDistribucion);
            ConfigureGrid(dgvRetiro);

            // Columnas Distribución
            dgvDistribucion.Columns.Add("colNroGuia", "Nro Guía");
            dgvDistribucion.Columns.Add("colNroHdr", "Nro HDR");

            var colResultadoDist = new DataGridViewComboBoxColumn
            {
                Name = "colResultado",
                HeaderText = "Resultado",
                DataSource = new[] { "Cumplida", "No cumplida" },
                FlatStyle = FlatStyle.Flat
            };
            dgvDistribucion.Columns.Add(colResultadoDist);

            // Columnas Retiro
            dgvRetiro.Columns.Add("colNroGuia", "Nro Guía");
            dgvRetiro.Columns.Add("colNroHdr", "Nro HDR");

            var colResultadoRet = new DataGridViewComboBoxColumn
            {
                Name = "colResultado",
                HeaderText = "Resultado",
                DataSource = new[] { "Cumplida", "No cumplida" },
                FlatStyle = FlatStyle.Flat
            };
            dgvRetiro.Columns.Add(colResultadoRet);
        }

        private void ConfigureGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = false;
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
            dgvDistribucion.Rows.Clear();
            dgvRetiro.Rows.Clear();

            btnConfirmarRendicion.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniFletero.Text.Trim();

            // Validaciones DNI
            if (!IsValidDni(dni, out string error))
            {
                MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDniFletero.Focus();
                return;
            }

            // TODO: acá iría la búsqueda real en BD/archivo Fleteros
            // Simulación: si DNI = 12345678 existe
            if (dni != "12345678")
            {
                MessageBox.Show("No existe el fletero. Vuelva a intentarlo.", "Fletero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblFleteroValue.Text = "-";
                dgvDistribucion.Rows.Clear();
                dgvRetiro.Rows.Clear();
                btnConfirmarRendicion.Enabled = false;
                return;
            }

            // Mostrar fletero
            lblFleteroValue.Text = "Juan Pérez";

            // TODO: cargar HDR pendientes reales
            // Simulación de datos:
            dgvDistribucion.Rows.Clear();
            dgvDistribucion.Rows.Add("501", "HDR-1001", "Cumplida");
            dgvDistribucion.Rows.Add("502", "HDR-1001", "No cumplida");

            dgvRetiro.Rows.Clear();
            dgvRetiro.Rows.Add("601", "HDR-2001", "Cumplida");
            dgvRetiro.Rows.Add("602", "HDR-2001", "Cumplida");

            btnConfirmarRendicion.Enabled = dgvDistribucion.Rows.Count > 0 || dgvRetiro.Rows.Count > 0;
        }

        private void btnConfirmarRendicion_Click(object sender, EventArgs e)
        {
            if (lblFleteroValue.Text == "-" || string.IsNullOrWhiteSpace(lblFleteroValue.Text))
            {
                MessageBox.Show("Debe seleccionar un transportista primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que todos tengan resultado seleccionado
            if (!AllRowsHaveResult(dgvDistribucion) || !AllRowsHaveResult(dgvRetiro))
            {
                MessageBox.Show("Hay guías sin resultado seleccionado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: persistir rendición + actualizar estados + comisiones + imprimir resumen
            // Acá solo muestro resumen
            string resumen =
                "Operación exitosa. Rendición confirmada.\n\n" +
                $"Fletero: {lblFleteroValue.Text}\n" +
                $"HDR Distribución rendidas: {CountHdrDistinct(dgvDistribucion)}\n" +
                $"HDR Retiro rendidas: {CountHdrDistinct(dgvRetiro)}\n";

            MessageBox.Show(resumen, "Rendición", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private bool AllRowsHaveResult(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var val = row.Cells["colResultado"].Value;
                if (val == null || string.IsNullOrWhiteSpace(val.ToString()))
                    return false;
            }
            return true;
        }

        private int CountHdrDistinct(DataGridView dgv)
        {
            var set = new System.Collections.Generic.HashSet<string>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var hdr = row.Cells["colNroHdr"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(hdr)) set.Add(hdr);
            }
            return set.Count;
        }

        private void lblCdValue_Click(object sender, EventArgs e)
        {

        }
    }
}
