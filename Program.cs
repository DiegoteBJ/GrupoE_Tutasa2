using GrupoE_Tutasa.GenerarHDR;
using GrupoE_Tutasa.GenerarHDRTransporte;

namespace GrupoE_Tutasa.FormularioPrincipal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();

            Application.Run(new FormularioPrincipal());
            // Application.Run(new EntregarEncomiendaAgenciaForm());
            // Application.Run(new EntregaEnCDFormNuevo());
            // Application.Run(new ActualizarHDRForm());
            // Application.Run(new GenerarHDRTransporteForm());
        }
    }
}