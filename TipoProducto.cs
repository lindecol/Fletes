using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FletesLiquidos
{
    class TipoProducto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public static List<TipoProducto> getTipoProducto()
        {
            List<TipoProducto> producto = new List<TipoProducto>();
            producto.Add(new TipoProducto
            {
                Codigo = "CO2",
                Nombre = "CO2"
            });

            producto.Add(new TipoProducto
            {
                Codigo = "GASES",
                Nombre = "GASES"
            });

            return producto;

        }
    }



    public class LocalNacional {

        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public static List<LocalNacional> getLocalNacional()
        {
            List<LocalNacional> producto = new List<LocalNacional>();
            producto.Add(new LocalNacional
            {
                Codigo = "LOCAL",
                Nombre = "LOCAL"
            });

            producto.Add(new LocalNacional
            {
                Codigo = "NACIONAL",
                Nombre = "NACIONAL"
            });

            return producto;

        }

    }
   

}
