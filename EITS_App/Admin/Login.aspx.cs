// User name: zaheerkhan
// Password : welcome!

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

namespace EITS_App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FormsAuthentication.SignOut();
                Roles.DeleteCookie();
                Session.Clear();
            }
        }

        protected void Login1_LoginError(object sender, EventArgs e)
        {
            Login1.FailureText = "Your login attempt was not successful. Please try again.";
            MembershipUser usrInfo = Membership.GetUser(Login1.UserName);
            if (usrInfo != null)
            {
                if (usrInfo.IsLockedOut)
                {
                    Login1.FailureText = "Your account has been locked out because of too many invalid login attempts. Please contact the administrator to have your account unlocked.";
                }
                else if (!usrInfo.IsApproved)
                {
                    Login1.FailureText = "Your account has not yet been approved. You cannot login until an administrator has approved your account.";
                }
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }


        protected void LoginButton_Click1(object sender, EventArgs e)
        {
            string strUserId;
            string[] strRole;
            strUserId = "";
            strUserId = this.Login1.UserName.ToString();
            MembershipUser user = Membership.GetUser(strUserId);
            bool isOnline = user.IsOnline; 
            if (strUserId != "" && user != null)
            {
                Session["UserId"] = user.ProviderUserKey;
                Session["UserName"] = user.UserName.ToString();
                strRole = Roles.GetRolesForUser(user.UserName.ToString());
                Session["Role"] = strRole[0].ToString();
            }
            else
            {
              isOnline = false;
                Session["UserId"] = "";
                Session["UserName"] = "";
                Session["Role"] = "";
                return;
            }
        }
    }
}
