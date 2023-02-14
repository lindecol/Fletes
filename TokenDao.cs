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
   public   class TokenDao
    {
        public static DataTable GetEncabezadoToken(int token)
        {

             string strSQl = @"  select
token,
                        (select usrdsc  from cs_usuario
                        where usrid = a.usrid) usuario,
                        empresa_tra,
                        tipoentrega,
                        (select empnmb from cs_empresa where empid = a.empid) empresa,
                        trunc(fecha_ini) fecha_ini,
                        trunc(fecha_fin) fecha_fin
                        from ROADNET.FLH_ENCABEZADOFLETE a
                        where token= :p_token ";

            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            db.AddInParameter(command, "p_token", System.Data.DbType.Int64, token);
            var ds = db.ExecuteDataSet(command);
            return ds.Tables[0];
            

        }


        public static DataTable GetAdicionales(int token)
        {
            string strSQl = @"   SELECT  DESCRIPCION, SUM(VALOR) TOTAL FROM FLH_ADICIONALES A
                     INNER JOIN FLB_CONCEPTOS B ON A.ID_CONCEPTO= B.ID_CONCEPTO
                     WHERE EXISTS (
                     SELECT * FROM FLH_RUTASPROCESADAS WHERE TOKEN= :P_TOKEN  AND HOJARUTA = A.HOJRUT_REP
                     )
                     GROUP BY DESCRIPCION";


            try
            {


                DbCommand command;
                Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
                command = db.GetSqlStringCommand(strSQl);
                db.AddInParameter(command, "P_TOKEN", System.Data.DbType.Int64, token);
                var ds = db.ExecuteDataSet(command);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {

                throw ex;
                    }

        }


        public static DataTable GetReporteLiquidacion(int token)
        {
            string strsql = @"  SELECT DECODE(CAB.EMPID,21,'OXIGENOS DE COLOMBIA',22,'LIQUIDO CARBONICO') COMPANIA,
         EMPRESA_TRA Transportadora,
         CAB.FECHA_INI,
         CAB.FECHA_FIN,
        PLANTA Fuente,
         CENTROCOSTO,
         trunc(SUM (VALOR),2) TotalKmCOP,
         trunc(SUM (TOTAL),2) TotalKm,
         trunc(SUM (COSTOFIJO),2) TotalCostoFijoCOP,
         trunc(SUM (ADICIONAL),2) TotalAdicionalesCOP,
         VALORREGLA
    FROM (SELECT A.TOKEN,
            A.HOJARUTA,
                 (SELECT CODCLIENTE || '-' || NOMBRECLIENTE
                    FROM ROADNET.FLH_RUTASPROCESADAS B
                   WHERE     A.TOKEN = B.TOKEN
                         AND A.HOJARUTA = B.HOJARUTA
                         AND CONSECUTIVO = 1)
                    PLANTA,
                 A.SUCURSALCLIENTE CENTROCOSTO,
                 CODCLIENTE,
                 NOMBRECLIENTE,
                 TRUNC ( (NVL (TOTAL, 0) * NVL (VALORREGLA, 0)), 2) VALOR,
                   DECODE (TANQUE_REP,
                           NULL, 0,
                           FLETESLIQ.ADICIONALESHR (HOJARUTA, TOKEN))
                 / (SELECT COUNT (*)
                      FROM ROADNET.FLH_RUTASPROCESADAS B
                     WHERE     TOKEN = :P_TOKEN
                           AND A.HOJARUTA = B.HOJARUTA
                           AND TANQUE_REP IS NOT NULL)
                    ADICIONAL,
                 DECODE (TANQUE_REP,
                         NULL, 0,
                         NVL (FLETESLIQ.COSTOFIJO (HOJARUTA, TOKEN), 0))
                    COSTOFIJO,
                 TOTAL,
                 VALORREGLA
            FROM ROADNET.FLH_RUTASPROCESADAS A
           WHERE TOKEN = :P_TOKEN) DATOS
           INNER JOIN FLH_ENCABEZADOFLETE CAB ON DATOS.TOKEN=CAB.TOKEN
GROUP BY CAB.EMPID,CAB.EMPRESA_TRA, CAB.FECHA_INI,
         CAB.FECHA_FIN,PLANTA, CENTROCOSTO,VALORREGLA
         ";


            try
            {


                DbCommand command;
                Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
                command = db.GetSqlStringCommand(strsql);
                db.AddInParameter(command, "p_token", System.Data.DbType.Int64, token);
                var ds = db.ExecuteDataSet(command);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        internal static object GetTokens(DateTime fini, DateTime ffin)
        {
            string strSQl = @"  SELECT (SELECT empnmb
                                FROM CS_EMPRESA
                               WHERE GRPECID = 1 AND EMPID = A.EMPID)
                                EMPID,
                             TOKEN,
                             (SELECT USRDSC
                                FROM CS_USUARIO
                               WHERE USRID = A.USRID)
                                USRID,
                             EMPRESA_TRA || '-' || nOMBRE_TRA EMPRESA_TRA,
                             tipoentrega,
                             fecha_ini,
                             fecha_fin,
                             fecha
                        FROM    ROADNET.FLH_ENCABEZADOFLETE A
                             INNER JOIN
                                (SELECT 21 EMPID, empres_tra, nombre_tra
                                   FROM SPRAX_M_TRANSP
                                  WHERE estado_auD = 'A'
                                 UNION ALL
                                 SELECT 22 EMPID, empres_tra, nombre_tra
                                   FROM SPRAX_M_TRANSP@COLC
                                  WHERE estado_auD = 'A') b
                             ON a.empresa_tra = b.empres_tra
                             WHERE  TRUNC(FECHA) BETWEEN TRUNC(:P_FECHA_INI) AND TRUNC(:P_FECHA_FIN)
                    ORDER BY fecha DESc
  ";

            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            db.AddInParameter(command, "P_FECHA_INI", System.Data.DbType.Date, fini);
            db.AddInParameter(command, "P_FECHA_FIN", System.Data.DbType.Date, ffin);
            var ds = db.ExecuteDataSet(command);
            return ds.Tables[0];
        }

        public static DataTable GetErrores(int token)
        {
            string strSQl = @"select * from ROADNET.FLH_LOG where v_token = :p_token";

            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            db.AddInParameter(command, "p_token", System.Data.DbType.Int64, token);
            var ds = db.ExecuteDataSet(command);
            return ds.Tables[0];
        }

        public static DataTable GetHrProcesadas(int token)
        {
            string strSQl = @"
                             select 
                             hojaruta,sucursalcliente,codcliente,nombrecliente,tanque_rep,tanquedsc,kmllegada,trunc(kilometrajedif)kilometrajedif,trunc(total) total,trunc(valorregla) valorregla,
                              b.empres_tra,empid,tipo_entrega,tipo_producto,r_inicial,r_final,trunc((valorkm)*(total),2)  valorkm
                             from ROADNET.FLH_RUTASPROCESADAS a
                             left  join roadnet.FLB_FLETECONFIG b on a.reglaid = B.ID
                             where a.token= :p_token
                               order by hojaruta asc, consecutivo asc
";

            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            db.AddInParameter(command, "p_token", System.Data.DbType.Int32, token);
            var ds = db.ExecuteDataSet(command);
            return ds.Tables[0];
        }


        public static DataTable GetTotalXSucursal(int token)
        {
            string strSQl = @"SELECT A.SUCURSALCLIENTE,A.TOTAL,A.FLETEXKM,A.ADICIONAL,TRUNC(A.COSTOFIJO,2) COSTOFIJO,trunc(fletexkm+ADICIONAL+COSTOFIJO,2) TOTALFLETE
                                FROM (
                                select 
                                sucursalcliente,
                                TRUNC(sum(TOTAL),2) TOTAL, 
                                sum(fletexkm) fletexkm,trunc(SUM(ADICIONAL)) ADICIONAL,
                                SUM(COSTOFIJO) COSTOFIJO from (
                                select A.*, 
                                TRUNC(A.TOTAL*A.VALORREGLA) FLETEXKM, 
                                nvl(FLETESLIQ.ADICIONALESSUCURSAL(HOJARUTA,TOKEN),0)ADICIONAL,
                                NVL(FLETESLIQ.COSTOFIJO (HOJARUTA, TOKEN),0) COSTOFIJO
                                from ROADNET.FLH_RUTASPROCESADAS A where token =:p_token
                                and 1=1
                                and tanque_rep is not null
                                )
                                group by sucursalcliente) A";

            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            db.AddInParameter(command, "p_token", System.Data.DbType.Int64, token);
            var ds = db.ExecuteDataSet(command);
            return ds.Tables[0];
        }

        public static DataTable GetTotalXPlanta(int token)
        {
            try
            {

                string strSQl = @"       select sucursalcliente,nombrecliente, trunc(sum(nvl(valor,0)),2) valor, trunc(SUM(COSTOFIJO),2) COSTOFIJO, TRUNC(sum(ADICIONAL),2) ADICIONAL from(
                                    SELECT 
                                        token,
                                        A.SUCURSALCLIENTE,
                                        NOMBRECLIENTE,
                                        FLETESLIQ.ADCIONALESXPLANTA(HOJARUTA,TOKEN) valor ,
                                        FLETESLIQ.ADICIONALESHR(HOJARUTA,TOKEN)ADICIONAL , 
                                        nvl(FLETESLIQ.COSTOFIJO(HOJARUTA,TOKEN) *
                                        (SELECT COUNT(*) FROM ROADNET.FLH_RUTASPROCESADAS B WHERE A.TOKEN =B.TOKEN AND A.HOJARUTA=B.HOJARUTA AND TANQUE_REP IS NOT NULL ),0)
                                        COSTOFIJO    
                                         FROM ROADNET.FLH_RUTASPROCESADAS A
                                     where token =:p_token                                    
                                    and 1=1 AND ORDEN__REP =0
                                    ) a 
                                    group by token,sucursalcliente,nombrecliente";

         
         
          
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            db.AddInParameter(command, "p_token", System.Data.DbType.Int64, token);
            var ds = db.ExecuteDataSet(command);
            return ds.Tables[0];
            }
            catch (Exception)
            {
                return null;

            }
        }

       

    }
}
