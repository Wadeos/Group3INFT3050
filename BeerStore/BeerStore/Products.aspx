<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BeerStore.Products" %>
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
            <table runat="server">
                <tr>
                    <td> <asp:Label ID="productName" runat="server"></asp:Label> </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" class="btn btn-default" Text="Add to Cart" OnClick="Button1_Click" />
</asp:Content>
