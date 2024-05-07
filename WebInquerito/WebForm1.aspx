<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebInquerito.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/folhaestilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Inquérito de Teste</h1>
            Nome:<asp:TextBox ID="txbNome" runat="server"></asp:TextBox>
            <br />
            <br />
            Distrito</div>
        <asp:ListBox ID="lbDistrito" runat="server">
            <asp:ListItem>Lisboa</asp:ListItem>
            <asp:ListItem>Porto</asp:ListItem>
            <asp:ListItem>Faro</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        Pratos Favoritos:<br />
        <asp:CheckBox ID="cbPizza" runat="server" Text="Pizza" />
        <asp:CheckBox ID="cbBife" runat="server" Text="Bife" />
        <asp:CheckBox ID="cbRefogado" runat="server" Text="Refogado" />
        <br />
        <br />
        Clube:<br />
        <asp:RadioButton ID="rbFcp" runat="server" GroupName="Clube" Text="FCP" />
        <asp:RadioButton ID="rbSlb" runat="server" GroupName="Clube" Text="SLB" />
        <asp:RadioButton ID="rbScp" runat="server" GroupName="Clube" Text="SCP" />
        <br />
        <br />
        <asp:Button ID="btnSubmeter" runat="server" OnClick="btnSubmeter_Click" Text="Submeter" CssClass="button" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
