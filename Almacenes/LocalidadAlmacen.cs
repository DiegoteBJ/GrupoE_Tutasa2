using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class LocalidadAlmacen
    {
        public static List<LocalidadEntidad> localidads = new();

        static LocalidadAlmacen()
        {
            if (File.Exists(@"localidads.json"))
            {
                string json = File.ReadAllText(@"localidads.json");
                localidads = JsonSerializer.Deserialize<List<LocalidadEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(localidads);
            File.WriteAllText(@"localidads.json", json);
        }
    }
}
