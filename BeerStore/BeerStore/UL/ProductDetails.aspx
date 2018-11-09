<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="BeerStore.UL.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div>
    <div>
        <h1> Product Details</h1>
    </div>
      <asp:Repeater ID="productDetails" runat="server">
          <ItemTemplate>
        <div class="col-md-4 box">
            <asp:ImageButton ID="image" runat="server" CssClass="img-responsive img-thumbnail img center-block" ImageUrl='<%#Eval("ImageFile") %>'/>
            <hr />
            <div><asp:Label ID="Label1" runat="server" CssClass="h2 text-danger center-block" Text='<%#Eval("Brand") %>'></asp:Label>
                <asp:Label ID="Label4" runat="server" CssClass="h2 text-danger center-block"  Text='<%#Eval("Name") %>'></asp:Label>
            </div>
                <hr />
                <div><asp:Label ID="Label2" runat="server" Text='<%#Eval("Price") %>'></asp:Label></div>
                <hr />
                <div class="h2"><asp:Label ID="Label3" runat="server" class="text-danger" Text='<%#Eval("LongDescription") %>'></asp:Label></div>
            <div>
                <hr />
                <asp:Button ID="button1" runat="server" Onclick="returnProducts" CssClass="btn btn-danger" Text="Returns to products" />
            </div>
        </div>
        </ItemTemplate>
       </asp:Repeater>
    </div>
</asp:Content>
