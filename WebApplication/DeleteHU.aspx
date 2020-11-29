<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteHU.aspx.cs" Inherits="WebApplication.DeleteHU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            width: 853px;
        }
        .auto-style3 {
            width: 167px;
        }
        .auto-style4 {
            width: 853px;
            height: 26px;
        }
        .auto-style5 {
            width: 167px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Selecciona el projecto y después una de las historias de usuario que quieras borrar pulsa el botón Borrar:</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="186px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropProjects" runat="server" Width="416px">
                        </asp:DropDownList>
                        <asp:Button ID="ButtonProject" runat="server" OnClick="ButtonProject_Click" Text="Selecciona proyecto" Width="222px" />
                        <asp:Label ID="lblEmpty1" runat="server" Font-Bold="True" ForeColor="#006699"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblInfo" runat="server" ForeColor="#009933" Text="Ahora selecciona una historia de usuario" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropHU" runat="server" Visible="False" Width="416px">
                        </asp:DropDownList>
                        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Borrar" Visible="False" Width="222px" />
                        <asp:Label ID="lblEmpty2" runat="server" Font-Bold="True" ForeColor="#006699"></asp:Label>
                    </td>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
