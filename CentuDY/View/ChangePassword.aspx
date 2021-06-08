<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CentuDY.View.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="OldPassword" runat="server" Text="Old Password:"></asp:Label>
            <asp:TextBox ID="OldPasswordTxt" runat="server"></asp:TextBox><br />
            <asp:Label ID="NewPassword" runat="server" Text="New Password:"></asp:Label>
            <asp:TextBox ID="NewPasswordTxt" runat="server"></asp:TextBox><br />
            <asp:Label ID="ConfrimPassword" runat="server" Text="Confrim Password:"></asp:Label>
            <asp:TextBox ID="ConfirmPasswordTxt" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblMessage" Visible="false" runat="server" Text="Label"></asp:Label><br />
            <asp:Button ID="BtnChangePassword" Visible="true" OnClick="BtnChangePassword_Click" runat="server" Text="Change Password" />
            <asp:Button ID="BtnBackHome" Visible="true" OnClick="BtnBackHome_Click" runat="server" Text="Back Profile" />
        </div>
    </form>
</body>
</html>
