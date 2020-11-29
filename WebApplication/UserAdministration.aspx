<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAdministration.aspx.cs" Inherits="WebApplication.UserAdministration" %>

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
            width: 1076px;
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style5 {
            width: 100%;
            height: 308px;
        }
        .auto-style8 {
            width: 354px;
            color: #006699;
            height: 98px;
            text-align: center;
        }
        .auto-style10 {
            width: 364px;
        }
        .auto-style11 {
            width: 364px;
            text-align: center;
        }
        .auto-style12 {
            width: 364px;
            color: #006699;
        }
        .auto-style13 {
            width: 353px;
            height: 98px;
        }
        .auto-style14 {
            height: 98px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Administración de usuarios </strong></caption>
                <tr>
                    <td class="auto-style12"><strong>Vista previa de usuarios disponibles:&nbsp; </strong>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="32px" ImageUrl="~/Images/Usuario.png" Width="36px" />
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="170px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:DropDownList ID="DropUsers" runat="server" Width="352px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonUserAccess" runat="server" OnClick="ButtonUserAccess_Click" Text="Administrar permisos usuarios" Width="304px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonDeleteUsers" runat="server" OnClick="ButtonDeleteUsers_Click" Text="Borrar usuarios" Width="304px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table class="auto-style5">
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style13"></td>
                <td class="auto-style14"></td>
            </tr>
        </table>
    </form>
</body>
</html>
