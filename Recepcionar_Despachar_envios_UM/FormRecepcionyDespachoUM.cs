using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    public partial class FormRecepcionYDespachoUM : Form
    {
        // Datos precargados
        private Dictionary<string, string> _fleteros = new Dictionary<string, string>();
        private string _dniSeleccionado = "";

        public FormRecepcionYDespachoUM()
        {
            InitializeComponent();
            InicializarPrototipo();
        }

        private void InicializarPrototipo()
        {
            // Encabezado fijo (CD)
            lblUsuarioValue.Text = "Operario123";
            lblCdValue.Text = "CD Morón Centro";
            lblFleteroValue.Text = "-";

            // ListViews (4)
            ConfigurarListViewAsignadas(lvDistribucionAsignada);
            ConfigurarListViewAsignadas(lvRetiroAsignado);

            ConfigurarListViewNuevasDistribucion(lvNuevaDistribucion);
            ConfigurarListViewNuevasRetiro(lvNuevaRetiro);

            // Fleteros (3 DNIs)
            _fleteros = new Dictionary<string, string>
            {
                { "12345678", "Juan Pérez" },
                { "23456789", "Ana Gómez" },
                { "34567890", "Carlos López" } // sin guías
            };

            // Eventos
            btnBuscar.Click += btnBuscar_Click;
            btnConfirmar.Click += btnConfirmar_Click;
            btnCancelar.Click += (s, e) => Close();

            btnConfirmar.Enabled = false;
        }

        // ====== Configuración ListViews ======
        private void ConfigurarListViewAsignadas(ListView lv)
        {
            lv.Clear();
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.HideSelection = false;
            lv.CheckBoxes = true; // arriba con checkbox

            lv.Columns.Add("¿Cumplida?", 90);
            lv.Columns.Add("Nro Guía", 120);
            lv.Columns.Add("Nro HDR", 120);
        }

        private void ConfigurarListViewNuevasDistribucion(ListView lv)
        {
            lv.Clear();
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.HideSelection = false;
            lv.CheckBoxes = false; // abajo sin checkbox

            lv.Columns.Add("Nro Guía", 120);
            lv.Columns.Add("Tamaño", 90);
            lv.Columns.Add("Destino", 160);
            lv.Columns.Add("Nro HDR", 120);
        }

        private void ConfigurarListViewNuevasRetiro(ListView lv)
        {
            lv.Clear();
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.HideSelection = false;
            lv.CheckBoxes = false; // abajo sin checkbox

            lv.Columns.Add("Nro Guía", 120);
            lv.Columns.Add("Tamaño", 90);
            lv.Columns.Add("Origen", 160);
            lv.Columns.Add("Nro HDR", 120);
        }

        // ====== Buscar Fletero ======
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = SoloDigitos(txtDni.Text);

            if (!ValidarDni(dni, out string error))
            {
                MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return;
            }

            if (!_fleteros.ContainsKey(dni))
            {
                MessageBox.Show("No existe el fletero. Vuelva a intentarlo.", "Fletero",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPantalla(keepDni: true);
                return;
            }

            _dniSeleccionado = dni;
            lblFleteroValue.Text = _fleteros[dni];

            CargarDatosParaFletero(dni);

            bool hayAlgo =
                lvDistribucionAsignada.Items.Count > 0 ||
                lvRetiroAsignado.Items.Count > 0 ||
                lvNuevaDistribucion.Items.Count > 0 ||
                lvNuevaRetiro.Items.Count > 0;

            btnConfirmar.Enabled = hayAlgo;
        }

        private void CargarDatosParaFletero(string dni)
        {
            lvDistribucionAsignada.Items.Clear();
            lvRetiroAsignado.Items.Clear();
            lvNuevaDistribucion.Items.Clear();
            lvNuevaRetiro.Items.Clear();

            if (dni == "12345678")
            {
                AddAsignada(lvDistribucionAsignada, "501", "HDR-1001");
                AddAsignada(lvDistribucionAsignada, "502", "HDR-1001");
                AddAsignada(lvRetiroAsignado, "601", "HDR-2001");
                AddAsignada(lvRetiroAsignado, "602", "HDR-2001");

                AddNuevaDist(lvNuevaDistribucion, "703", "Grande", "CP 1600", "HDR-1200");
                AddNuevaDist(lvNuevaDistribucion, "704", "Mediano", "CP 1700", "HDR-1200");
                AddNuevaRet(lvNuevaRetiro, "801", "Chico", "Domicilio", "HDR-2200");
                AddNuevaRet(lvNuevaRetiro, "802", "Mediano", "Agencia Morón", "HDR-2200");
            }
            else if (dni == "23456789")
            {
                AddAsignada(lvDistribucionAsignada, "510", "HDR-1010");
                AddAsignada(lvDistribucionAsignada, "511", "HDR-1010");
                AddAsignada(lvRetiroAsignado, "610", "HDR-2010");
                AddAsignada(lvRetiroAsignado, "611", "HDR-2010");

                AddNuevaDist(lvNuevaDistribucion, "710", "Chico", "CP 1406", "HDR-1210");
                AddNuevaDist(lvNuevaDistribucion, "711", "Mediano", "CP 1414", "HDR-1210");
                AddNuevaRet(lvNuevaRetiro, "810", "Grande", "Agencia Oeste", "HDR-2210");
                AddNuevaRet(lvNuevaRetiro, "811", "Chico", "Domicilio", "HDR-2210");
            }
            else if (dni == "34567890")
            {
                MessageBox.Show(
                    "El fletero seleccionado no tiene guías asignadas ni guías disponibles para despachar.",
                    "Sin operación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void AddAsignada(ListView lv, string nroGuia, string nroHdr)
        {
            var item = new ListViewItem("");
            item.Checked = false; // arranca desmarcado
            item.SubItems.Add(nroGuia);
            item.SubItems.Add(nroHdr);
            lv.Items.Add(item);
        }

        private void AddNuevaDist(ListView lv, string nroGuia, string tam, string destino, string nroHdr)
        {
            var item = new ListViewItem(nroGuia);
            item.SubItems.Add(tam);
            item.SubItems.Add(destino);
            item.SubItems.Add(nroHdr);
            lv.Items.Add(item);
        }

        private void AddNuevaRet(ListView lv, string nroGuia, string tam, string origen, string nroHdr)
        {
            var item = new ListViewItem(nroGuia);
            item.SubItems.Add(tam);
            item.SubItems.Add(origen);
            item.SubItems.Add(nroHdr);
            lv.Items.Add(item);
        }

        // ====== Confirmar ======
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_dniSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un transportista primero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (okDist, noDist) = ContarCumplidas(lvDistribucionAsignada);
            var (okRet, noRet) = ContarCumplidas(lvRetiroAsignado);

            string hdrNuevaDist = GetHdrUnico(lvNuevaDistribucion);
            string hdrNuevaRet = GetHdrUnico(lvNuevaRetiro);

            var sb = new StringBuilder();
            sb.AppendLine("Operación exitosa. Rendición confirmada.");
            sb.AppendLine($"CD: {lblCdValue.Text}");
            sb.AppendLine($"Fletero: {lblFleteroValue.Text} (DNI {_dniSeleccionado})");
            sb.AppendLine();
            sb.AppendLine($"Distribución -> Cumplidas: {okDist} | No cumplidas: {noDist}");
            sb.AppendLine($"Retiro       -> Cumplidas: {okRet}  | No cumplidas: {noRet}");
            sb.AppendLine();
            sb.AppendLine($"Nueva HDR Distribución: {hdrNuevaDist}");
            sb.AppendLine($"Nueva HDR Retiro: {hdrNuevaRet}");

            MessageBox.Show(sb.ToString(), "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarPantalla();
        }

        private (int ok, int no) ContarCumplidas(ListView lv)
        {
            int ok = 0, no = 0;
            foreach (ListViewItem item in lv.Items)
                if (item.Checked) ok++; else no++;
            return (ok, no);
        }

        private string GetHdrUnico(ListView lv)
        {
            if (lv.Items.Count == 0) return "(sin HDR)";
            return lv.Items[0].SubItems[3].Text;
        }

        private void LimpiarPantalla(bool keepDni = false)
        {
            if (!keepDni) txtDni.Text = "";
            _dniSeleccionado = null;
            lblFleteroValue.Text = "-";

            lvDistribucionAsignada.Items.Clear();
            lvRetiroAsignado.Items.Clear();
            lvNuevaDistribucion.Items.Clear();
            lvNuevaRetiro.Items.Clear();

            btnConfirmar.Enabled = false;
        }

        private bool ValidarDni(string dni, out string error)
        {
            error = null;

            if (string.IsNullOrWhiteSpace(dni)) { error = "Debe ingresar un DNI."; return false; }
            if (!long.TryParse(dni, out long n) || n <= 0) { error = "Debe ingresar un número entero positivo."; return false; }
            if (dni.Length < 7 || dni.Length > 8) { error = "Debe ingresar un número que contenga entre 7 y 8 caracteres."; return false; }

            return true;
        }

        private string SoloDigitos(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
                if (char.IsDigit(c)) sb.Append(c);
            return sb.ToString();
        }
    }
}
