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
    public partial class Avis : System.Web.UI.Page
    {
        private Hebergement hebergement;
        Client client;

        protected void Page_Load(object sender, EventArgs e)
        {
                client = (Client)Session["Client"];
                hebergement = (Hebergement)Session["Avis"];

                this.lblClient.Text = hebergement.Nom;
                this.lblNumero.Text = hebergement.adresse.Numero;

                this.lblVoie.Text = hebergement.adresse.Voie;
                string url = "/Images/";
                this.lblPhoto.ImageUrl = url + hebergement.Photo;
        }

        protected void btnAvis_Click(object sender, EventArgs e)
        {

            int idclient = client.IdClient;
            int idhebergement = hebergement.IdHebergement;


            decimal note = Convert.ToInt32(this.txtNote.Text);
            string commentaire = this.txtCommentaire.Text;
            bool etat = true;


            DaoReservation daoAvis = new DaoReservation();
            daoAvis.createAvis(idclient, idhebergement, note, commentaire, etat, 5);

            Response.Redirect("./Reservation.aspx");
        }


    }
}