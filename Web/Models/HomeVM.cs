using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class HomeVM
    {
        public List<Brand> Brands { get; set; }
        public List<Advertisement> Advertisements { get; set; }
        public List<Category> Categories { get; set; }
        public List<FirstSlider> FirstSliders { get; set; }
        public List<Discount> Discounts { get; set; }
        public List<City> Cities { get; set; }
        public List<Store> Stores { get; set; }

    }
}
