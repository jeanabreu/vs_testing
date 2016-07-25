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


namespace WebApplication1.Views
{
    public partial class page_ImprCotizacion : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
                            NotConsulta.InnerHtml = (" <p class='alert alert-success'> El reporte OK " + reader.GetString(0) + "</p> ");
                        }
                        //============Inicio Reporte en Crystal============//
                        ReportDocument crCotizaciones = new ReportDocument();
                        crCotizaciones.Load(Server.MapPath("~/Mod_Reportes/rpt_Cotizacion.rpt"));
                        crCotizaciones.SetDataSource(ConsultaCmd);
                        CrystalReportViewer1.ReportSource = crCotizaciones;

                        //============Fin Reporte en Crystal============//

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
        }
    }
}