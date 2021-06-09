using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Advertisement
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int CityID { get; set; }
        public string AdvertName { get; set; }
        public decimal Price { get; set; }
        public DateTime Posttime { get; set; }
        public bool IsFeatured { get; set; }
        public bool Delivery { get; set; }
        public string AdvHost { get; set; }
        public int? StoreID { get; set; }
        public virtual Category Categories { get; set; }
        public virtual City Cities { get; set; }
        public virtual Store Stores { get; set; }
        public virtual List<AdvertisementPicture> AdvertisementPictures { get; set; }
        public virtual List<Detail> Details { get; set; }


    }
}
