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
        </div>
        <div class="form-inline">
            <h3> Please Select a Product</h3>
            <table runat="server" class="table">
                <thead>
                     <tr>
                        <th scope="col"> Image</th>
                        <th scope="col"> Brand </th>
                        <th scope="col"> Name </th>
                        <th scope="col"> Price</th>
                        <th scope="col"> Purchase </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row"> <asp:image ID="image" runat="server" class="img-thumbnail"></asp:image></th>
                        <th><asp:Label ID="brandtxt" runat="server"></asp:Label></th>
                        <th> <asp:Label ID="nametxt" runat="server"></asp:Label></th>
                        <th><asp:Label ID="Price" runat="server"></asp:Label></th>
                        <th><asp:Button ID="Button1" runat="server" class="btn btn-default" Text="Add to Cart" OnClick="Button1_Click" /></th>
                    </tr>
                </tbody>
                <tbody>
                    <tr>
                        <th scope="row"> <asp:image ID="image1" runat="server" class="img-thumbnail"></asp:image></th>
                        <th><asp:Label ID="Label1" runat="server"></asp:Label></th>
                        <th> <asp:Label ID="Label2" runat="server"></asp:Label></th>
                        <th><asp:Label ID="Label3" runat="server"></asp:Label></th>
                        <th><asp:Button ID="Button2" runat="server" class="btn btn-default" Text="Add to Cart" OnClick="Button1_Click" /></th>
                    </tr>
                </tbody>
            </table>
        </div>
</asp:Content>
