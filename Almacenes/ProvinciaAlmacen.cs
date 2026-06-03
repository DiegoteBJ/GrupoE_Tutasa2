using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ProvinciaAlmacen
    {
        public static List<ProvinciaEntidad> provincias = new();

        static ProvinciaAlmacen()
        {
            if (File.Exists(@"provincias.json"))
            {
                string json = File.ReadAllText(@"provincias.json");
                provincias = JsonSerializer.Deserialize<List<ProvinciaEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(provincias);
            File.WriteAllText(@"provincias.json", json);
        }
    }
}
