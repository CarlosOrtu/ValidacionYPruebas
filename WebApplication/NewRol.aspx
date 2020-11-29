<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewRol.aspx.cs" Inherits="WebApplication.NewRol" %>

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
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 439px;
        }
        .auto-style4 {
            width: 439px;
        }
        .auto-style5 {
            height: 26px;
            width: 172px;
        }
        .auto-style6 {
            width: 172px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Crear un nuevo rol</strong></caption>
                <tr>
                    <td class="auto-style3"><strong>Rellena los siguientes datos para continuar:</strong></td>
                    <td class="auto-style5">Nombre del rol:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxName" runat="server" Width="326px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">ID del rol:</td>
                    <td>
                        <asp:TextBox ID="TextBoxID" runat="server" Width="64px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="150px" />
                    </td>
                    <td class="auto-style6">Descripción del rol:</td>
                    <td>
                        <asp:TextBox ID="TextBoxDescription" runat="server" Height="89px" Width="326px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>
                        <asp:Button ID="ButtonAcept" runat="server" OnClick="ButtonAcept_Click" Text="Aceptar" Width="326px" />
                        <asp:Label ID="LabelError" runat="server" Font-Bold="True" ForeColor="#000099"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
