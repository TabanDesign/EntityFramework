using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;

namespace RelationManyToMany.Models
{
    public class Group
    {
        /// <summary>
        /// کانفیگوریشن را مینویسیم
        /// </summary>
        #region Confihuration
        internal class Configuration : EntityTypeConfiguration<Group>
        {
            public Configuration()
            {
                HasMany(c => c.Users)                   ///ابتدای یوزرز مقابل را انتخاب میکنیم
                    .WithMany(c => c.Groups)            ///سپس با این گروه ارتباط چند به چند میدهیم
                    .Map(c =>                           ///سپس اطلاعات زیر را مپ میکنیم
                    {                                   ///نکته : ابتدا باید لفت کی بیاید بعد رایت کی
                        c.ToTable("UsersInGroups");     ///نام تیبل مشترک را تعیین میکنیم
                        c.MapLeftKey("GroupID");        ///لفت کی را نام کلاسی که کانفیگوریشن در ان است را میگذاریم
                        c.MapRightKey("UserID");        ///و دیگری را رایت کی میگذاریم
                    });
            }
        }
        #endregion
        public Guid ID { get; set; }
        public string Name { get; set; }
        public virtual IList<User> Users { get; set; }
        public Group()
        {
            ID = Guid.NewGuid();
        }
    }
}
