using snooker1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace snooker1.Repos
{
    public class SnookerContext  : DbContext
    {
               
        public SnookerContext()  : base ("SnookerContext")
        {
            Database.SetInitializer<SnookerContext>(new SnookerDBInitialiser());

        }


        public DbSet<Player> Players { get; set; }

        public DbSet<Frame> Frames { get; set; }

        public DbSet<Match> Matches { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}