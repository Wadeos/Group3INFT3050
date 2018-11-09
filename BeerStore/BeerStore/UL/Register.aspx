<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BeerStore.UL.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Register Page </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
            <h1> Please Enter Register Details</h1>
            <asp:Button ID="Button1" runat="server" class="btn-link" OnClick="registerPage_Click" CausesValidation="False" Text="Admin Register" />
        </div>
        <asp:Panel ID="SearchBox" runat="server" DefaultButton="RegisterButton">
        <div class="form-group">
            <asp:label ID="email" runat="server" Text="Email:"></asp:label>
            <!-- Required validator determines if user has entered data-->
            <div class="form-inline">
                 <asp:TextBox ID="emailtxt" runat="server" class="form-control" Width="300px"></asp:TextBox> 
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                     ErrorMessage="Please Enter Email" ControlToValidate="emailtxt" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
                <!-- Use Regular expression to determine if Email is in right format-->
                <asp:RegularExpressionValidator id="emailvalid" runat="server" ControlToValidate="emailtxt" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ErrorMessage="Email must be in correct format" ForeColor="Red">
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label ID="firstNametxt" runat="server" Text="First Name:"></asp:label>
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
                <!-- compares passwords -->
                 <asp:CompareValidator ID="CompareValidator1" runat="server" 
                     ErrorMessage="Passwords must match" EnableClientScript="True" 
                     ControlToCompare="passwordtxt" 
                     ControlToValidate="confirmtxt"
                      ForeColor="Red">*</asp:CompareValidator>
            </div>
        <div class="form-group">
            <asp:label ID="Phone" runat="server" Text="Phone Number:"></asp:label>
             <div class="form-inline">
                    <asp:TextBox ID="phonetxt" runat="server" class="form-control" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                     ErrorMessage="Please Enter Phone" ControlToValidate="phonetxt" 
                     ForeColor="Red">* </asp:RequiredFieldValidator>
             </div>
        </div>
        <div class="form-group">
            <asp:label ID="address" runat="server" Text="Address:"></asp:label>
             <div class="form-inline">
                    <asp:TextBox ID="addresstxt" runat="server" class="form-control" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                     ErrorMessage="Please Enter Address" ControlToValidate="addresstxt" 
                     ForeColor="Red">* </asp:RequiredFieldValidator>
             </div>
        </div>
        </div>
        <div class="form-group">
            <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" class="btn btn-primary"/>
        </div>
        </asp:Panel>
          <!-- Summary of all errors on page -->
        <div>
            <asp:ValidationSummary ID="validsummary" runat="server"  ForeColor="Red" HeaderText="Please fix errors below:" />
        </div>
</asp:Content>
