using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class MovimientoEstadoGuiaAlmacen
    {
        public static List<MovimientoEstadoGuiaEntidad> movimientoEstadoGuias = new();

        static MovimientoEstadoGuiaAlmacen()
        {
            if (File.Exists(@"Datos\MovimientoEstadoGuiaEntidad.json"))
            {
                string json = File.ReadAllText(@"Datos\MovimientoEstadoGuiaEntidad.json");
                movimientoEstadoGuias = JsonSerializer.Deserialize<List<MovimientoEstadoGuiaEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(movimientoEstadoGuias);
            File.WriteAllText(@"Datos\MovimientoEstadoGuiaEntidad.json", json);
        }
    }
}
