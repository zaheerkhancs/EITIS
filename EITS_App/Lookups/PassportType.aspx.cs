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
    public partial class lkpPassportType : EITS_App.BaseController.BaseController 
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
                dt = _objDb.lkpPassportTypeCollection.GetAsDataTable("Active=1", "PassportType_ID");
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
            var row_ = new lkpPassportTypeRow();
            ///var objPt = new sp_Lookups_All();
            try
            {
                if(e!=null )
                {
                    row_ =
                        _objDb.lkpPassportTypeCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                    row_.Active = false;
                    _objDb.lkpPassportTypeCollection.Update(row_);
                   //objPt.PassportTypeDeleteLogically(e.CommandArgument.ToString());
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
            _SavePassprtType();
            mpePanel.Hide();
            _ShowData();
        }

        private void _SavePassprtType()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                lkpPassportTypeRow  _objRow;
                if (txtPassportType_ID.Text.Trim() == "")
                {
                    _objRow = new lkpPassportTypeRow();
                    _objRow.PassportType_Name = txtPassport_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpPassportTypeCollection.Insert(_objRow);
                }
                else
                {
                    _objRow = new lkpPassportTypeRow();
                    _objRow = _objDB.lkpPassportTypeCollection.GetRow("PassportType_ID=" + Convert.ToInt32(txtPassportType_ID.Text));
                    _objRow.PassportType_Name  = txtPassport_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpPassportTypeCollection.Update(_objRow);
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

                lkpPassportTypeRow _objRow = new lkpPassportTypeRow();
                _objRow = _objDb.lkpPassportTypeCollection.GetRow("PassportType_ID=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");

                 txtPassportType_ID.Text = _objRow.PassportType_ID.ToString();
                txtPassport_TypeName.Text = _objRow.PassportType_Name;
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
