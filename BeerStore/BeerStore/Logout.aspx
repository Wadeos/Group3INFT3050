<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="BeerStore.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Logout Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Click to logout</h1>
    <asp:Button ID="logoutButton" runat="server" class="btn" OnClick="logoutButton_Click" />

</asp:Content>
