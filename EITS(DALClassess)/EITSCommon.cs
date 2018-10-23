using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
using System.IO;
using System.Xml;
using System.Text;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections;
//using System.Data.SqlClient ;


namespace IOM.EITS.DAL
{
    

    /// <summary>
    /// Summary description for Common.
    /// </summary>

    public class EITSCommon
    {
        
        #region Declarations

        public static string[] strArray = new string[50];
        public static string BRK = "";
        public static Message objCached = new Message();
        //public static string xmlMsgFilePath = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath.Replace("/", "\\") + "\\" + System.Configuration.ConfigurationManager.AppSettings.Get("XMLCommonMsgFilePath"));
        public static string xmlMsgFilePath = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath.Replace("/", "\\") + "\\" + System.Configuration.ConfigurationSettings.AppSettings.Get("XMLCommonMsgFilePath"));

        //         SqlConnectionStringBuilder csb;
        //string stDatabaseUser, stDatabasePass;


        //public string DatabasePassword
        //{
        //    get { return stDatabasePass; }
        //    //set { stDatabasePass = value; }
        //}

        //public string DatabaseUserName
        //{
        //    get { return stDatabaseUser; }
        //    //set { stDatabaseUser = value; }
        //}


        #endregion

        #region Enums

        public enum Role : int
        {
            Admin = 1,
            SuperUser = 2,
            NormalUser = 3
        };

        #endregion

        #region DropDown Fill Up Functions
        public static void FillCombo(ref DropDownList DropDown, System.Data.DataTable dt, string DataTextField, string DataValueField, bool AddBlankRow, int SelectedItemValue, string SortExpressionFieldName, string SelectedItemText, string BlankRowText)
        {
            FillCombo(ref DropDown, dt, DataTextField, DataValueField, AddBlankRow, SelectedItemValue, SortExpressionFieldName, SelectedItemText, BlankRowText, "0");
        }

        public static void FillCombo(ref DropDownList DropDown, System.Data.DataTable dt, string DataTextField, string DataValueField, bool AddBlankRow, int SelectedItemValue, string SortExpressionFieldName, string SelectedItemText)
        {
            FillCombo(ref DropDown, dt, DataTextField, DataValueField, AddBlankRow, SelectedItemValue, SortExpressionFieldName, SelectedItemText, "", "0");
        }

        public static void FillCombo(ref DropDownList DropDown, System.Data.DataTable dt, string DataTextField, string DataValueField, bool AddBlankRow, int SelectedItemValue, string SortExpressionFieldName)
        {
            FillCombo(ref DropDown, dt, DataTextField, DataValueField, AddBlankRow, SelectedItemValue, SortExpressionFieldName, "", "", "0");
        }

        public static void FillCombo(ref DropDownList DropDown, System.Data.DataTable dt, string DataTextField, string DataValueField, bool AddBlankRow, int SelectedItemValue)
        {
            FillCombo(ref DropDown, dt, DataTextField, DataValueField, AddBlankRow, SelectedItemValue, "", "", "", "0");
        }

        public static void FillCombo(ref DropDownList DropDown, System.Data.DataTable dt, string DataTextField, string DataValueField, bool AddBlankRow)
        {
            FillCombo(ref DropDown, dt, DataTextField, DataValueField, AddBlankRow, 0, "", "", "", "0");
        }

        public static void FillCombo(ref DropDownList DropDown, System.Data.DataTable dt, string DataTextField, string DataValueField)
        {
            FillCombo(ref DropDown, dt, DataTextField, DataValueField, false, 0, "", "", "", "0");
        }

