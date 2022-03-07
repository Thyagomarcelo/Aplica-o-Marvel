using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class ChampionFilter
    {

        public string id { get; set; }
        public string name { get; set; }
        public Image image { get; set; }
        public string title { get; set; }
    }
}
