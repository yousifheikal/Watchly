using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchly.Entites
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime DateJoined { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>(); // One-to-Many relationship
        public ICollection<WatchList> WatchLists { get; set; } = new List<WatchList>();

    }
}
