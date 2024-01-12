<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PasarInfoDestino.aspx.cs" Inherits="PasarInfoDestino" EnableSessionState="True" %>

<!-- Para recuperar infomacion de una pagina previa, agregamos esta directiva. -->
<%@ PreviousPageType VirtualPath="~/PasarInfoOrigen.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        LECCION 3.3 :: GESTION DE ESTADO DE LA INFORMACION [Metodo para el paso de datos] [Destino]<br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="130px" Width="681px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
