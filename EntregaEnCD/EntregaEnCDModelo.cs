using System;
using System.Collections.Generic;
using System.Linq;
using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.FormularioPrincipal;

namespace GrupoE_Tutasa.EntregaEnCD
{
    public class EntregaEnCDModelo
    {
        private List<Guia> guias = new List<Guia>();

        public EntregaEnCDModelo()
        {
            CargarGuias();
        }

        private void CargarGuias()
        {
            guias = GuiaAlmacen.guias
                .Where(g => g.ModalidadEntrega == ModalidadEntregaEnum.CD
                         && g.CDDestinoId == Program.CDTrabajoId)
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
                         && g.Estado == EstadoGuiaEnum.EN_CD_DESTINO.ToString()
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

                int nuevoMovimientoId = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                    ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                    : 1;

                var movimiento = new MovimientoEstadoGuiaEntidad
                {
                    MovimientoId = nuevoMovimientoId,
                    GuiaId = guiaId,
                    FechaMovimiento = DateTime.Now,
                    Estado = EstadoGuiaEnum.ENTREGADA,
                    Ubicacion = guiaAlmacen.CDDestinoId.ToString()
                };

                MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(movimiento);
                MovimientoEstadoGuiaAlmacen.Guardar();
            }

            Guia guia = guias.FirstOrDefault(g => g.GuiaId == guiaId);
            if (guia != null)
                guia.Estado = EstadoGuiaEnum.ENTREGADA.ToString();

            var cuentaCorriente = CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
                .FirstOrDefault(cc => cc.GuiaId == guiaId);

            if (cuentaCorriente != null)
            {
                cuentaCorriente.FechaEntrega = DateTime.Now;
                cuentaCorriente.FechaMovimiento = DateTime.Now;
                CuentaCorrienteClienteAlmacen.Guardar();
            }
        }
    }
}
