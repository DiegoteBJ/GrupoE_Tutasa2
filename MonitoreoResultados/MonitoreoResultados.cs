namespace GrupoE_Tutasa.MonitoreoResultados
{
    public partial class MonitoreoResultadosForm : Form
    {
        private MonitoreoResultadosModelo modelo = new();
        public MonitoreoResultadosForm()
        {
            InitializeComponent();
        }

        private void MonitoreoResultadosForm_Load(object sender, EventArgs e)
        {
            var hoy = DateTime.Today;
            var anterior = new DateTime(hoy.Year, hoy.Month, 1).AddDays(-1);
            int anio = anterior.Year;
            int mes = anterior.Month;
            //MesUpDown.Value = mes;
            //AñoUpDown.Value = anio;
            ResultadoMensualLabel.Text = 0.ToString("C");
            ResultadosObtenidosListView.Items.Clear();
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerOtroBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            MonitoreoResultadosForm nuevoForm = new MonitoreoResultadosForm();
            nuevoForm.Show();
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            //int mes = (int)MesUpDown.Value;
            int mes = 0;//para que compile solamente.
            //int anio = (int)AñoUpDown.Value;
            int anio = 0;//para que compile solamente.


            decimal importePagado = 0;
            decimal resultadoMensualporEmpresa = 0;
            decimal resultadoMensualAcumulado = 0;
            ResultadosObtenidosListView.Items.Clear();

            if (modelo?.LProveedoresLD == null)
            {
                return;
            }

            foreach (var proveedoresLD in modelo.LProveedoresLD)
            {
                foreach (var documentos in modelo.LDocumentos)
                {
                    if (documentos.proveedorId == proveedoresLD.proveedorId && documentos.documentoFecha.Month == mes && documentos.documentoFecha.Year == anio)
                    {
                        importePagado = importePagado + documentos.documentoTotalsinIVA;
                    }
                }
                ListViewItem item = new ListViewItem(proveedoresLD.proveedorName);
                item.SubItems.Add((proveedoresLD.proveedorId * 1000000).ToString("C"));
                item.SubItems.Add(importePagado.ToString("C"));
                resultadoMensualporEmpresa = proveedoresLD.proveedorId * 1000000 - importePagado;
                item.SubItems.Add(resultadoMensualporEmpresa.ToString("C"));
                ResultadosObtenidosListView.Items.Add(item);

                resultadoMensualAcumulado = resultadoMensualporEmpresa + resultadoMensualAcumulado;
                resultadoMensualporEmpresa = 0;
                importePagado = 0;
            }
            ResultadoMensualLabel.Text = resultadoMensualAcumulado.ToString("C");
        }
    }
}
