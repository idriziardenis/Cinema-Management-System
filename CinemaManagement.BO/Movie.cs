using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Category Category { get; set; }
        public bool isActive { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }
        public string TrailerLink { get; set; }
        public int MinimumAge { get; set; }
        public BaseAudit BaseAuditObject { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
