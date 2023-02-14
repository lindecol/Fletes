using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FletesLiquidos
{
    public partial class FrmParametrizacionFletes : Form
    {
        int identificador = 0;
        DataSet dsRutasAsociadas;
        DataRow _fila;

        public FrmParametrizacionFletes()
        {
            InitializeComponent();
        }




        public FrmParametrizacionFletes( int id)
        {
            InitializeComponent();
            identificador= id  ;
            
        }

 




        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            // fijo =1, variable=2, fijovariable =3

            if (identificador == 0)
            {

                try
                {

                
                Guardar();
                    MessageBox.Show("Registro Almacenado");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {

                try
                {

                
                Actualizar();

                    MessageBox.Show("Registro Actualizado");
                    this.Dispose();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

          

        }

        
        private void Actualizar()
        {
            int id_tipo_liquidacion = 0;

            if (rbFijo.Checked)
            {
                id_tipo_liquidacion = 1;
            }

            if (rbFijoVariable.Checked)
            {
                id_tipo_liquidacion = 3;
            }

            if (rbVariable.Checked)
            {
                id_tipo_liquidacion = 2;
            }


            if (!ValidarCampos())
                return;

            FleteConfig cfg = new FleteConfig
            {
                in_EMPID = int.Parse(((DataRowView)this.cmbEmpresa.SelectedItem)["empid"].ToString()),
                in_EMPRES_TRA = (((DataRowView)this.cmbTransportadora.SelectedItem)["empres_tra"].ToString()),
                IN_ID_TIPOLIQUIDACION = id_tipo_liquidacion,
                in_R_FINAL = (nudRfinal.Value),
                in_R_INICIAL = nudRinicial.Value,
                in_TIPO_ENTREGA = ((LocalNacional)cmbLocalNacional.SelectedItem).Codigo,
                in_TIPO_PRODUCTO = ((TipoProducto)cmbTipoProducto.SelectedItem).Codigo,
                IN_VALORFIJO = NudFijo.Value,
                in_VALORKM = nudValorKm.Value,
                in_VEHICULO_VEH = (((DataRowView)this.cmbVehiculo.SelectedItem)["vehicu_veh"].ToString()),
            };

             FleteDao.ActualizarFleteConfig(cfg, identificador);

            foreach (DataRow item in dsRutasAsociadas.Tables[0].Rows)
            {
                if (item.RowState== DataRowState.Deleted)
                {
                    return;
                }

                item["ID_CONFIG"] = identificador;




                if (item["estado_reg"].ToString() == "1")
                {

                    var aplicaprom = item["APLICA_PROMEDIO"].ToString()=="1" ? true:false;
                    FleteDao.GuardarDetalleRegla(identificador, item["VEHICULO_VEH"].ToString(), aplicaprom);
                    item["estado_reg"] = "0";

                }





            }


        }

        private void Guardar()
        {
            int id_tipo_liquidacion = 0;

            if (rbFijo.Checked)
            {
                id_tipo_liquidacion = 1;
            }

            if (rbFijoVariable.Checked)
            {
                id_tipo_liquidacion = 3;
            }

            if (rbVariable.Checked)
            {
                id_tipo_liquidacion = 2;
            }


            if (!ValidarCampos())
                return;

            FleteConfig cfg = new FleteConfig
            {
                in_EMPID = int.Parse(((DataRowView)this.cmbEmpresa.SelectedItem)["empid"].ToString()),
                in_EMPRES_TRA = (((DataRowView)this.cmbTransportadora.SelectedItem)["empres_tra"].ToString()),
                IN_ID_TIPOLIQUIDACION = id_tipo_liquidacion,
                in_R_FINAL = (nudRfinal.Value),
                in_R_INICIAL = nudRinicial.Value,
                in_TIPO_ENTREGA = ((LocalNacional)cmbLocalNacional.SelectedItem).Codigo,
                in_TIPO_PRODUCTO = ((TipoProducto)cmbTipoProducto.SelectedItem).Codigo,
                IN_VALORFIJO = NudFijo.Value,
                in_VALORKM = nudValorKm.Value,
                in_VEHICULO_VEH = (((DataRowView)this.cmbVehiculo.SelectedItem)["vehicu_veh"].ToString()),
            };

            identificador = FleteDao.InsertarFleteConfig(cfg);

            //  MessageBox.Show("registro Almacenado", "FLetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  this.Dispose();

            foreach (DataRow item in dsRutasAsociadas.Tables[0].Rows)
            {
                item["ID_CONFIG"] = identificador;


                if (item["estado_reg"].ToString()=="1")
                {

                    var aplicaprom = item["APLICA_PROMEDIO"].ToString() == "1" ? true : false;

                    FleteDao.GuardarDetalleRegla(identificador, item["VEHICULO_VEH"].ToString(), aplicaprom);

                }





            }

            MessageBox.Show("Regla Almacenada con exito!");
        }

        private bool ValidarCampos()
        {
            //valida km ini y km fin
            if (nudRinicial.Value==nudRfinal.Value && (rbVariable.Checked|| rbFijoVariable.Checked))
            {

                MessageBox.Show("debe ingresar un valor para el rango de kilometrajes diferente", "FLetes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

                
            }


            return true;

            
        }

        private void FrmParametrizacionFletes_Load(object sender, EventArgs e)
        {
            rbFijoVariable.Visible = false;
            this.cmbTipoProducto.DataSource = TipoProducto.getTipoProducto();
            this.cmbLocalNacional.DataSource = LocalNacional.getLocalNacional();

            this.cmbEmpresa.DataSource = FleteDao.GetEmpresas().Tables[0];
            this.cmbEmpresa.DisplayMember = "empnmb";
            this.cmbEmpresa.ValueMember = "empid";




            bool habilitado = identificador == 0 ? true : false;

            this.cmbEmpresa.Enabled = habilitado;
            this.cmbTransportadora.Enabled = habilitado;


            if (identificador==0)
            {
                dsRutasAsociadas = FleteDao.GetVehiculosRegla(-4);
                //dsRutasAsociadas.Tables.Add(new DataTable());
                //dsRutasAsociadas.Tables[0].Columns.Add(new DataColumn { ColumnName = "ID_CONFIG" });
                //dsRutasAsociadas.Tables[0].Columns.Add(new DataColumn { ColumnName = "VEHICULO_VEH" });
                this.grvRutas.DataSource = dsRutasAsociadas.Tables[0];
            }
            else
            {
                //cargar valores en formulario
               _fila= FleteDao.CargarFleteConfig(identificador).Tables[0].Rows[0];
                //cargar valores en grilla
                CargarValoresCampos();



            }


          






        }

        private void CargarValoresCampos()
        {
            this.cmbEmpresa.SelectedValue = _fila["empid"].ToString();
            this.cmbTransportadora.SelectedValue = _fila["EMPRES_TRA"].ToString();
            this.cmbVehiculo.SelectedValue = _fila["VEHICULO_VEH"].ToString();



            switch (int.Parse(_fila["ID_TIPOLIQUIDACION"].ToString()))
            {
                case  1:
                    rbFijo.Checked = true;
                    rbFijoVariable.Checked = false;
                    rbVariable.Checked = false;
                    break;
                case 2:
                    rbFijo.Checked = false;
                    rbFijoVariable.Checked = false;
                    rbVariable.Checked = true;
                    break;

                case 3:
                    rbFijo.Checked = false;
                    rbFijoVariable.Checked = true; 
                    rbVariable.Checked = false;
                    break;


                default:
                    break;
            }


            NudFijo.Value = decimal.Parse(_fila["VALORFIJO"].ToString());
            nudRfinal.Value= decimal.Parse(_fila["R_FINAL"].ToString());
            nudRinicial.Value= decimal.Parse(_fila["R_INICIAL"].ToString());
            nudValorKm.Value= decimal.Parse(_fila["VALORKM"].ToString());


            cmbTipoProducto.SelectedValue = _fila["TIPO_PRODUCTO"].ToString();


            cmbLocalNacional.SelectedValue = _fila["TIPO_ENTREGA"].ToString();


            CargarDetalleVehiculos();







        }

        private void CargarDetalleVehiculos()
        {
           this.dsRutasAsociadas= FleteDao.GetVehiculosRegla(identificador);

            this.grvRutas.DataSource = dsRutasAsociadas.Tables[0];


        }

        string alias = "";

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            alias = ((DataRowView)cmbEmpresa.SelectedItem)["empalias"].ToString();

            try
            {

            this.cmbTransportadora.DataSource = FleteDao.GetTransportadoras(alias).Tables[0];
            this.cmbTransportadora.DisplayMember = "nombre_tra";
            this.cmbTransportadora.ValueMember = "empres_tra";
            }
            catch (Exception)
            {    
            }


        }

        private void cmbTransportadora_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

            
               this.cmbVehiculo.DataSource = FleteDao.GetVehiculo(((DataRowView)cmbTransportadora.SelectedItem)["empres_tra"].ToString(),
                                                                   alias).Tables[0];
            this.cmbVehiculo.DisplayMember = "nombre";
            this.cmbVehiculo.ValueMember = "vehicu_veh";
            }
            catch (Exception)
            {


            }
        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFijo.Checked)
            {
                NudFijo.Visible = true;
                nudRfinal.Visible = false;
                nudRinicial.Visible = false;
                nudValorKm.Visible = false;
                rbVariable.Checked = false;
                rbFijoVariable.Checked = false;

                lblValorFijo.Visible = true;

                lblrfinal.Visible = false;
                lblRinicial.Visible = false;
                lblValorxkm.Visible = false;

            }

            if (rbVariable.Checked)
            {
                NudFijo.Visible = false;
                nudRfinal.Visible = true;
                nudRinicial.Visible = true;
                nudValorKm.Visible = true;

                rbFijo.Checked = false;
                rbFijoVariable.Checked = false;


                lblValorFijo.Visible = false;

                lblrfinal.Visible = true;
                lblRinicial.Visible = true;
                lblValorxkm.Visible = true;
            }

            if (rbFijoVariable.Checked)
            {
                NudFijo.Visible = true;
                nudRfinal.Visible = true;
                nudRinicial.Visible = true;
                nudValorKm.Visible = true;
                rbVariable.Checked = false;
                rbFijo.Checked = false;

                lblValorFijo.Visible = true;

                lblrfinal.Visible = true;
                lblRinicial.Visible = true;
                lblValorxkm.Visible = true;

            }

        }

        private void cmbVehiculo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

     

        private void btnAgregaRuta_Click(object sender, EventArgs e)
        {
            DataRow dr = this.dsRutasAsociadas.Tables[0].NewRow();

            dr["ID_CONFIG"] = this.identificador;
            dr["vehiculo_veh"] = this.cmbVehiculo.Text;
            dr["estado_reg"] = 1;
            dr["Aplica_promedio"] = chkAplicaPromedio.Checked == true ? 1 : 0;


            if (this.dsRutasAsociadas.Tables[0].AsEnumerable().Where(p => p["vehiculo_veh"].ToString() == this.cmbVehiculo.Text).Count() > 0)
            {
                MessageBox.Show("ya existe una ruta agregada");
                return;
            }
            this.dsRutasAsociadas.Tables[0].Rows.Add(dr);
        }

        private void grvRutas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.grvRutas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }



            var obj = (DataRowView)(this.grvRutas.SelectedRows[0]).DataBoundItem;


            if ((int.Parse(obj["id_config"].ToString())==0))
            {
                obj.Delete();

            }
            else
            {            
                FleteDao.EliminarRutaConfig(int.Parse(obj["id_config"].ToString()), obj["vehiculo_veh"].ToString());
                CargarDetalleVehiculos();
            }

            //  obj.Delete();



        }


    }
}
