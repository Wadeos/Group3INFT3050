<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="AdminManageItems.aspx.cs" Inherits="BeerStore.UL.AdminManageItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Manage Items</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Returns all products from product data list (ObjectdataSource1) -->
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="productID" HeaderText="productID" SortExpression="productID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Brand" HeaderText="Brand" SortExpression="Brand" />
            <asp:BoundField DataField="imagefile" HeaderText="imagefile" SortExpression="imagefile" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="longDescription" HeaderText="longDescription" SortExpression="longDescription" />
            <asp:CommandField ButtonType="Button" ShowEditButton="True" CausesValidation="False" > <ItemStyle CssClass="col-xs-2" /> </asp:CommandField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" CausesValidation="False" > <ItemStyle CssClass="col-xs-2" /> </asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProducts" TypeName="BeerStore.Classes.ProductData"></asp:ObjectDataSource>




</asp:Content>
