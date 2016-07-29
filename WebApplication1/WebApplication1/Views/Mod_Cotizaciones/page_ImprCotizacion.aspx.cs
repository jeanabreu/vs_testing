using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Web;
using CrystalDecisions.Shared;


namespace WebApplication1.Views
{
    public partial class page_ImprCotizacion : System.Web.UI.Page
    {

        public void Page_Load(object sender, EventArgs e)
        {
            btnMostrarReporte.Enabled = false;
            lbTituloReporte.Enabled = false;
        }

        //Conexion con BD SQL SERVER//
        public void SQLserver_conexion()
        {
            string strConexion = "Data Source = COGNOS-SERVER; Initial Catalog = BI_VENTAS; Persist Security Info = True; User ID = dev; Password=@6209studio";

            try
            {
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    conexion.Open();

                    string ConsultaCmd = "SELECT TOP 1 CUNM FROM PCPCOHD0 WHERE RFDCNO = '" + txtConsultar.Text + "'";
                    SqlCommand cmd = new SqlCommand(ConsultaCmd, conexion);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteNonQuery();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            NotConsulta.InnerHtml = (" <p class='alert alert-success'>" + reader.FieldCount + " Registro encontrado a nombre de: " + reader.GetString(0) + "</p> ");
                        }

                        //Habitar Boton luego de Encontrar el registro
                        btnMostrarReporte.Enabled = true;

                    }
                    else
                    {
                        NotConsulta.InnerHtml = (" <p class='alert alert-danger'> No se encontraron registros con este #:" + txtConsultar.Text + "</p> ");
                    }

                    conexion.Close();

                }
            }
            catch (SqlException er)
            {
                NotConsulta.InnerHtml = (" <p class='alert alert-danger'>Error: No Conectado con DB, Error:');" + er.Message + "</p> ");
            }
        }

        //Evento Boton Consultar//
        public void btConsultarNumero_Click(object sender, EventArgs e)
        {
            string a = txtConsultar.Text;

            if (txtConsultar.Text != null)
            {

                SQLserver_conexion();

            }
            if (String.IsNullOrEmpty(a))
            {
                NotConsulta.InnerHtml = " <p class='alert alert-danger'> El Campo esta vacio o NO es valido </p> ";
            }

            /*else
            {
                NotConsulta.InnerHtml = " <p class='alert alert-danger'> No se encontro el # de Cotizacion o la misma fue Procesada! </p> ";
            }*/

            //============Inicio Reporte en Crystal============//
            /* ReportDocument crCotizaciones = new ReportDocument();
             crCotizaciones.Load(Server.MapPath("~/Mod_Reportes/rpt_Cotizacion.rpt"));
             crCotizaciones.SetDataSource(ConsultaCmd);
             CrystalReportViewer1.ReportSource = crCotizaciones;*/

            //============Fin Reporte en Crystal============//
        }

        public void btMostrarReporte_Click(object sender, EventArgs e)
        {
            string n = txtConsultar.Text;

            P
            ReportDocument oRep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pf.Name = "@numCotizacion";
            pdv.Value = n ;
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);
            CrystalReportViewer1.ParameterFieldInfo = pfs;
            oRep.Load(@"C:\Users\jmabreu\Source\Repos\vs_testing\WebApplication1\WebApplication1\Views\Mod_Reportes\rpt_DetalleCotizacion.rpt");
            CrystalReportViewer1.ReportSource = oRep;
            CrystalReportViewer1.ShowFirstPage();

        }

    }
}