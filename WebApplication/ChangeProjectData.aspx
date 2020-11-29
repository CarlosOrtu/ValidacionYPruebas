<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeProjectData.aspx.cs" Inherits="WebApplication.ChangeProjectDates" %>

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
            width: 230px;
        }
        .auto-style4 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Cambiar datos del proyecto</strong></caption>
                <tr>
                    <td class="auto-style2"><strong>Selecciona un proyecto:</strong></td>
                    <td class="auto-style3">Numero máximo integrantes:</td>
                    <td>
                        <asp:TextBox ID="TextBoxMax" runat="server" Width="91px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="181px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropProjects" runat="server" Width="261px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">Descripción:</td>
                    <td>
                        <asp:TextBox ID="TextBoxDescription" runat="server" Height="78px" Width="287px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
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
