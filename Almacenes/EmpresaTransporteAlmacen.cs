using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class EmpresaTransporteAlmacen
    {
        public static List<EmpresaTransporteEntidad> empresaTransportes = new();

        static EmpresaTransporteAlmacen()
        {
            if (File.Exists(@"empresatransporte.json"))
            {
                string json = File.ReadAllText(@"empresatransporte.json");
                empresaTransportes = JsonSerializer.Deserialize<List<EmpresaTransporteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(empresaTransportes);
            File.WriteAllText(@"empresatransporte.json", json);
        }
    }
}
