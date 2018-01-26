using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
    public class DataBaseContextinitialize:DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        public DataBaseContextinitialize()
        {

        }
        protected override void Seed(DataBaseContext dataBaseContext)
        {
            base.Seed(dataBaseContext);
            Country Country = null;
            Country =
               new Country(1, "ايران");

            Country.States =
               new List<State>();

            Country.States.Add(new State(1, "State 1"));
            Country.States.Add(new State(2, "State 2"));
            Country.States.Add(new State(3, "State 3"));

            dataBaseContext.Countreis.Add(Country);
            //-----------------------------------------
            Country = new Country(2, "آمریکا");
            Country.States =
               new List<State>();
            Country.States.Add(new State(4, "نیویورک"));
            Country.States.Add(new State(5, "تگزاز"));
            Country.States.Add(new State(6, "کالیفرنیا"));
            dataBaseContext.Countreis.Add(Country);
            //-----------------------------------------
            Country = new Country(3,"عراق");
            Country.States =
               new List<State>();
            for (int i = 0; i < 10; i++)
            {
                string strState = string.Format($"{i} state {Country.Namee}");
                Country.States.Add(new State(i,strState));
            }
            dataBaseContext.Countreis.Add(Country);
            //------------------------------------------
            Country = new Country(3, "آلمان");
            Country.States =
               new List<State>();
            for (int i = 0; i < 10; i++)
            {
                string strState = string.Format($"{i} state {Country.Namee}");
                Country.States.Add(new State(i, strState));
            }
            dataBaseContext.Countreis.Add(Country);
            //-------------------------------------------
            dataBaseContext.SaveChanges();
        }
    }
}
