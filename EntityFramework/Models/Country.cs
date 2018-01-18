using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [Table("CountryList")]
    public class Country : Autoset_Field
    {
        private string _name;
        [Column("CountryName")]
        [Required]
        [MaxLength(50)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //-----------------------------
        private int _code;
        [Required]
        [Column("CountryCode")]
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }
        //-----------------------------
        private MoreDetails _more;

        public MoreDetails More
        {
            get { return _more; }
            set { _more = value; }
        }

        //-----------------------------
        [NotMapped]
        public string Displayn
        {
            get
            {
                string dis;
                dis = string.Format($"Code : {Code}   Name : {Name} in time : {TimeClass.TimeNow}");
                return dis;
            }
        }
        //----------------------------------
        public Country()
        {

        }
    }
}
