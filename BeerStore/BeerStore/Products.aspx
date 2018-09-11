<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BeerStore.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Products" runat="server" class="margin">
        <table>
            <tr>
                <td> <asp:Label ID="productName" runat="server">ayyy</asp:Label></td>
                <td> <asp:Label ID="Label1" runat="server">ayyy</asp:Label></td>
            </tr>
            <tr>
                <td> </td>
                <td> </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" class="btn btn-default" Text="Add to Cart" />
        
    </form>
</asp:Content>
