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
namespace EITS_App.Lookups
{
    public partial class Agency : EITS_App.BaseController.BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack )
            {
                _Showdata();
            }

        }
        private void _Showdata()
        {
            var obj = new EITSDB();
            try
            {
                DataTable dt = GetGridData();
                if (dt != null)
                {
                    if (dt.Rows.Count == 0)
                    {
                        this._gvList.Visible = false;
                    }
                    else
                    {
                        this._gvList.Visible = true;
                        this._gvList.DataSource = dt;
                        this._gvList.DataBind();
                    }
                }
                else
                {
                    _gvList.Visible = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                obj.Dispose();
            }
        }
        private DataTable GetGridData()
        {
            EITSDB obb = new EITSDB();
            var dt = new DataTable();
            try
            {
                dt = obb.lkpAgencyCollection.GetAsDataTable("Active=1", "Agency_Name");
                this._gvList.DataSource = dt;
                this._gvList.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                obb.Dispose();
            }
            return dt;
        }

        protected void imgSave_Click(object sender, ImageClickEventArgs e)
        {
            EITSDB obj_ = new EITSDB();
            lkpAgencyRow row_ = new lkpAgencyRow();
            try
            {
                if (this.txtAgencyID.Text == "")
                {
                    row_.Agency_Name  = this.txtAgencyName.Text.Trim();
                    row_.Active = this.chkActive.Checked;
                    obj_.lkpAgencyCollection.Insert(row_);
                    _Showdata();

                }
                else
                {
                    row_.Agency_ID  = Convert.ToInt32(this.txtAgencyID .Text);
                    row_.Agency_Name  = this.txtAgencyName .Text;
                    row_.Active = this.chkActive.Checked;
                    obj_.lkpAgencyCollection.Update(row_);
                    _Showdata();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                obj_.Dispose();
            }
        }

        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {
            this.txtAgencyID.ReadOnly = true;
            this.txtAgencyID.Text = "";
            txtAgencyName.Text = "";
            mpePanel.Show();
        }

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            EITSDB obj_ = new EITSDB();
            lkpAgencyRow row_ = new lkpAgencyRow();
            try
            {
                row_ = obj_.lkpAgencyCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                this.txtAgencyID.Text = row_.Agency_ID .ToString();
                this.txtAgencyName.Text = row_.Agency_Name ;
                this.chkActive.Checked = row_.Active;
                //
                mpePanel.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            EITSDB obj_ = new EITSDB();
            sp_Lookups_All objcs = new sp_Lookups_All();
            
            try
            {
                lkpAgencyRow _objRow = new lkpAgencyRow();

                _objRow = obj_.lkpAgencyCollection.GetRow("Agency_ID = " + e.CommandArgument.ToString());
                _objRow.Active = false;
                 obj_.lkpAgencyCollection.Update(_objRow);

                _Showdata();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
            }
        }

    }
}
