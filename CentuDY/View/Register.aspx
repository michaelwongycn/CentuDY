<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CentuDY.View.Register" %>

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
                 
                <br />

                <asp:Label runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="inputPassword" runat="server"></asp:TextBox><br />
                
                <br />

                <asp:Label runat="server" Text="Confirm Password"></asp:Label><br />
                <asp:TextBox ID="inputConfPassword" runat="server"></asp:TextBox><br />
                 
                <br />

                <asp:Label runat="server" Text="Name"></asp:Label><br />
                <asp:TextBox ID="inputName" runat="server"></asp:TextBox><br />
                
                <br />

                <asp:Label runat="server" Text="Gender"></asp:Label><br />
                <asp:DropDownList ID="genderDropDown" runat="server">
                 <asp:ListItem Enabled="true" Text="Select gender" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                </asp:DropDownList><br />
                 
                <br />

                <asp:Label runat="server" Text="Phone Number"></asp:Label><br />
                <asp:TextBox ID="inputPhoneNumber" runat="server"></asp:TextBox><br />
                 
                <br />

                <asp:Label runat="server" Text="Address"></asp:Label><br />
                <asp:TextBox ID="inputAddress" runat="server"></asp:TextBox>
                

                <br />
                <br />
                <asp:Label ID="lblmessage" Visible="false" runat="server" Text="Label"></asp:Label><br />
                <asp:Button ID="btnRegister" OnClick="btnRegister_Click" Visible="true" runat="server" Text="Register" />
                <asp:Button ID="btnBackLogin" OnClick="btnBackLogin_Click" Visible="true" runat="server" Text="Back To Login Page" />
            </div>
    </form>
    </div>
</body>
</html>

