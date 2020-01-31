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
    public partial class Messageries : System.Web.UI.Page
    {
        private List<Messagerie> messageries;
        Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = (Client)Session["Client"];

            messageries = loadMessagerie(14, 5);

            if (!IsPostBack)
            {
                this.gdvMessagerie.DataSource = this.messageries;
                this.gdvMessagerie.DataBind();
            }

        }

        private List<Messagerie> loadMessagerie(int idexpediteur, int iddestinataire)
        {
            DaoMessagerie daoMessagerie = new DaoMessagerie();
            return daoMessagerie.GetMessage(idexpediteur, iddestinataire);
        }

        protected void btnAddMessage_Click(object sender, EventArgs e)
        {

            int idexpediteur = client.IdClient;
             int iddestinataire = Convert.ToInt32(this.txtDestinataire.Text);


            string messages = this.txtMessages.Text;
            string date = this.txtDate.Text;
            bool statut = true;


            DaoMessagerie daoMessagerie = new DaoMessagerie();
            daoMessagerie.createMessage(idexpediteur, iddestinataire, messages, date, statut);

            Response.Redirect("./ok.aspx");
        }
    }
}