<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateProfile.aspx.vb" Inherits="EADD_Final_Project.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--Page Info--%>
        <div class="container-fluid">
            <h3><strong>Update User Profile - Step 2 of 2</strong></h3>
        </div>
        <div class="container-fluid">
            <br />
            First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ErrorMessage="First Name Is Required" ForeColor="Red" ControlToValidate="FirstNameTextBox"></asp:RequiredFieldValidator>
            <br />
            <br />
            Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ErrorMessage="Last Name Is Required" ForeColor="Red" ControlToValidate="LastNameTextBox"></asp:RequiredFieldValidator>
            
            <br />
            <br />
            Country:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="CountryDropDownList" runat="server">
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
            </asp:DropDownList>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidatorCountry" runat="server" ErrorMessage="Country Is Required" ForeColor="Red" ControlToValidate="CountryDropDownList" InitialValue="-1"></asp:RequiredFieldValidator>
            <br />
            <br />
            Profile Picture:&nbsp; <asp:FileUpload ID="ProfilePictureFileUpload" runat="server" ToolTip="Gif, Png, Jpg, Jpeg &amp; Bmp are the only file types allowed." />
            &nbsp;
            <asp:Label ID="InvalidFileTypeLabel" runat="server" Text=""></asp:Label>
            <br />
            <br />
        </div>
        <div class="container-fluid">
            <asp:HyperLink ID="ReturnLink" runat="server" NavigateUrl="~/Login.aspx">Return to Login</asp:HyperLink>
            &nbsp;&nbsp;&nbsp; <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
        &nbsp;&nbsp;
            <asp:Label ID="ConfirmLabel" runat="server" Text=""></asp:Label>
            <br />
            <br />
        </div>
        <div class="container-fluid">
            <asp:Button ID="ContinueButton" runat="server" Text="Continue to Site" PostBackUrl="~/Home.aspx" />
        </div>
    </form>
</body>
</html>
