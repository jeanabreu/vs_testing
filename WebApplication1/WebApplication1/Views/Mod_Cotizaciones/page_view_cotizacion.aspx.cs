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

            if (IsPostBack) // Evento PostBack, valida la session y general el reporte
            {
                oRep1 = (ReportDocument)Session["Report"];
                //Session["Report"] = null;
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@numCotizacion";
                pdv.Value = n;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);
                Session["Report"] = null;
                CrystalReportViewer1.ParameterFieldInfo = pfs;
                oRep1.Load(Server.MapPath("~\\Views\\Mod_Reportes\\rpt_DetalleCotizacion.rpt"));
                oRep1.SetDatabaseLogon("Dev", "@6209studio", @"COGNOS-SERVER", "BI_VENTAS"); //Parametros DB 
                CrystalReportViewer1.ReportSource = oRep1;
                CrystalReportViewer1.ShowFirstPage();             

            }

            if (Session["Report"] == null) //Generacion de Reporte inicial
            {
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
                Session.Add("Report", oRep1);
                CrystalReportViewer1.ReportSource = oRep1;
                CrystalReportViewer1.ShowFirstPage();

                try
                {
                    oRep1.Close();
                    oRep1.Dispose();
                }
                catch { }
            }
           else 
            {
                oRep1 = (ReportDocument)Session["Report"];
                CrystalReportViewer1.ReportSource = oRep1;
            }
            

        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            
            /*try
            {
                oRep1.Close();
                oRep1.Dispose();
            }
            catch { }*/
        }


    }
}