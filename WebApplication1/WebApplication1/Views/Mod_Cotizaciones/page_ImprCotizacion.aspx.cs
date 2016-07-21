using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class page_ImprCotizacion : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btConsultarNumero_Click(object sender, EventArgs e)
        {
            int a = 1;
            if (a == 2)
            {
                //NotConsulta.InnerHtml = " <p class='alert alert-success'> OK! </p> ";
                //Response.Redirect("../Views/Mod_Portada/page_Portada.aspx");
                //Server.Transfer("../Views/Mod_Portada/page_Portada.aspx", true);
            }
            else
            {
                NotConsulta.InnerHtml = " <p class='alert alert-danger'> No se encontro el # de Cotizacion! </p> ";
            }
        }
    }
}