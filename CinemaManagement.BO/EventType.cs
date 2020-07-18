using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class EventType
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
        public override string ToString()
        {
            return Type;
        }
    }
}
