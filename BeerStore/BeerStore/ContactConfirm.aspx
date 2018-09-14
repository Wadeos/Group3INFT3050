<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="ContactConfirm.aspx.cs" Inherits="BeerStore.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" align="center" >
        <div class="jumbotron">
            <h1>Thanks.</h1>
            <p>Your enquiry has been successfully sent
            and we appreciate you contacting us.
            We'll be in touch soon.
            </p>
        </div>
    </div>
    <div class="form-group" align="center">
        <asp:Button ID="btnHome" runat="server" Text="Return to Home >" CssClass="btn btn-primary" />
    </div>
</asp:Content>
