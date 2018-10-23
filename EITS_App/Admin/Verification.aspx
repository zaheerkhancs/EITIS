<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master" CodeBehind="Verification.aspx.cs" Inherits="ECC_App.Verification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="style2">
        Account Verification</h2>
    <p>
        <asp:Label ID="StatusMessage" runat="server" 
            style="font-size: small; font-family: Tahoma"></asp:Label>
    </p>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style2
        {
            font-family: Tahoma;
            font-size: small;
        }
    </style>

</asp:Content>
