<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PasarInfoOrigen.aspx.cs" Inherits="PasarInfoOrigen" EnableSessionState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        LECCION 3.3 :: GESTION DE ESTADO DE LA INFORMACION [Metodo para el paso de datos]<br />
        <br />
        DATOS BASICOS DEL ESTUDIANTE:<br />
        <br />
        Ingrese sus datos iniciales:
        <br />
        <br />
        Nombre completo:&nbsp;
        <asp:TextBox ID="txtNombre" runat="server" Width="294px" CausesValidation="True"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese el nombre correctamente." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Indentificacion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtIdentificacion" runat="server" Height="18px" Width="294px" CausesValidation="True"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtIdentificacion" ErrorMessage="Ingrese la identificación correctamente." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Numero celular:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCelular" runat="server" Width="294px" CausesValidation="True"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCelular" ErrorMessage="Ingrese el telefono correctamente." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        METODOS DMETODOS DE TRANSFERENCIA DE DATOS:<br />
        <asp:Panel ID="Panel1" runat="server" Height="155px">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Font-Bold="True" Width="450px">
                <asp:ListItem Value="propiedades">1. Propiedades [CrossingPosting]</asp:ListItem>
                <asp:ListItem Value="estadoSesion">2. Estado de Sesion [Session y Trasnsfer]</asp:ListItem>
                <asp:ListItem Value="FindControl">3. FindControl</asp:ListItem>
                <asp:ListItem Value="CadenasURL">4. CadenasURL [QueryString]</asp:ListItem>
                <asp:ListItem Value="cookies">5. Cookies [Propiedades]</asp:ListItem>
                <asp:ListItem Value="cookies[httpcookies]">6. Cookies[HttpCookies]</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Seleccione un metodo de trasferencia" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="Medium" ForeColor="Black" Text="Complete su registro ahora" Font-Bold="True" Font-Italic="False" Font-Underline="False" PostBackUrl="~/PasarInfoDestino.aspx" />
        <br />
    
    </div>
    </form>
</body>
</html>
