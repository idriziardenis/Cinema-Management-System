using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Cinema
    {
        public int ID { get; set; }
        public string CinemaAdress { get; set; }
        public string FiscalNumber { get; set; }
        public string CinemaLogoPath { get; set; }
        public BaseAudit BaseAuditObject { get; set; }
    }
}
