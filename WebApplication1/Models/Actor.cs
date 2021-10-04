using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        // navigation property
        //[ForeignKey("BioId")]
        public ActorBiography Biography { get; set; }
        public int BiographyId { get; set; }
        //public int BioId { get; set; }

        // lawrence.Biography

        public List<Movie> Movies { get; set; }
    }
}
