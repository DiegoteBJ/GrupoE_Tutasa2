using GrupoE_Tutasa.Entrega_en_Agencia;

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
          //Application.Run(new EntregarEncomiendaAgenciaForm());
        }
    }
}