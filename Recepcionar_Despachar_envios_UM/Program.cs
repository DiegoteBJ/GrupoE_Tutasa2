using System;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ ABRIR TU FORM UM (el que se ve en el explorador)
            Application.Run(new FormRecepcionYDespachoUM());
        }
    }
}