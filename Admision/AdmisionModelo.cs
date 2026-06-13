using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.EmitirFactura;
using GrupoE_Tutasa.FormularioPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace GrupoE_Tutasa.Admision
{
    internal class AdmisionModelo
    {
        int CDTrabajoId = Program.CDTrabajoId;
        public List<GuiasAAdmitir> LGuiasAAdmitir =>
        GuiaAlmacen.guias
        .Where(g => g.Estado == EstadoGuiaEnum.RENDIDA && g.CDOrigenId == Program.CDTrabajoId)
        .Select(g => new GuiasAAdmitir
        {
            Id = g.GuiaId,
            clienteID = g.ClienteId,
            numeroGuia = g.GuiaId,
            CDOrigenId = g.CDOrigenId,
            CDDestinoId = g.CDDestinoId,
            tamaño = g.TipoCaja.ToString(),
            estadoGuia = g.Estado.ToString(),
            observaciones = g.ObservacionesAdmision,
            tipoImposicion = g.ModalidadImposicion.ToString().Substring(0, 1),
            tipoEntrega = g.ModalidadEntrega.ToString().Substring(0, 1),
            tarifarioId = g.TarifarioId
        })
        .ToList();
                
        public List<Cajas> LCajas =>
            Enum.GetValues<TipoCajaEnum>()
                .Select((e, i) => new Cajas { ID = i + 1, nombre = e.ToString() })
                .ToList();

        public decimal ObtenerCoeficiente(int origenId, int destinoId, string tipoCaja)
        {
            if (origenId == destinoId)
                return 0;

            var tarifa = TarifaTransporteAlmacen.tarifaTransportes
                .FirstOrDefault(t =>
                    (t.CDOrigenId == origenId && t.CDDestinoId == destinoId) ||
                    (t.CDOrigenId == destinoId && t.CDDestinoId == origenId));

            if (tarifa == null)
                throw new Exception($"No se encontró tarifa de transporte para CD origen {origenId} y CD destino {destinoId}.");

            return tipoCaja switch
            {
                "S"  => tarifa.CoeficienteS,
                "M"  => tarifa.CoeficienteM,
                "L"  => tarifa.CoeficienteL,
                "XL" => tarifa.CoeficienteXL,
            };
        }

        public decimal ObtenerTarifaRetiroDomicilio(int tarifarioId)
        {
            var tarifa = TarifarioAlmacen.tarifarios
                .FirstOrDefault(t => t.TarifarioId == tarifarioId);
            return tarifa?.TarifaRetiroDomicilio ?? 0;
        }

        public decimal ObtenerTarifaEntregaAgencia(int tarifarioId)
        {
            var tarifa = TarifarioAlmacen.tarifarios
                .FirstOrDefault(t => t.TarifarioId == tarifarioId);
            return tarifa?.TarifaEntregaAgencia ?? 0;
        }

        public decimal ObtenerTarifaDistribucionDomicilio(int tarifarioId)
        {
            var tarifa = TarifarioAlmacen.tarifarios
                .FirstOrDefault(t => t.TarifarioId == tarifarioId);
            return tarifa?.TarifaDistribucionDomicilio ?? 0;
        }
        public List<CuentaCorrienteClienteEntidad> LCCClientes =>
        CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes.ToList();

        public void AdmitirGuia(int guiaId)
        {
            var guia = GuiaAlmacen.guias
                .FirstOrDefault(g => g.GuiaId == guiaId);

            guia.CDActualId = CDTrabajoId;
            if (guia != null)
            {
                if (guia.CDDestinoId == guia.CDActualId)
                    { guia.Estado = EstadoGuiaEnum.EN_CD_DESTINO;}
                else
                    { guia.Estado = EstadoGuiaEnum.ADMITIDA;}
                GuiaAlmacen.Guardar();

                int nuevoMovimientoId = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                    ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                    : 1;

                var movimiento = new MovimientoEstadoGuiaEntidad
                {
                    MovimientoId = nuevoMovimientoId,
                    GuiaId = guia.GuiaId,
                    FechaMovimiento = DateTime.Now,
                    Estado = guia.Estado,
                    Ubicacion = "En CD: " + guia.CDActualId.ToString()
                };

                MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(movimiento);
                MovimientoEstadoGuiaAlmacen.Guardar();
            }
        }
        public void CrearCCCliente(GuiasAAdmitir guia)
        {
            int nuevoId = CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes.Count > 0
                ? CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes.Max(cc => cc.CcClienteId) + 1
                : 1;

            var nuevaCC = new CuentaCorrienteClienteEntidad
            {
                CcClienteId = nuevoId,
                ClienteId = guia.clienteID,
                GuiaId = guia.numeroGuia,
                FechaMovimiento = DateTime.Now,
                FechaEntrega = DateTime.MaxValue,
                PrecioImposicion = guia.importeImposicion,
                PrecioTransporte = guia.importeTransporte,
                PrecioEntrega = guia.importeEntrega,
                PrecioCalculadoTotal = guia.importe,
                EmpresaTransporteId = 0,
                Facturado = false,
                DocumentoId = 0
            };

            CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes.Add(nuevaCC);
            CuentaCorrienteClienteAlmacen.Guardar();
        }
        public void CambiarTamañoGuia(int guiaId, string nuevoTamaño)
        {
            var guia = GuiaAlmacen.guias
                .FirstOrDefault(g => g.GuiaId == guiaId);

            if (guia != null)
            {
                guia.TipoCaja = Enum.Parse<TipoCajaEnum>(nuevoTamaño);
            }
        }
        public void RechazarGuia(int guiaId, string observaciones)
        {
            var guia = GuiaAlmacen.guias
                .FirstOrDefault(g => g.GuiaId == guiaId);

            if (guia != null)
            {
                guia.Estado = EstadoGuiaEnum.CANCELADA;
                guia.ObservacionesAdmision = observaciones;
            }
            GuiaAlmacen.Guardar();
        }
    }
}
