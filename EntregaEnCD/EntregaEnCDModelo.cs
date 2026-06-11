using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GrupoE_Tutasa.EntregaEnCD
{
    public class EntregaEnCDModelo
    {
        private List<Guia> guias = new List<Guia>();

        public EntregaEnCDModelo()
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
                .Where(g => g.ModalidadEntrega.ToString() == "CD" || g.ModalidadEntrega.ToString() == "1")
                .Select(g => new Guia
                {
                    GuiaId = g.GuiaId,
                    DniDestinatario = g.DniDestinatario,
                    NombreDestinatario = g.NombreDestinatario,
                    ApellidoDestinatario = g.ApellidoDestinatario,
                    Tamanio = g.TipoCaja.ToString(),
                    Estado = g.Estado.ToString(),
                    UbicacionActual = $"CD destino {g.CDDestinoId}"
                })
                .ToList();
        }

        public List<Guia> BuscarGuiasPendientesEnCD(long dni)
        {
            return guias
                .Where(g => g.DniDestinatario == dni
                         && g.Estado == "PENDIENTE_DE_ENTREGA"
                         && g.UbicacionActual.Contains("CD"))
                .ToList();
        }

        public Guia BuscarGuiaPorDni(long dni)
        {
            return guias.FirstOrDefault(g => g.DniDestinatario == dni);
        }

        public void ConfirmarEntrega(int guiaId)
        {
            var guiaAlmacen = GuiaAlmacen.guias
                .FirstOrDefault(g => g.GuiaId == guiaId);

            if (guiaAlmacen != null)
            {
                guiaAlmacen.Estado = EstadoGuiaEnum.ENTREGADA;
                GuiaAlmacen.Guardar();
            }

            Guia guia = guias.FirstOrDefault(g => g.GuiaId == guiaId);

            if (guia != null)
            {
                guia.Estado = "ENTREGADA";
            }

            var cuentaCorriente = CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
                .FirstOrDefault(cc => cc.GuiaId == guiaId);

            if (cuentaCorriente != null)
            {
                cuentaCorriente.FechaEntrega = DateTime.Now;
                CuentaCorrienteClienteAlmacen.Guardar();
            }
        }

        private class GuiaJson
        {
            public int GuiaId { get; set; }
            public long DniDestinatario { get; set; }
            public string NombreDestinatario { get; set; } = "";
            public string ApellidoDestinatario { get; set; } = "";
            public object TipoCaja { get; set; } = "";
            public object Estado { get; set; } = "";
            public object ModalidadEntrega { get; set; } = "";
            public int CDDestinoId { get; set; }
        }
    }
}