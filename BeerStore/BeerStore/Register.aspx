<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BeerStore.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Register Page </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="registerForm" runat="server" class="margin">
        <div class="row">
            <h1> Please Enter Register Details</h1>
        </div>
        <div class="form-group">
            <asp:label ID="email" runat="server" Text="Email:"></asp:label>
            <div class="form-inline">
                 <asp:TextBox ID="emailtxt" runat="server" class="form-control" Width="300px"></asp:TextBox> 
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                     ErrorMessage="Please Enter Email" ControlToValidate="emailtxt" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator id="emailvalid" runat="server" ControlToValidate="emailtxt" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ErrorMessage="Email must be in correct format" ForeColor="Red">
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label ID="FirstName" runat="server" Text="First Name:"></asp:label>
            <div class="form-inline">
                <asp:TextBox ID="fNametxt" runat="server" class="form-control" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Please Enter First Name" ControlToValidate="fNametxt" 
                ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label ID="LastName" runat="server" Text="Last Name:"></asp:label>
            <div class="form-inline">
                 <asp:TextBox ID="lNametxt" runat="server" class="form-control" Width="200px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="Please Enter Last Name" ControlToValidate="lNametxt" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
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
        <div class="form-group">
            <asp:label ID="confirm" runat="server" Text="Confirm Password:"></asp:label>
            <div class="form-inline">
                 <asp:TextBox ID="confirmtxt" runat="server" class="form-control" Width="200px" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                    ErrorMessage="Please Confirm Password" ControlToValidate="confirmtxt" 
                    ForeColor="Red">* </asp:RequiredFieldValidator>
                 <asp:CompareValidator ID="CompareValidator1" runat="server" 
                     ErrorMessage="Passwords must match" EnableClientScript="True" 
                     ControlToCompare="passwordtxt" 
                     ControlToValidate="confirmtxt"
                      ForeColor="Red">*</asp:CompareValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" class="btn btn-primary"/>
        </div>
           
        <div>
            <asp:ValidationSummary ID="validsummary" runat="server"  ForeColor="Red" HeaderText="Please fix errors below:" />
        </div>
  </form>
</asp:Content>
