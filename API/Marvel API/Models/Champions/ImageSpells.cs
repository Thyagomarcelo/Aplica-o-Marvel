using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class ImageSpells
    {
        public int Id { get; set; }
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double w { get; set; }
        public double h { get; set; }

        public virtual string SpellsId { get; set; }

    }
}
