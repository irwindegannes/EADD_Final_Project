<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="EADD_Final_Project.Home" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
        
    </asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-9">
                <div class="col-md-3" style="margin-right:60px">
                    <asp:Image ID="ProfilePicture" runat="server" AlternateText="Profile Picture" Height="160px" Width="165px" style="margin-bottom:10px" GenerateEmptyAlternateText="True" ToolTip="Profile Picture" />
                        <br /><br />
                    <asp:Label ID="Rank" runat="server" Text="Rank: " CssClass="well"></asp:Label><br /><br />
                    
                </div>
                <div class="col-md-6">
                    <div class="container-fluid">

                        <h5 class="panel-heading well">Account Summary</h5>
                        <h5 class="panel-body">...</h5>

                        <h5 class="well">Progress Summary</h5>

                        <h5 class="well">Achievements Summary</h5>

                        </div>
                </div>
            </div>
            <div class="col-md-3">
                <h3 class="well" style="text-align:center">Recent Activity</h3><br />
            </div>
        
        </div>
    </div>


    <asp:HiddenField ID="ProfilePictureHiddenField" runat="server" />
</asp:Content>
