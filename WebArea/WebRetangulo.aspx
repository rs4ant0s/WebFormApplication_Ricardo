<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRetangulo.aspx.cs" Inherits="WebArea.WebRetangulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Área do Retângulo</h1>
            Comprimento: <asp:TextBox ID="txtComprimento" runat="server"></asp:TextBox>
            <br />
            <br />
            Largura: <asp:TextBox ID="txtLargura" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
&nbsp;<asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Voltar</asp:LinkButton>
            <br />




        </div>
    </form>
</body>
</html>
