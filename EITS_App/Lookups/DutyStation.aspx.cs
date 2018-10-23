using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using IOM.EITS.DAL;
using System.Data.SqlClient;
using System.Data;
namespace EITS_App.Lookups
{
    public partial class lkpdutystation :EITS_App.BaseController .BaseController   
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack )
            {
                ShowGrid();
            }
        }

        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            var obj_ = new EITSDB();
            var row_ = new lkpDutyStationRow();
            var objds = new sp_Lookups_All();
            try
            {
                if(e!=null ){
                    row_ = obj_.lkpDutyStationCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                    row_.Active = false;
                    obj_.lkpDutyStationCollection.Update(row_);
                //objds.DutyStationDeleteLogically(e.CommandArgument.ToString());
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
            var obj_ = new EITSDB();
            var row_ = new lkpDutyStationRow();
            try
            {
                row_ = obj_.lkpDutyStationCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                this.txtDutyStation_ID.Text = row_.DutyStation_ID.ToString();
                this.txtDutyStationName.Text = row_.DutyStation_Name.ToString();
                this.chkActive.Checked = row_.Active;
                mpePanel.Show();
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
            this.txtDutyStation_ID.ReadOnly = true;
            this.txtDutyStation_ID.Text = "";
            this.txtDutyStationName.Text = "";
            this.txtDutyStationName.Focus();
            mpePanel.Show();
        }
        private void ShowGrid()
        {
            var obj_ = new EITSDB();
            var dt_ = new DataTable();
            try
            {
                dt_ = getGrid();
                if(dt_ .Rows .Count ==0)
                {
                    _gvList.Visible = false;
                }
                else
                {
                    _gvList.Visible = true;
                    _gvList.DataSource = dt_;
                    _gvList.DataBind();
                    
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
        //
        private DataTable getGrid()
        {
            EITSDB obj_ = new EITSDB();
            var dt_ = new DataTable();
            try
            {
                dt_ = obj_.lkpDutyStationCollection.GetAllAsDataTable();    
                if(dt_ !=null )
                {
                    _gvList.DataSource = dt_;
                    _gvList.DataBind();
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
            return dt_;
        }

        protected void imgSave_Click(object sender, ImageClickEventArgs e)
        {
            var obj_ = new EITSDB();
            var lkpds = new lkpDutyStationRow();
            
            try
            {
                if(this.txtDutyStation_ID.Text=="")
                {
                    //lkpds.DutyStation_ID = Convert.ToInt32(this.txtDutyStationName.Text.Trim());
                    lkpds.DutyStation_Name = this.txtDutyStationName.Text.Trim();
                    lkpds.Active = this.chkActive.Checked;
                    obj_.lkpDutyStationCollection.Insert(lkpds);
                    ShowGrid();
                }
                else
                {
                    lkpds.DutyStation_ID = Convert.ToInt32(this.txtDutyStation_ID.Text.Trim());
                    lkpds.DutyStation_Name = this.txtDutyStationName.Text.Trim();
                    lkpds.Active = this.chkActive.Checked;
                    obj_.lkpDutyStationCollection.Update(lkpds);
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
    }
}
