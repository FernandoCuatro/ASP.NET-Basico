using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PasarInfoOrigen : System.Web.UI.Page
{
    // Zona de propiedades
    public TextBox nombreOrigen { get { return this.txtNombre; } }
    public TextBox identificacionOrigen { get { return this.txtIdentificacion; } }
    public TextBox celularOrigen { get { return this.txtCelular; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        Application["MetodoPasar"] = "";
        Application["MetodoPasar"] = RadioButtonList1.SelectedItem;
        Application["opcionRadioBtn"] = RadioButtonList1.SelectedIndex + 1;
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Application["MetodoPasar"] = "";
        Application["MetodoPasar"] = RadioButtonList1.SelectedItem;
        Application["opcionRadioBtn"] = RadioButtonList1.SelectedIndex + 1;

        switch ((int)Application["opcionRadioBtn"]) // Inicia en cero, incrementamos en una unidad. 
        {
            case 1: 
            // Metodo de propiedades
            // Implemento en la pagina de destino
            break;

            case 2: 
            // Metodo de estado de Sesion
            String nombre = this.txtNombre.Text;
            String diu = this.txtIdentificacion.Text;
            String telefono = this.txtCelular.Text;

            // Usamos el estado de sesion
            Session.Add("SNombre", nombre);
            Session.Add("SDui", diu);
            Session.Add("STelefono", telefono);

            // Rediccionaramos a la segunda pagina (Destino)
            // No requiere el uso del bton de comando
            Server.Transfer("PasarInfoDestino.aspx");
            // Response.Redirect("PasarInfoDestino.aspx", false);
            break;

            case 3:
            // Metodo FindControl
            // Implemente en la pagina de destino
            break;

            case 4: // Cadenas URL
            string varNombre = this.txtNombre.Text;
            string varDui = this.txtIdentificacion.Text;
            string varCelular = this.txtCelular.Text;

            // Comando que redirecciona la cadena
            Response.Redirect("PasarInfoDestino.aspx?parNombre="+ varNombre + 
                              "&parDui=" + varDui + 
                              "&parCelular=" + varCelular);
            break;

            case 5: // Cokies, propiedades
            if (Request.Browser.Cookies)
            {
                // Creamos las Cookies
                Response.Cookies["DatosEstudiante"]["CKNombre"] = this.txtNombre.Text;
                Response.Cookies["DatosEstudiante"]["CKDui"] = this.txtIdentificacion.Text;
                Response.Cookies["DatosEstudiante"]["CKCelular"] = this.txtCelular.Text;
            }
            break;

            case 6: // Cookies, HttpCookies

            // Creamos un objeto tipo HttpCookies
            HttpCookie objCookieEstudiante =  new HttpCookie("DatosEstudiante");

            // Instnciamos la clase
            objCookieEstudiante["CKNombre"] = this.txtNombre.Text;
            objCookieEstudiante["CKDui"] = this.txtIdentificacion.Text;
            objCookieEstudiante["CKCelular"] = this.txtCelular.Text;

            /// Agreo las llaves a la collecion 
            Response.Cookies.Add(objCookieEstudiante);
            
            break;
        }


    }

}