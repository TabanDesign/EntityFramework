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
    [ComplexType]
    public class FullName
    {
        [MaxLength(20)]
        private string _firstName;

        public string FirstName
        {
            get
            {
                if (_firstName == null)
                {
                    return string.Empty;
                }
                return _firstName.Trim();
            }
            set { _firstName = value; }
        }
        [MaxLength(20)]
        private string _middleName;

        public string MiddleName
        {
            get
            {
                if (_middleName == null)
                {
                    return string.Empty;
                }
                return _middleName.Trim();
            }
            set { _middleName = value; }
        }
        [MaxLength(30)]
        private string _lastName;

        public string LastName
        {
            get
            {
                if (_lastName == null)
                {
                    return string.Empty;
                }
                return _lastName.Trim();
            }
            set { _lastName = value; }
        }
        public FullName()
        {

        }

        public FullName(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }
        public FullName(string firstname, string middlename, string lastname) : this(firstname, lastname)
        {
            _middleName = middlename;
        }

        public override string ToString()
        {
            string strFullName = string.Empty;
            if (FirstName != string.Empty)
            {
                strFullName = FirstName;
            }

            if (MiddleName != string.Empty)
            {
                if (strFullName == string.Empty)
                {
                    strFullName = MiddleName;
                }
                else
                {
                    strFullName += " " + MiddleName;
                }
            }

            if (LastName != string.Empty)
            {
                if (strFullName == string.Empty)
                {
                    strFullName = LastName;
                }
                else
                {
                    strFullName += " " + LastName;
                }
            }

            return strFullName;
        }
    }
}
