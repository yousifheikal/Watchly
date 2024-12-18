using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchly.ENum;

namespace Watchly.Entites
{
    public class Cast
    {
        public int CastId { get; set; }
        public string CharacterName { get; set; } = null!;
        public string ActorName { get; set; } = null!;
        public RoleType RoleType { get; set; }
        public string? Note { get; set; }
        
        // Foreign Key
        public int MovieId { get; set; }

        //RelationShip
        public Movie Movies { get; set; } 
    }
}
