namespace Migration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Migration.Models.DataBaseContext>
    {
        public Configuration()
        {
            ///برای اتوماتیک کردن مایگریشن و نود درصد کار را میکند اگر بنویسیم
            AutomaticMigrationsEnabled = true;
            ///یک درصد باقی مانده این است
            ///وقتی که نام پراپرتی را تغییر میدهیم ارور نمیدهد موقع اجرا ولی
            ///پراپرتی که نامش تغییر کرده است اطلاعاتش پاک میشود
            AutomaticMigrationDataLossAllowed = true;
        }
        /// <summary>
        /// این تابع رو استفاده نکن چون هربار که مایگریشن اجرا میشه این هم اجرا میشه
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(Migration.Models.DataBaseContext dataBaseContext)
        {
            ///راه استفاده این شکلی است
            ///به جای ادد . ادد یا اپدیت میگذاریم
            ///داخلش چک میکنیم اگر نامی که بهش میدهیم داخل بود دیگر اضافه نکن و اپدیت کن
            ///نکته : با ایدی شرط نباید بزارم چون اینجا بهش نمیدهم و یکبار دیگه میسازه
            dataBaseContext.Persons.AddOrUpdate(c => c.Name, new Models.Person() { Name = "USA", Population = "i dont know",Tel=+1 });
            dataBaseContext.Persons.AddOrUpdate(c => c.Name, new Models.Person() { Name = "Germany", Population = "i dont know too"});
        }
    }
}
