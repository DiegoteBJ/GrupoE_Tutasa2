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
            if (File.Exists(@"Datos\ServicioTransporteEntidad.json"))
            {
                string json = File.ReadAllText(@"Datos\ServicioTransporteEntidad.json");
                servicioTransportes = JsonSerializer.Deserialize<List<ServicioTransporteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(servicioTransportes);
            File.WriteAllText(@"Datos\ServicioTransporteEntidad.json", json);
        }
    }
}
