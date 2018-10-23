using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using IOM.EITS.DAL;


namespace EITS_App.Forms
{
    public partial class StaffInformationDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblStaffId.Text = Request.QueryString["StaffId"].Trim();
                _ShowData();
                _FillCombo();

                
            }

        }

        private void _ResetTextBoxes()
        {
            lblContract_ID.Text="";
            txtCon_JobTitle.Text = "";
            txtContract_Code.Text = "";
            txtCon_Start.Text = "";
            txtCon_End.Text = "";
            lblPassport_ID.Text ="";
            lblStaffId.Text = "";
            txtPassport_No.Text = "";
            txtPassportIssue.Text = "";
            txtPassportValid.Text = "";
            

        }


        private Guid UserId
        {
            get
            {
                if (Session["UserId"] != null) return (Guid)Session["UserId"];
                else return Guid.Empty;
            }
        }


        public String _GetCurrentDate()
        {

            return DateTime.Now.ToString();
        }


        private void _FillCombo()
        {
            EITSDB _objDB = new EITSDB();

            try
            {
                DataTable dtContractType = _objDB.lkpContract_TypeCollection.GetAllAsDataTable();
                EITSCommon.FillCombo(ref drpContractType, dtContractType, "Type_Name", "ContractType_ID", true);

                DataTable dtContractStatus = _objDB.lkpContract_StatusCollection.GetAllAsDataTable();
                EITSCommon.FillCombo(ref drpContractStatus, dtContractStatus, "Status_Name", "ContractStatus_ID", true);

                DataTable dtDutyStation = _objDB.lkpDutyStationCollection.GetAllAsDataTable();
                EITSCommon.FillCombo(ref drpDutyStation, dtDutyStation, "DutyStation_Name", "DutyStation_ID", true);

                DataTable dtPassportType = _objDB.lkpPassportTypeCollection.GetAllAsDataTable();
                EITSCommon.FillCombo(ref drpPassportType, dtPassportType, "PassportType_Name", "PassportType_ID", true);

                DataTable dtLeaveType = _objDB.lkpLeaveTypeCollection.GetAllAsDataTable();
                EITSCommon.FillCombo(ref drpLeaveType, dtLeaveType, "LeaveType_Name", "LeaveType_ID", true);

                DataTable dtVisaType = _objDB.lkpVisaTypeCollection.GetAllAsDataTable();
                EITSCommon.FillCombo(ref drpVisaType, dtVisaType, "VisaType_Name", "VisaType_ID", true);


            }
            finally
            {
                _objDB.Dispose();
            }
        }


        public void _ShowData()
        {
            EITSDB _objDB = new EITSDB();
            //get staff information
            try
            {
                tblStaffRow _objRow = new tblStaffRow();
                _objRow = _objDB.tblStaffCollection.GetRow("StaffId=" + Convert.ToInt32(lblStaffId.Text));
                lblName.Text = _objRow.FirstName + " " + _objRow.MiddleName + " " + _objRow.LastName;
                lblHome1.Text = _objRow.HomeAddress1;
                lblHome2.Text = _objRow.HomeAddress2;
                lblContact1.Text = _objRow.Contact_Kabul;
                lblContact2.Text = _objRow.Contact_Personal;
                lblEmail.Text = _objRow.Email;
                lblEmailPersonal.Text = _objRow.Email_Personal;
                lblCountry.Text = _objRow.Country_ID.ToString();
                lblId_no.Text = _objRow.Id_No;
                lblAgency.Text = "";
                lblDepartment.Text = _objRow.Department_ID.ToString();
         
                _ShowContract();
                _ShowPassport();
                _ShowLeaves();
                _ShowEmergencyContact();
                


            }
            finally
            {
                _objDB.Dispose();
            }

         

         



        }



        //-----------CONTRACT FUNCTIONS-------------------//
        public void _ShowContract()
        {
            EITSDB _objDB = new EITSDB();
            DataTable dt = new DataTable();

            try
            {                
                dt = _objDB.tblStaff_ContractCollection.GetAsDataTable("StaffId=" + Convert.ToInt32(lblStaffId.Text) + "and IsDeleted = 0", "Con_SDate DESC");
                _gvContract.DataSource = dt;
                _gvContract.DataBind();

            }
            finally
            {
                _objDB.Dispose();
            }
          

        }


        protected void imgSaveContract_Click(object sender, ImageClickEventArgs e)
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                tblStaff_ContractRow _objRow = new tblStaff_ContractRow();
                //new record
                if(lblContract_ID.Text == "")
                {                    
                    _objRow.StaffID = Convert.ToInt32(lblStaffId.Text);
                    _objRow.JobTitle = txtCon_JobTitle.Text;
                    _objRow.Contract_Code = txtContract_Code.Text;
                    _objRow.ContractStatus_ID = Convert.ToInt32(drpContractStatus.SelectedValue);
                    _objRow.DutyStation_ID = Convert.ToInt32(drpDutyStation.SelectedValue);       
                    _objRow.Con_SDate = Convert.ToDateTime(txtCon_Start.Text);
                    _objRow.Con_EDate = Convert.ToDateTime(txtCon_End.Text);
                    _objRow.ContractType_ID = Convert.ToInt32(drpContractType.SelectedValue);              
                    _objRow.IsDeleted = false;
                    _objRow.Created_By = UserId;
                    _objRow.Created_Date = Convert.ToDateTime(_GetCurrentDate());
                    _objDB.tblStaff_ContractCollection.Insert(_objRow);

                    mpePanelContract.Hide();
                    _ShowContract();
                }
                    //update existing record
                else
                {   
                    _objRow = _objDB.tblStaff_ContractCollection.GetRow("Contract_ID = " + lblContract_ID.Text);
                    _objRow.JobTitle = txtCon_JobTitle.Text;
                    _objRow.Contract_Code = txtContract_Code.Text;
                    _objRow.ContractStatus_ID = Convert.ToInt32(drpContractStatus.SelectedValue);
                    _objRow.DutyStation_ID = Convert.ToInt32(drpDutyStation.SelectedValue);      
                    _objRow.Con_SDate = Convert.ToDateTime(txtCon_Start.Text);
                    _objRow.Con_EDate = Convert.ToDateTime(txtCon_End.Text);
                    _objRow.ContractType_ID = Convert.ToInt32(drpContractType.SelectedValue);              
                    _objRow.IsDeleted = false;
                    _objRow.Updated_By = UserId;
                    _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                    _objDB.tblStaff_ContractCollection.Update(_objRow);

                    mpePanelContract.Hide();
                    _ShowContract();

                }


            }
            finally
            {
                _objDB.Dispose();
            }

        }
        protected void imgAddContract_Click(object sender, ImageClickEventArgs e)
        {
            mpePanelContract.Show();
            
        }

        protected void imgEditContract_Command(object sender, CommandEventArgs e)
        {
            EITSDB _objDB = new EITSDB();

            try
            {
                tblStaff_ContractRow _objRow = new tblStaff_ContractRow();
                _objRow = _objDB.tblStaff_ContractCollection.GetRow("Contract_ID = " + Convert.ToInt32(e.CommandArgument.ToString()) + "");
                lblContract_ID.Text = _objRow.Contract_ID.ToString();
                drpContractStatus.SelectedValue = _objRow.ContractStatus_ID.ToString();
                txtCon_JobTitle.Text = _objRow.JobTitle;
                txtContract_Code.Text = _objRow.Contract_Code;
                drpDutyStation.SelectedValue = _objRow.DutyStation_ID.ToString();
                txtCon_Start.Text = _objRow.Con_SDate.ToShortDateString();
                txtCon_End.Text = _objRow.Con_EDate.ToShortDateString();
                drpContractType.SelectedValue = _objRow.ContractType_ID.ToString();
                _objRow.Updated_By = UserId;
                _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                _objDB.tblStaff_ContractCollection.Update(_objRow);

                mpePanelContract.Show();

            }
            finally
            {
                _objDB.Dispose();
            }
        }

        protected void imgDeleteContract_Command(object sender, CommandEventArgs e)
        {
            EITSDB _objDB = new EITSDB();
            
            try
            {
                tblStaff_ContractRow _objRow = new tblStaff_ContractRow();
                _objRow = _objDB.tblStaff_ContractCollection.GetRow("Contract_ID = " + Convert.ToInt32(e.CommandArgument.ToString()) + "");
                _objRow.IsDeleted = true;
                _objRow.Updated_By = UserId;
                _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                _objDB.tblStaff_ContractCollection.Update(_objRow);
                _ShowContract();

            }
            finally
            {
                _objDB.Dispose();
            }

        }

        //-----------------PASSPORT FUNCTIONS--------------------//

        public void _ShowPassport()
        {
            EITSDB _objDB = new EITSDB();
            DataTable dt = new DataTable();

            try
            {
                dt = _objDB.tblStaff_PassportCollection.GetAsDataTable("StaffId=" +
                    Convert.ToInt32(lblStaffId.Text) + "and Active = 1", "Date_Issued DESC");
                _gvPassport.DataSource = dt;
                _gvPassport.DataBind();

            }
            finally
            {
                _objDB.Dispose();
            }
        }

        protected void imgSavePassport_Click(object sender, ImageClickEventArgs e)
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                tblStaff_PassportRow _objRow = new tblStaff_PassportRow();
                //new record
                if (lblPassport_ID.Text == "")
                {
                    _objRow.StaffID = Convert.ToInt32(lblStaffId.Text);
                    _objRow.Passport_No = txtPassport_No.Text;
                    _objRow.PassportType_ID = Convert.ToInt32(drpPassportType.SelectedValue);
                    _objRow.Date_Issued = Convert.ToDateTime(txtPassportIssue.Text);
                    _objRow.Valid_Until = Convert.ToDateTime(txtPassportValid.Text);
                    _objRow.Active = true;
                    _objRow.Created_By = UserId;
                    _objRow.Created_Date = Convert.ToDateTime(_GetCurrentDate());
                    _objDB.tblStaff_PassportCollection.Insert(_objRow);

                    mpePanelPassport.Hide();
                    _ShowPassport();
                }
                //update existing record
                else
                {
                    _objRow = _objDB.tblStaff_PassportCollection.GetRow("Passport_ID = " +

                    lblPassport_ID.Text);
                    _objRow.Passport_No = txtPassport_No.Text;
                    _objRow.PassportType_ID = Convert.ToInt32(drpPassportType.SelectedValue);
                    _objRow.Date_Issued = Convert.ToDateTime(txtPassportIssue.Text);
                    _objRow.Valid_Until = Convert.ToDateTime(txtPassportValid.Text);
                    _objRow.Updated_By = UserId;
                    _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                    _objDB.tblStaff_PassportCollection.Update(_objRow);

                    mpePanelPassport.Hide();
                    _ShowPassport();

                }


            }
            finally
            {
                _objDB.Dispose();
            }

        }

        protected void imgAddPassport_Click(object sender, ImageClickEventArgs e)
        {
            mpePanelPassport.Show();
        }



        protected void imgEditPassport_Command(object sender, CommandEventArgs e)
        {
            EITSDB _objDB = new EITSDB();

            try
            {
                tblStaff_PassportRow _objRow = new tblStaff_PassportRow();
                _objRow = _objDB.tblStaff_PassportCollection.GetRow("Passport_ID = " + 
                    Convert.ToInt32(e.CommandArgument.ToString()) + "");
                lblPassport_ID.Text = _objRow.Passport_ID.ToString();
                txtPassport_No.Text = _objRow.Passport_No;
                drpPassportType.SelectedValue = _objRow.PassportType_ID.ToString();
                txtPassportIssue.Text = _objRow.Date_Issued.ToString();
                txtPassportValid.Text = _objRow.Valid_Until.ToString();
                _objRow.Updated_By = UserId;
                _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                _objDB.tblStaff_PassportCollection.Update(_objRow);

                mpePanelPassport.Show();

            }
            finally
            {
                _objDB.Dispose();
            }
        }

        protected void imgDeletePassport_Command(object sender, CommandEventArgs e)
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                tblStaff_PassportRow _objRow = new tblStaff_PassportRow();
                _objRow = _objDB.tblStaff_PassportCollection.GetRow("Passport_ID = " +
                    Convert.ToInt32(e.CommandArgument.ToString()) + "");
                _objRow.Active = false;
                _objRow.Updated_By = UserId;
                _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                _objDB.tblStaff_PassportCollection.Update(_objRow);
                _ShowPassport();

            }
            finally
            {
                _objDB.Dispose();
            }

        }



        //---------------------LEAVE FUNCTIONS --------------------//


       
        protected void imgAddLeave_Click(object sender, ImageClickEventArgs e)
        {     
            mpePanelLeaveAdd.Show();        
        }

        public void _ShowLeaves()
        {
            
            EITSDB _objDB = new EITSDB();
            DataTable dt = new DataTable();

            try
            {
                dt = _objDB.tblStaff_LeaveTransCollection.GetAsDataTable("StaffID=" + Convert.ToInt32(lblStaffId.Text), "Sub_Date DESC");
                _gvLeave.DataSource = dt;
                _gvLeave.DataBind();

            }
            finally
            {
                _objDB.Dispose();
            }

        }
        protected void imgViewLeave_Command(object sender, CommandEventArgs e)
        {          
            _ShowLeaves();
            
        }
       
        protected void imgSaveLeave_Click(object sender, ImageClickEventArgs e)
        {


            EITSDB _objDB = new EITSDB();
            tblStaff_LeaveTransRow _objRow = new tblStaff_LeaveTransRow();
            txtSub_Date.Text = _GetCurrentDate();
            try
            {   //new record
                if(lblLeaveTrans_ID.Text == "")
                {
               
                _objRow.StaffID = Convert.ToInt32(lblStaffId.Text);
                _objRow.Sub_Date = Convert.ToDateTime(txtSub_Date.Text);
                _objRow.Leave_ID = Convert.ToInt32(drpLeaveType.SelectedValue);
                _objRow.FDate = Convert.ToDateTime(txtFDate.Text);
                _objRow.To_Date = Convert.ToDateTime(txtTo_Date.Text);
                _objRow.Remarks = txtLeaveRemarks.Text.Trim();
                _objRow.IsApproved = false;
                _objRow.IsDeleted = false;
                _objRow.Created_By = UserId;
                _objRow.Created_Date = Convert.ToDateTime(_GetCurrentDate());
                _objDB.tblStaff_LeaveTransCollection.Insert(_objRow);
               

                }
                else{
                _objRow = _objDB.tblStaff_LeaveTransCollection.GetRow("LeaveTrans_ID = " + lblLeaveTrans_ID.Text);
                _objRow.StaffID = Convert.ToInt32(lblStaffId.Text);
                _objRow.Sub_Date = Convert.ToDateTime(txtSub_Date.Text);
                _objRow.Leave_ID = Convert.ToInt32(drpLeaveType.SelectedValue);
                _objRow.FDate = Convert.ToDateTime(txtFDate.Text);
                _objRow.To_Date = Convert.ToDateTime(txtTo_Date.Text);
                _objRow.Remarks = txtLeaveRemarks.Text.Trim();
                _objRow.IsApproved = false;
                _objRow.IsDeleted = false;
                _objRow.Updated_By = UserId;
                _objRow.Updated_Date = Convert.ToDateTime(_GetCurrentDate());
                _objDB.tblStaff_LeaveTransCollection.Update(_objRow);

                }


            }
            finally
            {
                _objDB.Dispose();
            }

           _ShowLeaves();
            mpePanelLeaveAdd.Hide();
           

        }

        protected void imgCancelLeaveAdd_Click(object sender, ImageClickEventArgs e)
        {
           mpePanelLeaveAdd.Hide();
        }

        //-----------VISA FUNCTIONS---------------------------------------------------//



        public void _ShowVisas()
        {

            EITSDB _objDB = new EITSDB();
            DataTable dt = new DataTable();

            try
            {
                dt = _objDB.tblStaff_VisaCollection.GetAsDataTable("PassportID=" + Convert.ToInt32(lblPassport_IDAdd.Text), "Visa_ID");
                _gvVisa.DataSource = dt;
                _gvVisa.DataBind();

            }
            finally
            {
                _objDB.Dispose();
            }

        }

        protected void imgVisaView_Command(object sender, CommandEventArgs e)
        {

            mpePanelVisa.Show();           
            lblPassport_IDAdd.Text = e.CommandArgument.ToString();
            _ShowVisas();


        }

        protected void imgAddVisa_Click(object sender, ImageClickEventArgs e)
        {
            mpePanelVisaAdd.Show();
        }

        protected void imgSaveVisa_Click(object sender, ImageClickEventArgs e)
        {
            EITSDB _objDB = new EITSDB();
            tblStaff_VisaRow _objRow = new tblStaff_VisaRow();

            try
            {

                    _objRow.PassportID = Convert.ToInt32(lblPassport_IDAdd.Text);
                    _objRow.Date_Given = Convert.ToDateTime(txtVisaDate_Issued.Text);
                    _objRow.Valid_Date = Convert.ToDateTime(txtVisaValid_Until.Text);
                    _objRow.VisaType_ID = Convert.ToInt32(drpVisaType.SelectedValue);
                    _objRow.IsDeleted = false;
                    _objRow.Created_By = UserId;
                    _objRow.Created_Date = Convert.ToDateTime(_GetCurrentDate());
                    _objDB.tblStaff_VisaCollection.Insert(_objRow);

   

            }
            finally
            {
                _objDB.Dispose();
            }


            mpePanelVisa.Show();
            _ShowVisas();
            mpePanelVisaAdd.Hide();

        }


        //-------------------------EMERGENCY CONTACT INFORMATION FUNCTIONS ----------------//

        public void _ShowEmergencyContact()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                DataTable dt = new DataTable();
                dt = _objDB.tblStaff_EmergencyContactCollection.GetAsDataTable("StaffId=" + lblStaffId.Text, "Emergency_Name");
                _gvContact.DataSource = dt;
                _gvContact.DataBind();
                
            }
            finally
            {
                _objDB.Dispose();
            }
        }

        protected void imgAddEmergency_Click(object sender, ImageClickEventArgs e)
        {

        }

       




    }
}
