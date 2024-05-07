using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMySQL01
{
    public partial class WebFormUpdate : System.Web.UI.Page
    {
        DBconnect ligacao = new DBconnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ligacao.CarregarFormandos(ref ddlFormandos);
                carregarIdades();
                ddlidades.SelectedIndex = 17;
                txtNome.Enabled = false;
                RadioButton1.Enabled= false;
                RadioButton2.Enabled= false;
                ddlidades.Enabled=false;
            }
        }

        void carregarIdades()
        {
            for (int i = 1; i <= 150; i++)
            {
                ddlidades.Items.Add(i.ToString());
            }
        }

        protected void ddlFormandos_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtNome.Enabled = true;
            RadioButton1.Enabled = true;
            RadioButton2.Enabled = true;
            ddlidades.Enabled = true;
            string nome_aux = "";
            char genero = ' ';
            string id = ddlFormandos.SelectedItem.Text;
            string idade =ddlidades.SelectedItem.Text;
            if (id.Length > 0)
            {
                id = id.Substring(0, id.IndexOf(' '));
                tbID.Text = id;
                ligacao.DevolverFormando2(id, ref nome_aux,
                    ref genero, ref idade);

                txtNome.Text = nome_aux;
                if (genero == 'F')
                {
                    RadioButton2.Checked = true;
                }
                else if (genero == 'M')
                {
                    RadioButton1.Checked = true;
                }
               
            }
            else
            {
                txtNome.Text = "";
                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                lblMsg.Text = " Formando não encontrado ";
                txtNome.Enabled = false;
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                ddlidades.Enabled = false;
            }

        }
          
        protected void btnProcurar_Click(object sender, EventArgs e)
        {
            ddlFormandos.SelectedIndex = -1;
            ddlFormandos.Enabled = true;
            txtNome.Enabled = true;
            RadioButton1.Enabled = true;
            RadioButton2.Enabled = true;
            ddlidades.Enabled = true;
            string nome_aux = "";
            char genero = ' ';
            string id = tbID.Text;
            string idade = ddlidades.SelectedItem.Text;
            if (id.Length > 0)
            {
                ligacao.DevolverFormando2(id, ref nome_aux,
                    ref genero, ref idade);

                txtNome.Text = nome_aux;
                if (genero == 'F')
                {
                    RadioButton2.Checked = true;
                }
                else if (genero == 'M')
                {
                    RadioButton1.Checked = true;
                }

            }
            else
            {
                txtNome.Text = "";
                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                lblMsg.Text = " Não colocou o ID ou Formando não encontrado ";
                txtNome.Enabled = false;
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                ddlidades.Enabled = false;
                ddlFormandos.Enabled = false;
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {

           

            if (VerificarCampos())
            {
               
                if (ligacao.Update(tbID.Text, txtNome.Text, Genero(), ddlidades.SelectedItem.Text))
                {
                    lblMsg.Text = "Atualizado com sucesso";
                    txtNome.Text = "";
                    tbID.Text = "";
                    RadioButton1.Checked = false;
                    RadioButton2.Checked = false;
                    ddlFormandos.SelectedIndex = -1;
                    ddlidades.SelectedIndex = -1;
                    ligacao.CarregarFormandos(ref ddlFormandos);
                    carregarIdades();
                    ddlidades.SelectedIndex = 17;
                    txtNome.Enabled = false;
                    RadioButton1.Enabled = false;
                    RadioButton2.Enabled = false;
                    ddlidades.Enabled = false;
                }
                else
                {
                    lblMsg.Text = "Erro na actualização do registo!";
                }

            }


        }
        private char Genero()
        {
            char genero = 'T';

            if (RadioButton2.Checked)
            {
                genero = 'F';
            }
            else if (RadioButton1.Checked)
            {
                genero = 'M';
            }
           
            return genero;
        }

        private bool VerificarCampos()
        {
            if (tbID.Text =="" )
            {
                lblMsg.Text="Erro no campo ID";
                txtNome.Focus();
                return false;
            }
           
            if (Genero() == 'T')
            {
                lblMsg.Text="tem de prrencher um género";
                RadioButton2.Focus();
                return false;
            }

            if (ddlidades.SelectedIndex == -1) 
            {
                lblMsg.Text="tem de inseri uma idade";
                ddlidades.Focus();
                return false;
            }


            return true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}