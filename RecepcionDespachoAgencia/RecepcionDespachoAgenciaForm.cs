namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    public partial class RecepcionDespachoAgenciaForm : Form
    {
        private RecepcionDespachoAgenciaModelo modelo = new();

        public RecepcionDespachoAgenciaForm()
        {
            InitializeComponent();
        }

        private void RecepcionDespachoAgenciaForm_Load(object sender, EventArgs e)
        {
            UsuarioRespuestaLabel.Text = "Usuario01";
            AgenciaRespuestaLabel.Text = "Agencia Moron Centro";

            NombreFleteroRespuestaLabel.Text = "";
            ApellidoRespuestaLabel.Text = "";

            NumeroHDRSuperiorLabel.Text = "";

            HojasdeRutaListView.Items.Clear();
            HDRaRendirAgenciaListView.Items.Clear();
            DetalleGuiasListView.Items.Clear();

            HojasdeRutaListView.Columns.Add("HDR", 200);
            HDRaRendirAgenciaListView.Columns.Add("HDR", 300);
        }

        private void BuscarFleteroBoton_Click(object sender, EventArgs e)
        {
            HojasdeRutaListView.Items.Clear();
            HDRaRendirAgenciaListView.Items.Clear();
            DetalleGuiasListView.Items.Clear();

            string dni = DNIFleteroBox.Text.Trim();

            // Validar vacío
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show(
                    "El formato del DNI es incorrecto. Debe ingresar un número entero válido.");
                DNIFleteroBox.Clear();
                return;
            }

            // Validar numérico y convertir a long
            if (!long.TryParse(dni, out long dniBuscado))
            {
                MessageBox.Show(
                    "El formato del DNI es incorrecto. Debe ingresar un número entero válido.");
                DNIFleteroBox.Clear();
                return;
            }

            // Validar longitud
            if (dni.Length < 7 || dni.Length > 8)
            {
                MessageBox.Show(
                    "El formato del DNI es incorrecto. Debe ingresar un número entero válido.");
                DNIFleteroBox.Clear();
                return;
            }

            // Buscar fletero
            foreach (var fletero in modelo.LFleteros)
            {
                if (fletero.fleteroDNI == dniBuscado)
                {
                    modelo.fleteroActual = fletero;

                    NombreFleteroRespuestaLabel.Text =
                        fletero.fleteroNombre;

                    ApellidoRespuestaLabel.Text =
                        fletero.fleteroApellido;
                    foreach (var hdr in modelo.LHDRRetiro)
                    {
                        if (hdr.fleteroDNI == dniBuscado)
                        {
                            HojasdeRutaListView.Items.Add(hdr.numeroHDR);
                        }
                    }

                    // HDR de distribución
                    foreach (var hdr in modelo.LHDRDistribucion)
                    {
                        if (hdr.fleteroDNI == dniBuscado)
                        {
                            HDRaRendirAgenciaListView.Items.Add(hdr.numeroHDR);
                        }
                    }

                    return;
                }
            }

            // Si no se encontró
            MessageBox.Show(
                "No se encontró el fletero. Vuelva a intentarlo.");

            DNIFleteroBox.Clear();

            NombreFleteroRespuestaLabel.Text = "";
            ApellidoRespuestaLabel.Text = "";
        }

        private void HDRaRendirAgenciaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HDRaRendirAgenciaListView.SelectedItems.Count > 0)
            {
                string hdrSeleccionada =
                    HDRaRendirAgenciaListView.SelectedItems[0].Text;

                NumeroHDRSuperiorLabel.Text = hdrSeleccionada; 
                CargarDetalleHDR(hdrSeleccionada);
            }
        }

        private void HojasdeRutaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HojasdeRutaListView.SelectedItems.Count > 0)
            {
                string hdrSeleccionada =
                    HojasdeRutaListView.SelectedItems[0].Text;

                NumeroHDRSuperiorLabel.Text = hdrSeleccionada;
                CargarDetalleHDR(hdrSeleccionada);
            }
        }

        private void CargarDetalleHDR(string hdrSeleccionada)
        {
            NumeroHDRSuperiorLabel.Text = hdrSeleccionada;

            DetalleGuiasListView.Items.Clear();

            var hdrRetiro =
                modelo.LHDRRetiro.FirstOrDefault(
                    h => h.numeroHDR == hdrSeleccionada);

            var hdrDistribucion =
                modelo.LHDRDistribucion.FirstOrDefault(
                    h => h.numeroHDR == hdrSeleccionada);

            foreach (var guia in modelo.LGuias)
            {
                bool perteneceHDR = false;

                if (hdrRetiro != null)
                {
                    perteneceHDR =
                        hdrRetiro.GuiaIds.Contains(guia.guiaId);
                }

                if (!perteneceHDR && hdrDistribucion != null)
                {
                    perteneceHDR =
                        hdrDistribucion.GuiaIds.Contains(guia.guiaId);
                }

                if (perteneceHDR)
                {
                    ListViewItem item = new ListViewItem("");

                    item.SubItems.Add(guia.guiaId.ToString());
                    item.SubItems.Add(guia.tipo);

                    DetalleGuiasListView.Items.Add(item);
                }
            }
        }

        private void ConfirmarBoton_Click_1(object sender, EventArgs e)
        {
            bool hayAlgunaMarcada = false;

            foreach (ListViewItem item in DetalleGuiasListView.Items)
            {
                if (item.Checked)
                {
                    hayAlgunaMarcada = true;
                    break;
                }
            }

            if (!hayAlgunaMarcada)
            {
                MessageBox.Show(
                    "Debe controlar al menos una guía antes de confirmar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de confirmar la operación?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            MessageBox.Show(
                "Operación confirmada. Estados actualizados.");

            // FUTURO:
            // Una vez confirmada la operación:
            // 1. Actualizar estados de las guías marcadas.
            // 2. Remover la HDR procesada de la lista correspondiente.
            // 3. Limpiar el detalle de la HDR para permitir procesar otra HDR del mismo fletero.
            NumeroHDRSuperiorLabel.Text = "";
            DetalleGuiasListView.Items.Clear();

        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Si sale se eliminarán los datos ingresados. ¿Desea salir?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Operación cancelada. No se ha registrado ninguna actualización de estados");

                Close();
            }
        }
    }
}

