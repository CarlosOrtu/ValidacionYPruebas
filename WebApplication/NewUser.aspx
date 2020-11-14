<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="WebApplication.NewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
            height: 27px;
        }
        .auto-style2 {
            width: 367px;
        }
        .auto-style3 {
            width: 367px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 209px;
            height: 26px;
            text-align: right;
        }
        .auto-style6 {
            width: 209px;
            text-align: right;
        }
        .auto-style7 {
            width: 367px;
            height: 29px;
        }
        .auto-style8 {
            width: 209px;
            text-align: right;
            height: 29px;
        }
        .auto-style9 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Crea un nuevo usuario</strong></caption>
                <tr>
                    <td class="auto-style3"><strong>Rellena los siguientes datos para continuar:</strong></td>
                    <td class="auto-style5">Nombre de usuario:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="NewTBUserName" runat="server" Width="368px"></asp:TextBox>
                        <asp:Label ID="ErrorUserNameExists" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">Contraseña:</td>
                    <td>
                        <asp:TextBox ID="NewTBPassword" runat="server" TextMode="Password" Width="368px"></asp:TextBox>
                        <asp:Label ID="ErrorPassword" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">Repite la contraseña:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="NewTBRepeatPassword" runat="server" TextMode="Password" Width="368px"></asp:TextBox>
                        <asp:Label ID="ErrorRepeat" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">Email:</td>
                    <td>
                        <asp:TextBox ID="NewTBEmail" runat="server" TextMode="Email" Width="368px"></asp:TextBox>
                        <asp:Label ID="ErrorEmail" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="109px" />
                    </td>
                    <td class="auto-style6">Nombre:</td>
                    <td>
                        <asp:TextBox ID="NewTBName" runat="server" Width="368px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">Apellidos:</td>
                    <td>
                        <asp:TextBox ID="NewTBSurname" runat="server" Width="368px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">Teléfono:</td>
                    <td>
                        <asp:TextBox ID="NewTBPhone" runat="server" TextMode="Phone" Width="368px"></asp:TextBox>
                        <asp:Label ID="ErrorPhone" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>
                        <asp:Button ID="ButtonCreateNewUser" runat="server" OnClick="ButtonCreateNewUser_Click" Text="Aceptar" Width="372px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
