<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="BeerStore.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnBack" runat="server" Text="Continue Shopping" CssClass="btn btn-primary" OnClick="btnBack_Click" />
    <br />
    <div>
        <h1>Shopping Cart</h1>
        <p>For help and enquiries, call <b>1300 00 00 00</b> </p>
    </div>
    <br />
    <div>
        <asp:GridView ID="Gridview1" runat="server" CssClass="table table-bordered table-striped table-condensed" OnRowCommand="Gridview1_RowCommand" AllowSorting="True">
            <Columns>
                <asp:ButtonField CommandName="remove" Text="Remove" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Clear Cart" OnClick="btnClear_Click" />
    </div>
    <div class="form-group" align="center">
        <p>
            <b> <asp:Label ID="Label1" runat="server" Text="Total:">
                <asp:Label ID="Label2" runat="server"></asp:Label></asp:Label> <br />
        </p>
        <br />
        <asp:Button ID="btnCheckout" runat="server" Text="Secure Checkout" CssClass="btn btn-primary" OnClick="btnCheckout_Click1" />
    </div>
</asp:Content>
