<%@ Page Title="" Language="C#" MasterPageFile="~/View/MedicinePage/MedicinePage.Master" AutoEventWireup="true" CodeBehind="InsertMedicine.aspx.cs" Inherits="CentuDY.View.MedicinePage.InsertMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblDesc" runat="server" Text="Description"></asp:Label>
    <asp:TextBox ID="DescTxt" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblStock" runat="server" Text="Stock"></asp:Label>
    <asp:TextBox ID="StockTxt" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblPrice" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="PriceTxt" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblMessage" Visible="false" runat="server" Text="Label"></asp:Label><br />
    <br />
    <asp:Button ID="BtnInsert" OnClick="BtnInsert_Click" runat="server" Text="Insert Medicine" />
</asp:Content>
