namespace Paging.Models
{
    public class Country
    {
        //بدنه کانفیگوریشن
        #region Configuration
        public class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Country>
        {
            public Configuration()
            {
            }
        }
        #endregion /Configuration


        /// <summary>
        /// سازنده پیش فرض کلاس
        /// </summary>
        public Country()
        {
        }

        /// <summary>
        /// سازنده با دو ورودی آی دی و کشور
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
		public Country(int id, string name)
        {
            ID = id;
            Name = name;
        }

        /// <summary>
        /// پراپرتی آی دی
        /// </summary>
		public int ID { get; set; }

        /// <summary>
        /// پراپرتی نام
        /// </summary>
		public string Name { get; set; }
    }
}
