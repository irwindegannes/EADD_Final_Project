<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegisterUser.aspx.vb" Inherits="EADD_Final_Project.RegisterUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--Page Info--%>
        <div>
            <h3><strong>Register New User - Step 1 of 2</strong></h3>
            <br />    
        </div>
        
        <%--Control to create new user--%>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CancelDestinationPageUrl="~/Login.aspx" ContinueDestinationPageUrl="~/UpdateProfile.aspx">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
        <asp:HyperLink ID="ReturnLink" runat="server" NavigateUrl="~/Login.aspx">Return to Login</asp:HyperLink>
        <br />
    
    </div>
    </form>
</body>
</html>
