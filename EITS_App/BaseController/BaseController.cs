using System;
using System.Web;
using System.IO;
using System.Xml;
using System.Text;
using System.Security.Cryptography;
using System.Reflection;
using System.Configuration;
using System.Web.UI.WebControls;
using IOM.EITS.DAL;
using System.Data.Common;
using System.Collections;
using System.Web.Caching;
using System.Security;
using System.Web.Security;

namespace EITS_App.BaseController
{
    /// <summary>
    /// Summary description for BaseController.
    /// </summary>
    public class BaseController : System.Web.UI.Page
    {


        protected void LoadCache()
        {
            // Add code here if you want to load in to cache


        }

        public BaseController()
        {
        }
        protected override void OnError(System.EventArgs e)
        {
            if (HttpContext.Current.Error != null)
            {

                //EITSCommon.LogErrorToFile(HttpContext.Current.Error, HttpContext.Current.Request.FilePath.ToString(), "", "", true);
                //EITSCommon.SendErrorToMail(HttpContext.Current.Error, EITSCommon.ProjectName, HttpContext.Current.Request.FilePath.ToString(), EITSCommon.ToMail);
                Session["ErrorMsg"] = Server.GetLastError().Message;
                Response.Redirect("../DefaultError.aspx");
            }
        }

        private void EnvironmentLogin()
        {
            //Redirect the user to the Home page when Session is null
            string strUserId;
            string[] strRole;
            strUserId = "";
            strUserId = Environment.UserName;
            strRole = Roles.GetRolesForUser(strUserId);

            if (strUserId != "")
            {
                MembershipUser user = Membership.GetUser(Environment.UserName);
                //MembershipUser user = Membership.GetUser(HttpContext.Current.User.IsInRole("role"));

                Session["UserID"] = strUserId ;
                Session["UserName"] = strUserId;
                Session["Role"] = strRole[0].ToString();
                Session.Timeout = 30;
            }
            else
            {
                Response.Write("Not Authorised user");
                Response.End();
            }
        }

        protected override void OnLoad(System.EventArgs e)
        {
            //This line of code ensures that the pages are not cached by the browser
            Response.Cache.SetExpires(DateTime.Now);

            //Load Common Message file into Cache
            if (!Page.IsPostBack)
            {
                if (System.Web.HttpContext.Current.Cache["CommonMsg"] == null)
                {
                    EITSCommon.objCached.loadMsg(EITSCommon.xmlMsgFilePath);
                    System.Web.HttpContext.Current.Cache["CommonMsg"] = EITSCommon.objCached;
                    CacheDependency dependency = new CacheDependency(EITSCommon.xmlMsgFilePath);
                    System.Web.HttpContext.Current.Cache.Insert("CommonMsg", EITSCommon.objCached, dependency);
                }
                else
                {
                    EITSCommon.objCached = (Message)System.Web.HttpContext.Current.Cache["CommonMsg"];
                }
            }


            if (Session["UserId"] == null)
            {
                string authType = System.Configuration.ConfigurationSettings.AppSettings.Get("Authentication").ToString();


                //if (authType == "Windows")
                //{
                //    EnvironmentLogin();
                //    LoadCache();
                //}
                //else if (authType == "Forms")
                //{

                string pageRequested = System.IO.Path.GetFileName(Convert.ToString(Request.Url));

                if (pageRequested.ToLower().IndexOf("login.aspx") == -1)
                {
                    Response.Redirect("~//Admin//Login.aspx");//?key=Not_LoggedIn");
                }
            }
            base.OnLoad(e);
        }

    }

}
