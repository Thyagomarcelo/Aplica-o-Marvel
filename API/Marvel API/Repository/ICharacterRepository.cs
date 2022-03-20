using Marvel_API.Models.Champions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Repository
{
    public interface ICharacterRepository 
    {

        public Champion getById(string id);
    }
}
