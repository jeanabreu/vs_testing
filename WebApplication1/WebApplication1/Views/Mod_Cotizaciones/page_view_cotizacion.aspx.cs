using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Views.Mod_Cotizaciones;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Web;
using CrystalDecisions.Shared;
using System.Web.Configuration;

namespace WebApplication1.Views.Mod_Cotizaciones 
{
    public partial class page_view_cotizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String valor = Request.QueryString["valor"];
            
            string n = valor;

            ReportDocument oRep1 = new ReportDocument();

            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pf.Name = "@numCotizacion";
            pdv.Value = n;
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);
            CrystalReportViewer1.ParameterFieldInfo = pfs;
            oRep1.Load(Server.MapPath("~\\Views\\Mod_Reportes\\rpt_DetalleCotizacion.rpt"));
            oRep1.SetDatabaseLogon("Dev", "@6209studio", @"COGNOS-SERVER", "BI_VENTAS"); //Parametros DB 
            CrystalReportViewer1.ReportSource = oRep1;
            CrystalReportViewer1.ShowFirstPage();
        }
    }
}