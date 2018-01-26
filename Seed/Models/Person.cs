using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seed.Models
{
    /// <summary>
    /// نام تیبل را عوض میکنیم
    /// </summary>
    [Table("PersonDetails")]
    public class Person
    {
        /// <summary>
        /// یک ایدی برای هم نفر در نظر میگیریم و ان را اجباری پر شدن و کلید اصلی و... میگذاریم
        /// </summary>
        [Key()]
        [Required()]
        [Column("PersonId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }

        private FullName _fullName;
        /// <summary>
        /// اجرای لیزی لودینگ
        /// بسیار مهم
        /// </summary>
        public FullName FullName
        {
            get {
                if (_fullName==null)
                {
                    _fullName = new FullName();
                }
                return _fullName; }
            set { _fullName = value; }
        }
        /// <summary>
        /// سازنده پیش فرض
        /// جیو ایدی را به ایدی میدهیم
        /// </summary>
        public Person()
        {
            ID = Guid.NewGuid();
        }
        /// <summary>
        /// فرد با دو ورودی و حتما دیس باید باشد تا جیو ایدی به ایدی داده شود
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Person(string firstName,string lastName):this()
        {
            FullName.FirstName = firstName;
            FullName.LastName = lastName;
        }
        /// <summary>
        /// با سه ورودی با استفاده از قبلی
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        public Person(string firstName,string middleName,string lastName):this(firstName,lastName)
        {
            FullName.MiddleName = middleName;
        }
        /// <summary>
        /// ساخت یک تابع برای نمایش دادن درون لیست باکس
        /// فقط گت را میگذاریم تا رید اونلی شود
        /// و لیزی لودینگ رو اجرا میکنیم
        /// </summary>
        public string DisplayFullName
        {
            get
            {
                string strFullName = FullName.ToString();
                if (strFullName==string.Empty)
                {
                    return ("UnKhnown");
                }
                return strFullName;
            ;}
        }

    }
}
