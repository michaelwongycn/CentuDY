﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewMedicine.aspx.cs" Inherits="CentuDY.View.ViewMedicine" %>
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
            <asp:GridView ID="Grid_View_Medicine" runat="server" AutoGenerateColumns="false" OnRowCommand="Grid_RowCommand" OnRowDeleting="Grid_View_Medicine_RowDeleting" OnRowEditing="Grid_View_Medicine_RowEditing" OnRowDataBound="Grid_View_Medicine_RowDataBound" >
                <Columns>
                    <asp:BoundField DataField="MedicineId" HeaderText="Id" SortExpression="MedicineId" Visible="true" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" Visible="false" />
                    <asp:ButtonField Text="Add to Cart" HeaderText="Action" CommandName="AddToCart" ButtonType="Button" Visible="true" ItemStyle-Font-Underline="false" />
            </Columns>
            </asp:GridView>
</asp:Content>
