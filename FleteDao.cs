using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FletesLiquidos
{
  public  class FleteDao
    {

        internal static DataSet GetSucursales(int empid)
        {

            string strSQl = @"select scrid,scrnmb from cs_sucursal where empid=:p_empid and grpecid=1";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
                     db.AddInParameter(command, "p_empid", System.Data.DbType.String, empid);
            var ds = db.ExecuteDataSet(command);
            return ds;
        }

        internal static DataSet CargarFleteConfig(int identificador)
        {
            string strSQl = @"SELECT * 
                  FROM  ROADNET.FLB_FLETECONFIG a where id = :p_id ";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            db.AddInParameter(command, "p_id", System.Data.DbType.Int32, identificador);
            var ds = db.ExecuteDataSet(command);
            return ds;
        }

        internal static void ActualizarAdicional(DataRow item)
        {
            string strsql = @"update FLH_ADICIONALES a
                            set valor = :p_valor * (select tipo_concepto from FLB_CONCEPTOS b where a.id_concepto =b.id_concepto )
                            where hojrut_rep = :P_hojrut_rep
                            and id_concepto = :p_id_concepto";


            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("COOX");
            command = db.GetSqlStringCommand(strsql);

            db.AddInParameter(command, "p_valor", System.Data.DbType.Int64, item["valor"].ToString());
            db.AddInParameter(command, "p_hojrut_rep", System.Data.DbType.String, item["hojrut_rep"].ToString());
            db.AddInParameter(command, "p_id_concepto", System.Data.DbType.Int64, item["id_concepto"].ToString());
     
            db.ExecuteNonQuery(command);


        }

        internal static int CalcularFLetes(int empresa, string transportadora, string localNacional, DateTime fini, DateTime ffin)
        {
            string strsql = @"fletesliq.CALCULAR_FLETES";


            int token;

            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("COOX");
            command = db.GetStoredProcCommand(strsql);

            db.AddInParameter(command, "P_FECHA_INI", System.Data.DbType.Date, fini);
            db.AddInParameter(command, "P_FECHA_FIN", System.Data.DbType.Date, ffin);
            db.AddInParameter(command, "P_EMPRES_TRA", System.Data.DbType.String, transportadora);
            db.AddInParameter(command, "P_EMPID", System.Data.DbType.String, empresa);
            db.AddInParameter(command, "P_TIPOENTREGA", System.Data.DbType.String, localNacional);
            db.AddInParameter(command, "P_USRID", System.Data.DbType.String, Parametros.ParametrosIniciales.UsrId);

            db.AddOutParameter(command, "p_token", System.Data.DbType.Int64,100);

            db.ExecuteNonQuery(command);

           var rsta= db.GetParameterValue(command, "p_token");

            return int.Parse(rsta.ToString());


        }

        internal static DataSet CargarFleteConfig()
        {
            string strSQl = @"SELECT 
                           VEHICULO_VEH
                            ,VALORKM
                            ,VALORFIJO
                            ,TIPO_PRODUCTO
                            ,TIPO_ENTREGA
                            ,R_INICIAL
                            ,R_FINAL
                            ,a.empid
                            ,decode(ID_TIPOLIQUIDACION, 1 ,'FIJO',2,'VARIABLE', 3,'FIJO + VARIABLE') ID_TIPOLIQUIDACION
                            ,ID
                            , (select nombre_tra from roadnet.vw_fTransportadoras trans where trans.empres_tra= a. EMPRES_TRA and trans.empid = a.empid 
                                    and estado_aud ='A')  EMPRES_TRA
                            ,(SELECT UPPER(EMPNMB) FROM CS_EMPRESA WHERE EMPID = A.EMPID) EMPID
                  FROM  ROADNET.FLB_FLETECONFIG a";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

         


            var ds = db.ExecuteDataSet(command);
            return ds;
        }

        internal static void ActualizarKm(DataRow item)
        {
            string strSQL = @"";
            
            if (item["ORDEN__REP"].ToString()=="0" && item["TANQUE_REP"].ToString() == "")
            {
                strSQL = @"update SPRAX_D_REPARTOS
                            set KLMSAL_REA =:p_klmlle_rea
                             where :P_HOJARUTA_REP = hojrut_rep
                            and client_rep =:p_client_rep
                             and nvl(tanque_rep,0) =nvl(:p_tanque_rep,0)";
            }

            if (item["ORDEN__REP"].ToString() != "0" && item["TANQUE_REP"].ToString() == "")
            {
                strSQL = @"update SPRAX_D_REPARTOS
                            set KLMENT_REA =:p_klmlle_rea
                             where :P_HOJARUTA_REP = hojrut_rep
                            and client_rep =:p_client_rep
                             and nvl(tanque_rep,0) =nvl(:p_tanque_rep,0)";
            }

            if (item["ORDEN__REP"].ToString() != "0" && item["TANQUE_REP"].ToString() != "")
            {
                strSQL = @"update SPRAX_D_REPARTOS
                            set KLMSAL_REA =:p_klmlle_rea
                             where :P_HOJARUTA_REP = hojrut_rep
                            and client_rep =:p_client_rep
                             and nvl(tanque_rep,0) =nvl(:p_tanque_rep,0)";

            }

            if (item["ORDEN__REP"].ToString() == "0" && item["TANQUE_REP"].ToString() != "")
            {
                strSQL = @"update SPRAX_D_REPARTOS
                            set KLMSAL_REA =:p_klmlle_rea
                             where :P_HOJARUTA_REP = hojrut_rep
                            and client_rep =:p_client_rep
                             and nvl(tanque_rep,0) =nvl(:p_tanque_rep,0)";

            }



            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase(Parametros.GetBase(int.Parse(item["EMPRESA"].ToString())));
            command = db.GetSqlStringCommand(strSQL);

            db.AddInParameter(command, "p_klmlle_rea", System.Data.DbType.String, item["kmLlegada"].ToString());
            db.AddInParameter(command, "P_HOJARUTA_REP", System.Data.DbType.String, item["HojaRuta"].ToString());
            db.AddInParameter(command, "p_client_rep", System.Data.DbType.String, item["CodCliente"].ToString());
            db.AddInParameter(command, "p_tanque_rep", System.Data.DbType.String, item["tanque_rep"].ToString());
          
            db.ExecuteNonQuery(command);


        }

        internal static void ActualizarAprobacion(string hojarutaId, int empid, int aprobado, int usrid)
        {
             var strSQL = @"fletesliq.ACTUALIZARAPROBACION";


            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase(Parametros.GetBase(21));
            command = db.GetStoredProcCommand(strSQL);

            db.AddInParameter(command, "P_HOJRUT_REP", System.Data.DbType.String, hojarutaId) ;
            db.AddInParameter(command, "P_EMPID", System.Data.DbType.String, empid);
            db.AddInParameter(command, "P_APROBADO", System.Data.DbType.String, aprobado);
            db.AddInParameter(command, "P_USRID", System.Data.DbType.String, usrid);

            db.ExecuteNonQuery(command);
        }

       
        internal static void ActualizarRutaPromedio(DataRow item)
        {
            try
            {

            

            var tipo = item["APLICA_PROMEDIO"].ToString();
            string strSQL = "";

            if (tipo=="1")
            {
                 strSQL = @" insert into ROADNET.FLB_RUTASPROMEDIO (vehicu_veh,codemp_veh,empid)
                            values(:p_vehicu_veh,:p_codemp_veh,:p_empid)";
            }
            else
            {
                strSQL = @" delete from ROADNET.FLB_RUTASPROMEDIO 
                            where  :p_vehicu_veh=vehicu_veh and :p_codemp_veh=codemp_veh and :p_empid=empid";
            }

            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQL);

            db.AddInParameter(command, "p_vehicu_veh", System.Data.DbType.String, item["vehicu_veh"].ToString());
            db.AddInParameter(command, "p_codemp_veh", System.Data.DbType.String, item["codemp_veh"].ToString());
            db.AddInParameter(command, "p_empid", System.Data.DbType.String, item["empid"].ToString());

            db.ExecuteNonQuery(command);

            }
            catch (Exception ex)
            {

                
            }


        }

        internal static bool ActualizarFleteConfig(FleteConfig fl,int id)
        {
            string strSQl = @"UPDATE ROADNET.FLB_FLETECONFIG
                        SET 
                       EMPRES_TRA=:IN_EMPRES_TRA
                      ,EMPID=:in_EMPID
                      ,VEHICULO_VEH=:IN_VEHICULO_VEH
                      ,TIPO_ENTREGA=:IN_TIPO_ENTREGA
                      ,TIPO_PRODUCTO=:IN_TIPO_PRODUCTO
                      ,R_INICIAL=:IN_R_INICIAL
                      ,R_FINAL=:IN_R_FINAL
                      ,VALORKM=:IN_VALORKM
                      ,ID_TIPOLIQUIDACION=:IN_ID_TIPOLIQUIDACION
                      ,VALORFIJO=:IN_VALORFIJO
               WHERE ID=:P_ID";

          
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

            db.AddInParameter(command, "in_EMPRES_TRA", System.Data.DbType.String, fl.in_EMPRES_TRA);
            db.AddInParameter(command, "in_EMPID", System.Data.DbType.Int32, fl.in_EMPID);
            db.AddInParameter(command, "in_VEHICULO_VEH", System.Data.DbType.String, fl.in_VEHICULO_VEH);
            db.AddInParameter(command, "in_TIPO_ENTREGA", System.Data.DbType.String, fl.in_TIPO_ENTREGA);
            db.AddInParameter(command, "in_TIPO_PRODUCTO", System.Data.DbType.String, fl.in_TIPO_PRODUCTO);
            db.AddInParameter(command, "in_R_INICIAL", System.Data.DbType.Int32, fl.in_R_INICIAL);
            db.AddInParameter(command, "in_R_FINAL", System.Data.DbType.Int32, fl.in_R_FINAL);
            db.AddInParameter(command, "in_VALORKM", System.Data.DbType.Int32, fl.in_VALORKM);
            db.AddInParameter(command, "IN_ID_TIPOLIQUIDACION", System.Data.DbType.Int32, fl.IN_ID_TIPOLIQUIDACION);
            db.AddInParameter(command, "IN_VALORFIJO", System.Data.DbType.Int32, fl.IN_VALORFIJO);
            db.AddInParameter(command, "p_id", System.Data.DbType.Int32, id);




            // db.AddInParameter(command, "p_fecha_fin", System.Data.DbType.Date, fechafin);
            // db.AddInParameter(command, "P_COD_AGENCIA", System.Data.DbType.String, empid);


            db.ExecuteNonQuery(command);

            return true;

        }

        internal static void EliminarFleteConfig(int id)
        {
            var strsql = @"delete from FLB_FLETECONFIG where id = :p_id";

            
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strsql);

            db.AddInParameter(command, "p_id", System.Data.DbType.Int32, id);
       
            

            db.ExecuteNonQuery(command);
        }

        internal static void GuardarDetalleRegla(int Id, string vehiculo, bool p_APLICA_PROMEDIO)
        {

            string strSql = "insert into roadnet.FLB_FLETECONFIG_VEH (id_config,vehiculo_veh,APLICA_PROMEDIO) values(:p_id_config,:p_vehiculo_veh,:p_APLICA_PROMEDIO)";


          
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSql);

            db.AddInParameter(command, "p_id_config", System.Data.DbType.Int32, Id);
            db.AddInParameter(command, "p_vehiculo_veh", System.Data.DbType.String, vehiculo);
            db.AddInParameter(command, "p_APLICA_PROMEDIO", System.Data.DbType.Int32, p_APLICA_PROMEDIO == true ? 1 : 0);

            db.ExecuteNonQuery(command);
        



        }

        internal static DataSet GetTransportadoras(string dblink)
        {

            try
            {

            
            string strSQl = @"select 
                            empres_tra,
                            nombre_tra
                            from  SPRAX_M_TRANSP@"+ dblink + " TRA  where estado_auD ='A'";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);
            
            var ds = db.ExecuteDataSet(command);
            return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        internal static DataSet GetVehiculo( string codigoEmpresa,string dblink)
        {

            string strSQl = @"select vehicu_veh, vehicu_veh nombre,TIPOTK_VEH
                    from SPRAX_M_VEHICU@"+ dblink +" V where codemp_veh =:p_codemp_veh and estado_aud ='M'";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

            db.AddInParameter(command, "p_codemp_veh", System.Data.DbType.String, codigoEmpresa);

            var ds = db.ExecuteDataSet(command);
            return ds;
        }

        internal static DataSet GetVehiculoPromedio(string codigoEmpresa, string dblink, string empresa)
        {

            string strSQl = @" SELECT A.*, DECODE(B.VEHICU_VEH,NULL,0,1)  APLICA_PROMEDIO 
                    FROM vw_FRUTAS_FLETES A
                    lEFT JOIN ROADNET.FLB_RUTASPROMEDIO B ON B.EMPID = A.EMPID AND B.VEHICU_VEH = A.VEHICU_VEH AND A.codemp_veh=B.codemp_veh
                      where a.codemp_veh =:p_codemp_veh and a.estado_aud ='M' and a.empid = :p_empid ";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

            db.AddInParameter(command, "p_codemp_veh", System.Data.DbType.String, codigoEmpresa);
            db.AddInParameter(command, "p_empid", System.Data.DbType.String, empresa);

            var ds = db.ExecuteDataSet(command);
            return ds;
        }



        internal static DataSet GetEmpresas()
        {

            string strSQl = @"        select
                                empid,
                                empnmb,
                                empalias
                                 from cs_empresa where grpecid = 1";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("COOX");
            command = db.GetSqlStringCommand(strSQl);

            var ds = db.ExecuteDataSet(command);
            return ds;
        }







        internal static DataSet GetHr(DateTime fechaini, DateTime fechafin, int empid)
        {

            string strSQl = @"roadnet.FLETESLIQ.CONSULTAR_HR";
            
            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("COOX" );
            command = db.GetStoredProcCommand(strSQl);

            db.AddInParameter(command, "p_fecha_ini", System.Data.DbType.Date, fechaini);
            db.AddInParameter(command, "p_fecha_fin", System.Data.DbType.Date, fechafin);
            db.AddInParameter(command, "p_empid", System.Data.DbType.Int64, empid);

            var ds = db.ExecuteDataSet(command);
            return ds;




        }

        internal static DataSet GetVehiculosRegla(int identificador)
        {

            try
            {

       
            string strSQl = @"select id_config,vehiculo_veh, 0 estado_reg, aplica_promedio  from ROADNET.FLB_FLETECONFIG_VEH where id_config =:p_id_config";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

            db.AddInParameter(command, "p_id_config", System.Data.DbType.Int32, identificador);
            // db.AddInParameter(command, "p_fecha_fin", System.Data.DbType.Date, fechafin);
            // db.AddInParameter(command, "P_COD_AGENCIA", System.Data.DbType.String, empid);


            var ds = db.ExecuteDataSet(command);
            return ds;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static void GUardarAdicional(int idHojaRuta, int selectedValue, decimal value, string text)
        {
            var strsql = @"insert into FLH_ADICIONALES(HOJRUT_REP,
                        ID_CONCEPTO,
                        OBSERVACIONES,
                        VALOR)
                        values 
                        (
                        :p_HOJRUT_REP,
                        :p_ID_CONCEPTO,
                        :p_OBSERVACIONES,
                        :p_VALOR
                        )";


            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strsql);

            db.AddInParameter(command, "p_HOJRUT_REP", System.Data.DbType.Int32, idHojaRuta);
            db.AddInParameter(command, "p_ID_CONCEPTO", System.Data.DbType.Int32, selectedValue);
            db.AddInParameter(command, "p_OBSERVACIONES", System.Data.DbType.String, text);
            db.AddInParameter(command, "p_VALOR", System.Data.DbType.Int32, value);

            // db.AddInParameter(command, "p_fecha_fin", System.Data.DbType.Date, fechafin);
            // db.AddInParameter(command, "P_COD_AGENCIA", System.Data.DbType.String, empid);

            db.ExecuteNonQuery(command);



        }

        internal static DataSet GethrDetalle(string hrId, DateTime fechaIni)
        {
            string strSQl = @"roadnet.FLETESLIQ.CONSULTAR_HRDETALLE";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("COOX");
            command = db.GetStoredProcCommand(strSQl);

            db.AddInParameter(command, "P_HOJARUTA_REP", System.Data.DbType.String, hrId);
            db.AddInParameter(command, "p_fecha_ini", System.Data.DbType.Date, fechaIni);
            db.AddInParameter(command, "p_empid", System.Data.DbType.Int32, Parametros.ParametrosIniciales.Empresa);

            var ds = db.ExecuteDataSet(command);
            return ds;




        }

        internal static DataSet GetConceptos()
        {
            try
            {

          
            string strSQl = @"select * from FLB_CONCEPTOS";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

          //  db.AddInParameter(command, "P_hojrut_rep", System.Data.DbType.Int32, hrId);
            // db.AddInParameter(command, "p_fecha_fin", System.Data.DbType.Date, fechafin);
            // db.AddInParameter(command, "P_COD_AGENCIA", System.Data.DbType.String, empid);


            var ds = db.ExecuteDataSet(command);
            return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        internal static void EliminarRutaConfig(int v1, string vehiculo_veh)
        {
            try
            {
                int secuencia = GetSecuenciaRegla();


                string strSQl = @"
                        delete from FLB_FLETECONFIG_VEH
                        where id_config =:p_id_config and vehiculo_veh =:p_vehiculo_veh";

                int id = 0;
                DbCommand command;
                Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
                command = db.GetSqlStringCommand(strSQl);

                db.AddInParameter(command, "p_id_config", System.Data.DbType.Int32, v1);
                db.AddInParameter(command, "p_vehiculo_veh", System.Data.DbType.String, vehiculo_veh);              

                                               db.ExecuteNonQuery(command);


               
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal static DataSet GetAdicionales(int hrId)
        {
            string strSQl = @"
                        select 
                        ad.hojrut_rep,
                        ad.id_concepto,
                        concept.descripcion,
                        ad.valor,
                        ad.observaciones,
                        0 modificado
                        from FLH_ADICIONALES ad
                        inner join FLB_CONCEPTOS concept on concept.id_concepto = ad.id_concepto
                        where ad.hojrut_rep=:P_hojrut_rep";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

            db.AddInParameter(command, "P_hojrut_rep", System.Data.DbType.Int32, hrId);
            // db.AddInParameter(command, "p_fecha_fin", System.Data.DbType.Date, fechafin);
            // db.AddInParameter(command, "P_COD_AGENCIA", System.Data.DbType.String, empid);


            var ds = db.ExecuteDataSet(command);
            return ds;

        }


        internal static int InsertarFleteConfig(FleteConfig fl) {

            try
            {
                int secuencia = GetSecuenciaRegla();
            

            string strSQl = @"INSERT INTO ROADNET.FLB_FLETECONFIG
                      (
                        id
                       ,EMPRES_TRA
                      ,EMPID
                      ,VEHICULO_VEH
                      ,TIPO_ENTREGA
                      ,TIPO_PRODUCTO
                      ,R_INICIAL
                      ,R_FINAL
                      ,VALORKM
                      ,ID_TIPOLIQUIDACION
                      ,VALORFIJO
                      )
                    VALUES
                      (
                        :p_id
                       ,:in_EMPRES_TRA
                      ,:in_EMPID
                      ,:in_VEHICULO_VEH
                      ,:in_TIPO_ENTREGA
                      ,:in_TIPO_PRODUCTO
                      ,:in_R_INICIAL
                      ,:in_R_FINAL
                      ,:in_VALORKM
                      ,:IN_ID_TIPOLIQUIDACION
                      ,:IN_VALORFIJO
                      )";

            int id = 0;
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSQl);

            db.AddInParameter(command, "in_EMPRES_TRA", System.Data.DbType.String, fl.in_EMPRES_TRA);
            db.AddInParameter(command, "in_EMPID", System.Data.DbType.Int32, fl.in_EMPID);
            db.AddInParameter(command, "in_VEHICULO_VEH", System.Data.DbType.String, fl.in_VEHICULO_VEH);
            db.AddInParameter(command, "in_TIPO_ENTREGA", System.Data.DbType.String, fl.in_TIPO_ENTREGA);
            db.AddInParameter(command, "in_TIPO_PRODUCTO", System.Data.DbType.String, fl.in_TIPO_PRODUCTO);
            db.AddInParameter(command, "in_R_INICIAL", System.Data.DbType.Int32, fl.in_R_INICIAL);
            db.AddInParameter(command, "in_R_FINAL", System.Data.DbType.Int32, fl.in_R_FINAL);
                db.AddInParameter(command, "in_VALORKM", System.Data.DbType.Int32, fl.in_VALORKM);
                db.AddInParameter(command, "IN_ID_TIPOLIQUIDACION", System.Data.DbType.Int32, fl.IN_ID_TIPOLIQUIDACION);
            db.AddInParameter(command, "IN_VALORFIJO", System.Data.DbType.Int32, fl.IN_VALORFIJO);
                db.AddInParameter(command, "p_id", System.Data.DbType.Int32, secuencia);

                db.ExecuteNonQuery(command);
            return secuencia;
            }
            catch (Exception ex)
            {

                throw;
            }



        }

        private static int GetSecuenciaRegla()
        {
            string strSql = "SELECT ROADNET.SQ_FLETECONFIG.NEXTVAL seq  FROM DUAL";
            DbCommand command;
            Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
            command = db.GetSqlStringCommand(strSql);
            var ds = db.ExecuteDataSet(command);
            return int.Parse(ds.Tables[0].Rows[0]["seq"].ToString());




        }


        public static DataTable GetDetallexPlantaCargueAdicionales(int id, string planta )
        {
            try
            {


                string strSQl = @"        SELECT 
                                        HOJARUTA,
                                        token,
                                        A.SUCURSALCLIENTE,
                                        NOMBRECLIENTE,
                                        FLETESLIQ.ADICIONALESHR(HOJARUTA,TOKEN)ADICIONAL                                        
                                         FROM ROADNET.FLH_RUTASPROCESADAS A
                                     where token =:p_token                                    
                                    and 1=1 AND ORDEN__REP =0
                                    AND FLETESLIQ.ADICIONALESSUCURSAL(HOJARUTA,TOKEN)!=0
                                    AND sucursalcliente= :P_SUCURSALCLIENTE ";

                DbCommand command;
                Database db = DatabaseFactory.CreateDatabase("ConexionOracle");
                command = db.GetSqlStringCommand(strSQl);

                db.AddInParameter(command, "p_token", System.Data.DbType.Int32, id);
                db.AddInParameter(command, "P_SUCURSALCLIENTE", System.Data.DbType.String, planta);


                var ds = db.ExecuteDataSet(command);
                return ds.Tables[0];

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
