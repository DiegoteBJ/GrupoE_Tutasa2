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
            if (File.Exists(@"Datos\FleteroEntidad.json"))
            {
                string json = File.ReadAllText(@"Datos\FleteroEntidad.json");
                fleteros = JsonSerializer.Deserialize<List<FleteroEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(fleteros);
            File.WriteAllText(@"Datos\FleteroEntidad.json", json);
        }
    }
}
