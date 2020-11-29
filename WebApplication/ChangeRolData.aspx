<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeRolData.aspx.cs" Inherits="WebApplication.ChangeRolDates" %>

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
            width: 414px;
        }
        .auto-style3 {
            width: 145px;
        }
        .auto-style4 {
            width: 719px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Cambiar datos del rol</strong></caption>
                <tr>
                    <td class="auto-style2"><strong>Selecciona un rol:</strong></td>
                    <td class="auto-style3">ID del rol:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxID" runat="server" Width="91px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="181px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropRol" runat="server" Width="261px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">Descripción:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxDescription" runat="server" Height="78px" Width="287px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="ButtonAcept" runat="server" OnClick="ButtonAcept_Click" Text="Aceptar" Width="160px" />
                        <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="#006699"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
