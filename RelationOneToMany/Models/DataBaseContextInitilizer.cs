using System.Data.Entity;

namespace RelationOneToMany.Models
{
    class DataBaseContextInitilizer:DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        public DataBaseContextInitilizer()
        {
        }
        protected override void Seed(DataBaseContext context)
        {
            base.Seed(context);
        }
    }
}
