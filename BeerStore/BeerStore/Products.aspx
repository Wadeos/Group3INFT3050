<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BeerStore.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h3> Search for products</h3>
            <div class="input-group col-lg-4">
        <asp:TextBox ID="searchBar" runat="server" class="form-control" placeholder="Enter Beverage Name"></asp:TextBox>
        <div class="input-group-btn">    
            <asp:LinkButton runat="server" CssClass="btn btn-default" OnClick="searchbutton_Click"> 
                 <span class="glyphicon glyphicon-search"></span>
            </asp:LinkButton>
        </div>
    </div>
    <!-- https://bootsnipp.com/snippets/featured/ecommerce-product-display  -->
    <div class="col-md-2 column box">
        <asp:ImageButton ID="image" runat="server" class="img-responsive img img-thumbnail" OnClick="displayMore" />
        <div><asp:Label ID="brandtxt" runat="server"/>&nbsp<asp:Label ID="nametxt" runat="server"/></div>
        <div><div class="pull-right"><asp:Button ID="Button" runat="server" CssClass="btn btn-danger" Text="BUY"/></div><div class="text-danger"><asp:Label ID="price" runat="server"/></div></div>
    </div>
    <div class="col-md-2 column box">
        <asp:ImageButton ID="image1" runat="server" class="img-responsive img img-thumbnail" OnClick="displayMore" />
        <div><asp:Label ID="brandtxt1" runat="server"/>&nbsp<asp:Label ID="nametxt1" runat="server"/></div>
        <div><div class="pull-right"><asp:Button ID="Button1" runat="server" CssClass="btn btn-danger" Text="BUY"/></div><div class="text-danger"><asp:Label ID="price1" runat="server"/></div>
        <asp:Button ID="btnshowMore" runat="server" class="btn-link" OnClick="displayMore" Text="View more" />
        </div>
    </div>
    <div class="col-md-2 column box">
        <asp:ImageButton ID="image2" runat="server" class="img-responsive img img-thumbnail" OnClick="displayMore" />
        <div><asp:Label ID="brandtxt2" runat="server"/>&nbsp<asp:Label ID="nametxt2" runat="server"/></div>
        <div><div class="pull-right"><asp:Button ID="Button2" runat="server" CssClass="btn btn-danger" Text="BUY"/></div><div class="text-danger"><asp:Label ID="price2" runat="server"/></div></div>
    </div>
 </div>
</asp:Content>
