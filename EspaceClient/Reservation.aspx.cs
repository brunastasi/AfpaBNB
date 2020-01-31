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
        private List<Hebergement> hebergements;
        private List<Hebergement> reserver;
        private List<Hebergement> paiement;
        //private List<Hebergement> avis;

        protected void Page_Load(object sender, EventArgs e)
        {

            Client client = null;

            if (Session["Client"] != null)
            {
                client = (Client)Session["Client"];
                this.reserver = this.loadReservation(client.IdClient);
                this.hebergements = this.loadHebergements();

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

        private List<Hebergement> loadHebergements()
        {
            DaoHebergement daoHebergement = new DaoHebergement();
            return daoHebergement.GetHebergements();
        }

        private List<Hebergement> loadReservation(int idclient)
        {
            DaoReservation daoReservation = new DaoReservation();
            return daoReservation.GetReservation(idclient, 1);
        }

        protected void btnPaiement_Click(object sender, EventArgs e)
        {

            int idhebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            Hebergement hebergement = null;
            foreach (Hebergement item in this.hebergements)
            {
                if (item.IdHebergement == idhebergement)
                {
                    hebergement = item;
                    /*have*/
                    break; //have kitkat
                }
            }

            if (Session["Paiement"] != null)
            {
                this.paiement = (List<Hebergement>)Session["Paiement"];

                foreach (Hebergement item in this.paiement)
                {
                    if (item.IdHebergement == hebergement.IdHebergement)
                    {
                        Response.Redirect("/EspaceClient/Paiement.aspx");
                    }
                    else
                    {
                        this.paiement = (List<Hebergement>)Session["Paiement"];
                    }
                }
            }
            else
            {
                this.paiement = new List<Hebergement>();
            }

            this.paiement.Add(hebergement);

            Session["Paiement"] = this.paiement;
            Response.Redirect("/EspaceClient/Paiement.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Client client = (Client)Session["Client"];
            int idhebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            DaoReservation daoReservation = new DaoReservation();
            List<Hebergement> mesReservations = daoReservation.GetReservation(client.IdClient, 1);

            foreach (Hebergement item in mesReservations)
            {
                if (item.IdHebergement == idhebergement)
                {
                    daoReservation.DelReservation(client.IdClient, idhebergement);
                    Response.Redirect("../EspaceClient/Reservation.aspx");
                    /*have*/
                    break; //have kitkat
                }
            }
        }

        protected void btnAvis_Click(object sender, EventArgs e)
        {

            int idhebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            Hebergement hebergement = null;

            hebergement = hebergements.Where(h => h.IdHebergement == idhebergement).First();


            Session["Avis"] = hebergement;
            Response.Redirect("/EspaceClient/Avis.aspx");
        }
    }
}