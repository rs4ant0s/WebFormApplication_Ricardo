using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSalarios
{
    public partial class WebSalario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                double segSocial, irs, bruto;
                if (double.TryParse(txtBruto.Text, out bruto))
                {
                    segSocial = bruto * 0.2;
                    if (bruto < 500)
                    {
                        irs = 0;
                    }
                    else if (bruto >= 500 && bruto < 1000)
                    {
                        irs = bruto * 0.12;
                    }
                    else if (bruto >= 1000 && bruto < 1500)
                    {
                        irs = bruto * 0.15;
                    }
                    else
                    {
                        irs = bruto * 0.18;
                    }

                    double liquido = bruto - segSocial - irs;
                    if (bruto < 500)
                    {
                        lblResultado.Text = "Líquido: " + liquido.ToString() + "€ não pagou IRS"; 
                    }
                    else if (bruto >= 500 && bruto < 1000)
                    {
                        lblResultado.Text = "Líquido: " + liquido.ToString() + "€ pagou uma taxa de 12% para IRS";
                    }
                    else if (bruto >= 1000 && bruto < 1500)
                    {
                        lblResultado.Text = "Líquido: " + liquido.ToString() + "€ pagou uma taxa de 15% para IRS";
                    }
                    else
                    {
                        lblResultado.Text = "Líquido: " + liquido.ToString() + "€ pagou uma taxa de 18% para IRS";
                    }
                   
                }
                else
                {
                    lblResultado.Text = "Por favor, insira um número válido para o salário bruto.";
                    txtBruto.Focus();
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Ocorreu um erro: " + ex.Message;
            }
        }
    }
}