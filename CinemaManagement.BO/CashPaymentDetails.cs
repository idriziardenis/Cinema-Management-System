using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class CashPaymentDetails
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
