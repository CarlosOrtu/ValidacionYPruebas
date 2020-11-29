<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAccess.aspx.cs" Inherits="WebApplication.UserAccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            text-decoration: underline;
        }
        .auto-style2 {
            width: 336px;
        }
        .auto-style3 {
            width: 336px;
            height: 26px;
            text-align: right;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 420px;
        }
        .auto-style6 {
            height: 26px;
            width: 420px;
        }
        .auto-style7 {
            text-decoration: underline;
        }
        .auto-style8 {
            width: 211px;
        }
        .auto-style9 {
            width: 254px;
        }
        .auto-style10 {
            height: 26px;
            width: 254px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Administrar el acceso de usuarios</strong></caption>
                <tr>
                    <td class="auto-style2">Selecciona un usuario pulsa en mostrar opciones de permisos, marca la casilla que desees y por ultimo pulsa en Aplicar permisos:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropUsers" runat="server" Width="420px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="124px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style8"><strong><span class="auto-style7">Dar permisos</span></strong></td>
                                <td><strong><span class="auto-style7">Quitar permisos</span></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style8">
                                    <asp:CheckBox ID="CheckBoxUser" runat="server" Text="Adminstrador de usuarios" Visible="False" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="CheckBoxNOUser" runat="server" Text="Dejar de ser administrador de usuarios" Visible="False" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8"><asp:CheckBox ID="CheckBoxProject" runat="server" Text="Administrador de proyectos" Visible="False" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="CheckBoxNOProject" runat="server" Text="Dejar de ser administrador de proyectos" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style10">
                        <asp:Button ID="ButtonShow" runat="server" OnClick="ButtonShow_Click" Text="Mostrar opciones de permisos" Width="242px" />
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="ButtonAcept" runat="server" OnClick="ButtonAcept_Click" Text="Aplicar permisos" Width="411px" Visible="False" />
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
