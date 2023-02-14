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
    public partial class FrmDetalleHr : Form
    {

        string _id;
        int _empid;
        DateTime _fechaIni;
      
        DataTable tabla;
        public FrmDetalleHr( string id, int empid, DateTime fechaIni)
        {
            InitializeComponent();
            _id = id;
            _empid = empid;
           
            _fechaIni = fechaIni;

            tabla = FleteDao.GethrDetalle(id, fechaIni).Tables[0];
            tabla.Columns.Add(new DataColumn("KILOMETRAJEDIF"));
            tabla.Columns.Add(new DataColumn("TOTAL"));




            grvDetalle.DataSource = tabla;
            RefrescarTabla();


        }

        private void RefrescarTabla()
        {
            int cont = 0;
            if (tabla == null)
            {
                return;
            }
            //ACTUALIZA TABLA CON DIFERENCIA DE KILOMETROS
            foreach (DataRow item in tabla.Rows)
            {
                item["CONSECUTIVO"] = cont;
                if (cont != 0)
                {
                    var filaAnterior = tabla.Rows[cont - 1];
                    item["KILOMETRAJEDIF"] = int.Parse(item["kmLlegada"].ToString()) - int.Parse(filaAnterior["kmLlegada"].ToString());
                }
                cont++;
            }

            //TOMA EL CONSECUTIVO DE LA ULTIMA PARADA
            var ultimaFila = tabla.Rows[tabla.Rows.Count - 1];
            var kmUltimaFila = int.Parse(ultimaFila["KILOMETRAJEDIF"].ToString());
            decimal kmSuma;
            try
            {

            
            kmSuma = Math.Round((kmUltimaFila / (decimal.Parse(ultimaFila["CONSECUTIVO"].ToString()) - 1)), MidpointRounding.AwayFromZero);
            }
            catch (Exception)
            {
                kmSuma = 0;


            }

            cont = 0;
            //recorre filas y actualiza kilometrajes 
            foreach (DataRow item in tabla.Rows)
            {
                if (cont != 0 && cont != tabla.Rows.Count-1)
                {
                    item["total"] = int.Parse(item["KILOMETRAJEDIF"].ToString()) + kmSuma;

                }
                cont++;
            }
        }
        private void FrmDetalleHr_Load(object sender, EventArgs e)
        {

        }

        private void grvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            RefrescarTabla();
        }

        private void grvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex==-1)
            {
                return;
            }
            var tabla = (DataTable)this.grvDetalle.DataSource;

            tabla.Rows[e.RowIndex]["MODIFICADO"] = 1;

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            var registros = ((DataTable)grvDetalle.DataSource).AsEnumerable().Where(x => int.Parse(x["MODIFICADO"].ToString()) == 1);

            foreach (var item in registros)
            {
                FleteDao.ActualizarKm(item);
            }

            MessageBox.Show("Se actualizaron " + registros.Count() + " registros");
        }

        private void btnAprobarHr_Click(object sender, EventArgs e)
        {
            //buscar hoja de ruta?

            try
            {

         
           var rsta= MessageBox.Show("Desea Aprobar la hoja de ruta?","Fletes",MessageBoxButtons.YesNo,MessageBoxIcon.Information );
            if (rsta== DialogResult.No)
            {
                return;
            }

            FleteDao.ActualizarAprobacion(_id,_empid,1,Parametros.ParametrosIniciales.UsrId);
                MessageBox.Show("Se ha marcado la hoja de ruta como aprobada", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void tsbCancelarAprobacion_Click(object sender, EventArgs e)
        {
            try
            {

           
            var rsta = MessageBox.Show("Desea desaprobar la hoja de ruta?", "Fletes", MessageBoxButtons.YesNo);
            if (rsta == DialogResult.No)
            {
                return;
            }
                FleteDao.ActualizarAprobacion(_id, _empid, 0, Parametros.ParametrosIniciales.UsrId);
                MessageBox.Show("Se ha desmarcado la ruta como no aprobada", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
