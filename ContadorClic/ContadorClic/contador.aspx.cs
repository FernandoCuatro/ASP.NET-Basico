using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContadorClic
{
    public partial class contador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Incrementamos el contador de la session
            Session["Clicks"] = (int)Session["Clicks"] + 1;

            // Mostramos el mensaje
            Response.Write($"Total de clicks realizados en la sesión : {Session["Clicks"]} <br/>");
        }
    }
}