﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class TimeClass
    {
        public static DateTime TimeNow
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
