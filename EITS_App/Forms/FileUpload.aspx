<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainPage.Master" AutoEventWireup="true"
    CodeBehind="FileUpload.aspx.cs" Inherits="EITS_App.Forms.FileUpload" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
   
            <div>
                <asp:Panel ID="pnlPerson" runat="server">
                    <asp:Panel ID="PersonCaption" runat="server" CssClass="caption" Style="margin-bottom: 10px;
                        cursor: hand;">
                        Attach Files</asp:Panel>
                    <table style="width: 100%;" width="100%">
                        <tr>
                            <td align="right" class="style1">
                            </td>
                            <td align="left" class="style1">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td align="left" class="style1">
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style1">
                                &nbsp; Select File to Upload:
                            </td>
                            <td align="left" class="style4">
                                <asp:FileUpload ID="f_load" runat="server" BorderStyle="Solid" 
                                    BorderWidth="1px" Width="237px" />
                            </td>
                            <td align="left">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" align="right">
                                Staff Member:
                            </td>
                            <td class="style2" align="left">
                                <asp:DropDownList ID="ddlStaffmember" runat="server" Width="160px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                &nbsp;
                            </td>
                            <td align="left" class="style2">
                                <asp:Button ID="btnAdd" runat="server" CausesValidation="true"
                                    Text="Upload" Width="94px" onclick="btnAdd_Click" />
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" colspan="3" align="left">
                                <asp:GridView ID="_gvList" runat="server" AutoGenerateColumns="False" 
                                    Width="100%">
                                    <Columns>
                                    <asp:TemplateField>
                                    <ItemTemplate >
                                    <%#((GridViewRow )Container).DataItemIndex +1+"." %>
                                    </ItemTemplate>
                                        <ItemStyle Width="10px" />
                                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="File Type">
                                            <ItemTemplate>
                                                <img alt="" src='<%# DataBinder.Eval(Container.DataItem,"FileIcon") %>' />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="20px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="StaffId" Visible="False">
                                            <ItemTemplate>
                                                <asp:Label ID="lblStaffId" runat="server" Text='<%# Bind("staffId") %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="20px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="File Path">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("FilePath") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lblPath" runat="server" 
                                                    CommandArgument='<%# Eval("FilePath") %>' oncommand="lblPath_Command" 
                                                    Text='<%# Eval("FilePath") %>'></asp:LinkButton>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Left" Width="200px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Uploading Time">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("TimeUpload") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("TimeUpload") %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="60px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Upload Date">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("DateUpload") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("DateUpload") %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="60px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="File Size">
                                            <ItemTemplate>
                                                <asp:Label ID="lblsize" runat="server" Text='<%# Bind("filesize") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="50px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Delete">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="imgDelete" runat="server"
                                                    ImageUrl="~/images/del.gif" CommandArgument='<%# Bind("FilePath") %>' 
                                                    oncommand="imgDelete_Command" />
                                                    <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Are you sure you want to Delete ?"
                                                        TargetControlID="imgDelete">
                                                    </cc1:ConfirmButtonExtender>
                                            </ItemTemplate>
                                            <ItemStyle Width="40px" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <AlternatingRowStyle CssClass="even" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                    <div style="white-space: nowrap; text-align: center;">
                        <asp:Button ID="btnSavePerson" runat="server" Text="Save"
                            CausesValidation="true" Width="61px" onclick="btnSavePerson_Click" />
                        <asp:Button ID="btnCancelPerson" runat="server" CausesValidation="false" Text="Cancel" />
                    </div>
                </asp:Panel>
            </div>
</asp:Content>
