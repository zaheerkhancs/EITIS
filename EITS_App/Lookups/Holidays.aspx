<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainPage.Master"
    CodeBehind="Holidays.aspx.cs" Inherits="EITS_App.tblHolidays" %>

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
                                Holidays</asp:Panel>
                            <asp:HiddenField ID="hidEditIndex" runat="server" Value="-1" />
                            <div class="divCol">
                                Holiday ID:</div>
                            <div class="divColLast">
                                <asp:TextBox ID="txtHoliday_ID" runat="server" MaxLength="64" Width="250" Enabled="False"></asp:TextBox>
                            </div>
                            <div class="clearer">
                            </div>
                            <div class="divCol">
                                Holiday Name:</div>
                            <div class="divColLast">
                                <asp:TextBox ID="txtHolidayName" runat="server" MaxLength="64" Width="250"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv" runat="server" ErrorMessage="" Text='<img src="../images/Message_Warning.png">' ControlToValidate="txtHolidayName"></asp:RequiredFieldValidator>
                            </div>
                            <div class="clearer">
                            </div>
                            <div class="divCol">
                                Holiday Date:</div>
                            <div class="divColLast">
                                <asp:TextBox ID="txtHDate" runat="server" MaxLength="64" Width="250"></asp:TextBox>
                                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtHDate">
                                </cc1:CalendarExtender>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=""
                                    Text='<img src="../images/Message_Warning.png">' ControlToValidate="txtHDate"></asp:RequiredFieldValidator>
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
                        Holidays
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <table style="width: 488px" align="center">
                            <tr>
                                <td colspan="3">
                                    <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" Font-Names="Tahoma"
                                        Font-Size="Small" Width="100%" Style="font-size: small; font-family: Verdana">
                                        <Columns>
                                            <asp:BoundField DataField="HolidayID" HeaderText="Holiday ID" ItemStyle-Width="180px">
                                                <ItemStyle Width="180px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="HolidayName" HeaderText="Holiday Name" ItemStyle-Width="300px">
                                                <ItemStyle Width="300px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Date" HeaderText="Holiday Date" ItemStyle-Width="300px"
                                                DataFormatString="{0:d}">
                                                <ItemStyle Width="300px" />
                                            </asp:BoundField>
                                            <asp:CheckBoxField DataField="Active" HeaderText="Active" Visible="False" />
                                            <asp:TemplateField ItemStyle-Width="10px">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgEdit" runat="server" CausesValidation="False" CommandArgument='<%# Eval("HolidayID") %>'
                                                        ImageUrl="~/images/edt.gif" OnCommand="imgEdit_Command" />
                                                </ItemTemplate>
                                                <ItemStyle Width="10px" />
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgDelete" runat="server" CommandArgument='<%# Eval("HolidayiD") %>'
                                                        ImageUrl="~/images/del.gif" OnCommand="imgDelete_Command" CausesValidation="False" />
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
