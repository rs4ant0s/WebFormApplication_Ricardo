<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebCalendario.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 363px;
        }
        .auto-style3 {
            width: 140px;
        }
        .auto-style2 {
            width: 140px;
        }
        .auto-style4 {
            width: 322px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Selecione a sua data de nascimento:
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" Height="190px" Width="350px" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Height="20px" Text="Carregar Data" Width="108px" OnClick="Button2_Click" />
        <br />
        <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        Dia</td>
                    <td class="auto-style2">
                        Mês</td>
                     <td class="auto-style2">
                         Ano</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownListdDia" runat="server">
                        </asp:DropDownList>
                    </td>
                     <td class="auto-style3">
                         <asp:DropDownList ID="DropDownListMes" runat="server">
                         </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownListAno" runat="server">
                        </asp:DropDownList>
                    </td>
                     <td class="auto-style4">
        <asp:Button ID="Button3" runat="server" Height="20px" Text="Carregar Data" Width="108px" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>

        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="20px" Text="Calcular Idade" Width="108px" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
