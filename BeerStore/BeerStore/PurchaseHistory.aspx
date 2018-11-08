<%@ Page Title="Purchase History" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="PurchaseHistory.aspx.cs" Inherits="BeerStore.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p><font color="grey" size="2">TRANSACTION HISTORY</font> <br />
            <b><font size="6">Your Purchase History</font> </b>
        </p>
    </div>
    <br />
    <div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
</asp:Content>
