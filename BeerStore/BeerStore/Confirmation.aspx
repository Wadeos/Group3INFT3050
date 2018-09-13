<%@ Page Title="Confirmation" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="BeerStore.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group" align="center">
        <h1>Confirmation Page</h1>
        <p>Thank you for ordering from us! Your order total is: $175</p>
        <p>Please confirm your order.</p>
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="BackButton_Click" CssClass="btn btn-primary"/>
        <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
