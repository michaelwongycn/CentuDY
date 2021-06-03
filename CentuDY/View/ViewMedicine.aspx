<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewMedicine.aspx.cs" Inherits="CentuDY.View.ViewMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="SearchMedicines" runat="server" Text="Search Medicines"></asp:Label>
     <br />
     <asp:TextBox ID="TxtSearchMedicines" runat="server"></asp:TextBox>
     <br />
     <br />
     <asp:Button ID="BtnInsertMedicine" OnClick="BtnInsertMedicine_Click" runat="server" Text="Insert Medicine" />
     <asp:Button ID="BtnUpdateMedicine" OnClick="BtnUpdateMedicine_Click" runat="server" Text="Update Medicine" />
     <asp:Button ID="BtnDeleteMedicine" OnClick="BtnDeleteMedicine_Click" runat="server" Text="Delete Medicine" />
     <br />
     <br />
     <asp:Button ID="BtnAddCart" OnClick="BtnAddCart_Click" runat="server" Text="Add to Cart" />
</asp:Content>
