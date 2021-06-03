<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="CentuDY.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    <style>
        body, h1, form{
            margin: 0;
            font-family: sans-serif;
        }
        .content{
            padding-top: 50px;
            display: flex;
            flex-direction: column;
            text-align: center;
            align-items: center;    
        }
        .form-regis{
            text-align: left;
            padding-top: 50px;
            width: auto;
        }
    </style>
</head>
<body>
    <div class="content">
        <h1>Register new member</h1>
        <form id="form1" runat="server">
            <div class="form-regis">
                <asp:Label runat="server" Text="Username"></asp:Label><br />
                <asp:TextBox ID="inputUsername" runat="server"></asp:TextBox><br />
                <asp:Label ID="errMsgUsername" runat="server" Text=""></asp:Label><br />
                <br />

                <asp:Label runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="inputPassword" runat="server"></asp:TextBox><br />
                <asp:Label ID="errMsgPassword" runat="server" Text=""></asp:Label><br />
                <br />

                <asp:Label runat="server" Text="Confirm Password"></asp:Label><br />
                <asp:TextBox ID="inputConfPassword" runat="server"></asp:TextBox><br />
                <asp:Label runat="server" Text=""></asp:Label><br />
                <br />

                <asp:Label runat="server" Text="Name"></asp:Label><br />
                <asp:TextBox ID="inputName" runat="server"></asp:TextBox><br />
                <asp:Label runat="server" Text=""></asp:Label><br />
                <br />

                <asp:Label runat="server" Text="Gender"></asp:Label><br />
                <asp:DropDownList ID="genderDropDown" runat="server"></asp:DropDownList><br />
                <asp:Label ID="errMsgGender" runat="server" Text=""></asp:Label><br />
                <br />

                <asp:Label runat="server" Text="Phone Number"></asp:Label><br />
                <asp:TextBox ID="inputPhoneNumber" runat="server"></asp:TextBox><br />
                <asp:Label ID="errMsgPhoneNumber" runat="server" Text=""></asp:Label><br />
                <br />

                <asp:Label runat="server" Text="Address"></asp:Label><br />
                <textarea id="inputAddress" cols="22" rows="4"></textarea>
                <asp:Label ID="errMsgAddress" runat="server" Text=""></asp:Label><br />
                <br />

                <asp:Button ID="btnRegister" Text="Register" runat="server" />
            </div>
    </form>
    </div>
</body>
</html>
