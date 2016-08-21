<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateProfile.aspx.vb" Inherits="EADD_Final_Project.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><strong>Update Profile</strong></h3>
        </div>
        <div>
            <br />
            First Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Date of Birth: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            Gender:
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" >
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            Country: 
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Enabled="False" Selected="True">Select Country</asp:ListItem>
                <asp:ListItem>Trinidad &amp; Tobago</asp:ListItem>
                <asp:ListItem>United States</asp:ListItem>
                <asp:ListItem>England</asp:ListItem>
                <asp:ListItem>Jamaica</asp:ListItem>
                <asp:ListItem>Russia</asp:ListItem>
                <asp:ListItem>Barbados</asp:ListItem>
                <asp:ListItem>Mexico</asp:ListItem>
                <asp:ListItem>Greenland</asp:ListItem>
                <asp:ListItem>Japan</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Profile Picture:
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
        </div>
        <div>

        <asp:HyperLink ID="ReturnLink" runat="server" NavigateUrl="~/Login.aspx">Return to Login</asp:HyperLink>
        &nbsp;<asp:Button ID="Button1" runat="server" PostBackUrl="~/Home.aspx" Text="Submit" />

        </div>
    </form>
</body>
</html>
