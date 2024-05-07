<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="WebMySQL01.Logon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
            width: 132px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Logon Page:<br />
            <br />
             <table class="auto-style1">
                                 <tr>
                    <td class="auto-style2">Email:</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" Width="197px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtUserPass" runat="server" TextMode="Password" Width="197px"></asp:TextBox>
                    </td>
                    <td>  
                        <asp:CheckBox ID="ckbPass" runat="server" OnCheckedChanged="ckbPass_CheckedChanged" />
                    </td>
                </tr>
             </table>
        </div>
        <p>
            <asp:Button ID="btnLogon" runat="server" OnClick="btnLogon_Click" Text="Logon" Width="78px" />
        </p>
        <p>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
