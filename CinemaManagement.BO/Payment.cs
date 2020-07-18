using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Payment
    {
        public int ID { get; set; }
        public CashPaymentDetails CashPaymentDetails { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
