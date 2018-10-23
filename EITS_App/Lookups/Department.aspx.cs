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
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                dt = obb.lkpDepartmentCollection.GetAsDataTable("Active=1", "Department_Name");
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
            lkpDepartmentRow row_ = new lkpDepartmentRow();
            try
            {
                if (this.txtdeptId .Text == "")
                {
                    row_.Department_Name  = this.txtdeptName .Text.Trim();
                    row_.Active = Convert.ToInt32( this.chkActive.Checked);
                    obj_.lkpDepartmentCollection.Insert(row_);
                    _Showdata();

                }
                else
                {
                    row_.Department_ID  = Convert.ToInt32(this.txtdeptId .Text);
                    row_.Department_Name  = this.txtdeptName .Text;
                    row_.Active =Convert .ToInt32(  this.chkActive.Checked);
                    obj_.lkpDepartmentCollection.Update(row_); 
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
            this.txtdeptId.ReadOnly = true;
            this.txtdeptName.Text = "";
            this.txtdeptId.Text = "";
            mpePanel.Show();
        }

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            EITSDB obj_ = new EITSDB();
            lkpDepartmentRow row_ = new lkpDepartmentRow();
            try
            {
                row_ = obj_.lkpDepartmentCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                this.txtdeptId .Text = row_.Department_ID .ToString();
                this.txtdeptName .Text = row_.Department_Name ;
                this.chkActive.Checked = Convert.ToBoolean(row_.Active);
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
           try
            {
                lkpDepartmentRow _objRow = new lkpDepartmentRow();

                _objRow = obj_.lkpDepartmentCollection .GetRow("Department_ID = " + e.CommandArgument.ToString());
                _objRow.Active = 0;
                obj_.lkpDepartmentCollection .Update(_objRow);

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
