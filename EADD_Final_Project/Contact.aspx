<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="EADD_Final_Project.WebForm7" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    <div class="container-fluid well">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">
                        <h2>Contact Us</h2>
                        <h3>Help us to help you learn, drop us a line anytime...<br />
                            We're here to answer any questions that you may have.</h3>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-9">
                        <h3>Message</h3>
                        <asp:TextBox ID="ContactUsTextBox" runat="server" TextMode="MultiLine" Rows="4" Width="100%"></asp:TextBox>
                        <asp:Button ID="SubmitButton" runat="server" Text="Send" CssClass="pull-right" />
                    </div>
                    <div class="col-md-3">
                        
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-9">
                        <br />
                        <h4 style="color:blue"><strong><asp:Label ID="SubmitConfirmLabel" runat="server" Text="Your message was received. Thank you!"></asp:Label></strong></h4>
                    </div>
                    <div class="col-md-3">
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
