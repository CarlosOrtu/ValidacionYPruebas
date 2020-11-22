<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProyectList.aspx.cs" Inherits="WebApplication.ProyectList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="295px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
