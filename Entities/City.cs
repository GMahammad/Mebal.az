using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class City
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public virtual List<Advertisement> Advertisements { get; set; }
    }
}
