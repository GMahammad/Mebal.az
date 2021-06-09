using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class NewAdvertisementController : Controller
    {
        public IActionResult Store()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
