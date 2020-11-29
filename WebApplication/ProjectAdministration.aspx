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
        .auto-style8 {
            color: #006699;
        }
        .auto-style9 {
            width: 320px;
        }
        .auto-style10 {
            width: 320px;
            text-align: right;
        }
        .auto-style11 {
            text-decoration: underline;
        }
        .auto-style12 {
            width: 167px;
        }
        .auto-style13 {
            width: 167px;
            text-align: center;
        }
        .auto-style14 {
            text-align: center;
        }
        .auto-style15 {
            width: 246px;
        }
        .auto-style16 {
            text-align: center;
            width: 246px;
        }
        .auto-style17 {
            text-align: center;
            text-decoration: underline;
            width: 261px;
        }
        .auto-style19 {
            text-align: center;
            width: 261px;
        }
        .auto-style20 {
            width: 261px;
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
                        <asp:Button ID="ButtonChangeDates" runat="server" OnClick="ButtonChangeDates_Click" Text="Modificar datos poryecto" Width="315px" />
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
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="ButtonAdminRoles" runat="server" OnClick="ButtonAdminRoles_Click" Text="Adminsitración de roles" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style9"><strong><span class="auto-style8">Vista previa de proyectos disponibles: </span></strong></td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style13"><strong><span class="auto-style11">Nombre</span></strong></td>
                <td class="auto-style16"><strong><span class="auto-style11">Nº máximo de integrantes</span></strong></td>
                <td class="auto-style17"><strong>Descripción</strong></td>
                <td class="auto-style14"><strong><span class="auto-style11">Usuarios</span></strong></td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropProject" runat="server" Width="199px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="lblMax" runat="server"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:DropDownList ID="DropUsers" runat="server" Visible="False">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Button ID="ButtonShowData" runat="server" OnClick="ButtonShowData_Click" Text="Mostrar datos" Width="127px" />
                </td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
