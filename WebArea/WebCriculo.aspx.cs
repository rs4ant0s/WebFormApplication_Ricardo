using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArea
{
    public partial class WebCriculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (3.14 * Math.Pow(float.Parse("0" + txtRaio.Text), 2)).ToString();

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