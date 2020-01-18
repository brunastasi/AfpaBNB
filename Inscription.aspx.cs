using AFPABNB.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB
{
    public partial class Inscription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {

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

            string type = this.txtType.Text;


            DaoClient daoClient = new DaoClient();
            daoClient.createClient(nom, prenom, numero, voie, ville, codepostal, telephone, login, password, email, type, 12);

            Response.Redirect("Connexion.aspx");

        }
    }
}