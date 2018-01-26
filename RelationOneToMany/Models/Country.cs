using System.Collections.Generic;

namespace RelationOneToMany.Models
{
    public class Country
    {
        public Country()
        {
        }
        public int ID { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// لیستی از کلاس چندتایی را میسازیم
        /// ویرچوال کاره لیزی لودینگ را خودکار انجام میدهد
        /// </summary>
        public virtual IList<State> States { get; set; }
    }
}
