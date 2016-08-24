<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Lessons.aspx.vb" Inherits="EADD_Final_Project.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">





    <div class="container-fluid">



        <div class="row">
            <div class="col-sm-3">
                <asp:Button ID="IntroButton" runat="server" Text="Introduction" CssClass="btn-block" />
                <br />
                <asp:Button ID="SelectButton" runat="server" Text="SELECT statement" CssClass="btn-group" /><a href="#" title="Complete Previous Lesson To Unlock"><span id="SelectLock" class="glyphicon glyphicon-lock"></span></a>
                <br />
                <asp:Button ID="UpdateButton" runat="server" Text="UPDATE statement" CssClass="btn-block" /> &nbsp <a href="#" title="Complete Previous Lesson To Unlock"><span id="UpdateLock" class="glyphicon glyphicon-lock"></span></a>
                <br />
                <asp:Button ID="DeleteButton" runat="server" Text="DELETE statement" CssClass="btn-block" /> &nbsp <a href="#" title="Complete Previous Lesson To Unlock"><span id="DeleteLock" class="glyphicon glyphicon-lock"></span></a>
                <br />
                <br />
                <asp:HiddenField ID="LessonIdHF" runat="server" />
                <asp:HiddenField ID="IsLikedHF" runat="server" />
            </div>
            <div class="col-sm-9">
                <div class="panel-heading">
                    <asp:Panel ID="LessonContentPanel" runat="server">
                        <div class="well">
                            <asp:Label ID="ContentsLabel" runat="server"></asp:Label>
                            <div class="panel-body">
                                <asp:Button ID="DownloadButton" runat="server" Text="Download" />
                                &nbsp; 
                                <asp:Button ID="LikeButton" runat="server" Text="Like" />
                            </div>
                            <ul class="pager">
                                <li class="previous"><a href="#">Previous</a></li>
                                <li class="next"><a href="#">Next</a></li>
                            </ul>
                        </div>
                    </asp:Panel>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
