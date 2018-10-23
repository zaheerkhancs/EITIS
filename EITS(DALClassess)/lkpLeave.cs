using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IOM.EITS.DAL;

namespace IOM.EITS.DAL
{
    public  class LkpLeave:IDisposable
    {
        private EITSDB obj_=null;
        private  bool isDisposed = false;
       

        public void Dispose()
        {
            if(null!=obj_ )
            {
                obj_.Dispose();
                isDisposed = true;
            }
        }
        public LkpLeave()
        {
            obj_ = new EITSDB();
        }
        public EITSDB ObjectDB
        {
            get { return obj_; }
        }

        public DataTable GetLeaveRecord()
        {
            SqlCommand cmd = ((SqlCommand)obj_.CreateCommand("sp_getlkpLeaveRec", true));
            DataTable _dt = obj_.CreateDataTable(cmd);
            return _dt;
        }

        //
        public DataTable LeavelistDeleteLogically(string  leave_Id)
        {
            SqlCommand cmdSelect = ((SqlCommand) obj_.CreateCommand("sp_leave_deletelogically",true ));
            cmdSelect.Parameters.Add("@@_leaveId", SqlDbType.Int).Value = Convert.ToInt32( leave_Id);
            DataTable dt_dll = obj_.CreateDataTable(cmdSelect);
            return dt_dll;
        }
    }
}
