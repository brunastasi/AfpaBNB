using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNB.Entities
{
    public class Reservation
    {
        public int idReservation { get; set; }
        public int idClient { get; set; }
        public int idHebergement { get; set; }
        public DateTime DateReservation { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public decimal Prix { get; set; }
    }
}