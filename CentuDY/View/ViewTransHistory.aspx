<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewTransHistory.aspx.cs" Inherits="CentuDY.View.ViewTransHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    Transaction History
    <asp:GridView ID="Grid_View_Transaction_History" runat="server" AutoGenerateColumns="false" OnRowDataBound="Grid_View_Transaction_History_RowDataBound">
        <Columns>
            <asp:BoundField DataField="Medicine.Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:BoundField DataField="HeaderTransaction.TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
            <asp:TemplateField HeaderText="SubTotal">
                <ItemTemplate>
                    <asp:Label ID="txtSubTotal" runat="server" 
                        Text='<%# ((Convert.ToInt32(Eval("Quantity")))*(Convert.ToInt32(Eval("Medicine.Price"))))%>'>
                    </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="GrandTotal">
                <ItemTemplate>
                    <asp:Label Text="" ID="txtGrandTotal" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
