﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNB.Entities
{
    public class Adresse
    {
        public int IdAdresse { get; set; }
        public string Nom { get; set; }
        public string Numero { get; set; }
        public string Voie { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
    }
}