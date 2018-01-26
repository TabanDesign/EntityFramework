using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Namee { get; set; }
        public virtual IList<State> States { get; set; }
        public Country()
        {
        }
        public Country(int id,string namee)
        {
            ID = id;
            Namee = namee;
        }
        
    }
}
