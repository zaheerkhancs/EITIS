﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master"
    CodeBehind="ContractStatus.aspx.cs" Inherits="EITS_App.Lookups.lkpContractStatus" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="btnHidden" runat="Server" Style="display: none" />
            <cc1:ModalPopupExtender ID="mpePanel" runat="server" TargetControlID="btnHidden"
                PopupControlID="pnlPopup" CancelControlID="imgCancel" BackgroundCssClass="modalBackground"
                PopupDragHandleControlID="Caption" Drag="true">
            </cc1:ModalPopupExtender>
            <table style="width: 100%;" width="100%">
                <tr>
                    <td class="style2">
                        <asp:Panel ID="pnlPopup" runat="server" CssClass="modalBox" Style="display: none;"
                            Width="500px">
                            <asp:Panel ID="pnlManage" runat="server" CssClass="caption" Style="margin-bottom: 10px;
                                cursor: hand;">
                                Contract Status</asp:Panel>
                            <asp:HiddenField ID="hidEditIndex" runat="server" Value="-1" />
                            <div class="divCol">
                                Contract Status_ID:</div>
                            <div class="divColLast">
                                <asp:TextBox ID="txtContractStatusID" runat="server" MaxLength="64" Width="250" Enabled="False"
                                    ReadOnly="True"></asp:TextBox>
                            </div>
                            <div class="clearer">
                            </div>
                            <div class="divCol">
                                Status Name:
                            </div>
                            <div class="divColLast">
                                <asp:TextBox ID="txtStatusName" runat="server" MaxLength="64" Width="250"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=""
                                    Text='<img src="../images/Message_Warning.png">' ControlToValidate="txtStatusName"></asp:RequiredFieldValidator>
                            </div>
                            <div class="clearer">
                            </div>
                            <div class="clearer">
                            </div>
                            <div class="divCol">
                                Active:</div>
                            <div class="divColLast">
                                <asp:CheckBox ID="chkActive" runat="server" Enabled="false" Checked="true" />
                            </div>
                            <div class="clearer">
                            </div>
                            <div class="clearer">
                            </div>
                            <div style="white-space: nowrap; text-align: center;">
                                <asp:ImageButton ID="imgSave" runat="server" CausesValidation="true" ImageUrl="~/images/save.gif"
                                    OnClick="imgSave_Click" />
                                <asp:ImageButton ID="imgCancel" runat="server" CausesValidation="false" ImageUrl="~/images/cncl2.gif" />
                            </div>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Contract Status
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <table style="width: 577px" align="center">
                            <tr>
                                <td>
                                    <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" Font-Names="Tahoma"
                                        Font-Size="Small" Width="100%" Style="font-size: small; font-family: Verdana">
                                        <Columns>
                                            <asp:BoundField DataField="ContractStatus_ID" HeaderText="Contract Status ID" ItemStyle-Width="300px">
                                                <ItemStyle Width="300px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Status_Name" HeaderText="Status Name" ItemStyle-Width="180px">
                                                <ItemStyle Width="200px" />
                                            </asp:BoundField>
                                            <asp:CheckBoxField DataField="Active" HeaderText="Active" Visible="False" />
                                            <asp:TemplateField ItemStyle-Width="10px">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgEdit" runat="server" CausesValidation="False" ImageUrl="~/images/edt.gif"
                                                        CommandArgument='<%# Eval("ContractStatus_ID") %>' OnCommand="imgEdit_Command" />
                                                </ItemTemplate>
                                                <ItemStyle Width="10px" />
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/images/del.gif" CausesValidation="False"
                                                        CommandArgument='<%# Eval("ContractStatus_ID") %>' OnCommand="imgDelete_Command" />
                                                    <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Are you sure you want to Delete ?"
                                                        TargetControlID="imgDelete">
                                                    </cc1:ConfirmButtonExtender>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <AlternatingRowStyle CssClass="even" />
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:ImageButton ID="imgAdd" runat="server" ImageUrl="~/images/add.gif" OnClick="imgAdd_Click"
                            CausesValidation="false" />
                        &nbsp;
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .style2
        {
            text-align: left;
        }
        .style3
        {
            text-align: center;
            font-weight: bold;
            font-size: small;
        }
        .clearer
        {
            width: 497px;
        }
    </style>
</asp:Content>
