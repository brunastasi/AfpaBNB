using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB.EspaceClient
{
    public partial class Paiement : System.Web.UI.Page
    {
        private List<Hebergement> paiement;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.paiement = (List<Hebergement>)Session["Paiement"];

            if (!IsPostBack)
            {
                this.gdvReserver.DataSource = this.paiement;
                this.gdvReserver.DataBind();

            }

            Session.Remove("Paiement");

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).CommandArgument);
            Hebergement article = this.paiement.Where(a => a.IdHebergement == id).First();

            if (article != null)
            {

                this.paiement.Remove(article);

                Response.Redirect("Paiement.aspx");
            }
        }
    }
}