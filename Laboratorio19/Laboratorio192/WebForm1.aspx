<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <asp:TextBox ID="txtRespuesta" runat="server"
            TextMode="MultiLine" Rows="15" Columns="80"
            ReadOnly="true"></asp:TextBox>
        </div>
    </form>
</body>
</html>
