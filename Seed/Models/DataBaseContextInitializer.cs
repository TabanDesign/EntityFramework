using System.Data.Entity;

namespace Seed.Models
{
    /// <summary>
    /// سناریوی دستی
    /// از سناریوی دوم استفاده میکند و ان را اجرا میکند
    /// </summary>
    public class DataBaseContextInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public DataBaseContextInitializer()
        {
        }
        /// <summary>
        /// از تابع سید (داده ریزی) استفاده میکند
        /// این تابع فقط برای اولین بار که دیتابیسی وجود ندارد اجرا میشود
        /// انواع دادن داده به پرسن
        /// </summary>
        /// <param name="dataBaseContext"></param>
        protected override void Seed(DataBaseContext dataBaseContext)
        {
            base.Seed(dataBaseContext);
            dataBaseContext.People.Add(new Person("mohammad", "mahdi", "hajian"));
            //dataBaseContext.People.Add(new Person("ali", "hajian"));

            FullName fullName = new FullName
            {
                FirstName = "amir",
                MiddleName = "hesam",
                LastName = "fafari"
            };
            //dataBaseContext.People.Add(new Person() {fullName});

            dataBaseContext.People.Add(new Person()
            {
                FullName = new FullName()
                {
                    FirstName = "amir",
                    MiddleName = "hesam",
                    LastName = "fafari"
                }
            }
                );
        }
    }
}
