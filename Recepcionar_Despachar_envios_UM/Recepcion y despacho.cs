using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    // ── Modelos de datos en memoria ──────────────────────────────────────────

    class Fletero
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
    }

    class GuiaHDR
    {
        public string NroGuia { get; set; }
        public string HDR { get; set; }
        public bool Cumplida { get; set; }
    }

    class NuevaGuia
    {
        public string NroGuia { get; set; }
        public string Tamanio { get; set; }
        public string Destino { get; set; }
        public string HDR { get; set; }
    }

    public partial class Recepcion_y_despacho : Form
    {
        // Datos de ejemplo (simulan lo que vendría de la BD)
        private readonly List<Fletero> _fleteros = new List<Fletero>
        {
            new Fletero { DNI = "12345678", Nombre = "Juan Pérez"    },
            new Fletero { DNI = "87654321", Nombre = "María González" },
            new Fletero { DNI = "11223344", Nombre = "Carlos López"  },
        };

        // Guías de distribución asignadas al fletero encontrado
        private readonly Dictionary<string, List<GuiaHDR>> _guiasDistribucion =
            new Dictionary<string, List<GuiaHDR>>
            {
                ["12345678"] = new List<GuiaHDR>
            {
                new GuiaHDR { NroGuia = "G-00123456", HDR = "HDR-0041", Cumplida = false },
                new GuiaHDR { NroGuia = "G-00123457", HDR = "HDR-0041", Cumplida = true  },
                new GuiaHDR { NroGuia = "G-00123458", HDR = "HDR-0042", Cumplida = false },
            },
                ["87654321"] = new List<GuiaHDR>
            {
                new GuiaHDR { NroGuia = "G-00111111", HDR = "HDR-0050", Cumplida = false },
            },
            };

        // Guías de retiro asignadas al fletero encontrado
        private readonly Dictionary<string, List<GuiaHDR>> _guiasRetiro =
            new Dictionary<string, List<GuiaHDR>>
            {
                ["12345678"] = new List<GuiaHDR>
            {
                new GuiaHDR { NroGuia = "G-00198001", HDR = "HDR-R009", Cumplida = true  },
                new GuiaHDR { NroGuia = "G-00198002", HDR = "HDR-R010", Cumplida = false },
            },
                ["87654321"] = new List<GuiaHDR>
            {
                new GuiaHDR { NroGuia = "G-00222222", HDR = "HDR-R020", Cumplida = false },
            },
            };

        // Nuevas guías de distribución (pendientes de asignar)
        private readonly List<NuevaGuia> _nuevasDistribucion = new List<NuevaGuia>
        {
            new NuevaGuia { NroGuia = "G-00200001", Tamanio = "M", Destino = "Palermo",  HDR = "HDR-0055" },
            new NuevaGuia { NroGuia = "G-00200002", Tamanio = "G", Destino = "Palermo",  HDR = "HDR-0055" },
        };

        // Nuevas guías de retiro (pendientes de asignar)
        private readonly List<NuevaGuia> _nuevasRetiro = new List<NuevaGuia>
        {
            new NuevaGuia { NroGuia = "G-00300010", Tamanio = "P", Destino = "Belgrano", HDR = "HDR-R020" },
        };

        private bool _actualizando = false; // evita recursión en eventos ItemChecked

        public Recepcion_y_despacho()
        {
            InitializeComponent();
        }

        // ── Carga inicial ────────────────────────────────────────────────────

        private void Recepcion_y_despacho_Load(object sender, EventArgs e)
        {
            // Cargar las listas de nuevas guías (siempre visibles)
            CargarNuevaGuias(lvNuevaDistribucion, _nuevasDistribucion);
            CargarNuevaGuias(lvNuevoRetiro, _nuevasRetiro);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonbuscardnifletero_Click(object sender, EventArgs e)
        {

        }

        private void nombretxtbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2DNIFletero(object sender, EventArgs e)
        {
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemChecked(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        private void ActualizarContadores()
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}