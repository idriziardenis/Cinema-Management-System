using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Ticket
    {
        public int ID { get; set; }
        public Cinema Cinema { get; set; }
        public Booking Booking { get; set; }
        public Payment Payment { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }
        public DateTime Date { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
