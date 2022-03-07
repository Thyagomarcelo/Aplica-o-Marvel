using Marvel_API.Models;
using Marvel_API.Models.Champions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Marvel_API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Champions> Champions{get;set;}
        public DbSet<Champion> Champion { get; set; }
        public DbSet<Image> image { get; set; }
        public DbSet<ImagePassive> imagePassive { get; set; }
        public DbSet<ImageSpells> imageSpells { get; set; }
        public DbSet<Spells> spells { get; set; }
        public DbSet<AllyTips> allytypes { get; set; }
        public DbSet<EnemyTips> enemyytypes { get; set; }
        public DbSet<Tags> tags { get; set; }
        public DbSet<Info> info { get; set; }
        public DbSet<Passive> passive { get; set; }
    }
}