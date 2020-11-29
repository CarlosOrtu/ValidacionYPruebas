<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserToProject.aspx.cs" Inherits="WebApplication.AddUserToProject" %>

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
            width: 483px;
        }
        .auto-style3 {
            width: 351px;
        }
        .auto-style4 {
            width: 483px;
            text-align: right;
        }
        .auto-style5 {
            width: 483px;
            text-align: right;
            height: 26px;
        }
        .auto-style6 {
            width: 351px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 351px;
            text-align: right;
        }
        .auto-style9 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Añade un usuario a un proyecto</strong></caption>
                <tr>
                    <td class="auto-style2">Selecciona un usuario, después un proyecto, escribe el rol que tomará en el proyecto y pulsa Aceptar:</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="168px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">-Proyecto:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropProjects" runat="server" Width="345px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">-Usuario:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropUsers" runat="server" Width="345px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">-Rol que tomará el usuario:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropRol" runat="server" Height="19px" Width="345px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        <asp:Label ID="lblEmpty" runat="server" Font-Bold="True" ForeColor="#006699"></asp:Label>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="ButtonAcept" runat="server" OnClick="ButtonAcept_Click" Text="Aceptar" Width="210px" />
                    </td>
                    <td>
                        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
