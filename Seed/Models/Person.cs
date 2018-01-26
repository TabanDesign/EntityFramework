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
    [Table("PersonDetails")]
    public class Person
    {
        [Key()]
        [Required()]
        [Column("PersonId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }


        private FullName _fullName;

        public FullName FullName
        {
            get {
                if (_fullName==null)
                {
                    _fullName = new FullName();
                }
                return _fullName; }
            set { _fullName = value; }
        }

        public Person()
        {
            ID = Guid.NewGuid();
        }

        public Person(string firstName,string lastName):this()
        {
            FullName.FirstName = firstName;
            FullName.LastName = lastName;
        }

        public Person(string firstName,string middleName,string lastName):this(firstName,lastName)
        {
            FullName.MiddleName = middleName;
        }

        public string DisplayFullName
        {
            get
            {
                string strFullName = FullName.ToString();
                if (strFullName==string.Empty)
                {
                    return ("UnKhnown");
                }
                return strFullName;
            ;}
        }

    }
}
