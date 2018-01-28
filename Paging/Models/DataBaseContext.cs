using System.Data.Entity;

namespace Paging.Models
{
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// سازنده استاتیک
        /// </summary>
		static DataBaseContext()
        {
            Database.SetInitializer(new DataBaseContextInitializer());
        }


        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public DataBaseContext():base("PagingDB")
        {
            Configuration.LazyLoadingEnabled = true;
        }


        /// <summary>
        /// کالکشن کانتریز
        /// </summary>
		public DbSet<Country> Countries { get; set; }


        /// <summary>
        /// متد آن مدل کریتینگ برای اعمال کانفیگوریشن در کلاس ها
        /// </summary>
        /// <param name="modelBuilder"></param>
		protected override void OnModelCreating
            (System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Country.Configuration());
        }
    }
}
