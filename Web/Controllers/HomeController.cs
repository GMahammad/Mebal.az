using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CategoryService _categoryService;
        private FSliderService _fsliderservice;
        private AdvertisementService _advertservice;
        private DiscountService _discountservice;
        private readonly BrandService _brandService;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, FSliderService fsliderservice = null, AdvertisementService advertservice = null, DiscountService discountservice = null)

        {
            _brandService = new BrandService(context);
            _logger = logger;
            _categoryService = new CategoryService(context);
            _fsliderservice = new FSliderService(context);
            _advertservice = new AdvertisementService(context);
            _discountservice = new DiscountService(context);
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM()
            {
                Advertisements = _advertservice.GetAdvertisements(),
                FirstSliders = _fsliderservice.GetSlider(),
                Categories = _categoryService.GetCategories(),
                Discounts = _discountservice.GetDiscounts(),
                Brands = _brandService.GetBrands(),
                Cities = _advertservice.GetCities(),
                Stores=_advertservice.GetStores()

        };
            return View(vm);
        }
      
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
