using System.Collections.Generic;

namespace FluentApi.Models
{
    public class Country
    {
        #region Configuration
        /// <summary>
        /// کلاس اینترنال کانفیگوریشن
        /// Fluent Api
        /// خیلی از کارهایی که با فلوانت ای پی آی میشود انجام داد با اتربیوت هم میتوان انجام داد
        /// در ذیل مشخص شده چه فعالیتی رو بهتر است با فلوانت ای پی آی انجام داد و یا اتربیوت
        /// در دیتابیس تفاوتی بین فلو انت ای پی آی و اتربیوت نیست ولی در ام وی سی هنوز به خوبی فلوانت ای پی آی را سنس نمیکند ولی اتربیوت ها در ام وی سی در ویو تاثیر میگذارند
        /// اگر برای آیتمی هم اتربیوت هم فلو انت ای پی آی در نظر گرفته شود فلو انت ای پی آی عمل میکند
        /// </summary>
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Country>
        {
            public Configuration()
            {
                // Note: Attribute is better!
                //نام جدول چه باشد
                ToTable("Countries");
                // Note: Attribute is better!
                //پرایمری نمودن آی دی
                HasKey(current => current.ID);
                // Note: Attribute is better!
                //آی دی اتو اینکریمنت نباشد
                Property(current => current.ID)
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

                //پراپرتی آی دی
                Property(current => current.ID)
                    // Note: Attribute is better!
                    //نام آی دی چه باشد
                    .HasColumnName("ID")
                    // Note: Attribute is better!
                    //اوردر آی دی چه باشد
                    .HasColumnOrder(0)
                    // Note: Attribute is better!
                    //نیاز به مقدار دهی باشد
                    .IsRequired()
                    ;

                //پراپرتی نام
                Property(current => current.Name)
                    // Note: Attribute is better!
                    //نام چه باشد
                    .HasColumnName("Name")
                    // Note: Attribute is better!
                    //اوردر نام چه باشد
                    .HasColumnOrder(1)
                    // Note: Attribute is better!
                    //نیاز به مقدار دهی باشد
                    .IsRequired()
                    // Note: Fluent Api is better!
                    //یونی کد باشد
                    .IsUnicode(true)
                    // Note: Fluent Api is better!
                    //حداکثر طول متن نام چه باشد
                    .HasMaxLength(50)
                    // Note: Fluent Api is better!
                    //طول نام قابل تغییر باشد
                    .IsVariableLength()
                    ;

                //ترکیب فلوانت ای پی آی برای  ایجاد انواع مختلف 

                // Char(x):
                //.IsUnicode(false)
                //.HasMaxLength(x)
                //.IsFixedLength()

                // nChar(x):
                //.IsUnicode(true)
                //.HasMaxLength(x)
                //.IsFixedLength()

                // VarChar(x):
                //.IsUnicode(false)
                //.HasMaxLength(x)
                //.IsVariableLength()

                // nVarChar(x):
                //.IsUnicode(true)
                //.HasMaxLength(x)
                //.IsVariableLength()

                // VarChar(Max):
                //.IsUnicode(false)
                //.IsMaxLength()
                //.IsVariableLength()

                // nVarChar(Max):
                //.IsUnicode(true)
                //.IsMaxLength()
                //.IsVariableLength()

                // توصيه استاد داریوش تصدیقی
                // استفاده نماييد Fluent Api فقط برای حالات ذيل از

                // Char(x):
                //.IsUnicode(false)
                //.HasMaxLength(x)
                //.IsFixedLength()

                // nChar(x):
                //.IsUnicode(true)
                //.HasMaxLength(x)
                //.IsFixedLength()

                // VarChar(x):
                //.IsUnicode(false)
                //.HasMaxLength(x)
                //.IsVariableLength()

                // VarChar(Max):
                //.IsUnicode(false)
                //.IsMaxLength()
                //.IsVariableLength()
            }
        }
        #endregion /Configuration

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual IList<State> States { get; set; }
    }
}
