using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class Skins
    {
        public string id { get; set; }
        public int num { get; set; }
        public string name { get;set; }
        public bool chromas { get; set; }

        public string ChampionId { get; set; }
    }
}
