using System.Data.Entity;

namespace RelationOneToMany.Models
{
    public class DataBaseContext:DbContext
    {
        /// <summary>
        /// سناریوی دلخواه
        /// </summary>
        static DataBaseContext()
        {
            Database.SetInitializer(new DataBaseContextInitilizer());
        }
        public DataBaseContext():base("RelationDB")
        {
        }
        /// <summary>
        /// دو جدول میخاهیم
        /// </summary>
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
    }
}
