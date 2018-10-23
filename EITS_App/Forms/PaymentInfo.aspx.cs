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
    public partial class PaymentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _SearchStaff();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchStaff();
        }

        public void _SearchStaff()
        {
            EITSDB _objDB = new EITSDB();
            try
            {
                DataTable dt = new DataTable();
                dt = _objDB.tblStaffCollection.GetAsDataTable("LastName LIKE '%" + txtSearchLastName.Text.Trim() + "%'", "FirstName");
                _gvList.DataSource = dt;
                _gvList.DataBind();
            }
            finally
            {
                _objDB.Dispose();
            }


        }
    }
}
