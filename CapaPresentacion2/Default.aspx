<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CapaPresentacion2._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Login</h2>

        <asp:Label ID="Label1" runat="server" Text="Usuario:" /><br />
        <asp:TextBox ID="txtUsuario" runat="server" /><br /><br />

        <asp:Label ID="Label2" runat="server" Text="Clave:" /><br />
        <asp:TextBox ID="txtClave" runat="server" TextMode="Password" /><br /><br />

        <asp:Button ID="btnLogin" runat="server"
            Text="Ingresar"
            OnClick="btnLogin_Click" /><br /><br />

        <asp:Label ID="lblMensaje" runat="server" />
    </form>
</body>
</html>
