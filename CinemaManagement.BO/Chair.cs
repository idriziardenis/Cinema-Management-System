using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Chair
    {
        public int ID { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public bool isBooked { get; set; } = false;
        public BaseAudit BaseAuditObject { get; set; }

    }
}
