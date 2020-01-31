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
    public partial class ListeHebergements : System.Web.UI.Page
    {
        private List<Hebergement> hebergements;
        private List<Hebergement> detail;

        protected void Page_Load(object sender, EventArgs e)
        {
            //string ddlDepartement = "";
            //string ddlTypeHebergement = "";
            //if (Page.PreviousPage != null)
            //{
            //    DropDownList ddlHebergement = <DropDownList> PreviousPage.FindControl("ddlDepartement");
            //    DropDownList ddlTypeHebergement = <DropDownList> PreviousPage.FindControl("ddlTypeHebergement");

            //    if (ddlDepartement != null && string isNullOrEmpty(ddlDepartement.SelectedValue))
            //    ddlDepartement = ddlDepartement.SelectedValue;

            //    if (ddlTypeHebergement != null && string isNullOrEmpty(ddlTypeHebergement.SelectedValue){
            //        ddlTypeHebergement = ddlTypeHebergement.SelectValue;
            //    }
            //}

            this.hebergements = this.loadHebergements();

            if (!IsPostBack)
            {
                this.lvwArticle.DataSource = this.hebergements;
                this.lvwArticle.DataBind();
            }
        }

        private List<Hebergement> loadHebergements()
        {
            DaoHebergement daoHebergement = new DaoHebergement();
            return daoHebergement.GetHebergements();
        }

        protected void lvwArticle_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            this.dtpArticle.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            this.lvwArticle.DataSource = this.hebergements;
            this.lvwArticle.DataBind();
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

        protected void Detail_Click(object sender, EventArgs e)
        {

            int idhebergement = Convert.ToInt32(((LinkButton)sender).CommandArgument);

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

            if (Session["Detail"] != null)
            {
                this.detail = (List<Hebergement>)Session["Detail"];

                foreach (Hebergement item in this.detail)
                {
                    if (item.IdHebergement == hebergement.IdHebergement)
                    {
                        Response.Redirect("DetailHebergement.aspx");
                    }
                    else
                    {
                        this.detail = (List<Hebergement>)Session["Detail"];
                    }
                }
            }
            else
            {
                this.detail = new List<Hebergement>();
            }

            this.detail.Add(hebergement);

            Session["Detail"] = this.detail;
            Response.Redirect("DetailHebergement.aspx");
        }

    }
}