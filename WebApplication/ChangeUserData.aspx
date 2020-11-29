<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeUserData.aspx.cs" Inherits="WebApplication.ChangeUserDates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 89px;
        }
        .auto-style2 {
            width: 254px;
        }
        .auto-style3 {
            width: 254px;
            text-align: right;
        }
        .auto-style4 {
            width: 461px;
        }
        .auto-style5 {
            font-size: large;
            text-decoration: underline;
        }
        .auto-style6 {
            width: 335px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style5">
                    <strong>Cambio de datos del Usuario</strong></caption>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="157px" />
                    </td>
                    <td class="auto-style1">Email:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxEmail" runat="server" Width="310px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="LblNoChangeEmail" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1">Nombre:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxName" runat="server" Width="309px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1">Apellidos:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxSurname" runat="server" Width="309px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1">Teléfono:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBoxPhone" runat="server" Width="309px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="LblNoChangePhone" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="ButtonChange" runat="server" OnClick="ButtonChange_Click" Text="Aceptar" Width="107px" />
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="#006699"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
