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
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            width: 1346px;
        }
        .auto-style7 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style8 {
            width: 1061px;
        }
        .auto-style10 {
            width: 143px;
            text-align: right;
        }
        .auto-style11 {
            width: 510px;
        }
        .auto-style12 {
            width: 303px;
        }
        .auto-style13 {
            font-size: xx-large;
            text-decoration: underline;
            color: #0000CC;
        }
        .auto-style14 {
            width: 1346px;
            height: 25px;
        }
        .auto-style15 {
            width: 303px;
            height: 25px;
        }
        .auto-style16 {
            width: 1061px;
            height: 25px;
        }
        .auto-style17 {
            width: 143px;
            height: 25px;
        }
        .auto-style19 {
            text-align: left;
            font-size: large;
            text-decoration: underline;
        }
        .auto-style20 {
            height: 26px;
            width: 101px;
        }
        .auto-style21 {
            width: 101px;
        }
        .auto-style22 {
            height: 26px;
            width: 228px;
        }
        .auto-style23 {
            width: 228px;
        }
    </style>
</head>
<body style="height: 397px">
    <form id="form1" runat="server">
        <table style="width:100%;">
            <caption class="auto-style13">
                <strong>Menu Principal</strong></caption>
            <tr>
                <td class="auto-style5">
                    Ultimo cambio de contraseña:
                    <asp:Label ID="lblLastPasswordChange" runat="server"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Button ID="ButtonListProjects" runat="server" OnClick="ButtonListProjects_Click" Text="Ver la lista de proyectos" Width="290px" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="ButtonLogOut" runat="server" OnClick="ButtonLogOut_Click" Text="Cerrar sesión" Width="164px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    Ultimo inicio de sesión:&nbsp;
                    <asp:Label ID="lblLastLogin" runat="server"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:Button ID="ButtonChangeUserDates" runat="server" OnClick="ButtonChangeUserDates_Click" Text="Cambiar datos de usuario" Width="290px" />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="ButtonChangePassword" runat="server" CssClass="auto-style4" OnClick="ButtonChangePassword_Click" Text="Cambiar contraseña" Width="165px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style1">
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <table class="auto-style7">
                        <caption class="auto-style19">
                            <strong>Info. Usuario</strong></caption>
                        <tr>
                            <td class="auto-style20">Nombre de Usuario:</td>
                            <td class="auto-style22">
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Email:</td>
                            <td class="auto-style23">
                                <asp:Label ID="lblEmail" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Nombre</td>
                            <td class="auto-style23">
                                <asp:Label ID="lblName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Apellidos:</td>
                            <td class="auto-style23">
                                <asp:Label ID="lblSurname" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Teléfono</td>
                            <td class="auto-style23">
                                <asp:Label ID="lblPhone" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">&nbsp;</td>
                            <td class="auto-style23">&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style12">
                    <table class="auto-style7">
                        <caption>
                            <asp:Label ID="LblTitleAdmin" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Underline="True" ForeColor="#003300"></asp:Label>
                        </caption>
                        <tr>
                            <td class="auto-style11">
                                <asp:Button ID="ButtonAdminisUser" runat="server" Text="Administración de usuarios" Visible="False" Width="287px" OnClick="ButtonAdminisUser_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:Button ID="ButtonAdminisProyect" runat="server" Text="Administración de proyectos" Visible="False" Width="288px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
                <td class="auto-style17">
                    </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style8">
                    <table class="auto-style7">
                    </table>
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
