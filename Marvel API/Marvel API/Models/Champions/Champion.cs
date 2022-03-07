using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class Champion
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public virtual Info info { get; set; }
        public string lore { get; set; }
        public virtual Image image { get; set; }  
        public string partype { get; set; }
        public virtual List<AllyTips> allytips { get; set; }
        public virtual List<EnemyTips> enemytips { get; set; }
        public virtual List<Tags> tags { get; set; }
        public virtual Stats stats { get; set; }
        public virtual List<Spells> spells { get; set; }
        public virtual Passive passive { get; set; }
    }
}
