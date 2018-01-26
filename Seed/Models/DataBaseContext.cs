using System.Data.Entity;

namespace Seed.Models
{
    /// <summary>
    /// کلاسی با ارث بری از دی بی کانتکس
    /// </summary>
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// سناریو ی خودمان را میسازیم
        /// </summary>
        static DataBaseContext()
        {
            Database.SetInitializer(new DataBaseContextInitializer());
        }
        /// <summary>
        /// سازنده ی پیشفرض
        /// نام دیتا بیس را عوض میکنیم
        /// </summary>
        public DataBaseContext():base("seedDB")
        {

        }
        /// <summary>
        /// یک پراپرتی برای کار با دیتابیس
        /// </summary>
        public DbSet<Person> People { get; set; }
    }
}
