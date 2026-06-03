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
            if (File.Exists(@"tarifarios.json"))
            {
                string json = File.ReadAllText(@"tarifarios.json");
                tarifarios = JsonSerializer.Deserialize<List<TarifarioEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(tarifarios);
            File.WriteAllText(@"tarifarios.json", json);
        }
    }
}
