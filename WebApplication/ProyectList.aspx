<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProyectList.aspx.cs" Inherits="WebApplication.ProyectList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 97px;
            text-align: right;
        }
        .auto-style2 {
            text-align: right;
            width: 379px;
        }
        .auto-style4 {
            text-decoration: underline;
            font-size: x-large;
        }
        .auto-style5 {
            width: 159px;
            text-align: center;
        }
        .auto-style6 {
            text-align: right;
        }
        .auto-style7 {
            text-align: right;
            width: 379px;
            height: 86px;
        }
        .auto-style8 {
            width: 97px;
            text-align: right;
            height: 86px;
        }
        .auto-style9 {
            width: 159px;
            text-align: center;
            height: 86px;
            text-decoration: underline;
        }
        .auto-style10 {
            text-align: right;
            height: 86px;
        }
        .auto-style11 {
            text-align: center;
            height: 86px;
            text-decoration: underline;
            width: 289px;
        }
        .auto-style12 {
            text-align: center;
            width: 289px;
        }
        .auto-style13 {
            text-decoration: underline;
        }
        .auto-style14 {
            text-align: center;
            height: 86px;
        }
        .auto-style15 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style4">
                    <strong>Tus proyectos</strong></caption>
                <tr>
                    <td class="auto-style7">Selecciona un proyecto y pulsa en mostrar datos para ver todos los detalles del proyecto:</td>
                    <td class="auto-style8"></td>
                    <td class="auto-style9"><strong>Nombre</strong></td>
                    <td class="auto-style11"><strong>Número maximo de integrantes</strong></td>
                    <td class="auto-style14"><strong><span class="auto-style13">Descripción</span></strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropProyectList" runat="server" Width="239px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="LblName" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="LblMax" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style15">
                        <asp:Label ID="LblDescription" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonShowData" runat="server" OnClick="ButtonShowData_Click" Text="Mostrar datos" Width="144px" />
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="145px" />
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
