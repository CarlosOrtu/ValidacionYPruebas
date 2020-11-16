<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebApplication.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
            font-size: large;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 237px;
        }
        .auto-style4 {
            width: 237px;
        }
        .auto-style5 {
            height: 26px;
            width: 382px;
        }
        .auto-style6 {
            width: 382px;
        }
        .auto-style7 {
            height: 26px;
            width: 249px;
        }
        .auto-style8 {
            width: 249px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Cambio de contraseña</strong></caption>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style3">Contraseña actual:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TBOldPassword" runat="server" TextMode="Password" Width="386px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="ErrorChangePassword" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">Contraseña nueva:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TBChangePassword" runat="server" TextMode="Password" Width="386px"></asp:TextBox>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">Repite la nueva contraseña:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TBChangePassword2" runat="server" TextMode="Password" Width="386px"></asp:TextBox>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="ButtonChangePassword" runat="server" OnClick="ButtonChangePassword_Click" Text="Aceptar" />
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
