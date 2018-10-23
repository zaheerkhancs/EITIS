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
    public partial class EditUser : EITS_App.BaseController.BaseController 
    {

        string userName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            userName = this.Request.QueryString["UserName"];
            lblUserFeedbackOK.Visible = false;

            if (!this.IsPostBack)
            {
                MembershipUser user = Membership.GetUser(userName);
                lblUserName.Text = user.UserName;
                txtEmail.Text = user.Email;
                txtFullName.Text = user.Comment;
                lblRegistered.Text = user.CreationDate.ToString("f");
                lblLastLogin.Text = user.LastLoginDate.ToString("f");
                lblLastActivity.Text = user.LastActivityDate.ToString("f");
                chkApproved.Checked = user.IsApproved;
            }
        }

        protected void chkApproved_CheckedChanged(object sender, EventArgs e)
        {
            MembershipUser user = Membership.GetUser(userName);
            user.IsApproved = chkApproved.Checked;
            Membership.UpdateUser(user);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                MembershipUser user = Membership.GetUser(userName);
                user.Email = txtEmail.Text;
                user.Comment = txtFullName.Text;

                user.IsApproved = chkApproved.Checked;
                Membership.UpdateUser(user);
                lblUserFeedbackOK.Visible = true;
                Response.Redirect("~\\Admin\\ManageUsers.aspx");
            }
        }
    }
}
