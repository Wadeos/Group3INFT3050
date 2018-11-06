<%@ Page Title="Confirmation" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="BeerStore.Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" align="center" >
        <div class="jumbotron">
            <%-- Confirming details --%>
            <h1>Confirmation Page</h1><
            <script runat="server">
                protected void confirm_Click(object sender, EventArgs e)
                {
                    confirm();
                    resultlbl.Visible = true;

                }
            </script>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="Button1" runat="server" Text="Confirm Payment" OnClick="confirm_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Processing Payment Details...."></asp:Label>
                    <asp:Image ID="Image1" runat="server" ImageUrl="Images/loading.gif" />
                </ProgressTemplate>
             </asp:UpdateProgress>
            <asp:Label ID="resultlbl" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
