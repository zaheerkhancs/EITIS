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
    public partial class lkpVisaType : EITS_App.BaseController.BaseController 
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
                dt = _objDb.lkpVisaTypeCollection.GetAsDataTable("Active=1", "VisaType_ID");
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
            var row_ = new lkpVisaTypeRow();
            ///var objVt = new sp_Lookups_All();
            try
            {
                row_ = _objDb.lkpVisaTypeCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                row_.Active = false;
                _objDb.lkpVisaTypeCollection.Update(row_);
               // objVt.VisaTypeDeleteLogically(e.CommandArgument.ToString());
                _ShowData();
            }
            finally
            {
                _objDb.Dispose();
            }
        }


        protected void imgSave_Click(object sender, ImageClickEventArgs e)
        {
            _SaveVisaType();
            mpePanel.Hide();
            _ShowData();
        }

        private void _SaveVisaType()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                lkpVisaTypeRow _objRow;
                if (txtVisaType_ID.Text.Trim() == "")
                {
                    _objRow = new lkpVisaTypeRow();
                    _objRow.VisaType_Name  = txtVisa_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpVisaTypeCollection.Insert(_objRow);
                }
                else
                {
                    _objRow = new lkpVisaTypeRow();
                    _objRow = _objDB.lkpVisaTypeCollection.GetRow("VisaType_ID=" + Convert.ToInt32(txtVisaType_ID.Text));
                    _objRow.VisaType_Name  = txtVisa_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpVisaTypeCollection.Update(_objRow);
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

                lkpVisaTypeRow _objRow = new lkpVisaTypeRow();
                _objRow = _objDb.lkpVisaTypeCollection.GetRow("VisaType_ID=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");

                txtVisaType_ID.Text = _objRow.VisaType_ID.ToString();
                txtVisa_TypeName.Text = _objRow.VisaType_Name;
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
