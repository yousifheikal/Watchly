using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchly.Entites
{
    public class WatchList
    {
        public int WatchListID { get; set; }
        public DateTime AddedDate { get; set; }

        // Foreign Keys
        public int UserID { get; set; }
        public int MovieID { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}
