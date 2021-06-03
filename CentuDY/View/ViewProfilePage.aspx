<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewProfilePage.aspx.cs" Inherits="CentuDY.View.ViewProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="BtnUpdateProfile" OnClick="BtnUpdateProfile_Click" runat="server" Text="Update Profile" />
    <asp:Button ID="BtnChangePassword" OnClick="BtnChangePassword_Click" runat="server" Text="Change Password" />
</asp:Content>
