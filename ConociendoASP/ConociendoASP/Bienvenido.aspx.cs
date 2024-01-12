using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConociendoASP
{
    public partial class Bienvenido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Fecha actual
            lblFecha.Text = DateTime.Today.ToString("D");

            // Hora actual
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}