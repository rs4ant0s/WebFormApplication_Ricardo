using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArea
{
    public partial class WebQuadrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (float.Parse("0" + txtLado.Text) * float.Parse("0" + txtLado.Text)).ToString();
            }
            catch
            {
                lblResultado.Text = "Erro!";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebMenu.aspx");
        }
    }
}