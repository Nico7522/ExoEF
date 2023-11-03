using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoEF.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }

       
        public string Title { get; set; }

        public int YearRelease { get; set; }
      
        public int DirectorID { get; set; }
        public Director DirectorFilm { get; set; }

        public List<ActorMovie>? Actors { get; set; }

        public string Genre { get; set; }
    }
}
