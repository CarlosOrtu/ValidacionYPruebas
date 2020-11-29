<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewHU.aspx.cs" Inherits="WebApplication.NewHU" %>

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
            width: 430px;
        }
        .auto-style3 {
            width: 159px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Crear una nueva historia de usuario</strong></caption>
                <tr>
                    <td class="auto-style2"><strong>Rellena los siguientes datos para continuar:</strong></td>
                    <td class="auto-style3">ID:</td>
                    <td>
                        <asp:TextBox ID="TextBoxID" runat="server" Width="475px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Descripción:</td>
                    <td>
                        <asp:TextBox ID="TextBoxDescription" runat="server" Width="475px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="170px" />
                    </td>
                    <td class="auto-style3">¿Cómo?:</td>
                    <td>
                        <asp:TextBox ID="TextBoxComo" runat="server" Width="475px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">¿Qué?:</td>
                    <td>
                        <asp:TextBox ID="TextBoxQue" runat="server" Width="475px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">¿Para qué?:</td>
                    <td>
                        <asp:TextBox ID="TextBoxPara" runat="server" Width="475px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Proyecto asociado:</td>
                    <td>
                        <asp:DropDownList ID="DropProjects" runat="server" Width="475px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="ButtonAcept" runat="server" OnClick="ButtonAcept_Click" Text="Aceptar" Width="328px" />
                        <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="#006699"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
