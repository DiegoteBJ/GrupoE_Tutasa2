using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    internal class RecepcionDespachoAgenciaModelo
    {
        // Lista de fleteros
        public List<Fletero> LFleteros => FleteroAlmacen.fleteros
                .OrderBy(f => f.Apellido)
                .ThenBy(f => f.Nombre)
                .Select(f => new Fletero
                {
                    fleteroDNI = f.Dni,
                    fleteroNombre = f.Nombre,
                    fleteroApellido = f.Apellido
                })
                .ToList();

        // Lista de HDR Retiro
        public List<HDRRetiro> LHDRRetiro => HDRRetiroAlmacen.hDRRetiros
                .OrderBy(h => h.FechaEmision)
                .Select(h =>
                {
                    var fletero = FleteroAlmacen.fleteros.FirstOrDefault(f => f.FleteroId == h.FleteroId);

                    return new HDRRetiro
                    {
                        numeroHDR = h.HdrRetiroId.ToString(),
                        fleteroDNI = fletero?.Dni ?? 0,
                        estadoHDR = h.Estado.ToString(),
                        GuiaIds = h.GuiaIds
                    };
                })
                .ToList();


        // Lista de HDR Distribución
        public List<HDRDistribucion> LHDRDistribucion => HDRDistribucionAlmacen.hDRDistribucions
                .Select(h =>
                {
                    var fletero = FleteroAlmacen.fleteros.FirstOrDefault(f => f.FleteroId == h.FleteroId);

                    return new HDRDistribucion
                    {
                        numeroHDR = h.HdrDistribucionId.ToString(),
                        fleteroDNI = fletero?.Dni ?? 0,
                        estadoHDR = h.Estado.ToString(),
                        GuiaIds = h.GuiaIds
                    };
                })
                .ToList();

        // Lista de Guías
        public List<Guia> LGuias => GuiaAlmacen.guias
        .Select(g => new Guia
        {
            guiaId = g.GuiaId,
            tipo = g.TipoCaja.ToString(),
            estado = g.Estado.ToString()
        })
        .ToList();
    }

}

