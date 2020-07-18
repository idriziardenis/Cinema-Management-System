using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public EventType EventType { get; set; }
        public string Description { get; set; }
        public double Sales { get; set; }
        public string ImagePath { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Movie Movie { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
