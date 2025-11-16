<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Numero 1: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-top: 10px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Numero 2: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Resultado: "></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
