using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FletesLiquidos
{
    internal class ReportePlantillTransporte
    {
        public string Compania { get; set; }
        public string  Transportadora { get; set; }
        public string FechaIni { get; set; }
        public string FechaFin { get; set; }
        public Double TarifaXKm { get; set; }
        public string Fuente { get; set; }
        public string CentroCosto { get; set; }
        public Double TotalKm { get; set; }
        public Double TotalKmCOP { get; set; }
        public Double TotalCostoFijoCOP { get; set; }
        public Double TotalAdicionalesCOP { get; set; }
        public Double TotalXFuente { get; set; }
    }

    internal class ReporteDetalleAdicionales
    {
        public string Adicional { get; set; }
        public Double Total { get; set; }
    }

}
