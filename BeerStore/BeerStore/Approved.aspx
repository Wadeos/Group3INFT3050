<%@ Page Title="Approved Page" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Approved.aspx.cs" Inherits="BeerStore.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" align="center" >
        <div class="jumbotron">
            <h1>Payment Successful</h1>
            <p>Thank you for ordering from us.</p>
            <p>Your order will arrive in 1-2 Business Days.</p>
        </div>
    </div>
    <div>
<<<<<<< HEAD
        <asp:Label ID="Label1" runat="server" CssClass="h3" Text="Customer Details"></asp:Label>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="box">
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="First Name: "></asp:Label>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("FirstName") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Last Name: "></asp:Label>
                        <asp:Label ID="lblLName" runat="server" Text='<%#Eval("LastName") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label5" runat="server" Text="Shipping Address: "></asp:Label>
                        <asp:Label ID="lblShipping" runat="server" Text='<%#Eval("ShippingAddress") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label6" runat="server" Text="Email: "></asp:Label>
                        <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Label ID="Label2" runat="server" CssClass="h3" text="Customer Invoice"></asp:Label>
        <asp:Repeater ID="InvoiceRepeater" runat="server">
            <ItemTemplate>
                <div class="box">
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Product Brand: "></asp:Label>
                        <asp:Label ID="lblBrand" runat="server" Text='<%#Eval("Brand") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Product Name: "></asp:Label>
                        <asp:Label ID="lblpName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label5" runat="server" Text="Item Quantity: "></asp:Label>
                        <asp:Label ID="lblQuantity" runat="server" Text='<%#Eval("ItemQuantity") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label6" runat="server" Text="Subtotal: "></asp:Label>
                        <asp:Label ID="lblSubTotal" runat="server" Text='<%#Eval("SubTotal") %>'></asp:Label>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>    
        <asp:Label ID="Label7" runat="server" Text="Total Due:"></asp:Label>
        <asp:Label ID="LblSum" runat="server"></asp:Label>
=======
        <asp:Button ID="btnInvoice" runat="server" Text="Click To view Invoice" OnClick="displayInvoice_Click" />
            <asp:GridView ID="GridView1" runat="server" Visible="false"></asp:GridView>
>>>>>>> f62f3456171f0da2530b62cf6e06c451aae3723d
        <asp:Label ID="errorlbl" runat="server"></asp:Label>
    </div>
    <div class="form-group" align="center">
        <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-primary" OnClick="btnHome_Click" />
    </div>
</asp:Content>
