using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalendario
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";

            if (!IsPostBack) 
            {
                int i;
                for (i= 1; i<= 31; i++) 
                {
                    DropDownListdDia.Items.Add(i.ToString());
                }

                for (i = 1; i <= 12; i++)
                {
                    DropDownListMes.Items.Add(i.ToString());
                }

                //for (i=1900; i <= DateTime.Today.Year ; i++)
                //{
                //      DropDownListAno.Itens.Add(i.ToString());
                //}

                for (i = DateTime.Today.Year; i >= 1900; i--)
                {
                    DropDownListAno.Items.Add(i.ToString());
                }

                DropDownListAno.Items.FindByText("2000").Selected = true;

            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
            //Label2.Text = Calendar1_SelectedSate.ToString().Substring(0,10);
            Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Label2.Text == "") 
            {
                Label1.Text = "Tem que indicar uma data!";
            }
            else
            {
                DateTime datanascimento = Calendar1.SelectedDate, today = DateTime.Today;
                int age = today.Year - datanascimento.Year;

                if(datanascimento > today.AddYears(-age)) 
                {
                    //Significa que ainda não fez anos 
                    Label3.Text =" Ainda falta(m) " + (datanascimento.AddYears(age)-today).TotalDays.ToString() + "dia(s) para o aniversário";
                    age--;
                } 
                else
                {
                    //Significa que já fez anos 
                    Label3.Text = "Ainda falta(m)" + (datanascimento.AddYears(age + 1) - today).TotalDays.ToString() + "dia(s) para o aniversário";
                }
                Label1.Text = age.ToString()+" anos";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try 
            {
                DateTime dateTime = Convert.ToDateTime(TextBox1.Text);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                Label2.Text = Calendar1.SelectedDate.ToShortDateString();
                Label3.Text = "";
            }
            catch 
            {
                //TextBox1.Text = "Data incorrecta!";
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name:" + TextBox1.Text + "');", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string data = DropDownListdDia.SelectedValue + "/" + DropDownListMes.SelectedValue + "/" + DropDownListAno.SelectedValue;
            try 
            {
                DateTime dateTime = Convert.ToDateTime(data);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                Label2.Text = Calendar1.SelectedDate.ToShortDateString();
                TextBox1.Text = data;
                Label3.Text = "";
            }
            catch 
            {
                TextBox1.Text = "Data incorrecta!";
            }
        }
    }
}