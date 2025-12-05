<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Solicitantes.aspx.cs" Inherits="Solicitantes" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Solicitantes</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Listado de Solicitantes</h2>

        <asp:Button ID="btnNuevo" Text="Agregar Nuevo" runat="server" OnClick="btnNuevo_Click" />

        <asp:GridView ID="gvSolicitantes" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ID_SOLICITANTE" HeaderText="ID" />
                <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" />
                <asp:BoundField DataField="APELLIDO" HeaderText="Apellido" />
                <asp:BoundField DataField="CEDULA" HeaderText="Cédula" />
                <asp:BoundField DataField="ESTADO" HeaderText="Estado" />
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>