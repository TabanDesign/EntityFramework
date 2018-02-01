using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration.Models
{
    class DataBaseContext : DbContext
    {
        static DataBaseContext()
        {
            ///روش ادرس دهی
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataBaseContext, Migrations.Configuration>());
        }
        /// <summary>
        /// دستور ساخت خودکار مایگریشن
        ///enable-migrations -ContextTypeName DataBaseContext -EnableAutomaticMigrations
        /// </summary>
        public DataBaseContext() : base("MigrationDB")
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
