<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="AdminManageItems.aspx.cs" Inherits="BeerStore.UL.AdminManageItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Manage Items</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:BoundField DataField="productID" HeaderText="productID" SortExpression="productID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Brand" HeaderText="Brand" SortExpression="Brand" />
            <asp:BoundField DataField="imagefile" HeaderText="imagefile" SortExpression="imagefile" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="shortDescription" HeaderText="shortDescription" SortExpression="shortDescription" />
            <asp:BoundField DataField="longDescription" HeaderText="longDescription" SortExpression="longDescription" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllProducts" TypeName="BeerStore.BL.ProductsBL" UpdateMethod="updateProduct">
        <UpdateParameters>
            <asp:Parameter Name="productID" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Brand" Type="String" />
            <asp:Parameter Name="imagefile" Type="String" />
            <asp:Parameter Name="price" Type="Decimal" />
            <asp:Parameter Name="shortDescription" Type="String" />
            <asp:Parameter Name="longDescription" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>



    <br />
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Insert new Product"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Product ID:  "></asp:Label>
    <asp:TextBox ID="ProductID" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Name:  "></asp:Label>
    <asp:TextBox ID="Name" runat="server" ></asp:TextBox>
    <asp:Label ID="productIDSwitch" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Brand:  "></asp:Label>
    <asp:TextBox ID="Brand" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Text="Image File:  "></asp:Label>
    <asp:TextBox ID="image" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label12" runat="server" Text="Price:  "></asp:Label>
    <asp:TextBox ID="Price" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label13" runat="server" Text="Short Description:  "></asp:Label>
    <asp:TextBox ID="ShortDescription" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label14" runat="server" Text="Long Description:  "></asp:Label>
    <asp:TextBox ID="LongDescription" runat="server" ></asp:TextBox>
    <br />
    <asp:Button ID="InsertButton" runat="server" Text="Insert" OnClick="InsertButton_Click" />



    </asp:Content>
