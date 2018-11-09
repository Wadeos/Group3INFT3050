<%@ Page EnableEventValidation="true" Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BeerStore.UL.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="SearchBox" runat="server" DefaultButton="btn_search">
        <div>
            <h3> Search for products</h3>
            <!-- https://www.w3schools.com/howto/howto_css_searchbar.asp used to create the search bar-->
            <div class="input-group col-md-3">
        <asp:TextBox ID="searchBar" runat="server" class="form-control" placeholder="Enter Beverage Name"></asp:TextBox>
        <div class="input-group-btn"> 
            <asp:LinkButton ID="btn_search" runat="server" CssClass="btn btn-default" OnClick="searchbutton_Click"> 
                 <span class="glyphicon glyphicon-search"></span>
            </asp:LinkButton>
        </div>
        </div>
      </div>
    </asp:Panel>
    <!-- https://bootsnipp.com/snippets/featured/ecommerce-product-display  used to create shaded box around the products-->
    <div>
        <h3> Please select a product </h3>
        <p class="text-danger"> Select Image to view more Information</p> 
        <asp:Label ID="errorlbl" CssClass="h3" runat="server"></asp:Label>
        <asp:Button ID="btn_show" runat="server" CssClass="btn btn-danger" Text="Show All Products" OnClick="btn_showAll" />
    </div>
    <!-- Uses repeater to insert the amount of products inside database-->
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
        <ItemTemplate>
            <div class="col-md-2 column box">
                <asp:ImageButton ID="img" runat="server" class="img-responsive img img-thumbnail center-block" ImageUrl='<%#Eval("ImageFile") %>' CommandName="ShowDetails" CommandArgument='<%#Eval("ProductID") %>'/>
                <div><asp:Label ID="brand" runat="server" Text='<%#Eval("Brand") %>'/>&nbsp<asp:Label ID="name" runat="server" Text='<%#Eval("Name") %>'/></div>
                <div><div class="pull-right"><asp:Button ID="Button" runat="server" CssClass="btn btn-danger" Text="Add To Cart" CommandName="Add" CommandArgument='<%#Eval("ProductID") %>'/></div><div class="text-danger"><asp:Label ID="pri" runat="server" Text='<%#Eval("Price") %>'/></div></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div>
    </div>
</asp:Content>
