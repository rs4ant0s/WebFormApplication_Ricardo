<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSalario.aspx.cs" Inherits="WebSalarios.WebSalario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calcular o Salario Líquido :</h1>
            <br />
            Insira o valor do salário bruto :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBruto" runat="server"></asp:TextBox>
&nbsp;&nbsp;€&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Calcular" Width="103px" OnClick="Button1_Click" />
            <br />
            <br />
            <h3><asp:Label ID="lblResultado" runat="server"></asp:Label></h3>
        </div>
    </form>
</body>
</html>
