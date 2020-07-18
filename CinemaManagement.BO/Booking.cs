using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Booking
    {
        public int ID { get; set; }
        public Client Client { get; set; }
        public Schedule Schedule { get; set; }
        public Chair Chair { get; set; }
        public BaseAudit BaseAuditObject { get; set; }

    }
}