        //INSTANT C# NOTE: C# does not support optional parameters. Overloaded method(s) are created above.
        //ORIGINAL LINE: Public Sub FillCombo(ByRef DropDown As DropDownList, ByVal ds As Object, ByVal Dat
        public static void FillCombo(ref DropDownList DropDown, System.Data.DataTable dt, string DataTextField, string DataValueField, bool AddBlankRow, int SelectedItemValue, string SortExpressionFieldName, string SelectedItemText, string BlankRowText, string BlankRowValue)
        {

            if (DropDown != null)
            {
                if (dt != null)
                {
                    DropDown.Items.Clear();
                    //'adding --please select---row if required

                    if (dt.Rows.Count > 0)
                    {
                        DropDown.DataTextField = DataTextField;
                        DropDown.DataValueField = DataValueField;
                        DropDown.DataSource = dt;
                        DropDown.DataBind();
                    }

                    //if() //(((System.Collections.Generic.List<clsClientMSTProperty>)ds).Count > 0)

                    if (AddBlankRow == true)
                    {
                        //'DropDown.Items.Insert(0, New ListItem("--Please Select--", ""))
                        if (BlankRowText == "")
                        {
                            if (BlankRowValue == "")
                            {
                                DropDown.Items.Insert(0, new ListItem("--Please Select--", ""));
                            }
                            else
                            {
                                DropDown.Items.Insert(0, new ListItem("--Please Select--", BlankRowValue));
                            }

                        }
                        else
                        {
                            DropDown.Items.Insert(0, new ListItem(BlankRowText, ""));
                        }
                    }
                    //'showing particular value as selected
                    if (SelectedItemValue != 0)
                    {
                        DropDown.Items.FindByValue(Convert.ToString(SelectedItemValue)).Selected = true; //.Items.FindByValue(SelectedItemValue).Selected = true;

                    }
                    if (SelectedItemText != "")
                    {
                        DropDown.Items.FindByText(SelectedItemText).Selected = true;
                    }
                }
            }

        }

        #endregion

