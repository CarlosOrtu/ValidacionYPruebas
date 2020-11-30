<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HUAdministration.aspx.cs" Inherits="WebApplication.HUAdministration" %>

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
            text-align: center;
            width: 1074px;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            width: 1074px;
        }
        .auto-style8 {
            color: #006699;
        }
        .auto-style9 {
            width: 405px;
        }
        .auto-style10 {
            width: 405px;
            text-align: right;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style12 {
            text-align: center;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Administración de historias de usuario</strong></caption>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="162px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="ButtonNewHU" runat="server" OnClick="ButtonNewHU_Click" Text="Crear historia de usuario" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="ButtonChangeData" runat="server" OnClick="ButtonChangeData_Click" Text="Modificar historia de usuario" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Borrar historia de usuario" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style9"><strong><span class="auto-style8">Vista previa de historias de usuario disponibles:</span></strong></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Selecciona un poryeccto y pulsa &quot;Mostrar HU&quot;</td>
                <td class="auto-style12"><strong>ID</strong></td>
                <td class="auto-style12"><strong>Descripción</strong></td>
                <td class="auto-style12"><strong>¿Qué?</strong></td>
                <td class="auto-style12"><strong>¿Cómo?</strong></td>
                <td class="auto-style12"><strong>¿Para qué?</strong></td>
                <td class="auto-style12"><strong>Proyecto asociado</strong></td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropProject" runat="server" Width="256px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblID" runat="server"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblQue" runat="server"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblComo" runat="server"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblPara" runat="server"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblProject" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblEmpty1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    <asp:Button ID="ButtonShowHU" runat="server" OnClick="ButtonShowHU_Click" Text="Mostrar HU" Width="151px" />
                </td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropHU" runat="server" Visible="False" Width="256px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Button ID="ButtonShowData" runat="server" OnClick="ButtonShowData_Click" Text="Mostrar datos de historias de usuario" Visible="False" Width="298px" />
                </td>
                <td class="auto-style11">
                    <asp:Label ID="lblEmpty2" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
