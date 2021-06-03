<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="CentuDY.View.ViewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    Data User
    <br />
    <asp:Button ID="BtnDeleteUsers" OnClick="BtnDeleteUsers_Click" runat="server" Text="Delete User" />
</asp:Content>
