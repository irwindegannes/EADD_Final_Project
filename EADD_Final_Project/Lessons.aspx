<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Lessons.aspx.vb" Inherits="EADD_Final_Project.Lessons" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    <div class="container-fluid well">
        <div class="row">
            <div class="col-md-3">
                <asp:Panel id="LessonsPanel" runat="server" CssClass="well">
                    <div class="panel-info" style="text-align:center"><h3><strong>Lessons</strong></h3></div><br />
                        <asp:Button ID="IntroButton" runat="server" Text="1. Introduction to SQL" CssClass="btn-block" />
                        <br />
                        <asp:Button ID="SelectButton" runat="server" Text="2. SELECT Command" CssClass="btn-block" />
                        <br />
                        <asp:Button ID="WhereButton" runat="server" Text="3. WHERE Command" CssClass="btn-block" />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" Text="4. INSERT Command" CssClass="btn-block" />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" Text="5. DELETE Command" CssClass="btn-block" />
                        <br />
                        <asp:Button ID="SandBoxButton" runat="server" Text="6. SandBox Activities" CssClass="btn-block" ToolTip="Has not been implemented..." Enabled="false" BorderStyle="Groove"/>
                </asp:Panel>
            </div>
            <div class="col-md-9">
                <div class="container-fluid well">
                    <asp:Panel id="LessonIntroPanel" runat="server">
                        <h2 style="text-align:center"><strong>Welcome to MY SQL Lessons</strong></h2>
                        <h3 style="text-align:center">Where you will learn all about SQL and complete common learning objectives</h3>
                        <h3 style="text-align:center">Select a Lesson to begin learning!</h3>
                        <br /><br /><br /><br /><br /><br />
                    </asp:Panel>
                    <asp:Panel ID="LessonContentPanel" runat="server">
                        <div class="panel-heading">
                            <div class="container-fluid text-center" id="LessonVideoContainer">
                                <asp:Label ID="LessonVideoLabel" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                        <div class="panel-body">
                            <asp:Label ID="LessonContentsLabel" runat="server"></asp:Label>
                        </div>
                        <asp:Panel ID="ActivityPanel" runat="server">
                            <div class="panel-footer">
                                <div class="col-md-12">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <h3>
                                                <asp:Label ID="ActivityNameLabel" runat="server" Text=""></asp:Label></h3>
                                            
                                            <h4>
                                                <asp:Label ID="ActivityTaskLabel" runat="server" Text=""></asp:Label></h4>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <asp:TextBox ID="ActivityTextBox" runat="server" TextMode="MultiLine" Height="60px" Width="100%" Rows="3"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <h4><asp:Label ID="ActivitySolutionLabel" runat="server" Text="Hover mouse here, to see the solution!"></asp:Label></h4>
                                        </div>
                                        <div class="col-md-6">
                                            <asp:Button ID="SubmitButton" CssClass="pull-right" runat="server" Text="Submit" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <h3 style="color:red"><asp:Label ID="ActivityResponseLabel" runat="server" Text=""></asp:Label></h3>
                                            
                                            <%--Used in debugging an issue with the insert into activity--%>
                                            <%--<h4 style="color:red"><asp:Label ID="UserResponseLabel" runat="server" Text=""></asp:Label></h4>
                                            <h4 style="color:red"><asp:Label ID="HFSolutionLabel" runat="server" Text=""></asp:Label></h4>
                                            <h4 style="color:red"><asp:Label ID="testanswerLabel" runat="server" Text=""></asp:Label></h4>--%>

                                            <h3>Activity Results</h3>
                                            <asp:GridView ID="ActivityResultsGridView" runat="server" AutoGenerateColumns="False" Width="100%"></asp:GridView>
                                            <asp:SqlDataSource ID="ActivitySqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                        <br /><br />
                        <asp:Panel ID="IntroFooterPanel" runat="server">
                            <div class="panel-footer">
                                <div class="col-md-12 text-center">
                                    <asp:Button ID="IntroContinueButton" runat="server" Text="Start Learning" Width="110px" Height="30px"/>
                                </div>
                            </div>
                        </asp:Panel>
                        <br /><br />
                        <asp:Panel ID="FooterPanel" runat="server">
                            <div class="row">
                                <br /><br />
                                <div class="col-md-6 text-center">
                                    <br /><br />
                                    <asp:Button ID="DownloadButton" runat="server" Text="Download This Lesson" />
                                </div>
                                <div class="col-md-6 text-center">
                                    <br /><br />
                                    <asp:Button ID="LikeButton" runat="server" Text="Like This Lesson" />
                                </div>
                                <br />
                                <br />
                                <br />
                                <br />
                                <div class="row">
                                    <div class="col-md-12">
                                        <br />
                                        <br />
                                        <br />
                                    <ul class="pager">
                                        <li class="previous"><a href="#">Previous</a></li>
                                        <li class="next"><a href="#">Next</a></li>
                                    </ul>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
    <asp:HiddenField ID="LessonIdHF" runat="server" />
    <asp:HiddenField ID="LessonDownloadURLHF" runat="server" />
    <asp:HiddenField ID="IsLikedHF" runat="server" />
    <asp:HiddenField ID="ActivityAnswerHF" runat="server" />
    <asp:HiddenField ID="ActivityIsCorrectHF" runat="server" Value="No" />
    
</asp:Content>
