using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginsT1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //verificar as credenciais
            if(tbEmail.Text=="joaquim@gmail.com" &&
                tbPassword.Text == "12345")
            {
                Session["email"] = "joaquim@gmail.com";
                Session["perfil"] = "admin";
                Session["data_login"] = DateTime.Now;
                Response.Redirect("segura.aspx");
            }
            if (tbEmail.Text == "maria@gmail.com" &&
                tbPassword.Text == "12345")
            {
                Session["email"] = "maria@gmail.com";
                Session["perfil"] = "util";
                Session["data_login"] = DateTime.Now;
                Response.Redirect("segura.aspx");
            }
            //login falhou
            Label1.Text = "Login falhou.Tente novamente.";
        }
    }
}