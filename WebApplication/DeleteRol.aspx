<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteRol.aspx.cs" Inherits="WebApplication.DeleteRol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>Selecciona el rol y pulsa el botón Borrar:</td>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Volver" Width="245px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropRol" runat="server" Width="512px">
                        </asp:DropDownList>
                        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Borrar" Width="136px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
