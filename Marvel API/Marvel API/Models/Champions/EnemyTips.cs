using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class EnemyTips
    {
        public int Id { get; set; }
        public string description { get; set; }

        public string ChampionId { get; set; }
    }
}
