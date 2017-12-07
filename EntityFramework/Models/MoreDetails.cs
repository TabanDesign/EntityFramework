using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [ComplexType]
    public class MoreDetails
    {
        public int? Area { get; set; }
        public int? Population { get; set; }
        //---------------------------------
        public MoreDetails()
        {

        }
        public MoreDetails(int area,int population)
        {
            Area = area;
            Population = population;
        }
    }
}
