<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Lessons.aspx.vb" Inherits="EADD_Final_Project.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">

   <div class="container">
        <div class="row">
            <div class="col-sm-3">
                <asp:HiddenField ID="LessonIdHF" runat="server" />
                <asp:HiddenField ID="IsLikedHF" runat="server" />
                <asp:Button ID="Button1" runat="server" Text="Introduction" />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="SELECT statement" /><a href="#"><span id="SelectLock" class="glyphicon glyphicon-lock"></span></a>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Text="UPDATE statement" /><a href="#"><span id="UpdateLock" class="glyphicon glyphicon-lock"></span></a>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" Text="DELETE statement" /><a href="#"><span id="DeleteLock" class="glyphicon glyphicon-lock"></span></a>
                <br />

            </div>
            <div class="col-sm-6">
                <div class="panel-heading">
                    

                        <asp:Panel ID="Panel1" runat="server">
                            <div class="well">
                                <asp:Label ID="NotesLabel" runat="server"></asp:Label>
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
