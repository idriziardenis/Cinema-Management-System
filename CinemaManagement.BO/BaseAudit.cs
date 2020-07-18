using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class BaseAudit
    {
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }

        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public int UpdateNo { get; set; }
    }
}
