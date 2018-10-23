<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile ="~/MasterPages/Login.Master" CodeBehind="Login.aspx.cs" Inherits="EITS_App.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 67px;
        }
        .style3
        {
            font-size: x-small;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table bgcolor="#D2D9C4" cellpadding="0" cellspacing="0" style="width: 400px; height: 152px">
        <tr>
            <td>
            </td>
            <td style="height: 18px">
            </td>
        </tr>
        <tr>
            <td style="height: 77px; width: 172px" valign="top">
                <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/Admin/About.aspx" Height="83px"
                    Width="377px" onloginerror="Login1_LoginError">
                    <LayoutTemplate>
                        <table border="0" cellpadding="1" cellspacing="0" 
                            style="border-collapse:collapse;">
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0" style="height:116px;width:372px;">
                                        <tr>
                                            <td align="center" class="style2">
                                                &nbsp;</td>
                                            <td align="center" colspan="2">
                                                Log In</td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style2" rowspan="2">
                                                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/login_icon.gif" />
                                            </td>
                                            <td align="right" class="style3">
                                                User Name:</td>
                                            <td>
                                                <asp:TextBox ID="UserName" runat="server" Width="200px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                    ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                                    ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style3">
                                                Password:</td>
                                            <td>
                                                <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                    ControlToValidate="Password" ErrorMessage="Password is required." 
                                                    ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" class="style2" style="color:Red;">
                                                &nbsp;</td>
                                            <td align="center" colspan="2" style="color:Red;">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style2">
                                                &nbsp;</td>
                                            <td align="right" colspan="2">
                                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" 
                                                    onclick="LoginButton_Click1" Text="Log In" ValidationGroup="Login1" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                </asp:Login>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>

