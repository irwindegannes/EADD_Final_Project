<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateProfile.aspx.vb" Inherits="EADD_Final_Project.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Update User Profile</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid" style="margin-top: 20px">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-3">
                    </div>
                    <div class="col-md-6 well">
                        <h2 style="text-align: center"><strong>My SQL Tutor</strong></h2>
                        <h3 style="text-align: center">Update User Profile
                            <br />
                            Registration Step 2 of 2</h3>
                    </div>
                    <div class="col-md-3">
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                    </div>
                    <div class="col-md-6 well">
                        <div class="row">
                            <h4>&nbsp First Name:
                                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ErrorMessage="First Name Is Required" ForeColor="Red" ControlToValidate="FirstNameTextBox"></asp:RequiredFieldValidator>
                            </h4>
                            <h4>&nbsp Last Name:
                                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ErrorMessage="Last Name Is Required" ForeColor="Red" ControlToValidate="LastNameTextBox"></asp:RequiredFieldValidator>
                            </h4>
                            <h4>&nbsp Country:&nbsp&nbsp&nbsp&nbsp&nbsp
                            <asp:DropDownList ID="CountryDropDownList" runat="server">
                                <asp:ListItem Value="-1">Select Country</asp:ListItem>
                                <asp:ListItem>Trinidad &amp; Tobago</asp:ListItem>
                                <asp:ListItem>United States</asp:ListItem>
                                <asp:ListItem>England</asp:ListItem>
                                <asp:ListItem>Jamaica</asp:ListItem>
                                <asp:ListItem>Barbados</asp:ListItem>
                                <asp:ListItem>Mexico</asp:ListItem>
                                <asp:ListItem>Greenland</asp:ListItem>
                                <asp:ListItem>Japan</asp:ListItem>
                                <asp:ListItem>China</asp:ListItem>
                            </asp:DropDownList>&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorCountry" runat="server" ErrorMessage="Country Is Required" ForeColor="Red" ControlToValidate="CountryDropDownList" InitialValue="-1"></asp:RequiredFieldValidator>
                            </h4>
                            <h4>&nbsp Profile Picture:<asp:FileUpload ID="ProfilePictureFileUpload" runat="server" ToolTip="Gif, Png, Jpg, Jpeg &amp; Bmp are the only file types allowed." /></h4>
                            <br />
                            <asp:Label ID="InvalidFileTypeLabel" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="row">
                            <div class="col-md-6" style="text-align: center">
                                <asp:HyperLink ID="ReturnLink" runat="server" NavigateUrl="~/Login.aspx">Return to Login</asp:HyperLink>
                            </div>
                            <div class="col-md-6" style="text-align: center">
                                <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
                            </div>
                        </div>
                        <div class="row">
                            <h4>
                                <asp:Label ID="ConfirmLabel" runat="server" Text=""></asp:Label></h4>
                        </div>
                        <div class="row">
                            <asp:Button ID="ContinueButton" runat="server" Text="Continue to Site" PostBackUrl="~/Home.aspx" />
                        </div>
                    </div>
                    <div class="col-md-3">
                    </div>
                </div>
            </div>
        </div>
    </form>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="js/myJavaScript.js"></script>
</body>
</html>
