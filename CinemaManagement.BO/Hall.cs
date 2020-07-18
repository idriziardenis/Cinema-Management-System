using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Hall
    {
        public int ID { get; set; }
        public int NoRow { get; set; }
        public int NoColumn { get; set; }
        public string Name { get; set; }
        public Technology Technology { get; set; }
        public BaseAudit BaseAuditObject { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
