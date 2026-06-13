using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GrupoE_Tutasa.Almacenes;

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
                    Tamanio = g.TipoCaja.ToString(),
                    Estado = g.Estado.ToString(),
                    UbicacionActual = $"Agencia destino {g.AgenciaDestinoId}"
                })
                .ToList();
        }

        public List<Guia> BuscarGuiasPendientesEnAgencia(long dni)
        {
            return guias
                .Where(g => g.DniDestinatario == dni
                         && g.Estado == "EN_CD_DESTINO"
                         && g.UbicacionActual.Contains("Agencia"))
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

                int nuevoMovimientoId = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                    ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                    : 1;

                var movimiento = new MovimientoEstadoGuiaEntidad
                {
                    MovimientoId = nuevoMovimientoId,
                    GuiaId = guiaId,
                    FechaMovimiento = DateTime.Now,
                    Estado = EstadoGuiaEnum.ENTREGADA,
                    Ubicacion = guiaAlmacen.AgenciaDestinoId.ToString()
                };

                MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(movimiento);
                MovimientoEstadoGuiaAlmacen.Guardar();
            }

            Guia guia = guias.FirstOrDefault(g => g.GuiaId == guiaId);

            if (guia != null)
            {
                guia.Estado = "ENTREGADA";
                GuardarGuiasEnJson(guiaId);
            }

            var cuentaCorriente = CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
                .FirstOrDefault(cc => cc.GuiaId == guiaId);

            if (cuentaCorriente != null)
            {
                cuentaCorriente.FechaEntrega = DateTime.Now;
                cuentaCorriente.FechaMovimiento = DateTime.Now;
                CuentaCorrienteClienteAlmacen.Guardar();
                //GuardarFechaEntregaEnCuentaCorrienteJson(guiaId);
            }
        }
        private void GuardarFechaEntregaEnCuentaCorrienteJson(int guiaId)
        {
            string rutaArchivo = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "CuentaCorrienteClienteEntidad.json"
            );

            if (!File.Exists(rutaArchivo))
            {
                return;
            }

            string json = File.ReadAllText(rutaArchivo);

            List<CuentaCorrienteJson> cuentas = JsonSerializer.Deserialize<List<CuentaCorrienteJson>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<CuentaCorrienteJson>();

            CuentaCorrienteJson cuenta = cuentas.FirstOrDefault(c => c.GuiaId == guiaId);

            if (cuenta != null)
            {
                cuenta.FechaEntrega = DateTime.Now;
            }

            string jsonActualizado = JsonSerializer.Serialize(
                cuentas,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(rutaArchivo, jsonActualizado);
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
            public object TipoCaja { get; set; } = "";
            public object Estado { get; set; } = "";
            public object ModalidadEntrega { get; set; } = "";
            public int AgenciaDestinoId { get; set; }
        }
        private class CuentaCorrienteJson
        {
            public int CcClienteId { get; set; }
            public int ClienteId { get; set; }
            public int GuiaId { get; set; }
            public DateTime FechaMovimiento { get; set; }
            public DateTime FechaEntrega { get; set; }
            public decimal PrecioImposicion { get; set; }
            public decimal PrecioTransporte { get; set; }
            public decimal PrecioEntrega { get; set; }
            public decimal PrecioCalculadoTotal { get; set; }
            public int EmpresaTransporteId { get; set; }
            public bool Facturado { get; set; }
            public int DocumentoId { get; set; }
        }
    }
}