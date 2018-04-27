using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria Usadas--
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using System.Data.SqlClient;
namespace Login_Tienda
{
   public class Generar_Reporte
    {
    public void mostrar(SqlConnection con, string Pparametros, string Pdocumento)
        {
           ReportDocument _report = new ReportDocument();
            //Plantilla_Reporte _reporte = new Plantilla_Reporte();
            _report.Load(Pdocumento);
            _report.SetParameterValue(0,Pparametros);
            VisorReporte obj = new VisorReporte();
            obj.crystalReportViewer1.ReportSource = _report;
    //        obj.crystalReportViewer1.Zoom(100);
            obj.ShowDialog();
        }
    }
}
