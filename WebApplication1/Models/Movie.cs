using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Movie
    {
        // public int Id { get; set; }
        public int MovieId { get; set; }
        /*
        [Key]
        public int MovieKey { get; set; }
        */
        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
