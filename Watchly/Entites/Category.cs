using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchly.Entites
{
    public class Category
    {
        // Relation (Many To Many) Between Movie Create new Entity (MovieCategory)
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public ICollection<MovieCategory> MovieCategories { get; set; } = new List<MovieCategory>();

    }
}
