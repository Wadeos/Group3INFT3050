<%@ Page Title="Approved Page" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Approved.aspx.cs" Inherits="BeerStore.Approved" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" align="center" >
        <div class="jumbotron">
            <h1>Payment Successful</h1>
            <p>Thank you for ordering from us.</p>
            <p>Your order will arrive in 1-2 Business Days.</p>
            <p> An Email will automatically be sent to you with your order</p>
        </div>
    </div>
    <div>
        <div class="row" align="center">
            <asp:Label ID="Label1" runat="server" CssClass="h3"><b>Customer Invoice</b></asp:Label>  
        </div>             
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="box" align="center">
                    <div class="row" align="center">
                        <asp:Label ID="Label3" runat="server" ><b>First Name: </b></asp:Label>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("FirstName") %>'></asp:Label>
                    </div>
                    <div align="center">
                        <asp:Label ID="Label4" runat="server" align="right"><b>Last Name: </b></asp:Label>
                        <asp:Label ID="lblLName" runat="server" align="left" Text='<%#Eval("LastName") %>'></asp:Label>
                    </div>
                    <div align="center">
                        <asp:Label ID="Label5" runat="server" align="right"><b>Shipping Address: </b></asp:Label>
                        <asp:Label ID="lblShipping" runat="server" align="left" Text='<%#Eval("ShippingAddress") %>'></asp:Label>
                    </div>
                    <div align="center">
                        <asp:Label ID="Label6" runat="server"><b>Email: </b></asp:Label>
                        <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                    </div>
                    </br>
                    </br>
                </div>
                </br>
                </br>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="InvoiceRepeater" runat="server">
            <ItemTemplate>
                <div class="box" align="center">
                    <div>
                        <asp:Label ID="Label3" runat="server"><b>Product Brand: </b></asp:Label>
                        <asp:Label ID="lblBrand" runat="server" Text='<%#Eval("Brand") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label4" runat="server"><b>Product Name: </b></asp:Label>
                        <asp:Label ID="lblpName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label5" runat="server"><b>Item Quantity: </b></asp:Label>
                        <asp:Label ID="lblQuantity" runat="server" Text='<%#Eval("ItemQuantity") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label6" runat="server"><b>Subtotal: </b></asp:Label>
                        <asp:Label ID="lblSubTotal" runat="server" Text='<%#Eval("SubTotal") %>'></asp:Label>
                    </div>
                    </br>
                    </br>
                </div>
            </ItemTemplate>
        </asp:Repeater>    
        <div class="row" align="center">
            <asp:Label ID="Label7" runat="server" align="center"><b>Total Due: </b></asp:Label>
            <asp:Label ID="LblSum" runat="server"></asp:Label>
            <asp:Label ID="errorlbl" runat="server"></asp:Label>
        </div>
        </br>
        </br>
    <div class="form-group" align="center">
        <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-primary" OnClick="btnHome_Click" />
    </div>
</asp:Content>
