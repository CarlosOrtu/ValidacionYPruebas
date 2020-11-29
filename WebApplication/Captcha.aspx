<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Captcha.aspx.cs" Inherits="WebApplication.captcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-decoration: underline;
            color: #3366CC;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Captcha</strong></caption>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">Escribe en el cuadro de texto la palabra que aparece en la imagen en minúsculas:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="78px" ImageUrl="~/Images/Screenshot_1.png" Width="315px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="LabelError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        <asp:TextBox ID="TextBoxCaptcha" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonAcept" runat="server" OnClick="ButtonAcept_Click" Text="Aceptar" Width="135px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
