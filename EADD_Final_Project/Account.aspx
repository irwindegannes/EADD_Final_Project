<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Account.aspx.vb" Inherits="EADD_Final_Project.WebForm4" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    <div class="container-fluid well">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <h1 style="text-align: center"><strong>Account Details</strong></h1>
                </div>
                <div class="row well">
                    <h3>&nbsp <strong> First Name: </strong>
                        <asp:Label ID="FNameLabel" runat="server" Text="John"></asp:Label></h3>
                    <h3>&nbsp <strong> Last Name: </strong>
                        <asp:Label ID="LNameLabel" runat="server" Text="Smith"></asp:Label></h3>
                    <h3>&nbsp <strong> Date of Birth: </strong>
                        <asp:Label ID="DOBLabel" runat="server" Text="9/12/1981"></asp:Label></h3>
                    <h3>&nbsp <strong> Gender: </strong>
                        <asp:Label ID="Label2" runat="server" Text="Male"></asp:Label></h3>
                    <h3>&nbsp <strong> Country: </strong>
                        <asp:Label ID="Label3" runat="server" Text="Trinidad & Tobago"></asp:Label></h3>
                    <h3>&nbsp <strong> Email Address: </strong>
                        <asp:Label ID="Label4" runat="server" Text="johnsmith@email.com"></asp:Label></h3>
                </div>
                <div class="row well">
                    <h2>&nbsp Change Password</h2>
                    <h3>&nbsp <strong> Current Password:</strong>&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></h3>
                    <h3>&nbsp <strong> New Password:</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></h3>
                    <h3>&nbsp <strong> Confirm Password:</strong>&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></h3>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ChangePWButton" runat="server" Text="Change Password" PostBackUrl="#" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
