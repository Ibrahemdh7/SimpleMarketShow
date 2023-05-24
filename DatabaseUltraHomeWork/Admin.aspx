<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="DatabaseUltraHomeWork.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="my-3">
            <button id="btn_orders" class="btn btn-primary" runat="server" onclick="btn_orders_Click">View Order</button>
        </div>
        <div class="my-3">
            <button id="btn_Proudcts" class="btn btn-primary" runat="server" onclick="btn_Proudcts_Click">View Products</button>
        </div>
        <div class="my-3">
            <button id="btn_SignOut" runat="server" class="btn btn-danger" onclick="btn_SignOut_Click">Sign Out</button>
        </div>

        <div class="my-3">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="InvoiceNumber" DataSourceID="SqlDataSource1" CssClass="table table-striped">
                <Columns>
                    <asp:BoundField DataField="OrderDate" HeaderText="Order Date" SortExpression="OrderDate" />
                    <asp:BoundField DataField="Shipping" HeaderText="Shipping" SortExpression="Shipping" />
                    <asp:BoundField DataField="ShipMethod" HeaderText="Ship Method" SortExpression="ShipMethod" />
                    <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" />
                    <asp:BoundField DataField="InvoiceNumber" HeaderText="Invoice Number" InsertVisible="False" ReadOnly="True" SortExpression="InvoiceNumber" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [OrderDate], [Shipping], [ShipMethod], [Total], [InvoiceNumber] FROM [Invoices]"></asp:SqlDataSource>
        </div>

        <div class="my-3">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource2" CssClass="table table-striped">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="Product ID" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="ShortDescription" HeaderText="Short Description" SortExpression="ShortDescription" />
                    <asp:BoundField DataField="LongDescription" HeaderText="Long Description" SortExpression="LongDescription" />
                    <asp:BoundField DataField="CategoryID" HeaderText="Category ID" SortExpression="CategoryID" />
                    <asp:BoundField DataField="ImageFile" HeaderText="Image File" SortExpression="ImageFile" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" SortExpression="UnitPrice" />
                    <asp:BoundField DataField="OnHand" HeaderText="On Hand" SortExpression="OnHand" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
