using AFPABNB.Dao;
using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB.EspaceClient
{
    public partial class Favoris : System.Web.UI.Page
    {
        private List<Hebergement> favoris;

        protected void Page_Load(object sender, EventArgs e)
        {
            //BackOffice MasterPage = (BackOffice)Page.Master;
            //Client client1 = MasterPage.client;

            Client client = null;

            if (Session["Client"] != null)
            {
                client = (Client)Session["Client"];
                this.favoris = this.loadFavoris(client.IdClient);

                if (this.favoris != null)
                {
                    this.Label1.Text = "";
                }
                else
                {
                    this.Label1.Text = "<div class=\"alert alert-danger\" role=\"alert\">Vous n'avez actuellement pas de favoris !</div>";
                }
            }

            if (client == null)
            {
                Response.Redirect("../Connexion.aspx");
            }


            if (!IsPostBack)
            {
                this.gdvFavoris.DataSource = this.favoris;
                this.gdvFavoris.DataBind();

            }

        }
        private List<Hebergement> loadFavoris(int idclient)
        {
            DaoFavoris daoFavoris = new DaoFavoris();
            return daoFavoris.GetFavoris(idclient, 1);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).CommandArgument);
            Hebergement article = this.favoris.Where(a => a.IdHebergement == id).First();

            if (article != null)
            {

                this.favoris.Remove(article);

                Response.Redirect("Favoris.aspx");
            }
        }
    }
}