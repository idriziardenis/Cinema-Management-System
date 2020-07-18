using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class ClientPremiumDetails
    {
        public int ID { get; set; }
        public DateTime SubscribedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Discount { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
