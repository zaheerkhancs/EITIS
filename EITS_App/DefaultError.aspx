<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="DefaultError.aspx.cs" Inherits="EITS_App.DefaultError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%">
        <tr>
            <td width="100%" >
                <h2>
                    Server Error</h2>
            </td>
        </tr>
        <tr>
            <td width="100%" >
                &nbsp;</td>
        </tr>
        <tr>
            <td width="100%" >
                <asp:Label ID="lblmsg" runat="server" Font-Bold="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td width="100%" >
                &nbsp;</td>
        </tr>
        <tr>
            <td width="100%" >
                Please contact the server administrator.</td>
        </tr>
    </table>
</asp:Content>

