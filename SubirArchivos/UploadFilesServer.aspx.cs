using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UploadFilesServer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnviarActividad_Click(object sender, EventArgs e)
    {
        if (FileUpload1.FileName == "")
        {
            lblMensaje.Text = "¡Selecciona el archivo de la actividad a subir!";
        }
        else
        {
            FileUpload1.SaveAs(Server.MapPath("~/Actividades/") + FileUpload1.FileName);
            lblMensaje.Text = "El archivo " + FileUpload1.FileName + ", se proceso en el servidor correctamente";
        }
    }
}