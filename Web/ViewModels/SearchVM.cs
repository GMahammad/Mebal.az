using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helper;

namespace Web.ViewModels
{
    public class SearchVM
    {
        public List<Advertisement> Advetisements { get; set; }
        public List<Category> Categories { get; set; }
        public List<City> Cities { get; set; }
        public List<Advertisement> AllAdvertisements { get; set; }
        public List<Brand> Brands { get; set; }
        public Detail Isnew { get; set; }
        public List<Store> Stores { get; set; }
        public int? StoreID { get; set; }
        public int? CategoryID { get; set; }
        public int? Count { get; set; }
        public string SearchTerm { get; set; }
        public int? SortBy { get; set; }
        public int PageNo { get; set; }
        public int RecordSize { get; set; }
        public Pager Pager { get; set; }


    }
}
