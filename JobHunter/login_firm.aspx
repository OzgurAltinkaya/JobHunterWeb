<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login_firm.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 190px;
        }
    </style>
</head>
<body>
 
    <form id="form1" runat="server">
      
        <asp:Panel ID="pnlUnlogin" runat="server">
              <table class="auto-style1">
            <tr>
                <td class="auto-style2">Username:</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>
                  <tr>
                      <td colspan="2"><a href="register_student.aspx">If you are not registered Please click and Register now!</a></td>
                  </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblInfo" runat="server" EnableTheming="True"></asp:Label>
                </td>
            </tr>
        </table>
        </asp:Panel>
        <asp:Panel ID="pnlLogin" runat="server">
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
            &nbsp;Welcome!<br />
            <br />
            <asp:Button ID="btnLogout" runat="server" type="Button" OnClick="btnLogout_Click" Text="Logout" />
            
        </asp:Panel>
      
    </form>
 
</body>
</html>
