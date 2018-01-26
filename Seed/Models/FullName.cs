using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seed.Models
{
    /// <summary>
    /// ساختن کلاس کامپلکس که جدول جداگانه تولید نشود
    /// </summary>
    [ComplexType]
    public class FullName
    {
        [MaxLength(20)]
        private string _firstName;
        /// <summary>
        /// اجرای لیزی لودینگ که مقداری نال برنگرداند
        /// </summary>
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
        /// <summary>
        /// اجرای لیزی لودینگ
        /// </summary>
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
        /// <summary>
        /// اجرای لیزی لودینگ
        /// </summary>
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
        /// <summary>
        /// ساختن سازنده پیشفرض
        /// </summary>
        public FullName()
        {

        }
        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        public FullName(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }
        /// <summary>
        /// سازنده با سه ورودی و از روی دو ورودی ساخته شده است که نخاهیم دوباره درون سازنده پارامتر هارا را به فیلد ها بدهیم
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="middlename"></param>
        /// <param name="lastname"></param>
        public FullName(string firstname, string middlename, string lastname) : this(firstname, lastname)
        {
            _middleName = middlename;
        }
        /// <summary>
        /// ساختن یک تابع اورراید تو استرینگ برای ساختن نام کامل
        /// </summary>
        /// <returns>strFullName</returns>
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
