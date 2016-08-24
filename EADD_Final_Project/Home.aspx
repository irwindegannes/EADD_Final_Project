<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="EADD_Final_Project.Home" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <div class="row">
                    <div class="col-md-12">
                        <asp:Image ID="ProfilePicture" runat="server" AlternateText="Profile Picture" GenerateEmptyAlternateText="True" ToolTip="Profile Picture" Height="210px" Width="215px" BorderStyle="Double" BorderWidth="1px" />
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="row">
                        <h4 style="align-content: center"><strong>Rank: </strong>
                            <asp:Label ID="Rank" runat="server" Text=""></asp:Label></h4>
                        <br />
                    </div>
                </div>
            </div>
            <div class="col-md-9">
                <div class="row">
                    <div class="col-md-12">
                        <div class="container-fluid">
                            <div class="page-header">
                                <h1 style="text-align: center"><strong>Welcome to My SQL Tutor</strong></h1>
                            </div>
                            <h4>Please see the Lessons tab above to begin learning SQL. Please enjoy your stay.</h4>
                            <br />
                        </div>
                    </div>
                </div>
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-9">
                            <div class="container-fluid well">
                                <h3 class="panel-heading"><strong>Account Summary</strong></h3>
                                <br />
                                <h4><strong>Name:</strong>
                                    <asp:Label ID="NameLabel" runat="server" Text=""></asp:Label></h4>
                                <br />
                                <h4><strong>Country:</strong>
                                    <asp:Label ID="CountryLabel" runat="server" Text=""></asp:Label></h4>
                                <br />
                            </div>
                            <br />
                            <div class="container-fluid well">
                                <h3 class="panel-heading"><strong>Overall Lesson Progress</strong></h3>
                                <br />
                                <div class="progress">
                                    <div class="progress-bar progress-bar-striped" role="progressbar" aria-valuenow="70" aria-valuemin="0" aria-valuemax="100" style="width: 70%">
                                        70%
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="container-fluid well">
                                <h3 class="panel-heading"><strong>Achievement Summary</strong></h3>
                                <br />
                                <h4><strong>Achievements Unlocked:</strong>
                                    <asp:Label ID="AchUnlockedLabel" runat="server" Text="5"></asp:Label></h4>
                                <br />
                                <h4><strong>Achievements Remaining:</strong>
                                    <asp:Label ID="AchRemaining" runat="server" Text="15"></asp:Label></h4>
                                <br />
                            </div>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                        </div>
                        <div class="col-md-3">
                            <div class="container-fluid well">
                                <h3 class="panel-heading">Recent Activity</h3>
                                <br />
                                <asp:Label ID="UserLabel" runat="server" Text="John Downloaded the Select Lesson 3 days ago"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>


    <asp:HiddenField ID="CheckIdentityHF" runat="server" />
    <asp:HiddenField ID="ProfilePictureHiddenField" runat="server" />
</asp:Content>
