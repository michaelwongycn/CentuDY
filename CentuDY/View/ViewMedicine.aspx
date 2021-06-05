<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewMedicine.aspx.cs" Inherits="CentuDY.View.ViewMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br /> 
    <asp:Label ID="SearchMedicines" runat="server" Text="Search Medicines"></asp:Label>
            <br />
            <asp:TextBox ID="TxtSearchMedicines" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnInsertMedicine" Visible="false" OnClick="BtnInsertMedicine_Click" runat="server" Text="Insert Medicine" />
            <br />
            <asp:GridView ID="Grid_View_Medicine" runat="server" AutoGenerateColumns="false" OnRowDeleting="Grid_View_Medicine_RowDeleting" OnRowEditing="Grid_View_Medicine_RowEditing" OnRowDataBound="Grid_View_Medicine_RowDataBound" >
             <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" Visible="false" />
            </Columns>
            </asp:GridView>
            
</asp:Content>
