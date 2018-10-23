<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="ManageUsers.aspx.cs" Inherits="EITS_App.ManageUsers1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
     <table width="100%" >
        <tr align="left">
            <td>
                <h4>
                    Manage Users</h4>
            </td>
        </tr>
        <tr align="left">
            <td>
                <table width="100%" >
                    <tr align="left">
                        <td class="style4">
                            <span class="style3">Total Users:
                            <asp:Label ID="lblTotUsers" runat="server" Font-Bold="True"></asp:Label>
                            </span>
                            <br class="style3" />
                            <span class="style3">Users online now:
                            <asp:Label ID="lblOnlineUsers" runat="server" Font-Bold="True"></asp:Label>
                            </span>
                        </td>
                    </tr>
                    <tr align="left">
                        <td class="style4">
                            <span class="style3">Click one of the following link to display all users whose 
                            name begins with that letter: </span>
                            <br class="style3" />
                            <br class="style3" />
                            <span class="style3">
                            <asp:Repeater ID="rptAlphabet" runat="server" 
                                OnItemCommand="rptAlphabet_ItemCommand">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                        CommandArgument="<%# Container.DataItem %>" Text="<%# Container.DataItem %>"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:Repeater>
                            </span>
                            <br class="style3" />
                            <br class="style3" />
                            <span class="style3">Or use the control below to search by Username or Email:</span></td>
                    </tr>
                    <tr align="left">
                        <td>
                            <table width="100%">
                                <tr align="left">
                                    <td>
                                        <asp:DropDownList ID="ddlSearchTypes" runat="server">
                                            <asp:ListItem Selected="True" Text="UserName" />
                                            <asp:ListItem Text="E-mail" />
                                        </asp:DropDownList>
                                        contains
                                        <asp:TextBox ID="txtSearchText" runat="server" />
                                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" 
                                            Text="Search" />
                                    </td>
                                </tr>
                                <tr align="left">
                                    <td>
                                        <asp:GridView ID="gvwUsers" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="2" DataKeyNames="UserName" ForeColor="#333333" GridLines="None" 
                                            OnRowCreated="gvwUsers_RowCreated" onrowdeleting="gvwUsers_RowDeleting" 
                                            Width="100%" style="font-family: Tahoma; font-size: small">
                                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                            <Columns>
                                                <asp:BoundField DataField="UserName" HeaderStyle-HorizontalAlign="Left" 
                                                    HeaderText="UserName">
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:HyperLinkField DataNavigateUrlFields="Email" 
                                                    DataNavigateUrlFormatString="mailto:{0}" DataTextField="Email" 
                                                    HeaderStyle-HorizontalAlign="Left" HeaderText="E-mail">
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:HyperLinkField>
                                                <asp:BoundField DataField="CreationDate" 
                                                    DataFormatString="{0:dd-MMM-yy h:mm tt}" HeaderStyle-HorizontalAlign="Left" 
                                                    HeaderText="Created">
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="LastActivityDate" 
                                                    DataFormatString="{0:dd-MMM-yy h:mm tt}" HeaderStyle-HorizontalAlign="Left" 
                                                    HeaderText="Last activity">
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:CheckBoxField DataField="IsApproved" HeaderStyle-HorizontalAlign="Center" 
                                                    HeaderText="Active" ItemStyle-HorizontalAlign="Center" Visible="False">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:CheckBoxField>
                                                <asp:HyperLinkField DataNavigateUrlFields="UserName" 
                                                    DataNavigateUrlFormatString="EditUser.aspx?UserName={0}" HeaderText="Edit" 
                                                    ItemStyle-HorizontalAlign="Center" 
                                                    Text="&lt;img src='../images/edt.gif' border=0 /&gt;">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:HyperLinkField>
                                                <asp:ButtonField ButtonType="Image" CommandName="Delete" HeaderText="Delete" 
                                                    ImageUrl="~/images/del.gif" ItemStyle-HorizontalAlign="Center">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:ButtonField>
                                            </Columns>
                                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                            <EmptyDataTemplate>
                                                No record exists.
                                            </EmptyDataTemplate>
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr align="left">
                        <td>
                            <asp:HyperLink ID="lnkNewUser" runat="server" 
                                NavigateUrl="~/Admin/NewUser.aspx" 
                                style="font-weight: 700; font-size: small">New User</asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr align="left">
            <td>
                &nbsp;</td>
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
            text-align: center;
        }
        .style3
        {
            font-size: small;
        }
        .style4
        {
            text-align: center;
            font-family: Tahoma;
        }
    </style>

</asp:Content>
