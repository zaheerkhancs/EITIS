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
    public partial class NewUser :EITS_App.BaseController.BaseController  
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            try
            {
                MembershipUser user = Membership.GetUser(CreateUserWizard1.UserName);
                user.Comment = CreateUserWizard1.Question;
                Membership.UpdateUser(user);
                RadioButtonList chklRoles = (RadioButtonList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("rdRole");
                if (chklRoles != null)
                {
                    Roles.AddUserToRole(CreateUserWizard1.UserName, chklRoles.SelectedValue.ToString());
                }
            }
            catch { }
        }
    }
}
