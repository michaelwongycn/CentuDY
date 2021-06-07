<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CentuDY.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body{
            font-family: sans-serif;
        }
        #register{
            color: black;
            text-decoration: none;
            font-size: large;
        }
    </style>
</head>
<body>
    <h1 style="margin-top:200px; text-align: center;">Login to CentuDY</h1>
    <form id="form1" runat="server">
        <div style="display:flex; justify-content: center; align-items: center; flex-direction: column">
            <div style="height: 450px; padding-top: 40px;">  
                <asp:Label runat="server" Text="Email"></asp:Label><br />
                <asp:TextBox ID="inputEmail" runat="server"></asp:TextBox>   
                <br />        
                <br />
                <asp:Label runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="inputPassword" TextMode="Password" runat="server"></asp:TextBox>               
                <br /> 
                <br />
                <asp:CheckBox ID="chckRememberMe" Text="Remember Me" runat="server" /><br />
                <br />
                <asp:Label ID="lblMessage" Visible="false" Text="Label" runat="server" /><br />
                <asp:Button ID="btnLogin" ValidationGroup="Login" OnClick="btnLogin_Click" Text="Login" runat="server" /> <br />
                <br />
                <asp:HyperLink ID="register" NavigateUrl="Register.aspx" Text="Register" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>

