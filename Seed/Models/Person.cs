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
    [Table("PersonTable")]
    public class Person
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //----------------------------------
        private string _firstName;

        public string FirstName
        {
            get
            {
                if (_firstName == null)
                {
                    return string.Empty;
                }
                return _firstName; ; 
            }
            set { _firstName = value; }
        }
        //-----------------------------------
        private string _midleName;

        public string MidleName
        {
            get { return _midleName; }
            set { _midleName = value; }
        }
        //-----------------------------------
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        //------------------------------------
        public Person()
        {
            _id = Guid.NewGuid();
        }
        public Person(string firstName, string midleName, string lastName) :this(firstName,lastName)
        {
            _midleName = midleName;
        }
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}
