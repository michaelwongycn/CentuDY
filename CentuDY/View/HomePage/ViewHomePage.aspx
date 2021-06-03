<%@ Page Title="" Language="C#" MasterPageFile="~/View/HomePage/HomeMaster.Master" AutoEventWireup="true" CodeBehind="ViewHomePage.aspx.cs" Inherits="CentuDY.View.HomePage.ViewHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Button ID="BtnViewCart" OnClick="BtnViewCart_Click" runat="server" Text="View Cart" />
    <asp:Button ID="BtnViewTransHistory" OnClick="BtnViewTransHistory_Click" runat="server" Text="View Transaction History" />
    <asp:Button ID="BtnInsertMedicine" OnClick="BtnInsertMedicine_Click" runat="server" Text="Insert Medicine" />
    <br />
    <br />
    <asp:Button ID="BtnViewUsers" OnClick="BtnViewUsers_Click" runat="server" Text="View Users" />
    <asp:Button ID="BtnViewTransReport" OnClick="BtnViewTransReport_Click" runat="server" Text="View Transaction Report" />

</asp:Content>
