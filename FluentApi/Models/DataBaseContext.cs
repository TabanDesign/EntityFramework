using System.Data.Entity;

namespace FluentApi.Models
{
    public class DataBaseContext:DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer(new DataBaseContextInitialize());
        }
        public DataBaseContext():base("FluentApiDB")
        {
        }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }

        /// <summary>
        /// در اخر برای اجرای فلونت ای پی ای باید کانفیگوریشن انها را ادد کنیم
        /// کانفیگوریشن ها به صورت اینترنال درون کلاس های استان و کشور هستند
        /// کانفیگوریشن ها همان اتریبیوت ها هستند
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new State.Configuration());
            modelBuilder.Configurations.Add(new Country.Configuration());
        }
    }
}
