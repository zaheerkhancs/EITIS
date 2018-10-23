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
    
    public partial class ContractTypes : EITS_App.BaseController.BaseController 
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
        private DataTable  _GetGridData()
        {
            EITSDB  _objDb = new EITSDB ();
            DataTable dt = new DataTable();
            try
            {
                dt = _objDb.lkpContract_TypeCollection.GetAsDataTable("Active=1", "ContractType_ID");
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
            lkpContract_TypeRow row_ = new lkpContract_TypeRow();
            sp_Lookups_All objct = new sp_Lookups_All();
            try
            {
                if(e!=null )
                {
                    row_ = _objDb.lkpContract_TypeCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                    row_.Active = false;
                    _objDb.lkpContract_TypeCollection.Update(row_);
                    //objct.ContractTypeDeleteLogically(e.CommandArgument.ToString() );
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
            _SaveContract();  
            mpePanel.Hide();
            _ShowData();
        }

        private void _SaveContract()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                lkpContract_TypeRow _objRow;
                if (txtCon_ID.Text.Trim () == "")
                {
                    _objRow = new lkpContract_TypeRow();
                    _objRow.Type_Name = txtCon_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpContract_TypeCollection.Insert(_objRow);
                }
                else
                {
                    _objRow = new lkpContract_TypeRow();
                    _objRow = _objDB.lkpContract_TypeCollection.GetRow("ContractType_ID=" + Convert.ToInt32(txtCon_ID.Text ));
                    _objRow.Type_Name = txtCon_TypeName.Text;
                    _objRow.Active = chkActive.Checked;
                    _objDB.lkpContract_TypeCollection.Update(_objRow);
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

                lkpContract_TypeRow _objRow = new lkpContract_TypeRow();
                _objRow = _objDb.lkpContract_TypeCollection.GetRow("ContractType_ID=" + Convert.ToInt32(e.CommandArgument.ToString()) + "");

                txtCon_ID.Text = _objRow.ContractType_ID.ToString();
                txtCon_TypeName.Text = _objRow.Type_Name;
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
