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
    public partial class lkpContractStatus :EITS_App.BaseController .BaseController  
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ShowGrid();

        }
        //
        private void ShowGrid()
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
        private  DataTable GetGridData()
        {
            EITSDB obb = new EITSDB();
            var dt = new DataTable();
            try
            {
                dt = obb.lkpContract_StatusCollection.GetAsDataTable("Active=1", "Status_Name");
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
            lkpContract_StatusRow row_ = new lkpContract_StatusRow();
            try
            {
                if(this.txtContractStatusID.Text=="" )
                {
                    row_.Status_Name = this.txtStatusName.Text.Trim();
                    row_.Active = this.chkActive.Checked;
                    obj_.lkpContract_StatusCollection.Insert(row_);
                    ShowGrid();

                }
                else
                {
                    row_.ContractStatus_ID = Convert.ToInt32(this.txtContractStatusID.Text);
                    row_.Status_Name = this.txtStatusName.Text;
                    row_.Active = this.chkActive.Checked;
                    obj_.lkpContract_StatusCollection.Update(row_);
                    ShowGrid();
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
            lkpContract_StatusRow row_ = new lkpContract_StatusRow();
            try
            {
                row_=obj_.lkpContract_StatusCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                this.txtContractStatusID.Text = row_.ContractStatus_ID.ToString();
                this.txtStatusName.Text = row_.Status_Name;
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
            lkpContract_StatusRow row_ = new lkpContract_StatusRow();
            //sp_Lookups_All objcs = new sp_Lookups_All();
            try
            {
                if (e != null)
                {
                    //objcs.ContractStatusDeleteLogically( e.CommandArgument.ToString());
                    row_ = obj_.lkpContract_StatusCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                    row_.Active = false;
                    obj_.lkpContract_StatusCollection.Update(row_);
                }
                ShowGrid();
            
        }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
            }
        }

        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {
            this.txtContractStatusID.ReadOnly = true;
            this.txtContractStatusID.Text = ""; 
            this.txtStatusName.Text = "";
            this.txtStatusName.Focus();
            mpePanel.Show();
        }
    }
}
