using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebMySQL01
{
    public partial class index : System.Web.UI.Page
    {
        DBconnect ligacao = new DBconnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNFormandos.Text = ligacao.Count().ToString();
            lblMedia.Text = ligacao.Media().ToString("F2");
            if(!Page.IsPostBack)
            {
                lblMsg.Text = Request.QueryString["r"];
                ligacao.Bind(ref GridView1);
                GridView1.DataBind();
                //GridView1.PageIndexChanging += GridView1_PageIndexChanging
                lblUser.Text = Session["username"].ToString();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormInsert.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormDelete.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Altera o índice de página da GridView
            GridView1.PageIndex = e.NewPageIndex;

            // Recarrega os dados na GridView
            ligacao.Bind(ref GridView1);
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormUpdate.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}