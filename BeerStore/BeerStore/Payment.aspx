<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="BeerStore.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Payment Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="paymentForm" runat="server" class="margin">
        <div>
            <h1>Payment Information</h1>
        </div>
        <br />
        <div>
            <p><b>Please enter your credit card information below and click Submit.</b></p>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPaymentMethod" runat="server" Text="Credit Cards Accepted: "></asp:Label>
            <div class="form-inline">
                <asp:RadioButton ID="rdoVisa" class="radio-inline" runat="server" GroupName="paymentMethod" Text="Visa" />
                <asp:RadioButton ID="rdoMasterCard" class="radio-inline" runat="server" GroupName="paymentMethod" Text="MasterCard" />
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCardNumber" runat="server">Card Number</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtCardNumber" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredCardNumber" runat="server" 
                     ErrorMessage="Please Enter Card Number" ControlToValidate="txtCardNumber" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
                 <!-- another validator required  -->
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblExpiryDate" runat="server">Expiry Date (MM/YYYY)</asp:label>
            <div class="form-inline">
                <asp:DropDownList ID="ddlMonth" runat="server">
                    <asp:ListItem Value="1">01</asp:ListItem>
                    <asp:ListItem Value="2">02</asp:ListItem>
                    <asp:ListItem Value="3">03</asp:ListItem>
                    <asp:ListItem Value="4">04</asp:ListItem>
                    <asp:ListItem Value="5">05</asp:ListItem>
                    <asp:ListItem Value="6">06</asp:ListItem>
                    <asp:ListItem Value="7">07</asp:ListItem>
                    <asp:ListItem Value="8">08</asp:ListItem>
                    <asp:ListItem Value="9">09</asp:ListItem>
                    <asp:ListItem Value="10">10</asp:ListItem>
                    <asp:ListItem Value="11">11</asp:ListItem>
                    <asp:ListItem Value="12">12</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlYear" runat="server">
                    <asp:ListItem Value="1">2018</asp:ListItem>
                    <asp:ListItem Value="2">2019</asp:ListItem>
                    <asp:ListItem Value="3">2020</asp:ListItem>
                    <asp:ListItem Value="4">2021</asp:ListItem>
                    <asp:ListItem Value="5">2022</asp:ListItem>
                    <asp:ListItem Value="6">2023</asp:ListItem>
                    <asp:ListItem Value="7">2024</asp:ListItem>
                    <asp:ListItem Value="8">2025</asp:ListItem>
                    <asp:ListItem Value="9">2026</asp:ListItem>
                    <asp:ListItem Value="10">2027</asp:ListItem>
                    <asp:ListItem Value="11">2028</asp:ListItem>
                    <asp:ListItem Value="12">2029</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCVV" runat="server">CVV</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtCVV" runat="server" class="form-control" Width="100px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredCVV" runat="server" 
                     ErrorMessage="Please CVV" ControlToValidate="txtCVV" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
                     <!-- Requires another validator -->
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblNameOnCard" runat="server">Name On Card</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtNameOnCard" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredNameOnCard" runat="server" 
                     ErrorMessage="Please Enter Name On Card" ControlToValidate="txtNameOnCard" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCountry" runat="server">Country</asp:label>
            <div class="form-inline">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="1">Australia</asp:ListItem>
                    <asp:ListItem Value="2">New Zealand</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblAddress1" runat="server">Address 1</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtAddress1" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredAddress1" runat="server" 
                     ErrorMessage="Please Enter Address" ControlToValidate="txtAddress1" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblAddress2" runat="server">Address 2</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtAddress2" runat="server" class="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCity" runat="server">City</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtCity" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredCity" runat="server" 
                     ErrorMessage="Please Enter City" ControlToValidate="txtCity" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblState" runat="server">State</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtState" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredState" runat="server" 
                     ErrorMessage="Please Enter State" ControlToValidate="txtState" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblPostalCode" runat="server">Postal Code</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtPostalCode" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredPostalCode" runat="server" 
                     ErrorMessage="Please Enter Postal Code" ControlToValidate="txtPostalCode" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblContactNumber" runat="server">Contact Phone Number</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtContactNumber" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredContactNumber" runat="server" 
                     ErrorMessage="Please Enter Phone Number" ControlToValidate="txtContactNumber" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblEmail" runat="server">Email Address</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtEmail" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiredEmail" runat="server" 
                     ErrorMessage="Please Enter Email Address" ControlToValidate="txtEmail" 
                     ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator id="validEmail" runat="server" ControlToValidate="txtEmail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ErrorMessage="Email must be in correct format" ForeColor="Red">
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" />
         </div>
    </form>
</asp:Content>