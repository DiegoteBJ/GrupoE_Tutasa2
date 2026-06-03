using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class TarifaTransporteAlmacen
    {
        public static List<TarifaTransporteEntidad> tarifaTransportes = new();

        static TarifaTransporteAlmacen()
        {
            if (File.Exists(@"\Datos\TarifaTransporteEntidad.json"))
            {
                string json = File.ReadAllText(@"\Datos\TarifaTransporteEntidad.json");
                tarifaTransportes = JsonSerializer.Deserialize<List<TarifaTransporteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(tarifaTransportes);
            File.WriteAllText(@"\Datos\TarifaTransporteEntidad.json", json);
        }
    }
}
