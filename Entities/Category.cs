using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CategoryPhotoSlide { get; set; }
        public string CategoryPhotoDrop { get; set; }
        public virtual List<Advertisement> Advertisements { get; set; }

    }
}
