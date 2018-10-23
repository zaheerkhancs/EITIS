using System;
using System.Data;
using System.Web.UI;
using IOM.EITS.DAL;
using IOM.EITS;
namespace EITS_App
{
    public partial class lkpLeave : BaseController.BaseController 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack )
            {
                ShowData();
            }
        }
        protected void imgAdd_Click(object sender, ImageClickEventArgs e)
        {
            this.chkActive.Checked = true;
            this.txtLeaveId.ReadOnly = true;
            this.txtLeaveId.Text = "";
            this.txtLeaveDays.Text = "";
            this.ddlContractTypeId.Focus();
            _FillCombo();
            mpePanel.Show();
        }
        #region _GridDisplayModuls      
        private void ShowData()
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
                    this._gvList.DataSource = dt;
                    this._gvList.DataBind();
                    this._gvList.Visible = true;
                }
            }

        }
        public  DataTable GetGridData()
        {
            var objDb = new EITSDB();
        
            var objRow = new LkpLeave();
            var objectRow_ = new sp_Lookups_All();
            DataTable dt;
            try
            {
                return dt = objectRow_.GetLeaveRecord();
                //return dt = objRow.GetLeaveRecord();
                //this._gvList.DataSource = dt;
                //this._gvList.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objDb.Dispose();
            }
        }
        #endregion

        protected void imgSave_Click(object sender, ImageClickEventArgs e)
        {
            EITSDB obj_ = new EITSDB();
            EITSCommon cc = new EITSCommon();
            lkpLeaveRow lkplObj = new lkpLeaveRow();
            //
            try
            {
                if (this.txtLeaveId.Text == "")
                {
                    lkplObj.ContractType_ID = Convert.ToInt32(this.ddlContractTypeId.SelectedValue);
                    lkplObj.LeaveTypeID = Convert.ToInt32(this.ddlLeaveTypeId.SelectedValue);
                    lkplObj.LeaveDays = Convert.ToInt32(this.txtLeaveDays.Text.Trim());
                    lkplObj.Active = true;

                    obj_.lkpLeaveCollection.Insert(lkplObj);
                    ShowData();
                }
                else
                {
                    lkplObj.Leave_ID = Convert.ToInt32(this.txtLeaveId.Text.Trim());
                    lkplObj.ContractType_ID = Convert.ToInt32(this.ddlContractTypeId.SelectedValue);
                    lkplObj.LeaveTypeID = Convert.ToInt32(this.ddlLeaveTypeId.SelectedValue);
                    lkplObj.LeaveDays = Convert.ToInt32(this.txtLeaveDays.Text.Trim());
                    lkplObj.Active = true;
                    obj_.lkpLeaveCollection.Update(lkplObj);
                    ShowData();
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
        #region _FillComboBox
        private void _FillCombo()
        {
            EITSDB _obj = new EITSDB();
            try
            {
                DataTable _dtContractType = _obj.lkpContract_TypeCollection.GetAsDataTable("Active=1", "Type_Name");
                EITSCommon.FillCombo(ref ddlContractTypeId, _dtContractType, "Type_Name", "ContractType_ID", true);
                //
                DataTable _dtlkplType = _obj.lkpLeaveTypeCollection.GetAsDataTable("Active=1", "LeaveType_Name");
                EITSCommon.FillCombo(ref ddlLeaveTypeId, _dtlkplType, "LeaveType_Name", "LeaveType_ID", true);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _obj.Dispose();
            }
        }

        #endregion


        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
          
            EITSDB obj_ = new EITSDB();
            lkpLeaveRow row_ = new lkpLeaveRow();
            DataTable dt_ = new DataTable();
            try
            {
                _FillCombo();
                // row_ = obj_.lkpLeaveCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                row_ = obj_.lkpLeaveCollection.GetRow("Leave_ID=" + e.CommandArgument.ToString());
                this.txtLeaveId.Text = row_.Leave_ID.ToString();
                this.ddlContractTypeId.SelectedValue = row_.ContractType_ID.ToString();
                this.ddlLeaveTypeId.SelectedValue = row_.LeaveTypeID.ToString();
                this.txtLeaveDays.Text = row_.LeaveDays.ToString();
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

        protected void imgDelete_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            EITSDB obj_ = new EITSDB();
            var row_ = new lkpLeaveRow();
            //sp_Lookups_All Object_ = new sp_Lookups_All();
            try
            {
                row_ = obj_.lkpLeaveCollection.GetByPrimaryKey(Convert.ToInt32(e.CommandArgument.ToString()));
                row_.Active = false;
                obj_.lkpLeaveCollection.Update(row_);
                //Object_.LeavelistDeleteLogically(e.CommandArgument.ToString());
                ShowData();
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
