using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB
{
    public partial class Paiement : System.Web.UI.Page
    {
        private List<Hebergement> reserver;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Reserver"] == null)
            {
                this.Label1.Text = "<div class=\"alert alert-danger\" role=\"alert\">Vous n'avez actuellement pas de reservation !</div>";
            }
            else
            {
                this.Label1.Text = "";
            }

            this.reserver = (List<Hebergement>)Session["Reserver"];

            if (!IsPostBack)
            {
                this.gdvReserver.DataSource = this.reserver;
                this.gdvReserver.DataBind();

            }

            //Session.Remove("Reserver");

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).CommandArgument);
            Hebergement article = this.reserver.Where(a => a.IdHebergement == id).First();

            if (article != null)
            {

                this.reserver.Remove(article);

                Response.Redirect("Paiement.aspx");
            }
        }
    }
}