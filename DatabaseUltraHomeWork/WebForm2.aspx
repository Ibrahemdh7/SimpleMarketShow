<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DatabaseUltraHomeWork.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="floating-labels.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors"/>
    <meta name="generator" content="Jekyll v4.1.1"/>
    <link href="floating-labels.css" rel="stylesheet"/>
    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }
        .auto-style1 {
            position: relative;
            margin-bottom: 1rem;
            left: -25px;
            top: -253px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-signin">
        <div class="container">
            <h1 class="h3 mb-3 font-weight-normal">Registration</h1>

            <div class="form-label-group">
                <asp:TextBox ID="txtFirstName" class="form-control" placeholder="First Name" runat="server" required="required"></asp:TextBox>
                <label for="txtFirstName">First Name</label>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtLastName" class="form-control" placeholder="Last Name" runat="server" required="required"></asp:TextBox>
                <label for="txtLastName">Last Name</label>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtAddress" class="form-control" placeholder="Address" runat="server" required="required"></asp:TextBox>
                <label for="txtAddress">Address</label>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtEmail" type="email" class="form-control" placeholder="Email" runat="server" required="required" AutoPostBack="True" OnTextChanged="txtEmail_TextChanged1"></asp:TextBox>
                <label for="txtEmail">Email</label>
                <div class="progress">
                    <div id="d2" visible="false" runat="server" class="progress-bar progress-bar-danger">Wrong Email!!!!</div>
                </div>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtPassword" class="form-control" placeholder="Password" runat="server" TextMode="Password" required="required"></asp:TextBox>
                <label for="txtPassword">Password</label>
                <div class="progress">
                    <div id="d1" style="width: 0%" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></div>
                </div>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtrePassword" class="form-control" placeholder="Re Password" runat="server" required="required" TextMode="Password"></asp:TextBox>
                <label for="txtrePassword">Re Password</label>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtPhoneNumber" class="form-control" placeholder="Phone Number" runat="server" required="required" OnTextChanged="txtPhoneNumber_TextChanged1"></asp:TextBox>
                <label for="txtPhoneNumber">Phone Number</label>
                <div class="progress">
                    <div id="D3" visible="false" runat="server" class="progress-bar progress-bar-danger">Wrong Phone!!!!</div>
                </div>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtCity" class="form-control" placeholder="City" runat="server" required="required"></asp:TextBox>
                <label for="txtCity">City</label>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtState" class="form-control" placeholder="State" runat="server" required="required"></asp:TextBox>
                <label for="txtState">State</label>
            </div>

            <div class="form-label-group">
                <asp:TextBox ID="txtZip" class="form-control" placeholder="Zip" runat="server" required="required"></asp:TextBox>
                <label for="txtZip">Zip</label>
            </div>

            <asp:Button ID="btn_sign" runat="server" OnClick="btn_sign_Click" Text="Sign in" CssClass="btn btn-primary" />
        </div>
    </form>
</body>
</html>
