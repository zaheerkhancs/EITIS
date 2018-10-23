<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainPage.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="EITS_App.NewUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
     <table style="font-size: small">
        <tr align="left">
            <td class="style2">
                Create New User</td>
        </tr>
        <tr align="left">
            <td>
                <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
                    ContinueDestinationPageUrl="~/Admin/ManageUsers.aspx"
                    FinishDestinationPageUrl="~/Admin/ManageUsers.aspx" LoginCreatedUser="False" 
                    OnCreatedUser="CreateUserWizard1_CreatedUser" 
                     Width="100%">
                    <WizardSteps>
                        <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                            <ContentTemplate>
                                <table cellpadding="2" width="100%">
                                    <tr>
                                        <td class="style3">
                                            Username:</td>
                                        <td class="style4">
                                            <asp:TextBox ID="UserName" runat="server" Width="200px" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="valRequireUserName" runat="server" 
                                                ControlToValidate="UserName" Display="Dynamic" 
                                                ErrorMessage="Username is required." SetFocusOnError="true" 
                                                ToolTip="Username is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style3">
                                            Password:</td>
                                        <td class="style4">
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="200px" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="valRequirePassword" runat="server" 
                                                ControlToValidate="Password" Display="Dynamic" 
                                                ErrorMessage="Password is required." SetFocusOnError="true" 
                                                ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style3">
                                            Confirm Password:</td>
                                        <td class="style4">
                                            <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" 
                                                Width="200px" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="valRequireConfirmPassword" runat="server" 
                                                ControlToValidate="ConfirmPassword" Display="Dynamic" 
                                                ErrorMessage="Confirm Password is required." SetFocusOnError="true" 
                                                ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style3">
                                            Full Name:</td>
                                        <td class="style4">
                                            <asp:TextBox ID="Question" runat="server" Width="200px" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="valRequireFullname" runat="server" 
                                                ControlToValidate="Answer" Display="Dynamic" 
                                                ErrorMessage="Fullname is required." SetFocusOnError="true" 
                                                ToolTip="Fullname is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style3">
                                            Email:</td>
                                        <td class="style4">
                                            <asp:TextBox ID="Email" runat="server" Width="200px" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="valRequireEmail" runat="server" 
                                                ControlToValidate="Email" Display="Dynamic" ErrorMessage="E-mail is required." 
                                                SetFocusOnError="true" ToolTip="E-mail is required." 
                                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="valEmailPattern" runat="server" 
                                                ControlToValidate="Email" Display="Dynamic" 
                                                ErrorMessage="The e-mail address you specified is not well-formed." 
                                                SetFocusOnError="true" 
                                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                ValidationGroup="CreateUserWizard1">*</asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style3">
                                            Position:</td>
                                        <td class="style4">
                                            <asp:TextBox ID="Answer" runat="server" Width="200px" />
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="valRequireUserName0" runat="server" 
                                                ControlToValidate="Question" Display="Dynamic" SetFocusOnError="true" 
                                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style3">
                                            Role:</td>
                                        <td class="style4">
                                            <asp:RadioButtonList ID="rdRole" runat="server">
                                                <asp:ListItem Value="User">User</asp:ListItem>
                                                <asp:ListItem Value="Admin">Admin</asp:ListItem>
                                                <asp:ListItem Value="SuperUser">Super User</asp:ListItem>
                                                <asp:ListItem>Employee</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="3" style="text-align: right;" class="style5">
                                            <b>
                                            <asp:Label ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Label>
                                            </b>
                                        </td>
                                    </tr>
                                </table>
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                    ShowMessageBox="True" ShowSummary="False" ValidationGroup="CreateUserWizard1" />
                            </ContentTemplate>
                        </asp:CreateUserWizardStep>
                        <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                            <ContentTemplate>
                                <table border="0">
                                    <tr>
                                        <td>
                                            The user account has been successfully created.</td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="2">
                                            <asp:Button ID="ContinueButton" runat="server" CausesValidation="False" 
                                                CommandName="Continue" 
                                                PostBackUrl="~/Admin/ManageUsers.aspx" Text="Finish" 
                                                ValidationGroup="CreateUserWizard1" />
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:CompleteWizardStep>
                    </WizardSteps>
                </asp:CreateUserWizard>
            </td>
        </tr>
        <tr align="left">
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


<asp:Content ID="Content3" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style2
        {
            font-size: small;
            font-weight: bold;
            text-align: center;
        }
        .style3
        {
            width: 248px;
            font-weight: bold;
            text-align: right;
            color: #FFFFFF;
            background-color: #3471A8;
        }
        .style4
        {
            width: 349px;
        }
        .style5
        {
            color: #000000;
            background-color: #FFFFFF;
        }
    </style>

</asp:Content>