        #region Encrypt Decrypt Functions
        public static string EncryptQueryString(string strInput)
        {
            string tempEncryptQueryString = null;
            if (strInput.Trim() != "")
            {
                strInput = Encrypt(strInput.Trim());
                tempEncryptQueryString = HttpContext.Current.Server.UrlEncode(strInput);
            }
            else
            {
                tempEncryptQueryString = strInput.Trim();
            }
            return tempEncryptQueryString;
        }
        public static string DecryptQueryString(string strInput)
        {
            string tempDecryptQueryString = null;
            if (strInput.Trim() != "")
            {
                //strInput = HttpContext.Current.Server.UrlDecode(strInput.Trim());
                tempDecryptQueryString = Decrypt(strInput);
            }
            else
            {
                tempDecryptQueryString = strInput.Trim();
            }
            return tempDecryptQueryString;
        }
        //Function to Encrypt the string
        public static string Encrypt(string strText)
        {
            byte[] byKey = null;
            byte[] IV = { 0X12, 0X34, 0X56, 0X78, 0X90, 0XAB, 0XCD, 0XEF };

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(((string)("&%#@?,:*")).Substring(0, 8));

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        //Function to Decrypt the string
        public static string Decrypt(string strText)
        {
            byte[] byKey = null;
            byte[] IV = { 0X12, 0X34, 0X56, 0X78, 0X90, 0XAB, 0XCD, 0XEF };
            byte[] inputByteArray = new byte[strText.Length + 1];

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(((string)("&%#@?,:*")).Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;

                return encoding.GetString(ms.ToArray());

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region Paging Sorting Function

        public static void CustomPaging(ref GridView objDataGrid, System.Web.UI.WebControls.GridViewPageEventArgs e, System.Data.DataTable dt)
        {
            if (objDataGrid != null)
            {
                if (dt != null)
                {
                    DataView dv = new DataView(dt);
                    dv.Sort = objDataGrid.Attributes["SortExpression"];
                    if (objDataGrid.Attributes["SortASC"] == "No")
                    {
                        dv.Sort += " DESC";
                    }

                    objDataGrid.PageIndex = e.NewPageIndex;
                    objDataGrid.DataSource = dv;
                    objDataGrid.DataBind();

                    //						if (objDataGrid.CurrentPageIndex == objDataGrid.PageCount - 1 & (dt.Rows.Count/ objDataGrid.PageSize) <= objDataGrid.CurrentPageIndex)
                    //						{
                    //							objDataGrid.CurrentPageIndex = objDataGrid.CurrentPageIndex - 1;
                    //						}
                }
            }
        }
        public static void CustomSorting(ref GridView objDataGrid, System.Web.UI.WebControls.GridViewSortEventArgs e, System.Data.DataTable dt)
        {
            if (objDataGrid != null)
            {
                if (dt != null)
                {

                    //DataGrid dgActivityStatus = ((System.Web.UI.WebControls.DataGrid)source);

                    object strSort = objDataGrid.Attributes["SortExpression"];
                    object strASC = objDataGrid.Attributes["SortASC"];

                    objDataGrid.Attributes["SortExpression"] = e.SortExpression;
                    objDataGrid.Attributes["SortASC"] = "Yes";
                    if (Convert.ToString(e.SortExpression) == Convert.ToString(strSort))
                    {
                        if (Convert.ToString(strASC) == "Yes")
                        {
                            objDataGrid.Attributes["SortASC"] = "No";
                        }
                        else
                        {
                            objDataGrid.Attributes["SortASC"] = "Yes";
                        }
                    }

                    DataView dv = dt.DefaultView;
                    dv.Sort = objDataGrid.Attributes["SortExpression"];
                    if (objDataGrid.Attributes["SortASC"] == "No")
                    {
                        dv.Sort = dv.Sort + " " + "DESC";
                    }


                    objDataGrid.DataSource = dv;
                    objDataGrid.DataBind();
                }
            }
        }



        #endregion

        #region Recent Log
        public enum RecentLogType : int
        {

            tblComplain = 0,
            lkpAllegationtype = 1,
            lkpCandidate = 2,
            lkpComplainanttype = 3,
            lkpRespondanttype = 4,
            lkpResponsibleOffice = 5,
            lkpStatus= 6,
            BulkUpload=7
        };

        public static RecentLogType getRecentLogType(int nItem)
        {

            switch (nItem)
            {
                case 0:
                    return RecentLogType.tblComplain ;
                case 1:
                    return RecentLogType.lkpAllegationtype;
                case 2:
                    return RecentLogType.lkpCandidate;
                case 3:
                    return RecentLogType.lkpComplainanttype;
                case 4:
                    return RecentLogType.lkpRespondanttype;
                case 5:
                    return RecentLogType.lkpResponsibleOffice;
                case 6:
                    return RecentLogType.lkpStatus ;
                default:
                    return RecentLogType.BulkUpload ;

            }
        }
        #endregion

        #region Common Messages

        public enum Modes : int
        {
            SameRecord_AlreadyExists = -1,
            ErrorOccured = 0,
            Inserted_SuccessFully = 1,
            NoRecordExists = 2,
            Deleted_SuccessFully = 3,
            DeletedMultiple_SuccessFully = 4,
            Record_AlReady_Deleted = 5,
            Update_SameAlreadyExists = 6,
            LoginFailed = 7,
            PasswordRecovered = 8,
            NoUserExists = 9,
            ErrorOccured_ActionCancelled = 10,
            Search_NoCriteria = 11,
            FromDate_Greater_Todate = 12,
            Invalid_Date = 13,
            Updated_SuccessFully = 14,
            Password_Changed_Successfully = 15,
            Order_Moved_Successfully = 16,
            Order_Repeated_Successfully = 17,
            PathNotFound = 18,
            CannotDelete_ReferenceExists = 19,
            Cart_Empty = 20,
            Customer_Feedback = 21,
            Customer_Registration = 22,
            Order_Repeated_EmptyOrder = 23,
            Default_Error = 24
        };

        //INSTANT C# NOTE: C# does not support optional parameters. Overloaded method(s) are created above.
        //ORIGINAL LINE: Public Function GetMessage(ByVal mode As Modes, Optional ByRef lblMessage As Label = null) As String

        public static string GetMessage(Modes mode, ref Label lblMessage)
        {
            string strMessage = null;
            switch (mode)
            {
                case Modes.SameRecord_AlreadyExists:
                    strMessage = "Request was not executed as the same record already exists in the system.";
                    break;
                case Modes.ErrorOccured:
                    strMessage = "An error has occured.";
                    break;
                case Modes.Inserted_SuccessFully:
                    strMessage = "Record inserted successfully.";
                    break;
                case Modes.NoRecordExists:
                    strMessage = "No record(s) found.";
                    break;
                case Modes.Deleted_SuccessFully:
                    strMessage = "Record deleted successfully.";
                    break;
                case Modes.DeletedMultiple_SuccessFully:
                    strMessage = "Record(s) deleted successfully.";
                    break;
                case Modes.Record_AlReady_Deleted:
                    strMessage = "This record has already been deleted by another user.";
                    break;
                case Modes.Update_SameAlreadyExists:
                    strMessage = "Record cannot be modified as the same record already exists in the system.";
                    break;
                case Modes.LoginFailed:
                    strMessage = "Login failed.";
                    break;
                case Modes.PasswordRecovered:
                    strMessage = "Your password has been successfully sent to your e-mail address.";
                    break;
                case Modes.NoUserExists:
                    strMessage = "No such user exists.";
                    break;
                case Modes.ErrorOccured_ActionCancelled:
                    strMessage = "Could not complete the requested action, an error has occured.";
                    break;
                case Modes.Search_NoCriteria:
                    strMessage = "Please fill atleast one field for selected search category.";
                    break;
                case Modes.FromDate_Greater_Todate:
                    strMessage = "From Date cannot be greater than To Date.";
                    break;
                case Modes.Invalid_Date:
                    strMessage = "Invalid Date.";
                    break;
                case Modes.Updated_SuccessFully:
                    strMessage = "Record updated successfully.";
                    break;
                case Modes.Password_Changed_Successfully:
                    strMessage = "Password changed successfully.";
                    break;
                case Modes.Order_Moved_Successfully:
                    strMessage = "Order(s) moved successfully.";
                    break;
                case Modes.Order_Repeated_Successfully:
                    strMessage = "Order(s) successfully added to your shopping cart.";
                    break;
                case Modes.PathNotFound:
                    strMessage = "Path not found.";
                    break;
                case Modes.CannotDelete_ReferenceExists:
                    strMessage = "Cannot delete this record. Reference exists.";
                    break;
                case Modes.Customer_Feedback:
                    strMessage = "Thank you for giving your valuable feedback";
                    break;
                case Modes.Default_Error:
                    strMessage = "Due to some technical problem your request is not executed.";
                    break;
            }

            if (lblMessage != null)
            {
                lblMessage.Text = strMessage;
            }
            return strMessage;
        }


        public static void FillLookUp(ref Hashtable htLookUp, string strLookUp)
        {
            strArray = strLookUp.Split(',');
            for (int i = 0; i < strArray.Length; i++)
            {
                htLookUp.Add(strArray[i], strArray[i]);
            }

        }

        #endregion

        #region set lblMessage Function
        public static void SetlblMessage(string key, ref Label lblMsg)
        {
            if (key != null)
            {
                if (key == "Inserted_SuccessFully")
                { lblMsg.Text = objCached.Inserted_SuccessFully; }
                else if (key == "Updated_SuccessFully")
                { lblMsg.Text = objCached.Updated_SuccessFully; }
                else if (key == "Deleted_SuccessFully")
                { lblMsg.Text = objCached.Deleted_SuccessFully; }
                else if (key == "AddEditUser_AccesRights")
                { lblMsg.Text = objCached.AddEditUser_AccesRights; }
                else if (key == "Not_LoggedIn")
                { lblMsg.Text = objCached.Not_LoggedIn; }
            }
            else
            {
                lblMsg.Text = "";
            }
        }
        #endregion

        #region "Website Url"
        public static string getURL(string key)
        {
            if (key != "" || key != null)
            {
                if ((key.ToUpper().IndexOf("HTTP://") != -1) || (key.ToUpper().IndexOf("HTTPS://") != -1))
                {
                    return key;
                }
                else
                {
                    return ("http://" + key);
                }
            }
            else
            {
                return key;
            }
        }
        public static string GetNavigateURL(string Id, string sURL)
        {
            if (Id != null || Id != "")
            {
                return (sURL + EITSCommon.EncryptQueryString(Id));
            }
            else
            {
                return "#";
            }
        }
        #endregion

       
    }

}

