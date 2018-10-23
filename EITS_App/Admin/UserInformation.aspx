<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="UserInformation.aspx.cs" Inherits="EITS_App.UserInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1"  Runat="Server">
    <h2 class="style4">User Information</h2>
    <p>
        <asp:HyperLink ID="BackLink" runat="server" 
            NavigateUrl="~/Admin/ManageLocked.aspx">&lt;&lt; Back to User List</asp:HyperLink>
    </p>
    <table>
        <tr>
            <td class="style3">Username:</td>
            <td class="style2"><asp:Label runat="server" ID="UserNameLabel"></asp:Label></td>
        </tr>
        <tr>
            <td class="style3">Approved:</td>
            <td class="style2">
                <asp:CheckBox ID="IsApproved" runat="server" AutoPostBack="true" 
                    oncheckedchanged="IsApproved_CheckedChanged" />
            </td>
        </tr>
        <tr>
            <td class="style3">Locked Out:</td>
            <td>
                <span class="style2">
                <asp:Label runat="server" ID="LastLockoutDateLabel"></asp:Label>
                </span>
                <br class="style2" />
                <span class="style2">
                <asp:Button runat="server" ID="UnlockUserButton" Text="Unlock User" 
                    onclick="UnlockUserButton_Click" />
                </span>
            </td>
        </tr>
    </table>
    <p>
        <asp:Label ID="StatusMessage" CssClass="Important" runat="server"></asp:Label>
    </p>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style2
        {
            font-size: small;
        }
        .style3
        {
            font-size: small;
            font-weight: bold;
            font-family: Tahoma;
            text-align: right;
            color: #FFFFFF;
            background-color: #3471A8;
        }
        .style4
        {
            font-family: Tahoma;
            font-size: medium;
        }
    </style>

</asp:Content>


