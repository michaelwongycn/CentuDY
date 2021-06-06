<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewTransHistory.aspx.cs" Inherits="CentuDY.View.ViewTransHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="Grid_View_Transaction_History" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="DetailTransaction.Quantity" HeaderText="Medicine Name" SortExpression="Medicine Name" />
            <asp:BoundField DataField="User.Password" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
            
        </Columns>
    </asp:GridView>
</asp:Content>
