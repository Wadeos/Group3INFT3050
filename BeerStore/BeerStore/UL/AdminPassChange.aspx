<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="AdminPassChange.aspx.cs" Inherits="BeerStore.UL.AdminPassChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-inline">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Enter Email"></asp:Label>
            <asp:TextBox ID="emailtxt" runat="server" class="form-control" Width="300px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                     ErrorMessage="Please Enter Email" ControlToValidate="emailtxt" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator id="emailvalid" runat="server" ControlToValidate="emailtxt" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ErrorMessage="Email must be in correct format" ForeColor="Red">
                </asp:RegularExpressionValidator>
        </div>
        <div>
             <asp:Label ID="Label1" runat="server" Text="Enter New Passoword"></asp:Label>
            <asp:TextBox ID="passwordtxt" runat="server" class="form-control" Width="200px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                     ErrorMessage="Please Enter Password" ControlToValidate="passwordtxt" 
                     ForeColor="Red">* </asp:RequiredFieldValidator>
        </div>
        <div>
             <asp:Label ID="Label2" runat="server" Text="Confirm New Password"></asp:Label>
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
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="confirmPassword_Click"/>
            <asp:Label ID="errorlbl" runat="server"></asp:Label>
        </div>
</asp:Content>
