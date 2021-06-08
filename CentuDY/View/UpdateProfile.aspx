<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="CentuDY.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server" Text=""></asp:TextBox><br />
            <asp:Label ID="LblGender" runat="server" Text="Gender:"></asp:Label>
            <asp:DropDownList ID="genderDropDown" runat="server">
                <asp:ListItem Enabled="true" Text="Select gender" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                <asp:ListItem Text="Female" Value="2"></asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="LblPhone" runat="server" Text="Phone Number:"></asp:Label>
            <asp:TextBox ID="PhoneTxt" runat="server" Text=""></asp:TextBox><br />
            <asp:Label ID="LblAddress" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="AddressTxt" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="false"></asp:Label><br />
            <asp:Button ID="BtnUpdateProfile" Visible="true" OnClick="BtnUpdateProfile_Click" runat="server" Text="Updated" />
            <asp:Button ID="BtnBackHome" Visible="true" OnClick="BtnBackHome_Click" runat="server" Text="Back Profile" />
        </div>
    </form>
</body>
</html>
