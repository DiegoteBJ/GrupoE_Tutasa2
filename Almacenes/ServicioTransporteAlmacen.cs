using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ServicioTransporteAlmacen
    {
        public static List<ServicioTransporteEntidad> servicioTransportes = new();

        static ServicioTransporteAlmacen()
        {
            if (File.Exists(@"serviciotransporte.json"))
            {
                string json = File.ReadAllText(@"serviciotransporte.json");
                servicioTransportes = JsonSerializer.Deserialize<List<ServicioTransporteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(servicioTransportes);
            File.WriteAllText(@"serviciotransporte.json", json);
        }
    }
}
