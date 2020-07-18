using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class ChairClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal PriceIncreasePercentage { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
