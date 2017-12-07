using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Autoset_Field
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //------------------------
        private DateTime _actionTime;

        public DateTime ActionTime
        {
            get { return _actionTime; }
            set { _actionTime = value; }
        }

        //---------------------------
        public Autoset_Field()
        {
            _id = Guid.NewGuid();
            DateTime dtnow = TimeClass.TimeNow;
            _actionTime = dtnow;
        }
        //--------------------------
    }
}
