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

            Client client = null;

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

            Client client = (Client)Session["Client"];
            int idhebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            DaoFavoris daoFavoris = new DaoFavoris();
            List<Hebergement> mesFavoris = daoFavoris.GetFavoris(client.IdClient, 1);

            foreach (Hebergement item in mesFavoris)
            {
                if (item.IdHebergement == idhebergement)
                {
                    daoFavoris.DelFavoris(client.IdClient, idhebergement);
                    Response.Redirect("../EspaceClient/Favoris.aspx");
                    /*have*/
                    break; //have kitkat
                }
            }

        }
    }
}