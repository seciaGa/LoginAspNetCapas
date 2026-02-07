<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Habitaciones.aspx.cs" Inherits="CapaPresentacion2.Habitaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Agregar habitaciones</h2>
        <asp:label ID="lblnumero" runat="server" Text="Numero de habitación"></asp:Label><br />
        <asp:TextBox ID="txtnumero" runat="server"></asp:TextBox><br />
        <asp:label ID="lbldescripcion" runat="server" Text="Descripcion general"></asp:Label> <br />
        <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox> <br />
        <asp:label ID="lblcant_huespedes" runat="server" Text="Cantidad de huespedes permitidos"></asp:Label><br />
        <asp:TextBox ID="txtcant" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnguardar" runat="server" Text="Guardar" OnClick="btnguardar_Click"/><br />
        <div>
        </div>
        <asp:GridView id="gvHabitaciones" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id_habitaciones" HeaderText="ID"/>
                <asp:BoundField DataField="numero" HeaderText="#"/>
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion"/>
                <asp:BoundField DataField="cant_huespedes" HeaderText="Max-Personas"/>

            </Columns>


        </asp:GridView>
    </form>
</body>
</html>
