using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebMySQL01
{
    public partial class Logon : System.Web.UI.Page
    {
        DBconnect ligacao = new DBconnect();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogon_Click(object sender, EventArgs e)
        {
            if (ligacao.ValidateUser(txtUserName.Text, txtUserPass.Text)) 
            {
                
                Session["username"] = txtUserName.Text;
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
                Response.Redirect("index.aspx");
            }
            else
            {
                lblMsg.Text = " Nome ou Palavra passe icorrecto!";
                //lblMsg.Text = " a pass é " + txtUserPass.Text;
                //lblMsg.Text = " o user é " + txtUserName.Text;
            }
        }

        protected void ckbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPass.Checked) 
            {
             
                txtUserPass.TextMode = TextBoxMode.SingleLine;
                txtUserPass.Text = txtUserPass.Text;
            }
            else
            {
                txtUserPass.TextMode = TextBoxMode.Password;
                txtUserPass.Text = txtUserPass.Text;
            }
        }
    }
}