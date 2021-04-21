using Montres.DAO;
using Montres.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Montres
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error_login.Visible = false;

            ParteDAO dao = new ParteDAO();
            dao.Filtrar("(28X9-15) 8.15-15 / ADDO INDIA NEUMATICA");
        }

        protected void click_Button(object sender, EventArgs e)

        {
            LoginDAO dao = new LoginDAO();
          int res=   dao.consultamenu(new Usuario1(user.Text, contra.Text));

            if (res == 1)
            {

                Response.Redirect("Home.aspx");
            }
            else {
                error_login.Visible=true;
            }
            


        }

       

    }
}