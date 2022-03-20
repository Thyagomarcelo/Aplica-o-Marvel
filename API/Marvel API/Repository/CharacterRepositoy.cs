using Marvel_API.Models.Champions;
using SampleApp.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Threading.Tasks;

namespace Marvel_API.Repository
{
    public class CharacterRepository : GenericRepository<Champion>, ICharacterRepository
    {
        private ApplicationDbContext _context;

        public CharacterRepository(ApplicationDbContext context): base(context)
        {
            _context = context;
        }

        public Champion getById(string id)
        {
            var Champion = _context.Champion.Where(c => c.id == id).Include("enemytips")
                .Include("image")
                .Include("allytips")
                .Include("passive")
                .Include("passive.image")
                .Include("skins")
                .Include("spells")
                .Include("spells.image")
                .Include("stats")
                .Include("info")
                .Include("tags")
                .FirstOrDefault();


            return Champion;
        }
    }
}
