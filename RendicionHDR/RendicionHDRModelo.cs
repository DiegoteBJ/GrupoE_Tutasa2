using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.FormularioPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.RendicionHDR
{
    internal class RendicionHDRModelo
    {
        public int CDTrabajoId = Program.CDTrabajoId;

        public List<Fletero> LFleteros => FleteroAlmacen.fleteros
            .Select(f => new Fletero
            {
                fleteroDNI = f.Dni,
                fleteroNombre = f.Nombre,
                fleteroApellido = f.Apellido
            })
            .ToList();

        public List<HDRRetiro> LHDRRetiro =>
            HDRRetiroAlmacen.hDRRetiros
                .Select(h =>
                {
                    var fletero = FleteroAlmacen.fleteros
                        .FirstOrDefault(f => f.FleteroId == h.FleteroId);
                    return new HDRRetiro
                    {
                        numeroHDR = h.HdrRetiroId.ToString(),
                        fleteroDNI = fletero?.Dni ?? 0,
                        estadoHDR = h.Estado.ToString(),
                        fechaHDR = h.FechaEmision,
                        GuiaIds = h.GuiaIds
                    };
                })
                .ToList();

        public List<HDRDistribucion> LHDRDistribucion =>
            HDRDistribucionAlmacen.hDRDistribucions
                .Select(h =>
                {
                    var fletero = FleteroAlmacen.fleteros
                        .FirstOrDefault(f => f.FleteroId == h.FleteroId);
                    return new HDRDistribucion
                    {
                        numeroHDR = h.HdrDistribucionId.ToString(),
                        fleteroDNI = fletero?.Dni ?? 0,
                        estadoHDR = h.Estado.ToString(),
                        fechaHDR = h.FechaEmision,
                        GuiaIds = h.GuiaIds
                    };
                })
                .ToList();

        public List<Guia> ObtenerGuiasPorIds(List<int> ids) => GuiaAlmacen.guias
            .Where(g => ids.Contains(g.GuiaId))
            .Select(g =>
            {
                var cliente = ClienteAlmacen.clientes
                    .FirstOrDefault(c => c.ClienteId == g.ClienteId);
                return new Guia
                {
                    guiaId = g.GuiaId,
                    remitente = cliente != null
                        ? (!string.IsNullOrWhiteSpace(cliente.RazonSocial)
                            ? cliente.RazonSocial
                            : $"{cliente.Nombre} {cliente.Apellido}")
                        : string.Empty,
                    destinatario = $"{g.NombreDestinatario} {g.ApellidoDestinatario}",
                    domicilio = g.DomicilioEntrega != null
                        ? $"{g.DomicilioEntrega.Calle} {g.DomicilioEntrega.Numero}"
                        : string.Empty,
                    tamanio = g.TipoCaja.ToString(),
                    intentosEntrega = g.IntentosDeEntrega,
                    resultado = "Pendiente"
                };
            })
            .ToList();

        public void ConfirmarRendicionRetiro(string numeroHDR, List<ResultadoGuia> resultados)
        {
            var hdrEntidad = HDRRetiroAlmacen.hDRRetiros
                .FirstOrDefault(h => h.HdrRetiroId.ToString() == numeroHDR);
            if (hdrEntidad == null) return;

            AplicarResultadosGuiasRetiro(resultados);

            hdrEntidad.Estado = EstadoHDRRetiroEnum.RENDIDA;
            hdrEntidad.FechaRendicion = DateTime.Now;
            HDRRetiroAlmacen.Guardar();
        }

        public void ConfirmarRendicionDistribucion(string numeroHDR, List<ResultadoGuia> resultados)
        {
            var hdrEntidad = HDRDistribucionAlmacen.hDRDistribucions
                .FirstOrDefault(h => h.HdrDistribucionId.ToString() == numeroHDR);
            if (hdrEntidad == null) return;

            AplicarResultadosGuiasDistribucion(resultados);

            hdrEntidad.Estado = EstadoHDRDistribucionEnum.RENDIDA;
            hdrEntidad.FechaRendicion = DateTime.Now;
            HDRDistribucionAlmacen.Guardar();
        }

        private void AplicarResultadosGuiasRetiro(List<ResultadoGuia> resultados)
        {
            int nuevoMovimientoId = ProximoMovimientoId();

            foreach (var resultado in resultados)
            {
                var guiaEntidad = GuiaAlmacen.guias
                    .FirstOrDefault(g => g.GuiaId == resultado.guiaId);
                if (guiaEntidad == null) continue;

                EstadoGuiaEnum nuevoEstado;
                string ubicacion;

                if (resultado.resultado == "Cumplida")
                {
                    nuevoEstado = EstadoGuiaEnum.RENDIDA;
                    ubicacion = "En CD: " + CDTrabajoId;
                }
                else
                {
                    nuevoEstado = EstadoGuiaEnum.A_RETIRAR;
                    ubicacion = "Retiro no realizado";
                }

                guiaEntidad.Estado = nuevoEstado;

                MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(new MovimientoEstadoGuiaEntidad
                {
                    MovimientoId = nuevoMovimientoId++,
                    GuiaId = guiaEntidad.GuiaId,
                    FechaMovimiento = DateTime.Now,
                    Estado = nuevoEstado,
                    Ubicacion = ubicacion
                });
            }

            GuiaAlmacen.Guardar();
            MovimientoEstadoGuiaAlmacen.Guardar();
        }

        private void AplicarResultadosGuiasDistribucion(List<ResultadoGuia> resultados)
        {
            int nuevoMovimientoId = ProximoMovimientoId();

            foreach (var resultado in resultados)
            {
                var guiaEntidad = GuiaAlmacen.guias
                    .FirstOrDefault(g => g.GuiaId == resultado.guiaId);
                if (guiaEntidad == null) continue;

                EstadoGuiaEnum nuevoEstado;
                string ubicacion;

                if (resultado.resultado == "Cumplida")
                {
                    if (guiaEntidad.ModalidadEntrega == ModalidadEntregaEnum.AGENCIA)
                    {
                        nuevoEstado = EstadoGuiaEnum.EN_AGENCIA_DESTINO;
                        ubicacion = "En agencia: " + guiaEntidad.AgenciaDestinoId;
                    }
                    else
                    {
                        nuevoEstado = EstadoGuiaEnum.ENTREGADA;
                        ubicacion = "Entregada al destinatario";

                        var cuentaCorriente = CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
                            .FirstOrDefault(cc => cc.GuiaId == guiaEntidad.GuiaId);
                        if (cuentaCorriente != null)
                        {
                            cuentaCorriente.FechaEntrega = DateTime.Now;
                            cuentaCorriente.FechaMovimiento = DateTime.Now;
                        }
                    }
                }
                else
                {
                    nuevoEstado = EstadoGuiaEnum.PENDIENTE_DE_ENTREGA;
                    guiaEntidad.IntentosDeEntrega++;
                    ubicacion = "Pendiente de entrega";
                }

                guiaEntidad.Estado = nuevoEstado;

                MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(new MovimientoEstadoGuiaEntidad
                {
                    MovimientoId = nuevoMovimientoId++,
                    GuiaId = guiaEntidad.GuiaId,
                    FechaMovimiento = DateTime.Now,
                    Estado = nuevoEstado,
                    Ubicacion = ubicacion
                });
            }

            GuiaAlmacen.Guardar();
            MovimientoEstadoGuiaAlmacen.Guardar();
            CuentaCorrienteClienteAlmacen.Guardar();
        }

        private int ProximoMovimientoId() =>
            MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                : 1;
    }
}
