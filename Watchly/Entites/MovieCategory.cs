using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchly.Entites
{
    public class MovieCategory
    {
        // Primary Key
        public int MovieId { get; set; }
        public Movie Movie { get; set; } // Navigation Represent Entity Movie

        // Primary Key
        public int CategoryId { get; set; }
        public Category Categories { get; set; } // Navigation Represent Entity Category
    }
}
