<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMenu.aspx.cs" Inherits="WebArea.WebMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
        .auto-style2 {
            width: 140px;
        }
        .auto-style3 {
            width: 140px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Áreas</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Text="Retângulo" Width="118px" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnTriangulo" runat="server" Text="Trinagulo" Width="118px" OnClick="btnTriangulo_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCirculo" runat="server" Text="Circulo" Width="118px" OnClick="btnCirculo_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnQuadrado" runat="server" Text="Quadrado" Width="118px" OnClick="btnQuadrado_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
