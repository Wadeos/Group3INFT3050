<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="AdminManageAccounts.aspx.cs" Inherits="BeerStore.UL.AdminManageAccounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1>Manage User Accounts</h1>
        <!-- Adds data from user Accounts data class which then can be edited with the command fields -->
        </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:BoundField DataField="userId" HeaderText="userId" SortExpression="userId" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="userPassword" HeaderText="userPassword" SortExpression="userPassword" />
            <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
            <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" />
            <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" SortExpression="phoneNumber" />
            <asp:BoundField DataField="userAddress" HeaderText="userAddress" SortExpression="userAddress" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="errorlbl2" runat="server"></asp:Label>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getUserDetails" TypeName="BeerStore.BL.UserAcountBL" UpdateMethod="updateUserAccount">
        <UpdateParameters>
            <asp:Parameter Name="userId" Type="Int32" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="userPassword" Type="String" />
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="PhoneNumber" Type="Int32" />
            <asp:Parameter Name="userAddress" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>

    <br />
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Create New User Account"></asp:Label>
    <br />
     <asp:Label ID="Label1" runat="server" Text="UserID:  "></asp:Label>
    <asp:TextBox ID="UserID" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Email:  "></asp:Label>
    <asp:TextBox ID="Email" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Password:  "></asp:Label>
    <asp:TextBox ID="Password" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Text="First Name:  "></asp:Label>
    <asp:TextBox ID="FirstName" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label12" runat="server" Text="Last Name:  "></asp:Label>
    <asp:TextBox ID="LastName" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label13" runat="server" Text="Phone Number:  "></asp:Label>
    <asp:TextBox ID="PhoneNumber" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="Label14" runat="server" Text="Address:  "></asp:Label>
    <asp:TextBox ID="Address" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="errorlbl" runat="server"></asp:Label>
    <asp:Button ID="InsertButton" runat="server" Text="Create" OnClick="InsertButton_Click" />
</asp:Content>
