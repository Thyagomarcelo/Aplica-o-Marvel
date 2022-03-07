using Marvel_API.Models.Champions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.ClassModels
{
    public class ChampionModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public string lore { get; set; }
        public Image image { get; set; }
        public string partype { get; set; }
        public List<string> allytips { get; set; }
        public List<string> enemytips { get; set; }
        public List<string> tags { get; set; }
        public Stats stats { get; set; }
        public List<Spells> spells { get; set; }
        public Passive passive { get; set; }
    }
}
