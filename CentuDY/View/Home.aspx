<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CentuDY.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="UserName">
                Welcome
                <asp:Label ID="UserNameTxt" runat="server" Text="Label"></asp:Label>
            </div>
            <asp:Button ID="ViewMedicines" OnClick="ViewMedicines_Click" runat="server" Text="View Medicines" />
            <asp:Button ID="BtnViewProfile" OnClick="BtnViewProfile_Click" runat="server" Text="View Profile" />
            <asp:Button ID="BtnLogOut" OnClick="BtnLogOut_Click" runat="server" Text="Log Out" />
            <br />
            <br />
            <asp:Button ID="BtnViewCart" OnClick="BtnViewCart_Click" Visible="false" runat="server" Text="View Cart" />
            <asp:Button ID="BtnViewTransHistory" OnClick="BtnViewTransHistory_Click" Visible="false" runat="server" Text="View Transaction History" />
            <asp:Button ID="BtnInsertMedicine" OnClick="BtnInsertMedicine_Click" Visible="false" runat="server" Text="Insert Medicine" />
            <asp:Button ID="BtnViewUsers" OnClick="BtnViewUsers_Click" runat="server" Visible="false" Text="View Users" />
            <asp:Button ID="BtnViewTransReport" OnClick="BtnViewTransReport_Click" Visible="false" runat="server" Text="View Transaction Report" />
            <br />
            <br />
            <asp:GridView ID="Grid_View_Medicine" Visible="false" runat="server" AutoGenerateColumns="false" DataKeyNames="MedicineId" OnRowCommand="Grid_View_Medicine_RowCommand" >
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:ButtonField Text="Add to Cart" HeaderText="Action" CommandName="AddToCart" ButtonType="Button" ItemStyle-Font-Underline="false" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

