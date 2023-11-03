using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoEF.Entities
{
    public class Actor : Person
    {
        public List<ActorMovie> Movies { get; set; }
    }
}
