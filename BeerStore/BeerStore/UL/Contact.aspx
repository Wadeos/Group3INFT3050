<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BeerStore.UL.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h1 align="center">Contact Us</h1>
        </div>
        <br />
        <div class="row" align="center">
            <div><b><font size="4">1300 00 00 00</font></b></div>
            <div>International: +61 2 1234 1234</div>
            <br />
            <div>Operation Hours:</div>
            <div>Monday to Friday: 9am - 8pm AEST</div>
            <div>Weekends: 10am - 4pm AEST</div>
        </div>   
            <br />
            <br />
            <div align="center">        
                <p><b><font size="3">Or</font></b></p>
            </div>
            <br />
    <div class="container" align="center">
            <div>
                <h1>Send us an email</h1>
            </div>
            <br />
            <br />
            <asp:Label ID="lblReason" runat="server"><b> What are you contacting us about today? </b></asp:Label>
            <div>
                <asp:DropDownList ID="ddlReason" runat="server" Width="350px" Height="40px">
                    <asp:ListItem Value="None">Select Reason for Contact</asp:ListItem>
                    <asp:ListItem Value="1">Order enquiry/issue</asp:ListItem>
                    <asp:ListItem Value="2">Store enquiry/feedback</asp:ListItem>
                    <asp:ListItem Value="3">Product enquiry/feedback</asp:ListItem>
                    <asp:ListItem Value="4">Website/App feedback</asp:ListItem>
                    <asp:ListItem Value="5">Compliments</asp:ListItem>
                    <asp:ListItem Value="6">Complaints</asp:ListItem>
                    <asp:ListItem Value="7">Other</asp:ListItem>
                    </asp:DropDownList>
                <%-- Required to choose a reason --%>
                <asp:RequiredFieldValidator ID="rfvReason" runat="server" 
                     ErrorMessage="Please Select Year." ControlToValidate="ddlReason" 
                     InitialValue="None"
                     ForeColor="Red" Display="Dynamic">
                </asp:RequiredFieldValidator>
             </div>
            <br />
            <asp:Label ID="lblEnquiry" runat="server"><b> Your Enquiry/Feedback </b></asp:Label>
            <div>
                <textarea id="enquiryArea" cols="50" rows="10" placeholder="Briefly tell us what we can help you with"></textarea>
            </div>
            <br />
            <div>
                <asp:Label ID="lblContactMethod" runat="server" Text="Preferred contact method: "></asp:Label>
                <asp:RadioButton ID="rdoEmail" class="radio-inline" runat="server" GroupName="contactMethod" Text="Email" />
                <asp:RadioButton ID="rdoPhone" class="radio-inline" runat="server" GroupName="contactMethod" Text="Phone" />
            </div>
            <br />
            <div>
                <asp:Label ID="lblFirstName" runat="server"><b> First Name </b></asp:Label>
            </div>
            <div class="form-inline">
                <asp:TextBox ID="txtFirstName" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter First Name --%>
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                     ErrorMessage="Please Enter First Name." ControlToValidate="txtFirstName" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Can only use texts. Digits and special character's not allowed --%>
                <asp:RegularExpressionValidator ID="revFirstName"
                    runat="server" ControlToValidate="txtFirstName"
                    ValidationExpression="^[a-zA-Z'.\s]{1,50}"
                    CssClass="text-danger" ErrorMessage="Enter a Valid Name."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
            <br />
            <div>
                <asp:Label ID="lblLastName" runat="server"><b> Last Name </b></asp:Label>
            </div>
            <div class="form-inline">
                <asp:TextBox ID="txtLastName" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter Last Name --%>
                <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                     ErrorMessage="Please Enter Last Name." ControlToValidate="txtLastName" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Can only use texts. Digits and special character's not allowed --%>
                <asp:RegularExpressionValidator ID="revLastName"
                    runat="server" ControlToValidate="txtLastName"
                    ValidationExpression="^[a-zA-Z'.\s]{1,50}"
                    CssClass="text-danger" ErrorMessage="Enter a Valid Name."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
            <br />
            <div>
                <asp:Label ID="lblPhone" runat="server"><b> Phone Number </b></asp:Label>
            </div>
            <div class="form-inline">
                <asp:TextBox ID="txtPhone" runat="server" class="form-control" Width="300px"></asp:TextBox>
                <%-- Required to enter Phone Number --%>
                <asp:RequiredFieldValidator ID="rfvPhone" runat="server" 
                     ErrorMessage="Please Enter Phone Number" ControlToValidate="txtPhone" 
                     ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <%-- Must enter a 8-11 digit number --%>
                <asp:RegularExpressionValidator ID="revPhoneNumber"
                    runat="server" ControlToValidate="txtPhone"
                    CssClass="text-danger" ValidationExpression="\d{8,11}"
                    ErrorMessage="Enter a Valid Contact Number."
                    ForeColor="Red" Display="Dynamic">                   
                </asp:RegularExpressionValidator>
            </div>
            <br />
            <div>
                <asp:Label ID="lblEmail" runat="server"><b> Email Address </b></asp:Label>
            </div>
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
        <br />
            <div class="form-group" align="center">
                <%-- Submit button --%>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            </div>
    </div>
            
</asp:Content>
