using AFPABNB.Dao;
using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB
{
    public partial class Connexion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Client client = null;

            if (Session["Client"] != null)
            {
                //client = (Client)Session["Client"];
                Response.Redirect("/EspaceClient/Compte.aspx");
            }

        }

        protected void btnValider_Click(object sender, EventArgs e)
        {

            string login = this.txtLogin.Text;
            string password = this.txtPassword.Text;

            DaoClient daoClient = new DaoClient();
            Client client = daoClient.GetClient(login, password);

            if (client != null)
            {
                Session["client"] = client;
                //this.lblMessage.Text = "<div class=\"alert alert-danger\" role=\"alert\">OK</div>";
                Response.Redirect("/EspaceClient/Compte.aspx");
            }
            else
            {
                this.lblMessage.Text = "<div class=\"alert alert-danger\" role=\"alert\">Veuillez crée un compte !</div>";
            }

        }
    }
}