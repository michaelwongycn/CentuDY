<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="CentuDY.View.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:GridView ID="Grid_View_Cart" runat="server" AutoGenerateColumns="false" OnRowDeleting="Grid_View_Cart_RowDeleting" >
        <Columns>
            <asp:BoundField DataField="Medicine.Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Medicine.Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" SortExpression="SubTotal" />
            <asp:BoundField DataField="GrandTotal" HeaderText="GrandTotal" SortExpression="GrandTotal" />
            <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="true" ShowHeader="true" Visible="true" />
        </Columns>
    </asp:GridView>
</asp:Content>
