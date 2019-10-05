using System.Data.Entity;
namespace MonsterCatcher.Models
{
    public class MvcBasicContext : DbContext
    {
        public DbSet<Monster> Monsters { get; set; }
    }
}