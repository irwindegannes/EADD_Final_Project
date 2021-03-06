﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Help.aspx.vb" Inherits="EADD_Final_Project.WebForm6" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">

	<div class="container-fluid well">
		<h2 style="text-align:center"><strong>Help - Frequently Asked Questions (FAQ)</strong></h2><br />
		
		<div class="container-fluid">
		<br />
		
		<div class="panel-group" id="accordion">
			<div class="container-fluid">
				<div class="row">
					<h3><strong>&nbsp General questions</strong></h3>
					<br />
				</div>
			</div>
			<div class="panel panel-default">
				<div class="panel-heading">
					<h4 class="panel-title">
						<a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">Is SQL the only programming language being taught on this site?</a>
					</h4>
				</div>
					<div id="collapseOne" class="panel-collapse collapse">
						<div class="panel-body">
							Yes. As per request by the client. The site caters for Individual learners seeking to learn practical skills in SQL.
						</div>
					</div>
				</div>
				<div class="panel panel-default">
					<div class="panel-heading">
						<h4 class="panel-title">
							<a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">Can I skip locked Lessons?</a>
						</h4>
					</div>
					<div id="collapseTwo" class="panel-collapse collapse">
						<div class="panel-body">
							No. You must complete the previous Lesson before you can continue to the next one.
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
