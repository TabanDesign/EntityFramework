using System.Data.Entity.ModelConfiguration;

namespace RelationOneToOne.Models
{
    public class Addess
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        /// <summary>
        /// اسم کلاس را مینویسیم و آدی اخرش مینویسیم
        /// در این صورت ایدی کلاس را توی این متغیر میریزد
        /// </summary>
        public int PersonID { get; set; }
        public Person Person { get; set; }

        #region Configuration()
        internal class Configuration:EntityTypeConfiguration<Addess>
        {
            public Configuration()
            {
                HasKey(c => c.PersonID)                     ///پرایمری کردن پرسن ایدی
                    .HasRequired(c => c.Person)             ///اجباری کردن پر کردن پرسن یعنی ادرس بدون فرد نمیشود
                    .WithOptional(c => c.Addess)            ///خوده ادرس اختیاری است
                    .WillCascadeOnDelete(true);             ///اگر فرد حذف شد ادرس هم حذف میشود
            }
        }
        #endregion
    }
}
