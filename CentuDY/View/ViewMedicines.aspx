<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewMedicines.aspx.cs" Inherits="CentuDY.View.ViewMedicines" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /> 
            <asp:Label ID="SearchMedicines" runat="server" Text="Search Medicines"></asp:Label>
            <br />
            <asp:TextBox ID="TxtSearchMedicines" Text="" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="SearchBtn" OnClick="SearchBtn_Click" runat="server" Text="Search" />
            <br />
            <asp:Button ID="BtnInsertMedicine" Visible="false" OnClick="BtnInsertMedicine_Click" runat="server" Text="Insert Medicine" />
            <br />
            <asp:GridView ID="Grid_View_Medicines" runat="server" AutoGenerateColumns="false" DataKeyNames="MedicineId" OnRowCommand="Grid_View_Medicines_RowCommand" OnRowDeleting="Grid_View_Medicines_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:ButtonField Text="Add to Cart" HeaderText="Buy" CommandName="AddToCart" ButtonType="Button" ItemStyle-Font-Underline="false" />
                    <asp:ButtonField Text="Update" HeaderText="Update" CommandName="Update" ButtonType="Button" ItemStyle-Font-Underline="false" Visible="false" />
                    <asp:ButtonField Text="Delete" HeaderText="Delete" CommandName="Delete" ButtonType="Button" ItemStyle-Font-Underline="false" Visible="false" />
            </Columns>
            </asp:GridView>
            <asp:Label ID="ErrorMessage" Visible="false" runat="server" Text=""></asp:Label>
</asp:Content>
