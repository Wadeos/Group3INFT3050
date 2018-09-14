<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="BeerStore.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div>
    <div>
        <h1> Product Details</h1>
    </div>
        <div class="col-md-4 box">
            <asp:ImageButton ID="image" runat="server" class="img-responsive img-thumbnail img center-block"/>
            <hr />
            <div><asp:Label ID="Label1" runat="server" CssClass="h2 text-danger center-block"></asp:Label></div>
                <hr />
                <div><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></div>
                <hr />
                <div class="h2"><asp:Label ID="Label3" runat="server" class="text-danger"></asp:Label></div>
            <div>
                <hr />
                <asp:Button ID="button1" runat="server" Onclick="returnProducts" CssClass="btn btn-danger" Text="Returns to products" />
            </div>
        </div>
    </div>
</asp:Content>
