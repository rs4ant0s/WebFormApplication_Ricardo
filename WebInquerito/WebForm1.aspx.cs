using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebInquerito
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            txbNome.MaxLength = 60;
        }

        protected void btnSubmeter_Click(object sender, EventArgs e)
        {
            string display = "", comida = "", clube = "";

            if (cbPizza.Checked)
            {
                comida = cbPizza.Text;
            }
            if(cbBife.Checked) 
            {
                if(comida.Length > 0) 
                {
                    comida = comida + ", ";
                }
                comida = comida + cbBife.Text;
            }
            if (cbRefogado.Checked) 
            {
                if (comida.Length > 0)
                {
                    comida = comida + " e ";
                }
                comida = comida + cbRefogado.Text;
            }
            
            if(rbFcp.Checked) 
            {
                clube =rbFcp.Text;
            }
            else if (rbSlb.Checked) 
            {
                clube =rbSlb.Text;
            }
            else if (rbScp.Checked) 
            {
                clube =rbScp.Text;
            }

            display = txbNome.Text + " vive em " + lbDistrito.Text + ", gosta de comer " + comida +
                " e o seu clube de coração é o " + clube;
            //display = txbNome.Text + " vive em \\n" + lbDistrito.Text + ", gosta de comer " + comida +
            //    " e o seu clube de coração é o " + clube;
            Label1.Text = display;
          
            ClientScript.RegisterStartupScript(this.GetType(), "Mensagem",
                "alert('" + display + "');",true);

            DBConnect ligacao = new DBConnect();
            if (ligacao.Insert(txbNome.Text,lbDistrito.Text,comida,clube))
            {
                Label1.Text = "Inseriu com sucesso!";
            }
            else 
            {
                Label1.Text = "Erro na inserção!";
            }
        }
    }
}