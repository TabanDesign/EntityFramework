using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace EntityFramework.Models
{
    public class DataBaseContext:DbContext
    {
        static DataBaseContext()
        {
            //اگر مدل تغییر کرد دوباره ساخته میشود
            //یعنی اگر یک کلاس اضافه شد یا یک پراپرتی تغییر کرد یا اضافه شد یا ...
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());

            //وقتی برنامه ران میشود دوباره دیتابیس ساخته میشود
            //Database.SetInitializer(new DropCreateDatabaseAlways<DataBaseContext>());

            //اگر دیتابیس وجود نداشت ان را میسازد
            //Database.SetInitializer(new CreateDatabaseIfNotExists<DataBaseContext>());
        }
        //----------------------------------------------------------
        private DbSet<Country> _countries;

        public DbSet<Country> Countries
        {
            get { return _countries; }
            set { _countries = value; }
        }
        
        public DataBaseContext():base("CountyListDataBase")
        {

        }
    }
}
