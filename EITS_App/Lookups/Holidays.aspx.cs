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
    public partial class tblHolidays : EITS_App.BaseController.BaseController 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                _ShowData();
        }

        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {
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
                dt = _objDb.tblHolidayCollection.GetAsDataTable("Active=1", "HolidayID");
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
            var row_ = new tblHolidayRow();
           // var objh = new sp_Lookups_All();
            try
                {
                if(e!=null )
                {
                    row_ = _objDb.tblHolidayCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                    row_.Active = false;
                    _objDb.tblHolidayCollection.Update(row_);
                    //objh.HolidayDeleteLogically(e.CommandArgument.ToString());
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
            _SaveHolidays();
            mpePanel.Hide();
            _ShowData();
        }

        private void _SaveHolidays()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                tblHolidayRow  _objRow;
                if (txtHoliday_ID.Text.Trim() == "")
                {
                    _objRow = new tblHolidayRow();
                    _objRow.HolidayName  = txtHolidayName.Text;
                    _objRow.Date = Convert.ToDateTime ( txtHDate.Text);
                    _objRow.Active = chkActive.Checked;
                    _objDB.tblHolidayCollection.Insert(_objRow);
                }
                else
                {
                    _objRow = new tblHolidayRow();
                    _objRow = _objDB.tblHolidayCollection.GetRow("HolidayiD=" + Convert.ToInt32(txtHoliday_ID.Text));
                    _objRow.HolidayName = txtHolidayName.Text;
                    _objRow.Date = Convert.ToDateTime(txtHDate.Text);
                    _objRow.Active = chkActive.Checked;
                    _objDB.tblHolidayCollection.Update(_objRow);
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

                tblHolidayRow _objRow = new tblHolidayRow();
                _objRow = _objDb.tblHolidayCollection.GetRow("HolidayID=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");

                txtHoliday_ID.Text = _objRow.HolidayId.ToString();
                txtHolidayName.Text = _objRow.HolidayName;
                txtHDate.Text = _objRow.Date.Date.ToShortDateString();
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
