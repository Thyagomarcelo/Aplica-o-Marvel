using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Models.Champions
{
    public class ResponseAPI
    {
        public int Id { get; set; }
        public string type { get; set; }
        public Champions data { get; set; }

    }
}
