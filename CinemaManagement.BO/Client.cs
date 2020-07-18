using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegisteredDate { get; set; }
        public Gender Gender { get; set; }
        public BaseAudit BaseAuditObject { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
