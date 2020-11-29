<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeHUData.aspx.cs" Inherits="WebApplication.ChangeHUData" %>

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
            width: 100%;
        }
        .auto-style3 {
            width: 314px;
        }
        .auto-style4 {
            width: 168px;
        }
        .auto-style5 {
            width: 628px;
        }
        .auto-style6 {
            text-align: right;
        }
        .auto-style7 {
            width: 314px;
            height: 29px;
        }
        .auto-style8 {
            width: 168px;
            height: 29px;
        }
        .auto-style9 {
            width: 628px;
            height: 29px;
        }
        .auto-style10 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <caption class="auto-style1">
                    <strong>Cambiar datos historia de usuario</strong></caption>
                <tr>
                    <td class="auto-style3"><strong>Selecciona un proyecto:</strong></td>
                    <td class="auto-style4">Descripción:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxDescription" runat="server" Visible="False" Width="400px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="110px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropProjects" runat="server" Width="289px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">¿Cómo?:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxComo" runat="server" Visible="False" Width="400px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="ButtonShow" runat="server" OnClick="ButtonShow_Click" Text="Mostrar historias" Width="169px" />
                        <asp:Label ID="lblError" runat="server" ForeColor="#006699"></asp:Label>
                    </td>
                    <td class="auto-style4">¿Qué?:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxQue" runat="server" Visible="False" Width="400px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Selecciona una historia de usuario:</strong></td>
                    <td class="auto-style4">¿Para qué?:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxPara" runat="server" Visible="False" Width="400px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:DropDownList ID="DropHU" runat="server" Visible="False" Width="289px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style8">Proyecto asociado:</td>
                    <td class="auto-style9">
                        <asp:DropDownList ID="DropProyects" runat="server" Visible="False" Width="400px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="ButtonAcept" runat="server" OnClick="ButtonAcept_Click" Text="Aceptar" Visible="False" Width="200px" />
                        <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="#006699"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
