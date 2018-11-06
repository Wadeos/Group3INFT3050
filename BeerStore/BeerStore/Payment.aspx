<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="BeerStore.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Payment Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:HyperLink ID="HyperLinkCart" runat="server" NavigateUrl="~/ShoppingCart.aspx">Back</asp:HyperLink>
        <div>
            <h1>Payment Information</h1>
        </div>
        <br />
        <div>
            <p><b>Please Enter Your Credit Card Information Below and Click Submit.</b></p>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPaymentMethod" runat="server" Text="Credit Cards Accepted: "></asp:Label>
            <div class="form-inline">
                <!--List of payment methods -->
                <asp:RadioButtonList RepeatDirection="Horizontal" ID="rblPaymentMethod" runat="server">
                    <asp:ListItem>&nbsp Visa&nbsp &nbsp </asp:ListItem>
                    <asp:ListItem>&nbsp MasterCard</asp:ListItem>
                </asp:RadioButtonList>

                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPaymentMethod" runat="server" 
                    ControlToValidate="rblPaymentMethod" 
                    ErrorMessage="Please Choose a Method."
                    ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator> 
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCardNumber" runat="server">Card Number</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtCardNumber" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <!-- Requires card number to be entered -->
                <asp:RequiredFieldValidator ID="requiredCardNumber" runat="server" 
                     ErrorMessage="Please Enter Card Number." ControlToValidate="txtCardNumber" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                 <!-- Correct digits is required (16 digits for standard credit card) -->
                <asp:RegularExpressionValidator ID="revCardNumber"
                    runat="server" ControlToValidate="txtCardNumber"
                    CssClass="text-danger" ValidationExpression="\d{16}"
                    ErrorMessage="Credit Card Number Does Not Exist. Check The Credit Card Information And Try Processing The Transaction Again."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblExpiryDate" runat="server">Expiry Date (MM/YYYY)</asp:label>
            <div class="form-inline">           
                <!-- List of months -->
                <asp:DropDownList ID="ddlMonth" runat="server">
                    <asp:ListItem Selected="True" Value="None">Select Month</asp:ListItem>
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
                <!-- Requires to select a month -->
                <asp:RequiredFieldValidator ID="rfvMonth" runat="server" 
                     ErrorMessage="Please Select Month." ControlToValidate="ddlMonth" 
                     InitialValue="None"
                     ForeColor="Red" Display="Dynamic">
                </asp:RequiredFieldValidator>
                <!-- List of years -->
                <asp:DropDownList ID="ddlYear" runat="server">
                    <asp:ListItem Selected="True" Value="None">Select Year</asp:ListItem>
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
                <!-- Requires to select year -->
                <asp:RequiredFieldValidator ID="rfvYear" runat="server" 
                     ErrorMessage="Please Select Year." ControlToValidate="ddlYear" 
                     InitialValue="None"
                     ForeColor="Red" Display="Dynamic">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCVV" runat="server">CVV</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtCVV" runat="server" class="form-control" Width="100px"></asp:TextBox>
                <!-- Required to enter CVV -->
                <asp:RequiredFieldValidator ID="rfvCVV" runat="server" 
                     ErrorMessage="Please Enter CVV." ControlToValidate="txtCVV" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <!-- Can only enter 3 digits -->
                <asp:RegularExpressionValidator ID="revCVV"
                    runat="server" ControlToValidate="txtCVV"
                    CssClass="text-danger" ValidationExpression="\d{3}"
                    ErrorMessage="Must be 3 Digits."
                    ForeColor="Red" Diplay="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblNameOnCard" runat="server">Name On Card</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtNameOnCard" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter name displayed on the card --%>
                <asp:RequiredFieldValidator ID="rfvNameOnCard" runat="server" 
                     ErrorMessage="Please Enter Name on Card." ControlToValidate="txtNameOnCard" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Can only use texts. Digits and special character's not allowed --%>
                <asp:RegularExpressionValidator ID="revName"
                    runat="server" ControlToValidate="txtNameOnCard"
                    ValidationExpression="^[a-zA-Z'.\s]{1,50}"
                    CssClass="text-danger" ErrorMessage="Enter a Valid Name."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCountry" runat="server">Country</asp:label>
            <div class="form-inline">
                <!-- List of countries -->
                <asp:DropDownList ID="ddlCountry" runat="server">
                    <asp:ListItem Selected="True" Value="None">Select Country</asp:ListItem>
                    <asp:ListItem Value="1">Australia</asp:ListItem>
                    <asp:ListItem Value="2">New Zealand</asp:ListItem>
                </asp:DropDownList>
                <!-- Required to select a country -->
                <asp:RequiredFieldValidator ID="rfvCOuntry" runat="server" 
                     ErrorMessage="Please Select Country." ControlToValidate="ddlCountry" 
                     InitialValue="None"
                     ForeColor="Red" Display="Dynamic">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblAddress1" runat="server">Address 1</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtAddress1" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter address --%>
                <asp:RequiredFieldValidator ID="requiredAddress1" runat="server" 
                     ErrorMessage="Please Enter Address" ControlToValidate="txtAddress1" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Must enter correct address --%>
                <asp:RegularExpressionValidator ID="revAddress"
                    runat="server" ControlToValidate="txtAddress1"
                    ValidationExpression="^\d+\s[A-z]+\s[A-z]+"
                    CssClass="text-danger" ErrorMessage="Enter a Valid Address."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <%-- 2nd address. Not required --%>
            <asp:label id="lblAddress2" runat="server">Address 2</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtAddress2" runat="server" class="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblCity" runat="server">City</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtCity" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter City --%>
                <asp:RequiredFieldValidator ID="requiredCity" runat="server" 
                     ErrorMessage="Please Enter City" ControlToValidate="txtCity" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Must be text. No digits allowed --%>
                <asp:RegularExpressionValidator ID="revCity"
                    runat="server" ControlToValidate="txtCity"
                    ValidationExpression="^[a-zA-Z'.\s]{1,58}"
                    CssClass="text-danger" ErrorMessage="Enter a Valid City."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblState" runat="server">State</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtState" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter State --%>
                <asp:RequiredFieldValidator ID="requiredState" runat="server" 
                     ErrorMessage="Please Enter State" ControlToValidate="txtState" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Must be text only --%>
                <asp:RegularExpressionValidator ID="revState"
                    runat="server" ControlToValidate="txtState"
                    ValidationExpression="^[a-zA-Z'.\s]{1,20}"
                    CssClass="text-danger" ErrorMessage="Enter a Valid State."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblPostalCode" runat="server">Postal Code</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtPostalCode" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter Postal code --%>
                <asp:RequiredFieldValidator ID="requiredPostalCode" runat="server" 
                     ErrorMessage="Please Enter Postal Code" ControlToValidate="txtPostalCode" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Must enter 4 digit number --%>
                <asp:RegularExpressionValidator ID="revPostal"
                    runat="server" ControlToValidate="txtPostalCode"
                    CssClass="text-danger" ValidationExpression="\d{4}"
                    ErrorMessage="Enter a Valid Postal Code."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblContactNumber" runat="server">Contact Number</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtContactNumber" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter Contact Number --%>
                <asp:RequiredFieldValidator ID="rfvContactNumber" runat="server" 
                     ErrorMessage="Please Enter Phone Number" ControlToValidate="txtContactNumber" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Must enter a 8-11 digit number --%>
                <asp:RegularExpressionValidator ID="revContactNumber"
                    runat="server" ControlToValidate="txtContactNumber"
                    CssClass="text-danger" ValidationExpression="\d{8,11}"
                    ErrorMessage="Enter a Valid Contact Number."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:label id="lblEmail" runat="server">Email Address</asp:label>
            <div class="form-inline">
                <asp:TextBox ID="txtEmail" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter email --%>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                     ErrorMessage="Please Enter Email Address" ControlToValidate="txtEmail" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Must be a valid email address --%>
                <asp:RegularExpressionValidator id="revEmail" runat="server" ControlToValidate="txtEmail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ErrorMessage="Email must be in correct format" ForeColor="Red" Display="Dynamic">
                </asp:RegularExpressionValidator>
            </div>
        </div>
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="Images/loading.gif"/>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
        <div class="form-group">
            <%-- Submit button for payment --%>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
        </div>
</asp:Content>