using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class DocumentoAlmacen
    {
        public static List<DocumentoEntidad> documentos = new();

        static DocumentoAlmacen()
        {
            if (File.Exists(@"\Datos\DocumentoEntidad.json"))
            {
                string json = File.ReadAllText(@"\Datos\DocumentoEntidad.json");
                documentos = JsonSerializer.Deserialize<List<DocumentoEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(documentos);
            File.WriteAllText(@"\Datos\DocumentoEntidad.json", json);
        }
    }
}
