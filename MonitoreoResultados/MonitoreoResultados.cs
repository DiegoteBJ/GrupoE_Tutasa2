using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.MonitoreoResultados
{
    public partial class MonitoreoResultadosForm : Form
    {
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
            MesUpDown.Value = mes;
            AñoUpDown.Value = anio;
            ResultadoMensualLabel.Text = string.Empty;
            ResultadosObtenidosListView.Items.Clear();
        }

    }
}
