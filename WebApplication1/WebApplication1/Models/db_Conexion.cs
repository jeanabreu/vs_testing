using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication1.Views;


namespace WebApplication1.Models
{
    public class db_Conexion
    {

        public void  SQLserver_conexion()
        {
            string strConexion = "Data Source = COGNOS - SERVER; Initial Catalog = BI_VENTAS; Persist Security Info = True; User ID = dev";

            try
            {
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    conexion.Open();
                    string ConsultaCmd = "SELECT RFDCNO FROM PCPCOHD0 WHERE RFDCNO = '00Q289473'";
                    SqlCommand cmd = new SqlCommand(ConsultaCmd, conexion);
                    cmd.ExecuteNonQuery();
                    //
                }
            }
            catch (SqlException er)
            {
                    //("<script>window.alert('Bienvenido');</script>" + er.Message);
            }
        }
    }
}