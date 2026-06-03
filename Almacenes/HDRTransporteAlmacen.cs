using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class HDRTransporteAlmacen
    {
        public static List<HDRTransporteEntidad> hDRTransportes = new();

        static HDRTransporteAlmacen()
        {
            if (File.Exists(@"\Datos\HDRTransporteEntidad.json"))
            {
                string json = File.ReadAllText(@"\Datos\HDRTransporteEntidad.json");
                hDRTransportes = JsonSerializer.Deserialize<List<HDRTransporteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRTransportes);
            File.WriteAllText(@"\Datos\HDRTransporteEntidad.json", json);
        }
    }
}
