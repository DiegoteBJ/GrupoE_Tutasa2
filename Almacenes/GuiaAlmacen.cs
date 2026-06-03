using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class GuiaAlmacen
    {
        public static List<GuiaEntidad> guias = new();

        static GuiaAlmacen()
        {
            if (File.Exists(@"guias.json"))
            {
                string json = File.ReadAllText(@"guias.json");
                guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(guias);
            File.WriteAllText(@"guias.json", json);
        }
    }
}
