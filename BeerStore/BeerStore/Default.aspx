<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BeerStore._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <h1>Welcome to Beer Store</h1>
          <h3> Welcome to Beer Store. Select from a wide range of Australian beers, wines and spirits </h3>
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>

