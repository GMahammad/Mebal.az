using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class AdvertisementDetailVM
    {

        public Advertisement Advertisement { get; set; }
        public List<Advertisement> DetAdvertisement { get; set; }
        public List<Advertisement> FeaturedAdvert { get; set; }
        public List<Brand> Brands { get; set; }
        public Detail Details { get; set; }

    }
}
