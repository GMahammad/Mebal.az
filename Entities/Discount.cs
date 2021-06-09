using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Discount
    {
        public int ID { get; set; }
        public string PhotoURL { get; set; }
        public int Percent { get; set; }
        public int CurrentPrice { get; set; }
        public int LastPrice { get; set; }

    }
}
