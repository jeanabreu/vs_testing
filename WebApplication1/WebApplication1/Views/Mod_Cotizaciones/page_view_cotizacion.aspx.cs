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
        public ReportDocument oRep1 = new ReportDocument();

        protected void Page_Load(object sender, EventArgs e)
        {
           

            //base.Page_Load(sender, e);
            String valor = Request.QueryString["valor"];

            string n = valor;

          
            if (IsPostBack) // Evento PostBack, valida la session y generar el reporte
            {
                oRep1 = (ReportDocument)Session["Reporte"];
               
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@numCotizacion";
                pdv.Value = n;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);
                //Session["Reporte"] = null;
                CrystalReportViewer1.ParameterFieldInfo = pfs;
                //oRep1.Load(Server.MapPath(@"E:\WebApps\appCotizacion\Views\Mod_Reportes\rpt_DetalleCotizacion.rpt"));
                //oRep1.Load(Server.MapPath("~\\Views\\Mod_Reportes\\rpt_DetalleCotizacion.rpt"));
                oRep1.Load(Server.MapPath("rpt_DetalleCotizacion.rpt"));
                oRep1.SetDatabaseLogon("Dev", "@6209studio", @"COGNOS-SERVER", "BI_VENTAS"); //Parametros DB 
                CrystalReportViewer1.ReportSource = oRep1;
                CrystalReportViewer1.ShowFirstPage();             

            }

            if (Session["Reporte"] == null) //Generacion de Reporte inicial
            {
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@numCotizacion";
                pdv.Value = n;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);
                CrystalReportViewer1.ParameterFieldInfo = pfs;
                //oRep1.Load(Server.MapPath(@"E:\WebApps\appCotizacion\Views\Mod_Reportes\rpt_DetalleCotizacion.rpt"));
                oRep1.Load(Server.MapPath("rpt_DetalleCotizacion.rpt"));
                oRep1.SetDatabaseLogon("Dev", "@6209studio", @"COGNOS-SERVER", "BI_VENTAS"); //Parametros DB 
                Session.Add("Reporte", oRep1);
                CrystalReportViewer1.ReportSource = oRep1;
                CrystalReportViewer1.ShowFirstPage();             
            }
            else 
            {
                oRep1 = (ReportDocument)Session["Reporte"];
                CrystalReportViewer1.ReportSource = oRep1;
            }

        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {

            if (Session["Reporte"] != null) //Remueve la sesion al inicializar 
            {
                //oRep1.Close();
                //oRep1.Dispose();
               // Session.Remove("Reporte");
            }
        }

        protected void btCerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("Reporte");
            Response.Write("<script type='text/javascript'>window.close();</script>");
        }
    }
}