<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="CapaPresentacion2.Principal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Principal</title>
</head>
<body>
    <div>
    <form id="form1" runat="server">
        <h2>Siii se pudoo</h2>
        <p>Inicio sesión correcto</p>
        <h3>Usuario:<asp:Label ID="lblusuario" Text="text" runat="server"></asp:Label></h3>
        <form><asp:Button ID= "Button1" Text="Cerrar Sesion" runat="server" OnClick="out_Click"/></form>
      </div>
    </form>
</body>
</html>
