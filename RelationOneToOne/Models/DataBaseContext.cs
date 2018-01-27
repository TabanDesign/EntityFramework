using System.Data.Entity;

namespace RelationOneToOne.Models
{
    public class DataBaseContext:DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }
        public DataBaseContext():base("RelationOneToOne")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Addess> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new Addess.Configuration());
        }
    }
}
