<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectAdministration.aspx.cs" Inherits="WebApplication.ProjectAdministration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-decoration: underline;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style6 {
            width: 1146px;
            text-align: center;
        }
        .auto-style7 {
            width: 162px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Adminsitración de proyectos</strong></caption>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="162px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="ButtonCreateUser" runat="server" OnClick="ButtonCreateUser_Click" Text="Crear proyecto" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Borrar proyectos" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="ButtonAddUserProject" runat="server" OnClick="ButtonAddUserProject_Click" Text="Añadir usuario a un proyecto" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
