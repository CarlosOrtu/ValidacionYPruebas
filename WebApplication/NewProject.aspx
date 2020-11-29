<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProject.aspx.cs" Inherits="WebApplication.NewProject" %>

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
            width: 458px;
        }
        .auto-style3 {
            text-align: left;
            width: 258px;
        }
        .auto-style4 {
            width: 258px;
        }
        .auto-style5 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style5">
                <caption class="auto-style1">
                    <strong>Crea un nuevo proyecto</strong></caption>
                <tr>
                    <td class="auto-style2"><strong>Rellena los siguientes datos para continuar:</strong></td>
                    <td class="auto-style3">Nombre del proyecto:</td>
                    <td>
                        <asp:TextBox ID="TextBoxName" runat="server" Width="326px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">Número máximo de integrantes:</td>
                    <td>
                        <asp:TextBox ID="TextBoxMax" runat="server" Width="64px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="150px" />
                    </td>
                    <td class="auto-style4">Descripción del proyecto:</td>
                    <td>
                        <asp:TextBox ID="TextBoxDescription" runat="server" Height="89px" Width="323px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="ButtonCreateNewProject" runat="server" OnClick="ButtonCreateNewProject_Click" Text="Aceptar" Width="328px" />
                        <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="#000099"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
