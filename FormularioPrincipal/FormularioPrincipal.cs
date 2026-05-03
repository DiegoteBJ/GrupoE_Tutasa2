using GrupoE_Tutasa.EstadoCCClientes;
using GrupoE_Tutasa.EmitirFactura;
using GrupoE_Tutasa.MonitoreoResultados;
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
