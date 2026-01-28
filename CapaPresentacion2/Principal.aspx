<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Principal.aspx.cs"
    Inherits="CapaPresentacion2.Principal" %>

<form id="form1" runat="server">
    <asp:TextBox ID="txtUsuario" runat="server" />
    <asp:TextBox ID="txtClave" runat="server" TextMode="Password" />
    <asp:Button ID="btnLogin" runat="server"
        Text="Ingresar"
        OnClick="btnLogin_Click" />
    <asp:Label ID="lblMensaje" runat="server" />
</form>
