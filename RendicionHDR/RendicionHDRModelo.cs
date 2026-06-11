using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RendicionHDR
{
    internal class RendicionHDRModelo
    {
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

        public List<HDRDistribucion> LHDRDistribucion => HDRDistribucionAlmacen.hDRDistribucions
        .Select(h =>
        {
            var fletero =
                FleteroAlmacen.fleteros
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


        public List<Guia> LGuias => GuiaAlmacen.guias
        .Select(g => new Guia
        {
            guiaId = g.GuiaId,
            destinatario = $"{g.NombreDestinatario} {g.ApellidoDestinatario}",
            domicilio = g.DomicilioEntrega != null
                ? $"{g.DomicilioEntrega.Calle} {g.DomicilioEntrega.Numero}"
                : string.Empty,
            tamanio = g.TipoCaja.ToString(),
            intentosEntrega = g.IntentosDeEntrega,
            resultado = "Pendiente"
        })
        .ToList();

    }
}
