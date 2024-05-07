<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTriangulo.aspx.cs" Inherits="WebArea.WebTriangulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Área do Triângulo</h1>
            Altura: <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
            <br />
            <br />
            Base: <asp:TextBox ID="txtBase" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
&nbsp;<asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Voltar</asp:LinkButton>
        </div>
    </form>
</body>
</html>
