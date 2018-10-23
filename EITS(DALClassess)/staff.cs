using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace IOM.EITS.DAL
{
    public class staff:IDisposable 
    {
        private EITSDB Object_ = null;
       private bool isDisposed = false;

       public staff() 
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
       // SP get First_Last Name staff
       public DataTable getFirstLastStaffName()
       {
           SqlCommand cmd = ((SqlCommand)Object_.CreateCommand("sp_getFirstLastStaffName", true));
           DataTable dt = Object_.CreateDataTable(cmd);
           return dt;
       }
    }
}
