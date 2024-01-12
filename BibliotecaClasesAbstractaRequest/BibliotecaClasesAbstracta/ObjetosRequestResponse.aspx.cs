using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ObjetosRequestResponse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<p>");


        string servidor = Request.UserHostAddress;
        Response.Write("Direccion del servidor actual: " + servidor + "<p>");

        string rutaApp = Request.AppRelativeCurrentExecutionFilePath;
        Response.Write("Ruta actual de la aplicacion: " + rutaApp + "<p>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "YouTube")
        {
            Response.Redirect("https://www.youtube.com/");
        }
        if (RadioButtonList1.SelectedValue == "Netflix")
        {
            Response.Redirect("https://www.netflix.com/sv/");
        }
        if (RadioButtonList1.SelectedValue == "HBOMax")
        {
            Response.Redirect("https://play.hbomax.com/");
        }
        if (RadioButtonList1.SelectedValue == "DisneyPlus")
        {
            Response.Redirect("https://www.disneyplus.com/");
        }
        if (RadioButtonList1.SelectedValue == "PrimeVideo")
        {
            Response.Redirect("https://www.primevideo.com/");
        }
    }
}