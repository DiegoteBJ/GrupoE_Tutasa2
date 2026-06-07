namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// AL.2.1 - Tarifario General
    /// </summary>
    internal class Tarifario
    {
        public int     TarifarioId                 { get; set; }   // PK
        public decimal TarifaRetiroDomicilio        { get; set; }
        public decimal TarifaEntregaAgencia         { get; set; }
        public decimal TarifaDistribucionDomicilio  { get; set; }
    }

    /// <summary>
    /// AL.2.2 - Tarifa Transporte (por ruta CD origen → CD destino)
    /// </summary>
    internal class TarifaTransporte
    {
        public int     CDOrigenId   { get; set; }   // FK → AL.18
        public int     CDDestinoId  { get; set; }   // FK → AL.18
        public decimal CoeficienteS  { get; set; }
        public decimal CoeficienteM  { get; set; }
        public decimal CoeficienteL  { get; set; }
        public decimal CoeficienteXL { get; set; }
    }
}
