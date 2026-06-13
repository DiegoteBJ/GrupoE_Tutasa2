using GrupoE_Tutasa.Admision;
using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.EmitirFactura;
using GrupoE_Tutasa.EntregaEnAgencia;
using GrupoE_Tutasa.EntregaEnCD;
using GrupoE_Tutasa.EstadoCCClientes;
using GrupoE_Tutasa.EstadoDeEncomienda;
using GrupoE_Tutasa.GenerarHDR;
using GrupoE_Tutasa.GenerarHDRTransporte;
using GrupoE_Tutasa.Imposicion;
using GrupoE_Tutasa.MonitoreoResultados;
using GrupoE_Tutasa.RecepcionDespachoAgencia;
using GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia;
using GrupoE_Tutasa.RendicionHDR;
using System.Security.Cryptography.X509Certificates;


namespace GrupoE_Tutasa.FormularioPrincipal
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        public int agenciaTrabajoId = Program.agenciaTrabajoId;
        public int CDTrabajoId = Program.CDTrabajoId;
        public string modalidadImposicion = Program.modalidadImposicion;
        
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            CDTrabajoLabel.Text = $"{CDTrabajoId}";
            AgenciaTrabajoLabel.Text = $"{agenciaTrabajoId}";
            ModalidadImposicionLabel.Text = $"{modalidadImposicion}";
        }

        private void EmitirFacturasBoton_Click(object sender, EventArgs e)
        {
            EmitirFacturaForm emitirFacturaForm = new EmitirFacturaForm();
            emitirFacturaForm.Show();
        }

        private void EstadoCCClientesBoton_Click(object sender, EventArgs e)
        {
            EstadoCClientesForm estadoCClientesForm = new EstadoCClientesForm();
            estadoCClientesForm.Show();
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonitoreoBoton_Click(object sender, EventArgs e)
        {
            MonitoreoResultadosForm monitoreoResultadosForm = new MonitoreoResultadosForm();
            monitoreoResultadosForm.Show();
        }

        private void ImponerEnCD_Click(object sender, EventArgs e)
        {
            ImposicionForm imposicionForm = new ImposicionForm();
            imposicionForm.Show();
        }
        private void AdmisionBoton_Click(object sender, EventArgs e)
        {
            AdmisionForm admisionForm = new AdmisionForm();
            admisionForm.Show();
        }

        private void AdmisionBoton_Click_1(object sender, EventArgs e)
        {
            AdmisionForm admisionForm = new AdmisionForm();
            admisionForm.Show();
        }

        private void RecepcionAgenciaBoton_Click(object sender, EventArgs e)
        {
            RecepcionDespachoAgenciaForm recepcionDespachoAgencia = new RecepcionDespachoAgenciaForm();
            recepcionDespachoAgencia.Show();
        }

        private void RecepcionCDLDBoton_Click(object sender, EventArgs e)
        {
            RecepcionDespachoCDLargaDistanciaForm recepcionDespacho = new RecepcionDespachoCDLargaDistanciaForm();
            recepcionDespacho.Show();
        }

        private void EntregaEnAgenciaBoton_Click(object sender, EventArgs e)
        {
            EntregaEnAgenciaForm entregaEnAgenciaForm = new EntregaEnAgenciaForm();
            entregaEnAgenciaForm.Show();
        }

        private void EntregaEnCDBoton_Click(object sender, EventArgs e)
        {
            EntregaEnCDForm entregaEnCDForm = new EntregaEnCDForm();
            entregaEnCDForm.Show();
        }

        private void EstadoEncomiendaBoton_Click(object sender, EventArgs e)
        {
            EstadoDeEncomiendaForm estadoDeEncomiendaForm = new EstadoDeEncomiendaForm();
            estadoDeEncomiendaForm.Show();
        }

        private void GenerarHDRBoton_Click(object sender, EventArgs e)
        {
            GenerarHDRFleteroForm generarHDRForm = new GenerarHDRFleteroForm();
            generarHDRForm.Show();
        }

        private void GenerarHDRTransporteBoton_Click(object sender, EventArgs e)
        {
            GenerarHDRTransporteForm generarHDRTransporteForm = new GenerarHDRTransporteForm();
            generarHDRTransporteForm.Show();
        }

        private void RendicionHDRBoton_Click(object sender, EventArgs e)
        {
            RendicionHDRForm rendicionHDRForm = new RendicionHDRForm();
            rendicionHDRForm.Show();
        }
    }
}