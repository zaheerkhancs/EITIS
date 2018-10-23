<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainPage.Master" AutoEventWireup="true" CodeBehind="PaymentInfo.aspx.cs" Inherits="EITS_App.Forms.PaymentInfo"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            font-size: small;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td>
                <h1>
                    Staff Payment Information</h1>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="PanelSearch" runat="server" 
                    GroupingText="Search for Staff Record" style="font-size: small">
                    <span class="style3">Last Name:</span>
                    <asp:TextBox ID="txtSearchLastName" runat="server" MaxLength="64" Width="200px"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnSearch" runat="server" CausesValidation="False" 
                        onclick="btnSearch_Click" Text="Search" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
               <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" Font-Names="Tahoma" 
                        Font-Size="Small" Width="100%" 
                    style="font-size: small; font-family: Verdana" GridLines="None">
                        <Columns>
                            <asp:BoundField DataField="StaffId" HeaderText="Staff ID" 
                                ItemStyle-Width="180px">
                                <ItemStyle Width="50px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="LastName" HeaderText="Last Name" 
                                ItemStyle-Width ="300px" >
                                <ItemStyle Width="150px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="FirstName" HeaderText="First Name" >
                        
                                <ItemStyle Width="150px" />
                            </asp:BoundField>
                        
                            <asp:BoundField DataField="BirthDate" DataFormatString="{0:MM-dd-yyyy}" 
                                HeaderText="Date of Birth">
                                <ItemStyle Width="150px" />
                            </asp:BoundField>
                        
                            <asp:BoundField DataField="Email" HeaderText="Email" >
                                <ItemStyle Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Country_ID" HeaderText="Country" />
                            <asp:TemplateField ItemStyle-Width="10px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgView" runat="server" OnCommand="imgView_Command" CommandArgument='<%# Eval("StaffId") %>' 
                                        ImageUrl="~/images/view.gif" CausesValidation="False" />
                                </ItemTemplate>
                                <ItemStyle Width="10px" />
                            </asp:TemplateField>
                        
                        </Columns>
                        <EmptyDataTemplate>
                            There is no staff information recorded.
                        </EmptyDataTemplate>
                        <AlternatingRowStyle CssClass="even" />
                    </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
