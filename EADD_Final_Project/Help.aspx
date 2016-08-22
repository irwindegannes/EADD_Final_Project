<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Help.aspx.vb" Inherits="EADD_Final_Project.WebForm6" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">

    <div class="container-fluid" style="margin-top:20px">
		<h3 style="text-align:center">&nbsp;</h3>
        <h3 style="text-align:center"><b>Help - Frequently Asked Questions (FAQ)</b></h3><br />
		
		<div class="container-fluid">
		<br />
		<br />
		
		<div class="panel-group" id="accordion">
			<div class="faqHeader">General questions</div>
			<br />
			<div class="panel panel-default">
				<div class="panel-heading">
					<h4 class="panel-title">
						<a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">Is SQL the only programming language going to be available?</a>
					</h4>
				</div>
					<div id="collapseOne" class="panel-collapse collapse">
						<div class="panel-body">
							Stay tuned for updates, coming soon!
						</div>
					</div>
				</div>
				<div class="panel panel-default">
					<div class="panel-heading">
						<h4 class="panel-title">
							<a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">Can I skip locked Topics?</a>
						</h4>
					</div>
					<div id="collapseTwo" class="panel-collapse collapse">
						<div class="panel-body">
							No. You must complete the previous topic before you can continue to the next one.
						</div>
					</div>
				</div>
				<div class="panel panel-default">
					<div class="panel-heading">
						<h4 class="panel-title">
							<a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseThree">New Question?</a>
						</h4>
					</div>
					<div id="collapseThree" class="panel-collapse collapse">
						<div class="panel-body">
							New Answer!
						</div>
					</div>
				</div>
				<div class="panel panel-default">
				<div class="panel-heading">
					<h4 class="panel-title">
						<a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseFour">New Question?</a>
					</h4>
				</div>
					<div id="collapseFour" class="panel-collapse collapse">
						<div class="panel-body">
							New Answer!
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>

</asp:Content>
