using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class Info
    {
        public int Id { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get;set; }
        public int difficulty { get; set; }

        public virtual string ChampionId { get; set; }
    }
}
