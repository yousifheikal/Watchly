using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchly.Entites
{
    public class Movie
    {
        public int MovieId {  get; set; }
        public string MovieName { get; set; } = null!; // Null-Forgiving Operator
        public string Title { get; set; } = null!;
        public string? Description { get; set; } // Short synopsis
        public DateTime ReleaseDate { get; set; } = DateTime.UtcNow; // Default value
        public int Duration { get; set; }
        public string? Language { get; set; }

        public ICollection<MovieCategory> MovieCategories { get; set; } = new List<MovieCategory>();
        public ICollection<Cast> Casts { get; set; } = new List<Cast>(); // One-to-Many relationship
        public ICollection<Review> Reviews { get; set; } = new List<Review>(); // One-to-Many relationship
        public ICollection<WatchList> WatchLists { get; set; } = new List<WatchList>();
    }
}
