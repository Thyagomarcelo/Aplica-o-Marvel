using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class Passive
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ImagePassive image { get; set; }

        public virtual string ChampionId { get; set; }
    }
}
