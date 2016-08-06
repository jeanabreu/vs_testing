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
        private ReportDocument oRep1 = new ReportDocument();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //base.Page_Load(sender, e);
            String valor = Request.QueryString["valor"];

            string n = valor;

            if (IsPostBack) // post back event, check if report is in session if it is view it.
            {
                oRep1 = (ReportDocument)Session["Report"];
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@numCotizacion";
                pdv.Value = n;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);
                CrystalReportViewer1.ParameterFieldInfo = pfs;
                oRep1.Load(@"C:\Users\jmabreu\Source\Repos\vs_testing\WebApplication1\WebApplication1\Views\Mod_Reportes\rpt_DetalleCotizacion.rpt");
                //oRep1.Load(Server.MapPath("~\\Views\\Mod_Reportes\\rpt_DetalleCotizacion.rpt"));
                oRep1.SetDatabaseLogon("Dev", "@6209studio", @"COGNOS-SERVER", "BI_VENTAS"); //Parametros DB 
                CrystalReportViewer1.ReportSource = oRep1;
                CrystalReportViewer1.ShowFirstPage();
            }

            if (Session["Report"] == null) // Report is not in session (previously loaded) so load report, set params, view and place in session
            {
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@numCotizacion";
                pdv.Value = n;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);
                CrystalReportViewer1.ParameterFieldInfo = pfs;
                oRep1.Load(@"C:\Users\jmabreu\Source\Repos\vs_testing\WebApplication1\WebApplication1\Views\Mod_Reportes\rpt_DetalleCotizacion.rpt");  
                //oRep1.Load(Server.MapPath("~\\Views\\Mod_Reportes\\rpt_DetalleCotizacion.rpt"));
                oRep1.SetDatabaseLogon("Dev", "@6209studio", @"COGNOS-SERVER", "BI_VENTAS"); //Parametros DB 
                Session.Add("Report", oRep1);
                CrystalReportViewer1.ReportSource = oRep1;
                CrystalReportViewer1.ShowFirstPage();
            }
            else // Report is already loaded and in session so use it also means we never reload the report
            {
                oRep1 = (ReportDocument)Session["Report"];
                // Now send the report to the viewer
                CrystalReportViewer1.ReportSource = oRep1;
            }
            //// How I would do it to so report is reloaded when ever button is pressed (IE Refreshing report, or load a different report if option present)
              // oRep1 = new ReportDocument();
                    //  oRep1.Load(Server.MapPath("Report_To_Load"));
                    //  oRep1.SetDatabaseLogon("UserID", "UserPassword", "ServerName", "DatabaseName");
                    //  oRep1.SetParameterValue("LocationId", fwsuser.currentLocation);
                    //  Session.Add(“Report”, oRep1);
              // CrystalReportViewer.ReportSource = oRep1;
             












        //------------------------///
       

        //ReportDocument oRep1 = new ReportDocument();
    

            
            //oRep1.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, "ExportedReport");
            //oRep1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "I:\\ASD.pdf");
            /*
            String valor = Request.QueryString["valor"];

            string n = valor;

            //ReportDocument oRep1 = new ReportDocument();
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
            //oRep1.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, "ExportedReport");
            //oRep1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "I:\\ASD.pdf");
            */

        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            try
            {
                oRep1.Close();
                oRep1.Dispose();
            }
            catch { }
        }


    }
}