using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ActorBiography
    {
        public int ActorBiographyId { get; set; }
        public string Text { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
    }
}
