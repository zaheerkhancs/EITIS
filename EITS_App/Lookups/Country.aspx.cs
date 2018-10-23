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
    public partial class Country :EITS_App.BaseController .BaseController 
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
                dt = obb.lkpCountryCollection.GetAllAsDataTable();
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
            lkpCountryRow row_ = new lkpCountryRow();
            try
            {
                if (this.txtCountryId .Text == "")
                {
                    row_.Country_Name  = this.txtCountryName .Text.Trim();
                    obj_.lkpCountryCollection.Insert(row_);
                    _Showdata();

                }
                else
                {
                    row_.Country_ID  = Convert.ToInt32(this.txtCountryId .Text);
                    row_.Country_Name  = this.txtCountryName .Text;
                    obj_.lkpCountryCollection .Update(row_);
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

        protected void imgEdit_Command(object sender, CommandEventArgs e)
        {
            EITSDB obj_ = new EITSDB();
            lkpCountryRow row_ = new lkpCountryRow();
            try
            {
                row_ = obj_.lkpCountryCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                this.txtCountryId.Text = row_.Country_ID .ToString( );
                this.txtCountryName.Text = row_.Country_Name ;
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
                obj_.lkpCountryCollection.DeleteByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                _Showdata();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {
            this.txtCountryId.ReadOnly = true;
            this.txtCountryName.Text = "";
            this.txtCountryId.Text = "";
            mpePanel.Show();
        }
    }
}
