<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BeerStore.Products1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Products" runat="server" class="margin">
         <asp:Table ID="Table1" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeadercell ID="categoryType"></asp:TableHeadercell>
                    <asp:TableHeadercell ID="beerName"></asp:TableHeadercell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                        <asp:TableCell ID="beerDescription"></asp:TableCell>
                </asp:TableRow>
         </asp:Table>
    </form>
</asp:Content>
