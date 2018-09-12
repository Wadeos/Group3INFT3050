<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BeerStore.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h1 align="center">Contact Us</h1>
        </div>
        <div class="row" align="center">
            <div><b><font size="4">1300 00 00 00</font></b></div>
            <div>International: +61 2 1234 1234</div>
            <br />
            <div>Operation Hours:</div>
            <div>Monday to Friday: 9am - 8pm AEST</div>
            <div>Weekends: 10am - 4pm AEST</div>
            <br />
            <br />
            <div>
                <p><b><font size="3">Or</font></b></p>
            </div>
            <br />
            <div>
                <h1>Send us an email</h1>
            </div>
            <br />
            <br />
            <asp:Label ID="lblReason" runat="server"><b> What are you contacting us about today? </b></asp:Label>
            <div>
                <asp:DropDownList ID="ddlReason" runat="server" Width="350px" Height="40px">
                    <asp:ListItem Value="1">Order enquiry/issue</asp:ListItem>
                    <asp:ListItem Value="2">Store enquiry/feedback</asp:ListItem>
                    <asp:ListItem Value="3">Product enquiry/feedback</asp:ListItem>
                    <asp:ListItem Value="4">Website/App feedback</asp:ListItem>
                    <asp:ListItem Value="5">Compliments</asp:ListItem>
                    <asp:ListItem Value="6">Complaints</asp:ListItem>
                    <asp:ListItem Value="7">Other</asp:ListItem>
                    </asp:DropDownList>
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
            </div>
            <br />
            <div>
                <asp:Label ID="lblLastName" runat="server"><b> Last Name </b></asp:Label>
            </div>
            <div class="form-inline">
                <asp:TextBox ID="txtLastName" runat="server" class="form-control" Width="300px"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblPhone" runat="server"><b> Phone Number </b></asp:Label>
            </div>
            <div class="form-inline">
                <asp:TextBox ID="txtPhone" runat="server" class="form-control" Width="300px"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblEmail" runat="server"><b> Email Address </b></asp:Label>
            </div>
            <div class="form-inline">
                <asp:TextBox ID="txtEmail" runat="server" class="form-control" Width="300px"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" />
            </div>
</asp:Content>
