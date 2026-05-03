using GrupoE_Tutasa.Entrega_en_Agencia;
using GrupoE_Tutasa.Entrega_en_CD;
using GrupoE_Tutasa.Actualizar_HDR;

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

            // Application.Run(new FormularioPrincipal());
            // Application.Run(new EntregarEncomiendaAgenciaForm());
            // Application.Run(new EntregaEnCDFormNuevo());
            Application.Run(new ActualizarHDRForm());
        }
    }
}