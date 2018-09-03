<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BeerStore.Products1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Products" runat="server" class="margin">
         <asp:DropDownList ID="CategoryList" runat="server">
             <asp:ListItem text=""></asp:ListItem>
             <asp:ListItem text=""></asp:ListItem>
         </asp:DropDownList>
         <asp:label ID="beerName" runat="server"></asp:label>
         <asp:label ID="beerDescription" runat="server"></asp:label>
         <asp:label ID="categoryType" runat="server"></asp:label>
    </form>
</asp:Content>
