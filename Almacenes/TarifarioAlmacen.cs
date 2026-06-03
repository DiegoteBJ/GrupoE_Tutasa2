using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class TarifarioAlmacen
    {
        public static List<TarifarioEntidad> tarifarios = new();

        static TarifarioAlmacen()
        {
            if (File.Exists(@"\Datos\TarifarioEntidad.json"))
            {
                string json = File.ReadAllText(@"\Datos\TarifarioEntidad.json");
                tarifarios = JsonSerializer.Deserialize<List<TarifarioEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(tarifarios);
            File.WriteAllText(@"\Datos\TarifarioEntidad.json", json);
        }
    }
}
