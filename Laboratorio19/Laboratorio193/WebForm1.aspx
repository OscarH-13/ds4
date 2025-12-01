<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consultar Item Fijo (ID = 2)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Resultado de la API (ID = 2)</h3>

            <asp:TextBox ID="txtRespuesta" runat="server"
                TextMode="MultiLine" Rows="15" Columns="80"
                ReadOnly="true"></asp:TextBox>
        </div>
    </form>
</body>
</html>
