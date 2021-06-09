using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helper;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly AdvertisementService _advertisementService;
        private readonly BrandService _brandService;
        private readonly DetailService _detailService;
        private readonly CategoryService _categoryService;


        public AdvertisementController(ApplicationDbContext context)
        {
            _advertisementService = new AdvertisementService(context);
            _brandService = new BrandService(context);
            _detailService = new DetailService(context);
            _categoryService = new CategoryService(context);

        }


        public IActionResult Index(string searchTerm, int? categoryID, int? minPrice, int? maxPrice, int? sortBy,int? storeID,int pageNo=1, int recordSize=12)
        {
            SearchVM vm = new SearchVM()
            {
                Advetisements = _advertisementService.SearchAdvertFilter(searchTerm, categoryID, minPrice, maxPrice, sortBy,storeID,pageNo, recordSize, out int count),
                Categories = _categoryService.GetCategories(),
                Cities = _advertisementService.GetCities(),
                Stores= _advertisementService.GetStores(),
                CategoryID=categoryID,
                SearchTerm=searchTerm,
                StoreID=storeID,
                SortBy = sortBy,
                Count=count,
                PageNo=pageNo,
                RecordSize = recordSize,
                Pager = new Pager(count, pageNo),
                AllAdvertisements = _advertisementService.GetAllAdvertisements()
        };
            return View(vm);
        }
        public IActionResult ResponsiveIndex(string searchTerm, int? categoryID, int? minPrice, int? maxPrice, int? sortBy, int? storeID)
        {
            SearchVM vm = new SearchVM()
            {
                Brands=_brandService.GetBrands(),
                Categories = _categoryService.GetCategories(),
                Stores = _advertisementService.GetStores(),
                CategoryID = categoryID,
                SearchTerm = searchTerm,
                StoreID = storeID,
                Cities = _advertisementService.GetCities()

            };

            return View(vm);
        }


        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            AdvertisementDetailVM vm = new AdvertisementDetailVM();
            vm.Brands = _brandService.GetBrands();
            vm.DetAdvertisement = _advertisementService.GetAdvertisements();
            vm.Details = _detailService.GetDetails(id.Value);
            
            vm.Advertisement = _advertisementService.GetAdvById(id.Value);
            vm.FeaturedAdvert = _advertisementService.GetFeatured(vm.Advertisement.CategoryID);
            if (vm.Advertisement == null) return NotFound();

            return View(vm);
        }

    }
}
