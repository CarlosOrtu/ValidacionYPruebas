<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            text-decoration: underline;
            width: 592px;
            height: 27px;
        }
        .auto-style3 {
            height: 26px;
            width: 592px;
        }
        .auto-style4 {
            width: 592px;
        }
        .auto-style5 {
            height: 27px;
        }
        .auto-style6 {
            text-decoration: underline;
            font-size: x-large;
        }
        .auto-style7 {
            width: 231px;
            height: 27px;
        }
        .auto-style8 {
            height: 26px;
            width: 231px;
        }
        .auto-style9 {
            width: 231px;
        }
        .auto-style10 {
            text-decoration: underline;
            width: 392px;
            height: 27px;
        }
        .auto-style11 {
            height: 26px;
            width: 392px;
        }
        .auto-style12 {
            width: 392px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style6">
                    <strong>Inicio de sesión</strong></caption>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style7">Nombre de usuario:</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox1" runat="server" Width="383px"></asp:TextBox>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style8">Contraseña</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox2" runat="server" Width="383px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style12">
                        <asp:Button ID="ButtonLogIn" runat="server" Text="Aceptar" Width="258px" />
                        <asp:Button ID="ButtonNewUser" runat="server" OnClick="Button1_Click" Text="Crear un nuevo usuario" />
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
