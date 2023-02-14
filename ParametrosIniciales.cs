using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FletesLiquidos
{
    public static class ParametrosIniciales
    {
        public static int UsrId { get; internal set; }
        public static int EmpID { get; set; }
       

        public static string GetBase(int empresa)
        {
            return empresa == 21 ? "COOX" : "COLC";

        }


    }
}
