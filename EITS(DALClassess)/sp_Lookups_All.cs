using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace IOM.EITS.DAL
{
   public  class sp_Lookups_All:IDisposable 
    {
       private EITSDB Object_ = null;
       private bool isDisposed = false;

       public sp_Lookups_All()
       {
           Object_ = new EITSDB(); 
       }
       public EITSDB ObjectDB
       {
           get { return Object_; }

       }
       public void Dispose()
       {
           try
           {
               if(Object_ !=null )
               {
                   Object_.Dispose();
                   isDisposed = true;
               }

           }
           catch
           {
               throw new NotImplementedException();
           }
           
       }
       // Methods 
       public DataTable GetLeaveRecord()
       {
           var cmd = ((SqlCommand)Object_.CreateCommand("sp_getlkpLeaveRec", true));
           DataTable _dt = Object_.CreateDataTable(cmd);
           return _dt;
       }

       // Leave List Table 
       public DataTable LeavelistDeleteLogically(string leave_Id)
       {
           SqlCommand cmdSelect = ((SqlCommand)Object_.CreateCommand("sp_leave_deletelogically", true));
           cmdSelect.Parameters.Add("@_leaveId", SqlDbType.Int).Value = Convert.ToInt32(leave_Id);
           DataTable dt_dll = Object_.CreateDataTable(cmdSelect);
           return dt_dll;
       }
       // Leave Type Table
       public DataTable LeaveTypeDeleteLogically(string ltId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpLeaveTypeDeleteLogically", true));
           cmd.Parameters.Add("@LeaveType_ID", SqlDbType.Int).Value = Convert.ToInt32(ltId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // Contract Type Table
       public DataTable ContractTypeDeleteLogically(string ctId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpContractTypeDeleteLogically", true));
           cmd.Parameters.Add("@ContractType_ID", SqlDbType.Int).Value = Convert.ToInt32(ctId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       //Contract Status Table
       public DataTable ContractStatusDeleteLogically(string csId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpContractStatusDeleteLogically", true));
           cmd.Parameters.Add("@ContractStatus_ID", SqlDbType.Int).Value = Convert.ToInt32(csId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // Duty Station Table
       public DataTable DutyStationDeleteLogically(string dsId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpDutyStationDeleteLogically", true));
           cmd.Parameters.Add("@DutyStation_ID", SqlDbType.Int).Value = Convert.ToInt32(dsId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // Holiday Table
       public DataTable HolidayDeleteLogically(string hId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpholidayDeleteLogically", true));
           cmd.Parameters.Add("@holidayId", SqlDbType.Int).Value = Convert.ToInt32(hId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // Passport Table
       public DataTable PassportTypeDeleteLogically(string ptId)
       {
           SqlCommand cmd = ((SqlCommand) Object_.CreateCommand("sp_lkpPassportTypeDeleteLogically", true));
           cmd.Parameters.Add("@PassportType_ID", SqlDbType.Int).Value = Convert.ToInt32(ptId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // Visa Type Table
       public DataTable VisaTypeDeleteLogically(string vtId)
       {
           SqlCommand cmd = ((SqlCommand) Object_.CreateCommand("sp_lkpVisaTypeDeleteLogically", true));
           cmd.Parameters.Add("@VisaType_ID", SqlDbType.Int).Value = Convert.ToInt32(vtId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // Relationship Table
       public DataTable RelationshipDeleteLogically(string rId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpRelationshipDeleteLogically", true));
           cmd.Parameters.Add("@Relationship_ID", SqlDbType.Int).Value = Convert.ToInt32(rId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // lkpAgency Table
       public DataTable AgencyDeleteLogically(string agId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpAgencyDeleteLogically", true));
           cmd.Parameters.Add("@Agency_ID", SqlDbType.Int).Value = Convert.ToInt32(agId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
       // 
       public DataTable DepartmentDeleteLogically(string dId)
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_lkpDepartmentDeleteLogically", true));
           cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = Convert.ToInt32(dId);
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
    }
    
    }

