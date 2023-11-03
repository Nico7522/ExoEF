using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoEF.Entities
{
    public class Director : Person
    {
        public List<Movie> Movies { get; set; }
    }
}
