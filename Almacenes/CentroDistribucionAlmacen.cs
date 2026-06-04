using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class CentroDistribucionAlmacen
    {
        public static List<CentroDistribucionEntidad> centroDistribucions = new();

        static CentroDistribucionAlmacen()
        {
            if (File.Exists(@"Datos\CentroDistribucionEntidad.json"))
            {
                string json = File.ReadAllText(@"Datos\CentroDistribucionEntidad.json");
                centroDistribucions = JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(centroDistribucions);
            File.WriteAllText(@"Datos\CentroDistribucionEntidad.json", json);
        }
    }
}
