<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SolicitantesNuevo.aspx.cs" Inherits="SolicitantesNuevo" %>

<!DOCTYPE html>
<html>
<body>
    <form runat="server">
        <h2>Nuevo Solicitante</h2>

        Nombre:<br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />

        Apellido:<br />
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox><br /><br />

        Cédula:<br />
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        Estado del Pasaporte:<br />
        <asp:DropDownList ID="ddlEstado" runat="server">
            <asp:ListItem>Pendiente</asp:ListItem>
            <asp:ListItem>En Proceso</asp:ListItem>
            <asp:ListItem>Aprobado</asp:ListItem>
            <asp:ListItem>Rechazado</asp:ListItem>
        </asp:DropDownList>
<br /><br />
    </form>
</body>
</html>
