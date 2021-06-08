<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="CentuDY.View.AddToCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br />
            <asp:Label Text="Medicine Name:" runat="server" />
            <asp:Label Text="" runat="server" ID="txtMedicineName" />
            <br />
            <asp:Label Text="Description:" runat="server" />
            <asp:Label Text="" runat="server" ID="txtMedicineDescription" />
            <br />
            <asp:Label Text="Stock:" runat="server" />
            <asp:Label Text="" runat="server" ID="txtMedicineStock" />
            <br />
            <asp:Label Text="Price:" runat="server" />
            <asp:Label Text="" runat="server" ID="txtMedicinePrice" />
            <br />

            <asp:Label Text="Insert Quantity:" runat="server" />
            <asp:TextBox ID="inputQuantity" runat="server" />
            <br />
            <asp:Label ID="txtAlert" Text="" runat="server" /><br /> 
            <br />
            <asp:Button ID="btnAddToCart" Text="Add to Cart" runat="server" OnClick="btnAddToCart_Click" />
</asp:Content>
