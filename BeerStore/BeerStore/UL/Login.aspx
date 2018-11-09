﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BeerStore.UL.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Login Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1> Login </h1>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Admin Login" OnClick="adminPage_Click" class="btn-link" CausesValidation="False"/>
        </div>
        <hr />
    </div>
    <asp:Panel ID="SearchBox" runat="server" DefaultButton="loginButton">
    <div class="form-group">
        <asp:label id="lblemail" runat="server"> E-mail: </asp:label>
        <div class="form-inline">
                <asp:TextBox ID="emailtxt" runat="server" class="form-control" Width="300px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                     ErrorMessage="Please Enter Email" ControlToValidate="emailtxt" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator id="emailvalid" runat="server" ControlToValidate="emailtxt" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ErrorMessage="Email must be in correct format" ForeColor="Red">
                </asp:RegularExpressionValidator>
        </div>
    </div>
     <div class="form-group">
            <asp:label ID="password" runat="server" Text="Password:"></asp:label>
             <div class="form-inline">
                    <asp:TextBox ID="passwordtxt" runat="server" class="form-control" Width="200px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                     ErrorMessage="Please Enter Password" ControlToValidate="passwordtxt" 
                     ForeColor="Red">* </asp:RequiredFieldValidator>
             </div>
        </div>
    <div>
        <asp:Label ID="errorlbl" runat="server" ForeColor="Red"></asp:Label>
    </div>
    <div class="form-group">
        <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" CssClass="btn btn-primary"/>
    </div>
        <asp:Button ID="Button2" runat="server" CssClass="btn-link" Text="Forgot Password? Click here" OnClick="redirectConfirm_Click" CausesValidation="false" />
    </asp:Panel>
    <div>
        <asp:ValidationSummary ID="validsummary" runat="server"  ForeColor="Red" HeaderText="Please fix errors below:" />
    </div>
</asp:Content>
