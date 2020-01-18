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
    public partial class Reservation : System.Web.UI.Page
    {
        private List<Hebergement> reserver;

        protected void Page_Load(object sender, EventArgs e)
        {
            //BackOffice MasterPage = (BackOffice)Page.Master;
            //Client client1 = MasterPage.client;

            Client client = null;

            if (Session["Client"] != null)
            {
                client = (Client)Session["Client"];
                this.reserver = this.loadReservation(client.IdClient);

                if (this.reserver != null)
                {
                    this.Label1.Text = "";
                }
                else
                {
                    this.Label1.Text = "<div class=\"alert alert-danger\" role=\"alert\">Vous n'avez actuellement pas de reservation !</div>";
                }
            }

            if (client == null)
            {
                Response.Redirect("Connexion.aspx");
            }


            if (!IsPostBack)
            {
                this.gdvReserver.DataSource = this.reserver;
                this.gdvReserver.DataBind();

            }

        }
        private List<Hebergement> loadReservation(int idclient)
        {
            DaoReservation daoReservation = new DaoReservation();
            return daoReservation.GetReservation(idclient, 1);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).CommandArgument);
            Hebergement article = this.reserver.Where(a => a.IdHebergement == id).First();

            if (article != null)
            {

                this.reserver.Remove(article);

                Response.Redirect("Favoris.aspx");
            }
        }
    }
}