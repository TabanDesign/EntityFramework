namespace FluentApi.Models
{
    public class State
    {
        #region Configuration
        /// <summary>
        /// Fluent Api
        /// </summary>
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<State>
        {
            public Configuration()
            {
                // Note: Attribute is better!
                ToTable("States");

                // Note: Attribute is better!
                HasKey(current => current.ID);

                // Note: Attribute is better!
                Property(current => current.ID)
                    .HasDatabaseGeneratedOption
                    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

                Property(current => current.ID)
                    // Note: Attribute is better!
                    .HasColumnName("ID")
                    // Note: Attribute is better!
                    .HasColumnOrder(0)
                    // Note: Attribute is better!
                    .IsRequired()
                    ;

                Property(current => current.CountryID)
                    // Note: Attribute is better!
                    .HasColumnName("CountryID")
                    // Note: Attribute is better!
                    .HasColumnOrder(1)
                    // Note: Attribute is better!
                    .IsRequired()
                    ;

                Property(current => current.Name)
                    // Note: Attribute is better!
                    .HasColumnName("Name")
                    // Note: Attribute is better!
                    .HasColumnOrder(2)
                    // Note: Attribute is better!
                    .IsRequired()
                    // Note: Fluent Api is better!
                    .IsUnicode(true)
                    // Note: Fluent Api is better!
                    .HasMaxLength(50)
                    // Note: Fluent Api is better!
                    .IsVariableLength()
                    ;

                // Note: Fluent Api is better!
                //فلوانت ای پی آی برای ایجاد رابطه یک به چند
                //در این قسمت میتوان کسکید دلیت رو هم فالس گذاشتیم و لی در اتربیوت نمیتوان
                HasRequired(current => current.Country)
                    .WithMany(country => country.States)
                    .HasForeignKey(current => current.CountryID)
                    .WillCascadeOnDelete(false)
                    ;

                //خودش
                //HasRequired(current => current.Country)
                //طرف مقابل
                //.WithMany(country => country.States)
                //خودش
                //.HasForeignKey(current => current.CountryID)
                //.WillCascadeOnDelete(false)
                //;

                //HasOptional(current => current.Country)
                //	.WithMany(country => country.States)
                //	.HasForeignKey(current => current.CountryID)
                //	.WillCascadeOnDelete(false)
                //	;
            }
        }
        #endregion /Configuration

        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

    }
}
