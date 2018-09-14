<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="AdminManageAccounts.aspx.cs" Inherits="BeerStore.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1>Manage User Accounts</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
        CssClass="table table-bordered table-striped table-condensed"
        OnPreRender="GridView1_PreRender">
        <Columns>
            <asp:BoundField DataField="userId" HeaderText="userId" SortExpression="userId" > <ItemStyle CssClass="col-xs-2" /> </asp:BoundField>
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email"> <ItemStyle CssClass="col-xs-6" /> </asp:BoundField>
            <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" > <ItemStyle CssClass="col-xs-4" /></asp:BoundField>
            <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" ><ItemStyle CssClass="col-xs-4" /> </asp:BoundField>
            <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" SortExpression="phoneNumber" ><ItemStyle CssClass="col-xs-6" /> </asp:BoundField>
            <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" > <ItemStyle CssClass="col-xs-8" /> </asp:BoundField>
            <asp:CommandField ButtonType="Button" ShowEditButton="True" CausesValidation="False" > <ItemStyle CssClass="col-xs-2" /> </asp:CommandField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" CausesValidation="False" > <ItemStyle CssClass="col-xs-2" /> </asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetUserAccounts" TypeName="BeerStore.Classes.UserAccountData"></asp:ObjectDataSource>
        </div>
</asp:Content>
