<%@ Page Title="Confirmation" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="BeerStore.Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" align="center" >
        <div class="jumbotron">
            <%-- Confirming details --%>
            <h1>Confirmation</h1>
            <script runat="server">
                protected void confirm_Click(object sender, EventArgs e)
                {
                    confirm();
                    Button2.Visible = true;
                    Button1.Visible = false;

                }
            </script>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <fieldset>
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="Confirm Payment" OnClick="confirm_Click" />
                    </fieldset>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Processing Payment Details...."></asp:Label> <br />
                    <asp:Image ID="Image1" runat="server" ImageUrl="Images/loading.gif" />
                </ProgressTemplate>
             </asp:UpdateProgress>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Label ID="resultlbl" runat="server" CssClass="h2"></asp:Label> <br />
                    <asp:Button ID="Button2" runat="server" CssClass="btn btn-default" Text="Continue" OnClick="transfer_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
