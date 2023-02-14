namespace FletesLiquidos
{
    internal class FleteConfig
    {

      public string in_EMPRES_TRA { get; set; }
      public int in_EMPID { get; set; }
        public string in_VEHICULO_VEH { get; set; }
        public string in_TIPO_ENTREGA { get; set; }
        public string in_TIPO_PRODUCTO { get; set; }
        public decimal in_R_INICIAL { get; set; }
        public decimal in_R_FINAL { get; set; }
        public decimal in_VALORKM { get; set; }
        public int IN_ID_TIPOLIQUIDACION { get; internal set; }
        public decimal IN_VALORFIJO { get; internal set; }
    }
}