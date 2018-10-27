using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiControllers.Models
{
    public class Reservation
    {
        public int Reservationid { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }
}
