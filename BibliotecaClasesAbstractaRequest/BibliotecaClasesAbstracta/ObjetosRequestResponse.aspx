<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ObjetosRequestResponse.aspx.cs" Inherits="ObjetosRequestResponse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        LECCION 3.2 :: OBJETOS REQUEST Y RESPONSE<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Informacion del navegaddor" />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>YouTube</asp:ListItem>
            <asp:ListItem>Netflix</asp:ListItem>
            <asp:ListItem>HBOMax</asp:ListItem>
            <asp:ListItem>DisneyPlus</asp:ListItem>
            <asp:ListItem>PrimeVideo</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ir al sitio seleccionado" />
        <br />
    
    </div>
    </form>
</body>
</html>
