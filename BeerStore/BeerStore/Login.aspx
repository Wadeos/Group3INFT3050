<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BeerStore.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Login Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="loginform" runat="server" class="margin">
    <div>
        <h1> Login </h1>
    </div>
    <div class="form-group">
        <asp:label id="lblemail" runat="server"> E-mail: </asp:label>
        <br />
        <asp:TextBox ID="emailtxt" runat="server" class="form-control" Width="300px"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:label id="lblpassword" runat="server">Password: </asp:label>
        <br />
        <asp:TextBox id="passwordtxt" runat="server" class="form-control" Width="300px"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" CssClass="btn btn-primary"/>
    </div>
    <div>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter an E-mail" ControlToValidate="emailtxt" ForeColor="Red">
         </asp:RequiredFieldValidator> <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter a Password" ControlToValidate="passwordtxt" ForeColor="Red">
         </asp:RequiredFieldValidator> <br />
    </div>
</form>
</asp:Content>
