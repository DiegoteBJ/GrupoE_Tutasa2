using GrupoE_Tutasa.Actualizar_HDR;
using GrupoE_Tutasa.EmitirFactura;
using GrupoE_Tutasa.Entrega_en_Agencia;
using GrupoE_Tutasa.Entrega_en_CD;
using GrupoE_Tutasa.Estado_de_Encomienda;
using GrupoE_Tutasa.EstadoCCClientes;
using ImponerEnCD;
using GrupoE_Tutasa.MonitoreoResultados;
using GrupoE_Tutasa.Recepcion_y_Despacho_CD_Larga_distancia;
using GrupoE_Tutasa.Recepcionar_Despachar_envios_UM;
using GrupoE_Tutasa.RecepcionDespachoAgencia;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.FormularioPrincipal
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
