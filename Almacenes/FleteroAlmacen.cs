using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class FleteroAlmacen
    {
        public static List<FleteroEntidad> fleteros = new();

        static FleteroAlmacen()
        {
            if (File.Exists(@"fleteros.json"))
            {
                string json = File.ReadAllText(@"fleteros.json");
                fleteros = JsonSerializer.Deserialize<List<FleteroEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(fleteros);
            File.WriteAllText(@"fleteros.json", json);
        }
    }
}
