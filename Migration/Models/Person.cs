using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration.Models
{
    public class Person
    {
        public Person()
        {
            ID = Guid.NewGuid();
        }
        [Key()]
        [Required()]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }

        private string _name;
        /// <summary>
        /// نام را اجباری میکنم و اگر ندهیم کلا برنامه اجرا نمیشود
        /// با ویرچوال هم لیزی لودینگ نمیشود
        /// </summary>
        [Required()]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _population;
        public string Population
        {
            get { return _population; }
            set { _population = value; }
        }

        private int? _tel;
        /// <summary>
        /// اگر علامت سوال بزاریم اجاره میدهم نال باشد
        /// اگر نباشد و اطلاعات ندهیم خودکار صفر میگذارد و الان که اجازه دادم نال میگذارد
        /// </summary>
        public int? Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

    }
}
