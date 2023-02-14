using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FletesLiquidos
{
    public static class ConceptoDao
    {

        public static void InsertaConcepto(int id, string descripcion, int SumaResta)
        {
            string strSQl = @"ROADNET.FLETESLIQ.ACTUALIZAR_CONCEPTO";

            
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetStoredProcCommand(strSQl);

            db.AddInParameter(command, "p_id", System.Data.DbType.Int32, id);
            db.AddInParameter(command, "p_descripcion", System.Data.DbType.String, descripcion);
            db.AddInParameter(command, "p_sumaresta", System.Data.DbType.Int32, SumaResta);
            db.AddInParameter(command, "p_estado", System.Data.DbType.Int32, 1);





            var ds = db.ExecuteNonQuery(command);


        }

        public static void GetConcepto(int id)
        {

        }

        public static DataSet GetConceptos()
        {
            string strSQl = @"select id_concepto,descripcion, decode(tipo_concepto,1,'SUMA','RESTA') tipo_concepto, ESTADO from roadnet.FLB_CONCEPTOS where estado =1";



            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

          

            var ds = db.ExecuteDataSet(command);
            return ds;


        }

        internal static void EliminarConcepto(int id_concepto)
        {
            var strSQL = @"update roadnet.FLB_CONCEPTOS
                    set estado = 0
                     where id_concepto =:p_id_concepto";

         
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");          
            command = db.GetSqlStringCommand(strSQL);

            db.AddInParameter(command, "p_id_concepto", System.Data.DbType.Int32, id_concepto);
            var ds = db.ExecuteNonQuery(command);


         
        }
    }
}
