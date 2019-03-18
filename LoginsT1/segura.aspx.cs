using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginsT1
{
    public partial class segura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se o utilizador tem sessão iniciada
            if (Session["email"] == null)
            {
                Response.Redirect("index.aspx");
            }
            if (Session["perfil"].ToString() != "admin")
            {
                Response.Redirect("menossegura.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //terminar sessão
            Session.Clear();
            Response.Redirect("index.aspx");
        }
    }
}