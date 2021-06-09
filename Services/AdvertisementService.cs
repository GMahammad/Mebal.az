using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace Service
{
    public class AdvertisementService
    {
        private ApplicationDbContext _context;
        public AdvertisementService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<Advertisement> SearchAdvertFilter(string searchTerm, int? categoryID, int? minPrice, int? maxPrice, int? sortBy,int? storeID,int? page,int MaxPage, out int count)
        {
            var advertisements = _context.Advertisements.AsQueryable();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                advertisements = advertisements.Where(x => x.AdvertName.Contains(searchTerm));
            }

            if (categoryID.HasValue)
            {
                advertisements = advertisements.Where(x => x.CategoryID == categoryID);
            }
            if (storeID.HasValue)
            {
                advertisements = advertisements.Where(x => x.StoreID == storeID);
            }
            if (minPrice.HasValue && maxPrice.HasValue)
            {
                advertisements = advertisements.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
            }
            if (sortBy.HasValue)
            {
                switch (sortBy)
                {
                    case 1:
                        advertisements = advertisements.OrderByDescending(x => x.Price);
                        break;
                    case 2:
                        advertisements = advertisements.OrderBy(x => x.Price);
                        break;
                    case 3:
                        advertisements = advertisements.OrderBy(x => x.ID);
                        break;
                    default:
                        advertisements = advertisements.OrderByDescending(x => x.ID);
                        break;
                }
            }
            count = advertisements.Count();
            int skip = (page.Value - 1)* MaxPage;
            advertisements = advertisements.Skip(skip).Take(MaxPage);
            return advertisements.Include("AdvertisementPictures.Picture").ToList();
        }
        public int GetProductsCount()
        {
            return _context.Advertisements.Count();
        }
        public List<Advertisement> GetAdvertisements()
        {
            return _context.Advertisements.Include("AdvertisementPictures.Picture").Take(12).ToList();
        }
        public List<Advertisement> GetAllAdvertisements()
        {
            return _context.Advertisements.Include("AdvertisementPictures.Picture").ToList();
        }
        public List<City> GetCities()
        {
            return _context.Cities.ToList();
        }
        public List<Store> GetStores()
        {
            return _context.Stores.ToList();
        }
        public Advertisement GetAdvById(int id)
        {
            return _context.Advertisements.FirstOrDefault(x => x.ID == id);
        }
        
        public List<Advertisement> GetFeatured(int id)
        {

            return _context.Advertisements.Include("AdvertisementPictures.Picture").Where(x => x.CategoryID == id).ToList();
        }
       
      

       
    }
}
