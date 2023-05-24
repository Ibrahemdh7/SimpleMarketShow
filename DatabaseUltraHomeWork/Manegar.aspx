<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manegar.aspx.cs" Inherits="DatabaseUltraHomeWork.Manegar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
          <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css"/>
      <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
      <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
      <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
    <asp:Button ID="btn_EMP" runat="server" Text="View Employees" CssClass="btn btn-outline-dark form-control" OnClick="btn_ViewEMP_Click"/><hr />
                <asp:Button ID="btn_Company" runat="server" Text="View Company" CssClass="btn btn-outline-dark form-control" OnClick="btn_Company_Click"/><hr />
                    <asp:Button ID="btn_SignOut" runat="server" Text="Sign Out" CssClass="alert alert-danger" Width="283px" style="left: 0px; top: 0px; height: 34px" OnClick="btn_SignOut_Click" />


        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Name" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name] FROM [Emoployee]"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="company" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="company" HeaderText="company" ReadOnly="True" SortExpression="company" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Company]"></asp:SqlDataSource>
    </form>
</body>
</html>
