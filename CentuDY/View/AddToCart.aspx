<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="CentuDY.View.AddToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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

            <asp:Button ID="btnAddToCart" Text="Add to Cart" runat="server" OnClick="btnAddToCart_Click" />
            
        </div>
    </form>
</body>
</html>
