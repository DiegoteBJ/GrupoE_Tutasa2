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
            MesTextBox.Text = mes.ToString();
            AnioTextBox.Text = anio.ToString();
            ResultadoMensualLabel.Text = 0.ToString("C");
            ResultadosObtenidosListView.Items.Clear();
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerOtroBoton_Click(object sender, EventArgs e)
        {
            MonitoreoResultadosForm_Load(sender, e);
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(MesTextBox.Text, out int mes) || mes<1 || mes> 12)
				{
					MessageBox.Show("Por favor, ingrese un número de mes válido (1-12).");
					return;
				}
            if (!int.TryParse(AnioTextBox.Text, out int anio) || anio<1900 ||  anio >DateTime.Today.Year)
				{
					MessageBox.Show("Por favor, ingrese un año válido");
                    return;
            }
            decimal importePagado = 0;
            decimal importeCobrado = 0;
            decimal resultadoMensualporEmpresa = 0;
            decimal resultadoMensualAcumulado = 0;
            ResultadosObtenidosListView.Items.Clear();

            if (modelo.LProveedoresLD == null)
            {
                return;
            }

            foreach (var proveedoresLD in modelo.LProveedoresLD)
            {
                importeCobrado = 0;
                int convenioVigente = modelo.ConvenioVigenteId(proveedoresLD.proveedorId, new DateTime(anio, mes, 1));
                importePagado = modelo.ConvenioVigenteImporte(convenioVigente);

                foreach (var Guias in modelo.LGuias)
                {
                    if(Guias.proveedorTransporteId == proveedoresLD.proveedorId && Guias.fechaEntrega.Month == mes && Guias.fechaEntrega.Year == anio && Guias.facturada == true)
                    {
                        importeCobrado = importeCobrado + Guias.importeTotal;
                    }
                }

                ListViewItem item = new ListViewItem(proveedoresLD.proveedorName);
                item.SubItems.Add((importeCobrado).ToString("C"));
                item.SubItems.Add(importePagado.ToString("C"));
                resultadoMensualporEmpresa = importeCobrado - importePagado;
                item.SubItems.Add(resultadoMensualporEmpresa.ToString("C"));
                ResultadosObtenidosListView.Items.Add(item);

                resultadoMensualAcumulado = resultadoMensualporEmpresa + resultadoMensualAcumulado;
                resultadoMensualporEmpresa = 0;
                importePagado = 0;
            }
            ResultadoMensualLabel.Text = resultadoMensualAcumulado.ToString("C");
        }

        private void MesTextBox_TextChanged(object sender, EventArgs e)
        {
            var mes = MesTextBox.Text;
            if (mes == string.Empty)
            {
                return;
            }
            if (!int.TryParse(mes, out int mesInt) || mesInt < 1 || mesInt > 12)
            {
                MessageBox.Show("Por favor, ingrese un número de mes válido (1-12).");
                MesTextBox.Text = string.Empty;
            }
        }

        private void AnioTextBox_TextChanged(object sender, EventArgs e)
        {
            var anio = AnioTextBox.Text;
            if (anio == string.Empty)
            {
                return;
            }
            if (!int.TryParse(anio, out int anioInt) || anioInt < 1900 || anioInt > DateTime.Today.Year)
            {
                MessageBox.Show("Por favor, ingrese un número de año válido.");
                AnioTextBox.Text = string.Empty;
            }
        }
    }
}
