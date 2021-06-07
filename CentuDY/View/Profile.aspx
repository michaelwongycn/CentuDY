<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="CentuDY.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="LblUserName" runat="server" Text="UserName:"></asp:Label>
    <asp:Label ID="UserNameTxt" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="LblName" runat="server" Text="Name:"></asp:Label>
    <asp:Label ID="NameTxt" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="LblGender" runat="server" Text="Gender:"></asp:Label>
    <asp:Label ID="GenderTxt" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="LblPhone" runat="server" Text="Phone Number:"></asp:Label>
    <asp:Label ID="PhoneTxt" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="LblAddress" runat="server" Text="Address:"></asp:Label>
    <asp:Label ID="AddressTxt" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="BtnUpdateProfile" OnClick="BtnUpdateProfile_Click" runat="server" Text="Update Profile" />
    <asp:Button ID="BtnChangePassword" OnClick="BtnChangePassword_Click" runat="server" Text="Change Password" />
</asp:Content>
