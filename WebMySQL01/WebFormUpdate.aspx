<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormUpdate.aspx.cs" Inherits="WebMySQL01.WebFormUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 122px;
        }
        .auto-style4 {
            width: 122px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Atualizar Formando<br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Formando</td>
                    <td>
                        <asp:DropDownList ID="ddlFormandos" runat="server" Height="20px" OnSelectedIndexChanged="ddlFormandos_SelectedIndexChanged" Width="252px" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">ID</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbID" runat="server"></asp:TextBox>
                        <asp:Button ID="btnProcurar" runat="server" Text="Procurar" Width="93px" OnClick="btnProcurar_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nome</td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server" Width="251px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Género</td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Genero" Text="Masculino" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" GroupName="Genero" Text="Feminino" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Idade</td>
                    <td>
                        <asp:DropDownList ID="ddlidades" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="95px" OnClick="btnCancelar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" Width="95px" OnClick="btnAtualizar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <br />
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
