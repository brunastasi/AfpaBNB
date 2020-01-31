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
    public partial class EspaceClient : System.Web.UI.MasterPage
    {
        public Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            //BackOffice MasterPage = (BackOffice)Page.Master;
            ////MasterPage.Client;

            //Client client = MasterPage.client;

            Client client = null;

            if (Session["Client"] != null)
            {
                client = (Client)Session["Client"];

                this.lblNom.Text = "" + client.Nom + " " + client.Prenom;

            }

            if (client == null)
            {
                Response.Redirect("../Connexion.aspx");
            }
            else
            {
                //StringBuilder stringBuilder = new StringBuilder();
                //stringBuilder.AppendLine("<a class='nav-link' href='default.aspx'>Accueil</a>");
                //stringBuilder.AppendLine("<a class='nav-link' href='listehebergements.aspx'>Hebergements</a>");
                //stringBuilder.AppendLine("<a class='nav-link' href='favoris.aspx'> Mes Favoris</a>");
                //stringBuilder.AppendLine("<a class='nav-link' href='reservations.asp'>Mes Reservations</a>");

                //this.ltlNav.Text = stringBuilder.ToString();

                //if(client.Nom == "toto")
                //{
                //    stringBuilder.AppendLine("<a href = '#' > Accueil </ a >");
                //}
            }
        }

        protected void Deconnexion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("../Default.aspx");
        }
    }
}