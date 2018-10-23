<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainPage.Master" AutoEventWireup="true" Inherits="EITS_App.UnauthorizedAccess" Title="Untitled Page" Codebehind="UnauthorizedAccess.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat  ="Server">
    <h2 class="style2">Unauthorized Access</h2>
    <p class="style2">
        You have attempted to access a page that you are not authorized to view.
    </p>
    <p>
        <span class="style2">If you have any questions, please contact the site administrator.</span>
    </p>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style2
        {
            font-size: small;
            font-family: Tahoma;
        }
    </style>

</asp:Content>

