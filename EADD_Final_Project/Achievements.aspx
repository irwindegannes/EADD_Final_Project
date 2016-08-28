<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Achievements.aspx.vb" Inherits="EADD_Final_Project.WebForm3" %>

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
                            <br />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-9">
                <h2 style="text-align: center"><strong>Achievement Details</strong></h2>
                <br />
                <h3><strong>Completion Points (CP):</strong>
                    <asp:Label ID="UserCPLabel" runat="server" Text=""></asp:Label></h3>
                <br />
                <h3><strong>Achievements Locked:</strong>
                    <asp:Label ID="ALockedLabel" runat="server" Text="7 of 9"></asp:Label></h3>
                <br />
                <h3><strong>Achievements Unlocked:</strong>
                    <asp:Label ID="AUnlockedLabel" runat="server" Text="2 of 9"></asp:Label></h3>
                <br />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <table style="border-width: medium; width: 100%; height: 150px; text-align: center;" border="1" class="well" draggable="auto">
                    <tr>
                        <td style="color: blue"><strong>Completed First Lesson</strong></td>
                        <td>Visited Help Page</td>
                        <td>Earned 10 CP</td>
                    </tr>
                    <tr>
                        <td>Completed All Lessons</td>
                        <td style="color: blue"><strong>Earned First CP</strong></td>
                        <td>Earned 15 CP</td>
                    </tr>
                    <tr>
                        <td>Liked A Lesson</td>
                        <td>Earned 5 CP</td>
                        <td>Earned Max CP</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ProfilePictureHiddenField" runat="server" />
</asp:Content>
