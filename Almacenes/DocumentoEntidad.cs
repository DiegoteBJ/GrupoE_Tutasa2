using System;

namespace GrupoE_Tutasa.Almacenes
{
    public enum TipoDocumentoEnum
    {
        FC,
        NC,
        ND,
        RC
    }

    public class DocumentoEntidad
    {
        public int DocumentoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaDocumento { get; set; }
        public TipoDocumentoEnum TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal NetoGravado { get; set; }
        public decimal IvaDF { get; set; }
        public decimal Total { get; set; }
    }
}
