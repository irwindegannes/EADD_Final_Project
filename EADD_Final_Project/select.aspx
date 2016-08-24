<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="select.aspx.vb" Inherits="EADD_Final_Project._select" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">


  <div class="jumbotron">
    <h1>Select</h1> 
    <p>Welcome to the Select page where you will learn all about the select </p> 
  </div>



    <h3>Learning content on Select</h3>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent vitae nunc ut augue tempor sagittis. Phasellus lacus eros, ullamcorper nec nunc quis, sagittis aliquet est. Praesent sed lectus rutrum, fringilla ipsum nec, pretium sem. Nullam turpis nulla, sodales a orci interdum, dignissim pretium ipsum. Duis quis congue eros. Sed nulla nisi, tincidunt non vehicula ac, interdum nec nunc. Integer feugiat lobortis placerat. Vivamus vel eros vitae orci lacinia auctor quis sed ligula. Cras quis malesuada tortor. Suspendisse mattis posuere ante, id pretium libero auctor ut. Vivamus et leo mollis, ultricies nisl in, tincidunt libero. Sed vitae enim pulvinar leo feugiat faucibus sed non risus.

Phasellus purus orci, blandit vestibulum est interdum, mollis semper felis. Fusce venenatis augue ut justo tempor, ac hendrerit mauris porta. Etiam faucibus ipsum imperdiet, lacinia mauris vitae, tincidunt mi. Nulla facilisi. Nulla luctus ligula quam, vitae lobortis enim dignissim vel. Aliquam sit amet rhoncus mauris. Sed lacinia est et odio pulvinar, id fringilla est malesuada.
    </p>

   <div class="panel panel-primary">
      <div class="panel-heading">Activity</div>
      <div class="panel-body">
          content goes here
          <div class="row">
              <div class="col-md-12">
                  <asp:TextBox ID="TextBox1" runat="server" Height="50px" TextMode="MultiLine" Width="100%"></asp:TextBox>
              </div>

              <div class="col-md-6">
                  Help
              </div>
              <div class="col-md-6">
                  <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg pull-right" runat="server" Text="Button" />
              </div>
              <div class="col-md-12">
                  Results go here
              </div>
              <div class="col-md-6 text-center">
                  <asp:Button ID="Button2" CssClass="btn btn-primary btn-lg" runat="server" Text="Download" />
              </div>
              <div class="col-md-6 text-center">
                  <asp:Button ID="Button3" CssClass="btn btn-primary btn-lg" runat="server" Text="Like Lession" />
              </div>
          </div>
      </div>
    </div>


    <br /><br /><br /><br /><br /><br /><br /><br />
</asp:Content>
