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
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddHebergement_Click(object sender, EventArgs e)
        {

            Client client = (Client)Session["Client"];

            // JUSTE CETTE PUTAIN DE LIGNE DE MERDE POUR RECUPERE L'ID !
            int idclient = client.IdClient;


            string nomhebergement = this.txtNomHebergement.Text;
            string photo = this.txtPhoto.Text;
            string type = this.txtType.Text;
            string description = this.txtDescription.Text;

            string nomadresse = this.txtNomAdresse.Text;

            string numero = this.txtNumero.Text;
            string voie = this.txtVoie.Text;
            string ville = this.txtVille.Text;
            string codepostal = this.txtCodePostal.Text;

            DaoHebergement daoHebergement = new DaoHebergement();
            daoHebergement.createHebergement(idclient, nomhebergement, photo, type, description, nomadresse, numero, voie, ville, codepostal, 10);

            //Response.Redirect("Connexion.aspx");
        }

        //protected void test(object sender, EventArgs e)
        //{
        //    string folderPath = Server.MapPath(@"~/Images/");
        //    string imageFilename = Path.GetFileName(idaspfileupload.FileName);
        //    string blabla = folderPath + imageFilename;

        //    uploadPhoto.SaveAs(blabla);

        //}
    }
}