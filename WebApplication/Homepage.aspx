<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WebApplication.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 143px;
        }
        .auto-style2 {
            width: 735px;
        }
        .auto-style3 {
            width: 59px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            width: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonListProjects" runat="server" OnClick="ButtonListProjects_Click" Text="Ver la lista de proyectos" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="ButtonLogOut" runat="server" OnClick="ButtonLogOut_Click" Text="Cerrar sesión" Width="164px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="ButtonChangePassword" runat="server" CssClass="auto-style4" OnClick="ButtonChangePassword_Click" Text="Cambiar contraseña" Width="165px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Label ID="lblLastPasswordChange" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
