<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="DatabaseUltraHomeWork.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
<script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
<link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="max-width: 400px;">
            </div>
            <h2 class="form-signin-heading">
        Login</h2>
    <label for="txtUsername">
        Username</label>
    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username"
         />
    <br />
    <label for="txtPassword">
        Password</label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"
        placeholder="Enter Password"  />
    <div class="checkbox">
        <asp:CheckBox ID="chkRememberMe" Text="Remember Me" runat="server" />
    </div>
    <asp:Button ID="btnLogin" Text="Login" runat="server"  Class="btn btn-primary" OnClick="btnLogin_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    <br />
            <asp:Label ID="Label1" runat="server" Text="Wrong Password"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Wrong Email"></asp:Label>
    <br />

    </form>
</body>
</html>
