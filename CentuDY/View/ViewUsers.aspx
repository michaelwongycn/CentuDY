<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="CentuDY.View.ViewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="Grid_View_Users" runat="server" AutoGenerateColumns="false" DataKeyNames="UserId" OnRowCommand="Grid_View_Users_RowCommand" OnRowDeleting="Grid_View_Users_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Role.RoleName" HeaderText="Role" SortExpression="RoleName" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:ButtonField Text="Delete" HeaderText="Delete" CommandName="Delete" ButtonType="Button" ItemStyle-Font-Underline="false" />
        </Columns>
    </asp:GridView>
</asp:Content>
