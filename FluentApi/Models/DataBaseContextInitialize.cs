using System.Data.Entity;

namespace FluentApi.Models
{
    class DataBaseContextInitialize : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        public DataBaseContextInitialize()
        {
        }
        protected override void Seed(DataBaseContext context)
        {
            base.Seed(context);
        }
    }
}
