using System.Data.Entity;

namespace GameWatcher.Models
{
    public class GameWatcherContext : DbContext
    {   
        public GameWatcherContext() : base("name=GameWatcherContext")
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Channel> Channels { get; set; }
    
    }
}
