using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using IOM.EITS.DAL;

namespace EITS_App
{
    public partial class lkpLeaveType : EITS_App.BaseController.BaseController 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                _ShowData();
        }

        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {
            this.txtLeaveType_ID.Text = "";
            this.txtLeave_TypeName.Text = "";
            mpePanel.Show();
        }

        private void _ShowData()
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
        private DataTable _GetGridData()
        {
            EITSDB _objDb = new EITSDB();
            DataTable dt = new DataTable();
            try
            {
                dt = _objDb.lkpLeaveTypeCollection.GetAsDataTable("Active=1", "LeaveType_ID");
                _gvList.DataSource = dt;
                _gvList.DataBind();
            }
            finally
            {
                _objDb.Dispose();
            }
            return dt;
        }

        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            EITSDB _objDb = new EITSDB();
            var row_ = new lkpLeaveTypeRow();
            var objLt = new sp_Lookups_All();
            try
            {
                if(e!=null )
                {
                    row_ = _objDb.lkpLeaveTypeCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                    row_.Active = false;
                    _objDb.lkpLeaveTypeCollection.Update(row_); 
                    //objLt.LeaveTypeDeleteLogically(e.CommandArgument.ToString());
                    _ShowData();

                }

            }
            finally
            {
                _objDb.Dispose();
            }
        }


        protected void imgSave_Click(object sender, ImageClickEventArgs e)
        {
            _SaveLeaveType();
            mpePanel.Hide();
            _ShowData();
        }

        private void _SaveLeaveType()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                lkpLeaveTypeRow  _objRow;
                if (txtLeaveType_ID.Text.Trim() == "")
                {
                    _objRow = new lkpLeaveTypeRow();
                    _objRow.LeaveType_Name  = txtLeave_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpLeaveTypeCollection.Insert(_objRow);
                }
                else
                {
                    _objRow = new lkpLeaveTypeRow();
                    _objRow = _objDB.lkpLeaveTypeCollection.GetRow("LeaveType_ID=" + Convert.ToInt32(txtLeaveType_ID.Text));
                    _objRow.LeaveType_Name = txtLeave_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpLeaveTypeCollection.Update(_objRow);
                }
            }
            finally
            {
                _objDB.Dispose();
            }
        }

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            EITSDB _objDb = new EITSDB();
            try
            {

                lkpLeaveTypeRow _objRow = new lkpLeaveTypeRow();
                _objRow = _objDb.lkpLeaveTypeCollection.GetRow("LeaveType_ID=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");

                txtLeaveType_ID.Text = _objRow.LeaveType_ID.ToString();
                txtLeave_TypeName.Text = _objRow.LeaveType_Name;
                chkActive.Checked = _objRow.Active;
                mpePanel.Show();
            }
            finally
            {
                _objDb.Dispose();
            }
        }
    }
}
