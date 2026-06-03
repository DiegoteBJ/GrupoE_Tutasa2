using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class HDRRetiroAlmacen
    {
        public static List<HDRRetiroEntidad> hDRRetiros = new();

        static HDRRetiroAlmacen()
        {
            if (File.Exists(@"hdrretiro.json"))
            {
                string json = File.ReadAllText(@"hdrretiro.json");
                hDRRetiros = JsonSerializer.Deserialize<List<HDRRetiroEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRRetiros);
            File.WriteAllText(@"hdrretiro.json", json);
        }
    }
}
