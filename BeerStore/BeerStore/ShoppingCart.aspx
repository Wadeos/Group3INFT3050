<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="BeerStore.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="HyperLinkShopping" runat="server" NavigateUrl="~/Products.aspx">< Continue Shopping</asp:HyperLink>
    <br />
    <div>
        <h1>Shopping Cart</h1>
        <p>For help and enquiries, call <b>1300 00 00 00</b> </p>
    </div>
    <br />
    <div align="center">
        <%-- Products thats been added to the shopping cart --%>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetShoppingCart" TypeName="BeerStore.Classes.ShoppingCartData"></asp:ObjectDataSource>
        <asp:GridView ID="GridViewShoppingCart" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="table table-bordered table-striped table-condensed"
         OnPreRender="grdCategories_PreRender">
            <Columns>
                <asp:BoundField DataField="Product" HeaderText="Product" SortExpression="Product"> 
                    <ItemStyle CssClass="col-xs-2" />
                </asp:BoundField>
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price">
                    <ItemStyle CssClass="col-xs-1" />
                </asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity">
                    <ItemStyle CssClass="col-xs-1" />
                </asp:BoundField>
                <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total">
                    <ItemStyle CssClass="col-xs-1" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="form-group" align="center">
        <p>
            <b> <font size="3">Subtotal *</font> <font size="7">$175</font></b> <br />
            <font size="1" color="grey"> (inc $2.03 GST)</font>
        </p>
        <br />
        <asp:Button ID="btnCheckout" runat="server" Text="Secure Checkout" CssClass="btn btn-primary" OnClick="btnCheckout_Click1" />
    </div>
</asp:Content>
