<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="AdminViewEmail.aspx.cs" Inherits="BeerStore.UL.AdminViewEmail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label runat="server" Cssclass="h4" text="An Email has been sent to your account please click the link to activate account"></asp:label> <br /><br />
    <asp:button runat="server" Cssclass="btn btn-default" text="Return to Admin Login" OnClick="return_Click"/>
</asp:Content>
