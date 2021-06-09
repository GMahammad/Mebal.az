using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<Advertisement> Advertisements { get; set; }
    }
}
