using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Models
{
    public class DataBaseContextInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        public DataBaseContextInitializer()
        {
        }
        protected override void Seed(DataBaseContext dataBaseContext)
        {
            base.Seed(dataBaseContext);
            dataBaseContext.People.Add(new Person("mohammad", "mahdi", "hajian"));
            //dataBaseContext.People.Add(new Person("ali", "hajian"));

            FullName fullName = new FullName
            {
                FirstName = "amir",
                MiddleName = "hesam",
                LastName = "fafari"
            };
            //dataBaseContext.People.Add(new Person() {fullName});

            dataBaseContext.People.Add(new Person()
            {
                FullName = new FullName()
                {
                    FirstName = "amir",
                    MiddleName = "hesam",
                    LastName = "fafari"
                }
            }
                );
        }
    }
}
