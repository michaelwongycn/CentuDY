<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="CentuDY.View.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:GridView ID="Grid_View_Cart" runat="server" AutoGenerateColumns="false" OnRowDeleting="Grid_View_Cart_RowDeleting" OnRowDataBound="Grid_View_Cart_RowDataBound" >
        <Columns>
            <asp:BoundField DataField="Medicine.Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Medicine.Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:TemplateField HeaderText="SubTotal">
                <ItemTemplate>
                    <asp:Label ID="txtSubTotal" runat="server" 
                        Text='<%# ((Convert.ToInt32(Eval("Quantity")))*(Convert.ToInt32(Eval("Medicine.Price"))))%>'>
                    </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="true" ShowHeader="true" Visible="true" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label Text="GrandTotal: " runat="server" />
    <asp:Label Text="" ID="txtGrandTotal" runat="server" />
    <br />
    <br />
    <asp:Label Text="" ID="errMsg" runat="server" />
    <br />
    <asp:Button Text="Checkout" ID="btnCheckout" OnClick="btnCheckout_Click" runat="server" />
</asp:Content>
