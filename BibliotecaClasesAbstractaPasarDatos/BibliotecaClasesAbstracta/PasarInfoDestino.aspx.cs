using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PasarInfoDestino : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.GroupingText = "DATOS BASICOS | ENVIADOS CON EL METODO #" + Application["MetodoPasar"] + " ";
        
        switch ((int)Application["opcionRadioBtn"])
        {
            case 1: // Propiedades
            Label1.Text = "¡Hola! " + this.PreviousPage.nombreOrigen.Text + "<br/>"
                        + "Estas a un paso de obtener tu registro. <br/>";

            Label2.Text = "Tu documento unico de indentidad es: " + PreviousPage.identificacionOrigen.Text;
            Label3.Text = "Tu celular es: " + PreviousPage.celularOrigen.Text;
            break;

            case 2: // Estado de Sesion
            string nombre = (string)(Session["SNombre"]);
            string diu = (string)(Session["SDui"]);
            string telefono  = (string)(Session["STelefono"]);

            Label1.Text = "¡Holis! " + nombre + ", Ya estas registrado.";
            Label2.Text = "DUI: " + diu;
            Label3.Text = "Celular: " + telefono;
            break;

            case 3: // FindControl
            TextBox varNombre = (TextBox) Page.PreviousPage.FindControl("txtNombre");
            TextBox varDui = (TextBox) Page.PreviousPage.FindControl("txtIdentificacion");
            TextBox varTelefono = (TextBox) Page.PreviousPage.FindControl("txtCelular");

            Label1.Text = varNombre.Text + ", Registrado.";
            Label2.Text = "DUI >> " + varDui.Text;
            Label3.Text = "Celular >> " + varTelefono.Text;
            break;

            case 4: // Cadenas URL
            Label1.Text = "==========\n" + (Request.QueryString["parNombre"]) + " ¡Hola!";
            Label2.Text = ">>>> DUI: " + (Request.QueryString["parDui"]);
            Label3.Text = ">>>> Celular: " + (Request.QueryString["parCelular"]);
            break;

            case 5: // Cookie, propiedades
            case 6: // Cookie, HttpCookie
            Label1.Text = "Hi! " + Request.Cookies["DatosEstudiante"]["CKNombre"] + ", Welcome!";
            Label2.Text = "DNI : " + Request.Cookies["DatosEstudiante"]["CKDui"];
            Label3.Text = "Telephone : " + Request.Cookies["DatosEstudiante"]["CKCelular"];
            break;
            

        }
    }
}