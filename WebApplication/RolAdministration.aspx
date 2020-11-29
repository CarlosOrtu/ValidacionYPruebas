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
        .auto-style8 {
            color: #006699;
        }
        .auto-style9 {
            width: 320px;
        }
        .auto-style12 {
            width: 320px;
            text-align: right;
        }
        .auto-style13 {
            text-align: center;
        }
        .auto-style14 {
            text-decoration: underline;
        }
        .auto-style15 {
            text-align: center;
            width: 286px;
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
        <table style="width:100%;">
            <tr>
                <td class="auto-style9"><strong><span class="auto-style8">Vista previa de proyectos disponibles:</span></strong></td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style15"><strong><span class="auto-style14">Nombre del rol</span></strong></td>
                <td class="auto-style13"><strong><span class="auto-style14">ID de rol</span></strong></td>
                <td class="auto-style13"><strong><span class="auto-style14">Descripción</span></strong></td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:DropDownList ID="DropRoles" runat="server" Width="199px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style15">
                    <asp:Label ID="lblNombre" runat="server"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="lblID" runat="server"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="ButtonShow" runat="server" OnClick="ButtonShow_Click" Text="Mostrar datos" Width="127px" />
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
