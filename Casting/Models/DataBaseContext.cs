using System.Data.Entity;

namespace Casting.Models
{
    public class DataBaseContext:DbContext
    {
        
        static DataBaseContext()
        {
            Database.SetInitializer(new DataBaseContextinitialize());
        }
        public DataBaseContext():base("CastingDB")
        {
        }
        public DbSet<Country> Countreis { get; set; }
        public DbSet<State> States { get; set; }
    }
}
