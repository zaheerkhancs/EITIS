using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using IOM.EITS.DAL;

namespace EITS_App.Forms
{
    public partial class StaffInformation : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _ShowData();
                _FillCombo();

            }

        }

        private Guid UserId
        {
            get
            {
                if (Session["UserId"] != null) return (Guid)Session["UserId"];
                else return Guid.Empty;
            }
        }


        private void _FillCombo()
        {
            EITSDB _objDB = new EITSDB();

            try
            {
                DataTable dtCountryID = _objDB.lkpCountryCollection.GetAllAsDataTable();
                EITSCommon.FillCombo(ref drpCountryId, dtCountryID, "Country_Name", "Country_ID", true);

            }
            finally
            {
                _objDB.Dispose();
            }
        }
        

        public void _ShowData()
        {
            
            DataTable dt = _GetGridData();

            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    _gvList.Visible = false;
                }
                else
                {
                    _gvList.DataSource = dt;
                    _gvList.DataBind();
                    _gvList.Visible = true;
                }
            }
            else
            {
                _gvList.Visible = false;
            }



        }


        public DataTable _GetGridData()
        {
            EITSDB _objDB = new EITSDB();
            DataTable dt = new DataTable();

            try
            {
                dt = _objDB.tblStaffCollection.GetAsDataTable("isDeleted = 0", "LastName");
                _gvList.DataSource = dt;
                _gvList.DataBind();

            }
            finally
            {
                _objDB.Dispose();
            }
            return dt;


        }


        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            //logical update only. set IsDeleted to true
            EITSDB _objDB = new EITSDB();
            try
            {
                tblStaffRow _objRow = new tblStaffRow();
                _objRow = _objDB.tblStaffCollection.GetRow("StaffId=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");
                _objRow.IsDeleted = true;
                _objRow.Updated_By = UserId;
                _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                _objDB.tblStaffCollection.Update(_objRow);
                _ShowData();


            }
            finally
            {
                _objDB.Dispose();
            }

        }

        protected void imgView_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("StaffInformationDetail.aspx?StaffId=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");

        }

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                tblStaffRow _objRow = new tblStaffRow();
                _objRow = _objDB.tblStaffCollection.GetRow("StaffId=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");

                txtCon_StaffId.Text = e.CommandArgument.ToString();
                txtCon_LastName.Text = _objRow.LastName;
                txtCon_FirstName.Text = _objRow.FirstName;
                txtCon_MiddleName.Text = _objRow.MiddleName;
                txtCon_BirthDate.Text = _objRow.BirthDate.ToString();
                txtCon_Address1.Text = _objRow.HomeAddress1;
                txtCon_Address2.Text = _objRow.HomeAddress2;
                drpCountryId.SelectedValue = _objRow.Country_ID.ToString();
                txtCon_ContactKabul.Text = _objRow.Contact_Kabul;
                txtCon_ContactPersonal.Text = _objRow.Contact_Personal;
                txtCon_Email.Text = _objRow.Email;
                txtCon_EmailPersonal.Text = _objRow.Email_Personal;
                mpePanelStaff.Show();           

            }
            finally
            {
                _objDB.Dispose();
            }

        }

        public void _ResetTextBox()
        {
            txtCon_StaffId.Text = "";
            txtCon_LastName.Text = "";
            txtCon_FirstName.Text = "";
            txtCon_MiddleName.Text = "";
            txtCon_Address1.Text = "";
            txtCon_Address2.Text = "";
            txtCon_ContactKabul.Text = "";
            txtCon_ContactPersonal.Text = "";
            txtCon_Email.Text = "";
            txtCon_EmailPersonal.Text = "";
            txtCon_BirthDate.Text = "";

        }


        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {
            _ResetTextBox();
            mpePanelStaff.Show();
        }

        protected void imgSave_Click(object sender, ImageClickEventArgs e)
        {
            _SaveContract();
            mpePanelStaff.Hide();
            _ShowData();
        }



        public String _GetCurrentDate()
        {

            return DateTime.Now.ToString();
        }


        public void _SaveContract()
        {

            EITSDB _objDB = new EITSDB();


            try
            {
                tblStaffRow _objRow;

                //insert new record
                if (txtCon_StaffId.Text.Trim() == "")
                {
                    //assign the textboxes
                    _objRow = new tblStaffRow();                
                    _objRow.LastName = txtCon_LastName.Text.Trim();
                    _objRow.FirstName = txtCon_FirstName.Text.Trim();
                    _objRow.MiddleName = txtCon_MiddleName.Text.Trim();
                    _objRow.BirthDate = Convert.ToDateTime(txtCon_BirthDate.Text);
                    _objRow.HomeAddress1 = txtCon_Address1.Text.Trim();
                    _objRow.HomeAddress2 = txtCon_Address2.Text.Trim();
                    _objRow.Country_ID = Convert.ToInt32(drpCountryId.SelectedValue);
                    _objRow.Contact_Kabul = txtCon_ContactKabul.Text.Trim();
                    _objRow.Contact_Personal = txtCon_ContactPersonal.Text.Trim();
                    _objRow.Email = txtCon_Email.Text.Trim();
                    _objRow.Email_Personal = txtCon_EmailPersonal.Text.Trim();
                    _objRow.IsDeleted = false;
                    _objRow.Created_By = UserId;
                    _objRow.Created_Date = Convert.ToDateTime(_GetCurrentDate());
   
                    //insert new record
                    _objDB.tblStaffCollection.Insert(_objRow);

                }
                //update existing record
                else
                {
                    _objRow = new tblStaffRow();
                    _objRow = _objDB.tblStaffCollection.GetRow("StaffId=" + Convert.ToInt32(txtCon_StaffId.Text.Trim()));
                    _objRow.LastName = txtCon_LastName.Text.Trim();
                    _objRow.FirstName = txtCon_FirstName.Text.Trim();
                    _objRow.MiddleName = txtCon_MiddleName.Text.Trim();
                    _objRow.BirthDate = Convert.ToDateTime(txtCon_BirthDate.Text);
                    _objRow.HomeAddress1 = txtCon_Address1.Text.Trim();
                    _objRow.HomeAddress2 = txtCon_Address2.Text.Trim();
                    _objRow.Country_ID = Convert.ToInt32(drpCountryId.SelectedValue);
                    _objRow.Contact_Kabul = txtCon_ContactKabul.Text.Trim();
                    _objRow.Contact_Personal = txtCon_ContactPersonal.Text.Trim();
                    _objRow.Email = txtCon_Email.Text.Trim();
                    _objRow.Email_Personal = txtCon_EmailPersonal.Text.Trim();
                    _objRow.Updated_By = UserId;
                    _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                    _objDB.tblStaffCollection.Update(_objRow);

                }


            }
            finally
            {
                _objDB.Dispose();
            }


        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchStaff();
        }

        public void _SearchStaff()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                DataTable dt = new DataTable();                         
                dt = _objDB.tblStaffCollection.GetAsDataTable("LastName LIKE '%" + txtSearchLastName.Text.Trim() + "%'", "FirstName");
                _gvList.DataSource = dt;
                _gvList.DataBind();
            }
            finally
            {
                _objDB.Dispose();
            }


        }




    }
}
