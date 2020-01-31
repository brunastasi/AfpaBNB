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
    public partial class DetailHebergement : System.Web.UI.Page
    {
        private List<Hebergement> detail; 

        protected void Page_Load(object sender, EventArgs e)
        {

            this.detail = (List<Hebergement>)Session["Detail"];


            if (!IsPostBack)
            {
                this.gdvDetail.DataSource = this.detail;
                this.gdvDetail.DataBind();

            }

            Session.Remove("Detail");
        }

        protected void Favoris_Click(object sender, EventArgs e)
        {

            Client client = (Client)Session["Client"];
            int idhebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            DaoFavoris daoFavoris = new DaoFavoris();

            List<Hebergement> mesFavoris = daoFavoris.GetFavoris(client.IdClient, 1);
            if (mesFavoris != null)
            {
                bool existe = false;
                foreach (Hebergement item in mesFavoris)
                {
                    if (item.IdHebergement == idhebergement)
                    {
                        existe = true;
                        /*have*/
                        break; //have kitkat
                    }
                }
                if (!existe)
                {
                    daoFavoris.createFavoris(client.IdClient, idhebergement, 2);
                }
            }
            else
            {
                daoFavoris.createFavoris(client.IdClient, idhebergement, 2);
            }

            Response.Redirect("/EspaceClient/Favoris.aspx");

        }

        protected void Reserver_Click(object sender, EventArgs e)
        {

            Client client = (Client)Session["Client"];
            int idhebergement = Convert.ToInt32(((Button)sender).CommandArgument);

            DaoReservation daoReservation = new DaoReservation();

            List<Hebergement> mesReservations = daoReservation.GetReservation(client.IdClient, 1);
            if (mesReservations != null)
            {
                bool existe = false;
                foreach (Hebergement item in mesReservations)
                {
                    if (item.IdHebergement == idhebergement)
                    {
                        existe = true;
                        /*have*/
                        break; //have kitkat
                    }
                }
                if (!existe)
                {
                    daoReservation.createReservation(client.IdClient, idhebergement, 2);
                }
            }
            else
            {
                daoReservation.createReservation(client.IdClient, idhebergement, 2);
            }

            Response.Redirect("/EspaceClient/Reservation.aspx");

        }

        protected void Contact_Click(object sender, EventArgs e)
        {

            //Client client = null;
            //client = (Client)Session["Client"];
            
            //Hebergement hebergement;
            //hebergement = (Hebergement)Session["Detail"];

            //int idexpediteur = client.IdClient;
            //int iddestinataire = hebergement.IdClient;


            //string messages = "test";

            //string date = "20/20/2021";
            //bool statut = true;


            //DaoMessagerie daoMessagerie = new DaoMessagerie();
            //daoMessagerie.createMessage(idexpediteur, iddestinataire, messages, date, statut);

            //Response.Redirect("./ok.aspx");
        }
    }
}