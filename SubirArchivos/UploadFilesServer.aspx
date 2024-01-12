<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadFilesServer.aspx.cs" Inherits="UploadFilesServer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 408px; width: 788px">
    <form id="form1" runat="server">
    <div>
    
        Lección 4.1 :: Subir archivos del cliente al servidor [Upload Files al Servidor]</div>
        <h2 class="auto-style1">Subir actividades al servidor </h2>
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 10px; top: 98px; position: absolute; height: 260px; width: 468px">
            <br />
            Se lecciona la actividad a subir:<br />
            <asp:FileUpload ID="FileUpload1" runat="server" style="z-index: 1; left: 42px; top: 52px; position: absolute; width: 369px;" />
            <br />
            <br />
            <asp:Button ID="btnEnviarActividad" runat="server" OnClick="btnEnviarActividad_Click" style="z-index: 1; left: 297px; top: 94px; position: absolute" Text="Enviar actividad" />
            <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#FF0066" style="z-index: 1; left: 17px; top: 144px; position: absolute; width: 429px"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
