using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB
{
    public partial class _Default : Page
    {
        private List<Hebergement> hebergements;
        private List<Hebergement> detail;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            //int idhebergement = Convert.ToInt32(((LinkButton)sender).CommandArgument);

            //Hebergement hebergement = null;
            //foreach (Hebergement item in this.hebergements)
            //{
            //    if (item.IdHebergement == idhebergement)
            //    {
            //        hebergement = item;
            //        /*have*/
            //        break; //have kitkat
            //    }
            //}

            //if (Session["Detail"] != null)
            //{
            //    this.detail = (List<Hebergement>)Session["Detail"];

            //    foreach (Hebergement item in this.detail)
            //    {
            //        if (item.IdHebergement == hebergement.IdHebergement)
            //        {
            //            Response.Redirect("Detail.aspx");
            //        }
            //        else
            //        {
            //            this.detail = (List<Hebergement>)Session["Detail"];
            //        }
            //    }
            //}
            //else
            //{
            //    this.detail = new List<Hebergement>();
            //}

            //this.detail.Add(hebergement);

            //Session["Detail"] = this.detail;
            //Response.Redirect("DetailHebergement.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListeHebergements.aspx");
        }
    }
}