using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GrupoE_Tutasa.EntregaEnAgencia
{
    public class EntregaEnAgenciaModelo
    {
        private List<Guia> guias = new List<Guia>();

        public EntregaEnAgenciaModelo()
        {
            CargarGuiasDesdeJson();
        }

        private void CargarGuiasDesdeJson()
        {
            string rutaArchivo = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "GuiaEntidad.json"
            );

            if (!File.Exists(rutaArchivo))
            {
                guias = new List<Guia>();
                return;
            }

            string json = File.ReadAllText(rutaArchivo);

            List<GuiaJson> guiasJson = JsonSerializer.Deserialize<List<GuiaJson>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<GuiaJson>();

            guias = guiasJson
                .Select(g => new Guia
                {
                    GuiaId = g.GuiaId,
                    DniDestinatario = g.DniDestinatario,
                    NombreDestinatario = g.NombreDestinatario,
                    ApellidoDestinatario = g.ApellidoDestinatario,
                    Tamanio = g.TipoCaja,
                    Estado = g.Estado,
                    UbicacionActual = $"Agencia destino {g.AgenciaDestinoId}"
                })
                .ToList();
        }

        public List<Guia> BuscarGuiasPendientesEnAgencia(long dni)
        {
            return guias
                .Where(g => g.DniDestinatario == dni
                         && g.Estado == "PENDIENTE_DE_ENTREGA"
                         && g.UbicacionActual.Contains("Agencia"))
                .ToList();
        }

        public Guia BuscarGuiaPorDni(long dni)
        {
            return guias.FirstOrDefault(g => g.DniDestinatario == dni);
        }

        public void ConfirmarEntrega(int guiaId)
        {
            Guia guia = guias.FirstOrDefault(g => g.GuiaId == guiaId);

            if (guia != null)
            {
                guia.Estado = "ENTREGADA";
                GuardarGuiasEnJson(guiaId);
            }
        }

        private void GuardarGuiasEnJson(int guiaId)
        {
            string rutaArchivo = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "GuiaEntidad.json"
            );

            string json = File.ReadAllText(rutaArchivo);

            List<GuiaJson> guiasJson = JsonSerializer.Deserialize<List<GuiaJson>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<GuiaJson>();

            GuiaJson guiaJson = guiasJson.FirstOrDefault(g => g.GuiaId == guiaId);

            if (guiaJson != null)
            {
                guiaJson.Estado = "ENTREGADA";
            }

            string jsonActualizado = JsonSerializer.Serialize(
                guiasJson,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(rutaArchivo, jsonActualizado);
        }
        private class GuiaJson
        {
            public int GuiaId { get; set; }
            public long DniDestinatario { get; set; }
            public string NombreDestinatario { get; set; } = "";
            public string ApellidoDestinatario { get; set; } = "";
            public string TipoCaja { get; set; } = "";
            public string Estado { get; set; } = "";
            public string ModalidadEntrega { get; set; } = "";
            public int AgenciaDestinoId { get; set; }
        }
    }
}