<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="EADD_Final_Project.Home" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
        
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
        
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    
    <div class="container-fluid" style="margin-top:60px">
        <div class="row">
            <div class="col-md-9" style="border-style:groove">
                <div class="col-md-3">
                    <asp:Image ID="ProfilePicture" runat="server" AlternateText="Profile Picture" ImageUrl="assets/profilepicture.png" Height="160px" Width="100%" />
                        <br />
                    <asp:Label ID="Rank" runat="server" Text="Rank: "></asp:Label>
                    
                </div>
                <div class="col-md-6" style="border-style:groove">
                    test
                </div>
            </div>
            <div class="col-md-3" style="border-style:groove">
                <h2 style="text-align:center">Recent Activity</h2><br /><br />
            </div>
        
        </div>
    </div>



</asp:Content>
