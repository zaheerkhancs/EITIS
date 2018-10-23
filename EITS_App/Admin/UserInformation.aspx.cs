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
    public partial class UserInformation : EITS_App.BaseController.BaseController 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.QueryString["user"];
            if (string.IsNullOrEmpty(userName))
                Response.Redirect("ManageUsers.aspx");
            MembershipUser usr = Membership.GetUser(userName);
            if (usr == null)
                Response.Redirect("ManageUsers.aspx");

            UserNameLabel.Text = usr.UserName;
            IsApproved.Checked = usr.IsApproved;

            if (usr.LastLockoutDate.Year < 2000)
                LastLockoutDateLabel.Text = string.Empty;
            else
                LastLockoutDateLabel.Text = usr.LastLockoutDate.ToShortDateString();

            UnlockUserButton.Enabled = usr.IsLockedOut;
        }

        protected void IsApproved_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the user's approved status
            string userName = Request.QueryString["user"];
            MembershipUser usr = Membership.GetUser(userName);
            usr.IsApproved = IsApproved.Checked;
            Membership.UpdateUser(usr);

            StatusMessage.Text = "The user's approved status has been updated.";
        }

        protected void UnlockUserButton_Click(object sender, EventArgs e)
        {
            // Unlock the user account
            string userName = Request.QueryString["user"];
            MembershipUser usr = Membership.GetUser(userName);
            usr.UnlockUser();

            UnlockUserButton.Enabled = false;
            StatusMessage.Text = "The user account has been unlocked.";
        }
    }
}
