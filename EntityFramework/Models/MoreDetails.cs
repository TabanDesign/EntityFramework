using System.ComponentModel.DataAnnotations.Schema;

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
