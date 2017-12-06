using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    //[ComplexType]        موقعی ک نمیخاهیم تبدیل به جدول شود و نامش با یک دش به کلاس مشتق شده میچسبد
    [Table("CountryList")]
    public class Country
    {
        private Guid _id;
        [Column("CountryID")]
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //------------------------
        private string _name;
        [Column("CountryName")]
        //[Required]
        [MaxLength(50)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //-----------------------------
        private int _code;
        [Required]
        [Column("countryCode")]
        //[NotMapped]
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        //-----------------------------
        [NotMapped]
        public string Displayn
        {
            get
            {
                string dis;
                dis = string.Format($"Code : {Code}   Name : {Name}");
                return dis;
            }
        }
        //----------------------------------
        public Country()
        {
            Id = Guid.NewGuid();
        }
    }
}
