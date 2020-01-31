using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNB.Entities
{
    public class Hebergement
    {
        public int IdHebergement { get; set; }
        public string Photo { get; set; }
        public string Nom { get; set; }
        public string Type { get; set; }
        public int Prix { get; set; }
        public int IdClient { get; set; }
        public string Description { get; set; }

        public Adresse adresse { get; set; }
        public Reservation reservation { get; set; }
    }
}