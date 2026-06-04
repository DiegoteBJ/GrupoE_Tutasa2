using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class DocumentoAlmacen
    {
        public static List<DocumentoEntidad> documentos = new();

        static DocumentoAlmacen()
        {
            if (File.Exists(@"Datos\DocumentoEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\DocumentoEntidad.json");
                    documentos = JsonSerializer.Deserialize<List<DocumentoEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar DocumentoEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(documentos,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\DocumentoEntidad.json", json);
        }
    }
}
