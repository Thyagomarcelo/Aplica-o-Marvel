using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.ClassModels
{
    public class ResponseAPIModel
    {
        public int Id { get; set; }
        public string type { get; set; }
        public ChampionsModel data { get; set; }
    }
}
