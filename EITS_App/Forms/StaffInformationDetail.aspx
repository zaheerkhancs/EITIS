<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainPage.Master" AutoEventWireup="true" CodeBehind="StaffInformationDetail.aspx.cs" Inherits="EITS_App.Forms.StaffInformationDetail"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            text-align: left;
            font-size:small;
        }
        .style2
        {            margin-left: 40px;
           
        }
        .style3
        {
            font-weight: bold;
        }
        .style6
        {
            font-weight: normal;
        }
        .style7
        {
            margin-left: 40px;
            font-weight: bold;
        }
        .style8
        {
            width: 100%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td>
                <h2 style="text-align: center">
                    View Staff Information</h2>
            </td>
        </tr>
</table>
                <table class="style1">
                    <tr>
                        <td class="style2">
                            Staff ID:</td>
                        <td class="style3">
                            <asp:Label ID="lblStaffId" runat="server"></asp:Label>
                        </td>
                        <td>
                            Agency:</td>
                        <td>
                            <asp:Label ID="lblAgency" runat="server" style="font-weight: 700"></asp:Label>
                                                    </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            ID No:</td>
                        <td class="style3">
                            <asp:Label ID="lblId_no" runat="server"></asp:Label>
                        </td>
                        <td>
                            Department:</td>
                        <td>
                            <asp:Label ID="lblDepartment" runat="server" style="font-weight: 700"></asp:Label>
                                                    </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Name:</td>
                        <td class="style3">
                            <asp:Label ID="lblName" runat="server"></asp:Label>
                        </td>
                        <td>
                            Contact No. Kabul:</td>
                        <td>
                            <b>
                            <asp:Label ID="lblContact1" runat="server"></asp:Label>
                            </b></td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Home Address 1:</td>
                        <td class="style3">
                            <asp:Label ID="lblHome1" runat="server"></asp:Label>
                            </td>
                        <td>
                            Contact No. Personal:</td>
                        <td>
                            <b>
                            <asp:Label ID="lblContact2" runat="server"></asp:Label>
                            </b></td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Home Address 2:</td>
                        <td class="style3">
                            <asp:Label ID="lblHome2" runat="server"></asp:Label>
                            </td>
                        <td>
                            Email:</td>
                        <td>
                            <b>
                            <asp:Label ID="lblEmail" runat="server"></asp:Label>
                            </b></td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Country:</td>
                        <td>
                            <b>
                            <asp:Label ID="lblCountry" runat="server"></asp:Label>
                            </b></td>
                        <td>
                            Email Personal:</td>
                        <td>
                            <b>
                            <asp:Label ID="lblEmailPersonal" runat="server"></asp:Label>
                            </b></td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3" colspan="4">
                            Contract Information</td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
    <asp:UpdatePanel ID="UpdatePanelContract" runat="server" >
    <ContentTemplate>
   
    
                      
                
                 

        
                  
     
    </table>   
       </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
