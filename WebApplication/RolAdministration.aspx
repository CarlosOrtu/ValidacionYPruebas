<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RolAdministration.aspx.cs" Inherits="WebApplication.RolAdministration" %>

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
            width: 1009px;
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
            height: 33px;
        }
        .auto-style4 {
            width: 237px;
        }
        .auto-style5 {
            width: 237px;
            height: 33px;
        }
        .auto-style6 {
            width: 1009px;
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Administración de roles</strong></caption>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style3">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="162px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear rol" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonChangeRol" runat="server" OnClick="ButtonChangeRol_Click" Text="Modificar datos rol" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Borrar rol" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
