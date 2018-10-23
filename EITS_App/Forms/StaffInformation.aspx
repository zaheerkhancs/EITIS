<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainPage.Master" AutoEventWireup="true" CodeBehind="StaffInformation.aspx.cs" Inherits="EITS_App.Forms.StaffInformation"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: left;
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
                    Staff Information</h1>
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
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
        </tr>
        <tr>
            <td>
    <asp:UpdatePanel ID="UpdatePanelStaff" runat="server">
    <ContentTemplate>
    <asp:Button ID="btnHidden" runat="Server" Style="display: none" />
        <cc1:ModalPopupExtender ID="mpePanelStaff" runat="server" 
            TargetControlID="btnHidden" PopupControlID="pnlPopup" 
            CancelControlID="imgCancel" BackgroundCssClass="modalBackground" 
            PopupDragHandleControlID="Caption" Drag="true">
        </cc1:ModalPopupExtender>
        <table style="width: 100%;" width="100%">
            <tr>
                <td class="style2">
                    <asp:Panel ID="pnlPopup" runat="server" CssClass="modalBox" Style="display:none;" 
                        Width="494px" Height="404px">
				      <asp:Panel ID="pnlManage" runat="server" CssClass="caption" Style="margin-bottom: 10px; cursor: hand;">
                          Staff Information</asp:Panel>
				<asp:HiddenField ID="hidEditIndex" runat="server" Value="-1" />
				<div class="divCol">
					Staff ID:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_StaffId" runat="server" MaxLength="64" Width="250" 
                        Enabled="False" ></asp:TextBox>
				</div>
				
				<div class="clearer">
				</div>
                <div class="divCol">
					Last Name:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_LastName" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
					<asp:RequiredFieldValidator ID="rfv" runat="server" ErrorMessage="*" Text="*" 
                        ControlToValidate="txtCon_LastName"></asp:RequiredFieldValidator>
				</div>	
				<div class="clearer">
				</div>
                <div class="divCol">
					First Name:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_FirstName" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
				</div>
				<div class="clearer">
				</div>
                <div class="divCol">
					Middle Name:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_MiddleName" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
				</div>	
				<div class="clearer">
				</div>                <div class="divCol">
					        Date of Birth:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_BirthDate" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
				    <asp:RequiredFieldValidator ID="rfv0" runat="server" 
                        ControlToValidate="txtCon_BirthDate" ErrorMessage="*" Text="*"></asp:RequiredFieldValidator>
                    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="MM-dd-yyyy" 
                        TargetControlID="txtCon_BirthDate">
                    </cc1:CalendarExtender>
				</div>	
				<div class="clearer">
				</div>
                <div class="divCol">
					Home Address 1:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_Address1" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
				</div>	
				<div class="clearer">
				</div>
                <div class="divCol">
					Home Address 2:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_Address2" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
				</div>	
				<div class="clearer">
				</div>
				<div class="divCol">
					Country of Birth:</div>
				<div class="divColLast">
                    <asp:DropDownList ID="drpCountryId" runat="server">
                    </asp:DropDownList>
                   
				</div>	
				<div class="clearer">
				</div>
                <div class="divCol">
					Contact No. Kabul:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_ContactKabul" runat="server" MaxLength="64" 
                        Width="250" ></asp:TextBox>
				</div>	
				<div class="clearer">
				</div>
                <div class="divCol">
					Contact No. Personal:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_ContactPersonal" runat="server" MaxLength="64" 
                        Width="250" ></asp:TextBox>
				</div>	
				<div class="clearer">
				</div>
                <div class="divCol">
					Email:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_Email" runat="server" MaxLength="64" Width="250" ></asp:TextBox>
				</div>	
				<div class="clearer">
				</div>
                <div class="divCol">
					Email Personal:</div>
				<div class="divColLast">
					<asp:TextBox ID="txtCon_EmailPersonal" runat="server" MaxLength="64" 
                        Width="250" ></asp:TextBox>
				</div>						
				
							
				<div class="clearer">
				</div>
			
				
				
				<div class="clearer">
				</div>
				<div style="white-space: nowrap; text-align: center;">
                    <asp:ImageButton ID="imgSave" runat="server"  CausesValidation ="true" 
                        ImageUrl="~/images/save.gif" onclick="imgSave_Click"/>
                    <asp:ImageButton ID="imgCancel" runat="server" CausesValidation = "false" ImageUrl="~/images/cncl2.gif" />
				
				</div>
			</asp:Panel></td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                        <table align="center">
        <tr>
            <td colspan="3">
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
                        
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgEdit" runat="server" OnCommand ="imgEdit_Command" CommandArgument='<%# Eval("StaffId") %>' 
                                        ImageUrl="~/images/edt.gif" CausesValidation="False" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton ID="imgDelete" runat="server" OnCommand="imgDelete_Command" CommandArgument='<%# Eval("StaffId") %>' 
                                        ImageUrl="~/images/del.gif" CausesValidation="False" />
                                    <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" 
                                        ConfirmText="Are you sure you want to Delete ?" TargetControlID="imgDelete">
                                    </cc1:ConfirmButtonExtender>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                            There is no staff information recorded.
                        </EmptyDataTemplate>
                        <AlternatingRowStyle CssClass="even" />
                    </asp:GridView>
            </td>
        </tr>
                </table>
                </td>
            </tr>
        
            <tr>
                <td class="style2">
                    <asp:ImageButton ID="imgAdd" runat="server" ImageUrl="~/images/add.gif" 
                        onclick="imgAdd_Click" CausesValidation="false" />
                        &nbsp;</td>
            </tr>
        </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
