using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class HDRDistribucionAlmacen
    {
        public static List<HDRDistribucionEntidad> hDRDistribucions = new();

        static HDRDistribucionAlmacen()
        {
            if (File.Exists(@"hdrdistribucion.json"))
            {
                string json = File.ReadAllText(@"hdrdistribucion.json");
                hDRDistribucions = JsonSerializer.Deserialize<List<HDRDistribucionEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRDistribucions);
            File.WriteAllText(@"hdrdistribucion.json", json);
        }
    }
}
