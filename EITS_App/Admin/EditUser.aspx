<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="EditUser.aspx.cs" Inherits="EITS_App.EditUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="font-size: small">
        <tr align="left">
            <td>
                <h4>
                    Edit User</h4>
            </td>
        </tr>
        <tr align="left">
            <td>
                <table width="100%">
                    <tr>
                        <td class="style3">
                            Username:</td>
                        <td>
                            <table cellpadding="2">
                                <tr>
                                    <td>
                                        <asp:Literal ID="lblUserName" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Email:</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" Width="400px" />
                            <asp:RequiredFieldValidator ID="valRequireEmail" runat="server" 
                                ControlToValidate="txtEmail" Display="Dynamic" Text="*" 
                                ValidationGroup="User" />
                            <asp:RegularExpressionValidator ID="valRegExEmail" runat="server" 
                                ControlToValidate="txtEmail" Display="Dynamic" Text="Invalid email" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                ValidationGroup="User" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Full Name:</td>
                        <td>
                            <asp:TextBox ID="txtFullName" runat="server" Width="400px" />
                            <asp:RequiredFieldValidator ID="valReqireFullname" runat="server" 
                                ControlToValidate="txtFullName" Display="Dynamic" Text="*" 
                                ValidationGroup="User" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Created:
                        </td>
                        <td>
                            <asp:Literal ID="lblRegistered" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Last Login:</td>
                        <td>
                            <asp:Literal ID="lblLastLogin" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Last Activity:</td>
                        <td>
                            <asp:Literal ID="lblLastActivity" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Active:</td>
                        <td>
                            <asp:CheckBox ID="chkApproved" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
                                Text="Update" />
                            &nbsp;<asp:Label ID="lblUserFeedbackOK" runat="server" EnableViewState="false" 
                                SkinID="FeedbackOK" Text="User updated successfully" Visible="false" />
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style2
        {
            color: #FFFFFF;
        }
        .style3
        {
            color: #FFFFFF;
            font-weight: bold;
            text-align: right;
            background-color: #3471A8;
        }
    </style>

</asp:Content>


