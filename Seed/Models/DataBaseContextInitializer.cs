using System.Data.Entity;

namespace Seed.Models
{
    /// <summary>
    /// سناریوی دستی
    /// از سناریوی دوم استفاده میکند و ان را اجرا میکند
    /// برای اینکه اجرا شود و هیچ دیتایی توی فرم به دیتا بیس اضافه نکنیم باید مثلا یک لود بزنیم تا
    /// بره سراغ اینجا
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
            dataBaseContext.People.Add(new Person("ali", "hajian"));



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
