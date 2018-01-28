using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;


namespace RelationOneToOne.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        /// <summary>
        /// چون یک به یک است یک پراپرتی برای طرف دیگر رابطه میسازیم
        /// برای کلاس طرف دیگر هم همین کار را میکنیم
        /// ویرچوال برای لیزی لودینگ کردن خودکار است
        /// </summary>
        public virtual Addess Addess { get; set; }
        public Person()
        {
        }
    }
}
