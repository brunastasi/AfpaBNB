﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNB
{
    public partial class Reservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["client"] != null)
            {
                Response.Redirect("Paiement.aspx");
            }
            else
            {
                Response.Redirect("Connexion.aspx");
            }
        }
    }
}