using System.Data.Entity;

namespace Paging.Models
{
    public class DataBaseContextInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        /// <summary>
        /// سازنده پیش فرض 
        /// </summary>
		public DataBaseContextInitializer()
        {
        }


        /// <summary>
        /// متد سید
        /// </summary>
        /// <param name="databaseContext"></param>
		protected override void Seed(DataBaseContext databaseContext)
        {
            for (int intIndex = 1; intIndex <= 1000; intIndex++)
            {
                string strCountryName =
                    string.Format("Country {0}", intIndex);

                databaseContext.Countries.Add
                    (new Country(intIndex, strCountryName));
            }

            // Optional
            databaseContext.SaveChanges();
        }
    }
}

