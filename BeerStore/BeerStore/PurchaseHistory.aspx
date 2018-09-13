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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPurchaseHistory" TypeName="BeerStore.Classes.PurchaseHistoryData"></asp:ObjectDataSource>
    <asp:GridView ID="GridViewPurchaseHistory" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
        CssClass="table table-bordered table-striped table-condensed"
        OnPreRender="grdCategories_PreRender">
        <Columns>
            <asp:BoundField DataField="OrderID" HeaderText="OrderID" SortExpression="OrderID">
                <ItemStyle CssClass="col-xs-2" />
            </asp:BoundField>
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date">
                <ItemStyle CssClass="col-xs-4" />
            </asp:BoundField>
            <asp:BoundField DataField="Product" HeaderText="Product" SortExpression="Product">
                <ItemStyle CssClass="col-xs-6" />
            </asp:BoundField>
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price">
                <ItemStyle CssClass="col-xs-8" />
            </asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity">
                <ItemStyle CssClass="col-xs-10" />
            </asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status">
                <ItemStyle CssClass="col-xs-12" />
            </asp:BoundField>
            <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total">
                <ItemStyle CssClass="col-xs-14" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
