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
using System.Data.SqlClient;


namespace ReportConnection
{
	/// <summary>
	/// Description of SDBC.
	/// </summary>
    public class ReportCon
    {
        SqlConnectionStringBuilder csb;
        string stDatabaseUser, stDatabasePass;


        public string DatabasePassword
        {
            get { return stDatabasePass; }
            //set { stDatabasePass = value; }
        }

        public string DatabaseUserName
        {
            get { return stDatabaseUser; }
            //set { stDatabaseUser = value; }
        }
        /// <summary>
        /// This method is the Constructor of this class and it initailizes the Connection
        /// After This Method you Must Initailize the Connection
        /// </summary>
        public ReportCon()
        {
            InitailizeConnection();
            
        }
        /// <summary>
        /// This method creates the connection using the xml file
        /// </summary>
        public void InitailizeConnection()
        {
            csb = new SqlConnectionStringBuilder();
            DataSet ds = new DataSet();
            HttpServerUtility _objServer = HttpContext.Current.Server;
            
            ds.ReadXml(_objServer.MapPath( "~\\Bin\\dbConnection.xml"));
            csb.DataSource = ds.Tables[0].Rows[0][0].ToString();
            csb.InitialCatalog = ds.Tables[0].Rows[0][1].ToString();
            csb.IntegratedSecurity = false;
            csb.UserID = stDatabaseUser = ds.Tables[0].Rows[0][2].ToString();
            csb.Password = stDatabasePass = ds.Tables[0].Rows[0][3].ToString();
        }
        }

    }      