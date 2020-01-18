using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNB.Entities
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}