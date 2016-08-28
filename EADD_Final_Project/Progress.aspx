<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Progress.aspx.vb" Inherits="EADD_Final_Project.WebForm2" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    <div class="container-fluid well">
        <div class="row">
            <div class="col-md-3">
                <div class="row">
                    <div class="col-md-12">
                        <asp:Image ID="ProfilePicture" runat="server" AlternateText="Profile Picture" GenerateEmptyAlternateText="True" ToolTip="Profile Picture" Height="210px" Width="220px" BorderStyle="Double" BorderWidth="1px" />
                    </div>
                </div>
                <br />
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-12">
                            <h4 style="align-content: center"><strong>Rank: </strong>
                                <asp:Label ID="Rank" runat="server" Text="Amateur"></asp:Label></h4>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-9">
                <div class="row">
                    <div class="col-md-12">
                        <div class="container-fluid">
                            <div class="page-header">
                                <h1 style="text-align: center"><strong>Lesson Progress Details</strong></h1>
                            </div>
                            <h4>Welcome to your lesson progress details, where you will be able to keep track of your progress throughout the lessons, and also see just how far you have to go before you complete the course.</h4>
                            <br />
                        </div>
                    </div>
                </div>
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-8">
                            <div class="container-fluid well">
                                <h3><strong>Lesson Progress</strong></h3>
                                <br />
                                <div class="progress" style="background-color: grey">
                                    <asp:Label ID="ProgressLabel" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <div class="container-fluid well">
                                <h3><strong>Activity Attempts: </strong></h3>
                                <br />
                                <h4><strong>Lesson Activities Attempted: </strong>
                                    <asp:Label ID="LessonActALabel" runat="server" Text="2 of 5"></asp:Label></h4>
                                <h4><strong>Lesson Activities Completed: </strong>
                                    <asp:Label ID="LessonActCLabel" runat="server" Text="2 of 5"></asp:Label></h4>
                                <h4><strong>Lesson Activities Unattempted: </strong>
                                    <asp:Label ID="LessonActULabel" runat="server" Text="2 of 5"></asp:Label></h4>
                            </div>
                            <div class="container-fluid well">
                                <h3><strong>Achievements</strong></h3>
                                <br />
                                <h4><strong>Achievements Locked:</strong>
                                    <asp:Label ID="AchUnlockedLabel" runat="server" Text="15"></asp:Label></h4>
                                <h4><strong>Achievements Unlocked:</strong>
                                    <asp:Label ID="AchRemaining" runat="server" Text="5"></asp:Label></h4>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="container-fluid well">
                                <h4 class="panel-heading"><strong>Recent Activity</strong></h4>
                                <br />

                                <asp:Repeater ID="ActivityRepeater" runat="server" OnItemDataBound="LikeSub">
                                    <ItemTemplate>
                                        <h4>
                                            <asp:Label ID="LikeInfoLabel" runat="server" Text=""></asp:Label></h4>
                                        <h4>
                                            <asp:Label ID="LessonIdLabel" runat="server" Text=""></asp:Label></h4>
                                        <h4>
                                            <asp:Label ID="DateLikedLabel" runat="server" Text=""></asp:Label></h4>
                                        <br />
                                    </ItemTemplate>
                                </asp:Repeater>
                                <h4>
                                    <asp:Label ID="UserLabel" runat="server" Text="You Downloaded <br /> The Select Lesson 3 days ago"></asp:Label></h4>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <asp:HiddenField ID="CheckIdentityHF" runat="server" />
    <asp:HiddenField ID="ProfilePictureHiddenField" runat="server" />
</asp:Content>
