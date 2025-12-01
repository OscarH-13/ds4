<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio203.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos - Laptops</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:650px; margin:20px auto; font-family:Segoe UI, Arial">

            <h2>Gestión de Laptops</h2>

            <!-- Barra de botones superior con imágenes -->
            <div style="margin-bottom:15px;">
                <asp:ImageButton ID="btnNuevo" runat="server"
                    ImageUrl="~/img/nuevo.png"
                    Width="36" Height="36"
                    ToolTip="Nuevo"
                    OnClick="btnNuevo_Click" />

                <asp:ImageButton ID="btnGuardar" runat="server"
                    ImageUrl="~/img/guardar.png"
                    Width="36" Height="36"
                    ToolTip="Guardar"
                    OnClick="btnGuardar_Click" />

                <asp:ImageButton ID="btnCancelar" runat="server"
                    ImageUrl="~/img/cancelar.png"
                    Width="36" Height="36"
                    ToolTip="Cancelar"
                    OnClick="btnCancelar_Click" />

                <asp:ImageButton ID="btnEliminar" runat="server"
                    ImageUrl="~/img/eliminar.png"
                    Width="36" Height="36"
                    ToolTip="Eliminar"
                    OnClick="btnEliminar_Click" />

            </div>

            <!-- Buscar por id -->
            <asp:Label ID="Label1" runat="server" Text="Buscar por id: "></asp:Label>
            <asp:TextBox ID="txtBuscarId" runat="server"></asp:TextBox>

            <asp:ImageButton ID="btnBuscar" runat="server"
                ImageUrl="~/img/buscar.png"
                Width="36" Height="36"
                ToolTip="Buscar"
                OnClick="btnBuscar_Click" />

            <br /><br />

            <!-- Campos de edición -->
            <table>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Id:" /></td>
                    <td><asp:TextBox ID="txtId" runat="server" Width="80px" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Nombre:" /></td>
                    <td><asp:TextBox ID="txtNombre" runat="server" Width="400px" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Precio:" /></td>
                    <td><asp:TextBox ID="txtPrecio" runat="server" Width="120px" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Stock:" /></td>
                    <td><asp:TextBox ID="txtStock" runat="server" Width="120px" /></td>
                </tr>
            </table>

            <br />

            <!-- Mensajes -->
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>

            <br /><br />

            <!-- Botón Salir -->
            <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />

        </div>
    </form>
</body>
</html>
