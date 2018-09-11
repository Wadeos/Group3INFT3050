<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BeerStore._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Home Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="homePage" runat="server" class="margin">
         <h1>Welcome to Beer Store</h1>
    <div class="input-group col-lg-4">
        <asp:TextBox ID="searchBar" runat="server" class="form-control" placeholder="Enter Beverage Name"></asp:TextBox>
        <div class="input-group-btn">    
            <asp:LinkButton runat="server" CssClass="btn btn-default" OnClick="searchbutton_Click"> 
                 <span class="glyphicon glyphicon-search"></span>
            </asp:LinkButton>
        </div>
    </div>
        <asp:Label ID="test" runat="server"> </asp:Label>
</form>

</asp:Content>

