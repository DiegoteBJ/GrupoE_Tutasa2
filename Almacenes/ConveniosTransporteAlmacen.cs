using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ConveniosTransporteAlmacen
    {
        public static List<ConveniosTransporteEntidad> conveniosTransportes = new();

        static ConveniosTransporteAlmacen()
        {
            if (File.Exists(@"Datos\ConveniosTransporteEntidad.json"))
            {
                string json = File.ReadAllText(@"Datos\ConveniosTransporteEntidad.json");
                conveniosTransportes = JsonSerializer.Deserialize<List<ConveniosTransporteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(conveniosTransportes);
            File.WriteAllText(@"Datos\ConveniosTransporteEntidad.json", json);
        }
    }
}
