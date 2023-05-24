<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DatabaseUltraHomeWork.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css"> 
    <script src="https://code.jquery.com/jquery-3.6.0.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
    </head>
<body>

    <form id="form1" runat="server">
        <nav class="navbar navbar-dark bg-dark"> 
            <a class="navbar-brand">MODERN Market</a>
            <asp:Label runat="server" class="navbar-brand text-uppercase" ID="lblCustomerName"></asp:Label>
            <asp:LinkButton class="nav-link" ID="LinkBtnSignOut" runat="server" OnClick="LinkBtnSignOut_Click">Sign Out</asp:LinkButton>
            <asp:LinkButton class="nav-link" runat="server" ID="LinkBtnSignIn" OnClick="LinkBtnSignIn_Click">Sign in</asp:LinkButton>
        </nav>
        
        <div class="container">
            <div class="row">
                <div class="col-md-2">
                    <asp:LinkButton ID="mask" runat="server" OnClick="LinkButton1_Click" CssClass="dropdown-item">mask</asp:LinkButton>
                </div>
                <div class="col-md-2">
                    <asp:LinkButton ID="props" runat="server" CssClass="dropdown-item" OnClick="LinkButton2_Click">props</asp:LinkButton>
                </div>
                <div class="col-md-2">
                    <asp:LinkButton ID="party" runat="server" CssClass="dropdown-item" OnClick="LinkButton3_Click">party</asp:LinkButton>
                </div>
                <div class="col-md-2">
                    <asp:LinkButton ID="custoumes" runat="server" CssClass="dropdown-item" OnClick="LinkButton4_Click">custoumes</asp:LinkButton>
                </div>
                <div class="col-md-2">
                    <asp:LinkButton ID="special" CssClass="dropdown-item" runat="server" OnClick="LinkButton5_Click">special</asp:LinkButton>
                </div>
            </div>
            <div class="row mt-3">
                <div class="col-md-4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" CssClass="btn btn-primary" />
                </div>
                <div class="col-md-4">
                    <asp:CheckBox ID="chk_mask" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="mask" />
                    <asp:CheckBox ID="chk_props" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="props" />
                    <asp:CheckBox ID="chk_party" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="party" />
                    <asp:CheckBox ID="chk_cust" runat="server" OnCheckedChanged="CheckBox4_CheckedChanged" Text="coustumes" />
                    <asp:CheckBox ID="chk_special" runat="server" OnCheckedChanged="CheckBox5_CheckedChanged" Text="special" />
                </div>
                <div class="col-md-4">
                </div>
            </div>
            <div class="row mt-3">
                <asp:DataList ID="DataList1" RepeatDirection="Horizontal" RepeatLayout="Flow" runat="server" CssClass="row row-cols-3 row-cols-md-3 align-items-center">
                    <ItemTemplate>
                        <div class="col mb-4">
                            <div class="card">
                                <img class="card-img-top" src='<%# Eval("ImageFile") %>' alt="Product Image" />
                                <div class="card-body">
                                    <h5 class="card-title"><asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' /></h5>
                                    <p class="card-text"><asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' /></p>
                                    <a href="#" class="btn btn-primary">Go somewhere</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </form>
</body>
</html>
