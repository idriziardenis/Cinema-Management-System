using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Schedule
    {
        public int ID { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public bool isMaintained { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
