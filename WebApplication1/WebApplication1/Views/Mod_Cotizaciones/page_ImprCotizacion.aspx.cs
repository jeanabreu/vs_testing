﻿using System;
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
using System.Web.Configuration;


namespace WebApplication1.Views
{

    public partial class page_ImprCotizacion : System.Web.UI.Page
    {
        CrystalDecisions.CrystalReports.Engine.ReportDocument oRep = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        
        public void Page_Load(object sender, EventArgs e)
        {
            //btnMostrarReporte.Enabled = false;                    
        }

        public string strConexion = "Data Source = COGNOS-SERVER; Initial Catalog = BI_VENTAS; Persist Security Info = True; User ID = dev; Password=@6209studio";

        //Conexion con BD SQL SERVER//
        public void SQLserver_conexion()
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    

                    conexion.Open();

                    //Consulta -  MSSQL Local string ConsultaCmd = "SELECT TOP 1 CUNM FROM PCPCOHD0 WHERE RFDCNO = '" + txtConsultar.Text + "'";
                    string ConsultaCmd = " SELECT * FROM OPENQUERY(AS400P, 'SELECT CUNM FROM LIBP16.PCPCOHD0 WHERE RFDCNO = ''" + txtConsultar.Text + "''')";
                    SqlCommand cmd = new SqlCommand(ConsultaCmd, conexion);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                   
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            NotConsulta.InnerHtml = (" <p class='alert alert-success'>" + reader.FieldCount + " Registro encontrado a nombre de: " + reader.GetString(0) + "</p> ");
                        }

                        //Mostrar el Reporte en un Pop-Up
                        MostrarReporte();
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

        }

        public void btMostrarReporte_Click(object sender, EventArgs e)
        {
              try
              {
                 string  n = txtConsultar.Text;

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

              catch (SqlException er)
              {
                  NotConsulta.InnerHtml = (" <p class='alert alert-danger'>Error: El reporte no pudo ser generado: ');" + er.Message + "</p> ");
              }
        }
        

        public void MostrarReporte()
        {   
            //Pop-up, pasando el valor de la Texbox
            string valor = txtConsultar.Text;
            string url = "page_view_cotizacion.aspx";
            string s = "window.open('" + url + "?valor=" + valor + "', 'popup_window', 'width=1350,height=700,left=400,top=300,resizable=yes');";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
        }
    }
}