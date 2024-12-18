using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchly.Entites
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; } = null!;
        public decimal Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        // Fk && Navigation Properties
        public int UserId {  get; set; }
        public User User { get; set; }

        // FK && Navigation Properties
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
