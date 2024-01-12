<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenido.aspx.cs" Inherits="ConociendoASP.Bienvenido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" ForeColor="Red" Text="Bienvenido a ASP con C#"></asp:Label>
        <br />
        <br />
        Fecha y Hora ctual del sistema:
        <br />
        <br />
        <asp:Label ID="lblFecha" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblHora" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
