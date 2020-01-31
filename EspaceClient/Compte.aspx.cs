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
    public partial class Compte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Client client = null;

            if (Session["Client"] != null)
            {
                client = (Client)Session["Client"];

                //this.lblNom.Text = "Bonjour, " + client.Prenom;
            }

            if (client == null)
            {
                Response.Redirect("Connexion.aspx");
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Client client = (Client)Session["Client"];

            int idclient = client.IdClient;

            string nom = this.txtNom.Text;
            string prenom = this.txtPrenom.Text;

            string numero = this.txtNumero.Text;
            string voie = this.txtVoie.Text;
            string ville = this.txtVille.Text;
            string codepostal = this.txtCodePostal.Text;
            string telephone = this.txtTelephone.Text;

            string login = this.txtLogin.Text;
            string password = this.txtPassword.Text;
            string email = this.txtEmail.Text;

            bool type = Convert.ToBoolean(this.txtType.Text);


            DaoClient daoClient = new DaoClient();
            daoClient.updateClient(idclient, nom, prenom, numero, voie, ville, codepostal, telephone, login, password, email, type, 13);

            Response.Redirect("./Compte.aspx");

        }
    }
}