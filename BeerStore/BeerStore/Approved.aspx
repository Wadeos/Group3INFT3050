﻿<%@ Page Title="Approved Page" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Approved.aspx.cs" Inherits="BeerStore.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" align="center" >
        <div class="jumbotron">
            <h1>Payment Successful</h1>
            <p>Thank you for ordering from us.</p>
            <p>Your order will arrive in 1-2 Business Days.</p>
        </div>
    </div>
    <div>
        <asp:Button ID="btnInvoice" runat="server" Text="Click To view Invoice" OnClick="displayInvoice_Click" />
            <asp:GridView ID="GridView1" runat="server" Visible="false"></asp:GridView>
        <asp:Label ID="errorlbl" runat="server"></asp:Label>
    </div>
    <div class="form-group" align="center">
        <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-primary" OnClick="btnHome_Click" />
    </div>
</asp:Content>
