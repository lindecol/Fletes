using Microsoft.Reporting.WinForms;
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
    public partial class FrmReportes : Form
    {
        int _token;
        public FrmReportes(int token)
        {
            InitializeComponent();

            _token = token;

        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

           
        }

        private void FrmReportes_Load_1(object sender, EventArgs e)
        {
            var ds = TokenDao.GetReporteLiquidacion(_token);

            List<ReportePlantillTransporte> lista1 = new List<ReportePlantillTransporte>();

            List<ReporteDetalleAdicionales> lista2 = new List<ReporteDetalleAdicionales>();

            foreach (var item in ds.AsEnumerable())
            {
                try
                {


                    ReportePlantillTransporte obj = new ReportePlantillTransporte
                    {
                        CentroCosto = item["CentroCosto"].ToString(),
                        Compania = item["Compania"].ToString(),
                        FechaFin = item["Fecha_Fin"].ToString(),
                        FechaIni = item["Fecha_Ini"].ToString(),
                        Fuente = item["Fuente"].ToString(),
                        TarifaXKm = double.Parse(item["valorregla"].ToString()),
                        TotalAdicionalesCOP = double.Parse(item["TotalAdicionalesCOP"].ToString()),
                        TotalCostoFijoCOP = double.Parse(item["TotalCostoFijoCOP"].ToString()),
                        TotalKm = double.Parse(item["TotalKm"].ToString()),
                        TotalKmCOP = double.Parse(item["TotalKmCOP"].ToString()),
                        //TotalXFuente = item["TotalXFuente"].ToString(),
                        Transportadora = item["Transportadora"].ToString()
                       



                    };
                    obj.TotalXFuente = obj.TotalAdicionalesCOP + obj.TotalCostoFijoCOP + obj.TotalKmCOP;

                lista1.Add(obj);

                }
                catch (Exception ex)
                {

                    throw;
                }
            }


            var ds2 = TokenDao.GetAdicionales(_token);

            foreach (var item in ds2.AsEnumerable())
            {
                lista2.Add(new ReporteDetalleAdicionales { Adicional = item["DESCRIPCION"].ToString(), Total = int.Parse(item["TOTAL"].ToString()) });
            }


            ReportDataSource rs1 = new ReportDataSource();
            rs1.Name = "dsEncabezado";
            rs1.Value = lista1;

            ReportDataSource rs2 = new ReportDataSource();
            rs2.Name = "dsAdicionales";
            rs2.Value = lista2;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs1);
            reportViewer1.LocalReport.DataSources.Add(rs2);
            reportViewer1.RefreshReport();




        }
    }
}
