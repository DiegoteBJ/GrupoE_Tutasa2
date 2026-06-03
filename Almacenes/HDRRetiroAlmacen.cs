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
            if (File.Exists(@"\Datos\HDRRetiroEntidad.json"))
            {
                string json = File.ReadAllText(@"\Datos\HDRRetiroEntidad.json");
                hDRRetiros = JsonSerializer.Deserialize<List<HDRRetiroEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRRetiros);
            File.WriteAllText(@"\Datos\HDRRetiroEntidad.json", json);
        }
    }
}
