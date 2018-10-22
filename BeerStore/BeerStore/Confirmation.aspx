<%@ Page Title="Confirmation" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="BeerStore.Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" align="center" >
        <div class="jumbotron">
            <%-- Confirming details --%>
            <h1>Confirmation Page</h1>
            <p>Thank you for ordering from us! Your order total is: <b>$175</b></p>
            <p>Please confirm your order.</p>
            <p>Order detail: <b>Corona</b>, Qt: 7</p>
        </div>
    </div>
    <div class="form-group" align="center"> 
        <%-- Back button --%>
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="BackButton_Click" CssClass="btn btn-primary"/>
        <%-- Confirm button --%>
        <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
