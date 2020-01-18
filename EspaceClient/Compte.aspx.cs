using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB.EspaceClient
{
    public partial class Compte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BackOffice MasterPage = (BackOffice)Page.Master;
            ////MasterPage.Client;

            //Client client = MasterPage.client;

            Client client = null;

            if (Session["Client"] != null)
            {
                client = (Client)Session["Client"];
            }

            if (client == null)
            {
                Response.Redirect("Connexion.aspx");
            }

        }
    }
}