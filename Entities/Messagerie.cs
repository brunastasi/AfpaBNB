using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNB.Entities
{
    public class Messagerie
    {
        public int IdMessagerie { get; set; }
        public int IdExpediteur { get; set; }
        public int IdDestinataire { get; set; }
        public string Messages { get; set; }
        public DateTime Date { get; set; }
        public bool Statut { get; set; } 

    }
}