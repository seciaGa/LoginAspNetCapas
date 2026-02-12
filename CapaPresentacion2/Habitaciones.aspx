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
        <br />
        <asp:Button ID="btnguardar" runat="server" Text="Guardar" OnClick="btnguardar_Click"/>
        <div>
        </div><hr />
        <asp:GridView id="dgvHabitaciones" runat="server" AutoGenerateColumns="false" BackColor="#6699FF" 
            DataKeyNames="id_habitaciones" OnRowEditing="dgvHabitaciones_RowEditing"
            OnRowUpdating="dgvHabitaciones_RowUpdating"
            OnRowCancelingEdit="dgvHabitaciones_RowCancelingEdit"
            OnRowDeleting="dgvHabitaciones_RowDeleting" OnSelectedIndexChanged="gvHabitaciones_SelectedIndexChanged"
            >
      
            <Columns>
                <asp:BoundField DataField="id_habitaciones" HeaderText="ID"/>
                <asp:BoundField DataField="numero" HeaderText="#"/>
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion"/>
                <asp:BoundField DataField="cant_huespedes" HeaderText="Max-Personas"/>

                <asp:CommandField ShowEditButton="true" EditText="Editar"/>
                <asp:CommandField ShowDeleteButton="true" DeleteText="Eliminar" />

            </Columns>

        </asp:GridView>
    </form>
</body>
</html>
