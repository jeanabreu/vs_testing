using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Test_Click(object sender, EventArgs e)
        {
            
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string usuario  = "";
            string password = "";

            usuario     = email.Text;
            password    = tpassword.Text;

            if (usuario == "admin" && password == "123456")
            {
                myDiv.InnerHtml = " <p class='alert alert-success'> OK! </p> ";
            }
            else
            {
                myDiv.InnerHtml = " <p class='alert alert-danger'> Error de Autenticacion! </p> " ;
            }
        }
    }
}