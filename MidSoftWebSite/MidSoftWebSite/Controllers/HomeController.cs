using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MidSoftWebSite.Models;
using MidSoftWebSite.Models.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MidSoftWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        MidsoftWebSiteContext _db = new MidsoftWebSiteContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
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
       
        public IActionResult HomePage()
        {
            var HomeList = _db.HomePage.ToList();
            ViewData["homeList"] = HomeList;
            return View();
        }
        public IActionResult AboutUs()
        {
            //var aboutUs = _db.AboutUs.ToList();
            //ViewData["aboutUs"] = aboutUs;
            //var aboutUs1 = _db.AboutUs.Where(x=> x.Id==1);

            return View();
        }
        public IActionResult Products()
        {
            var Products = _db.Product.ToList();
            ViewData["Products"] = Products;
            return View();
        }

        public IActionResult Referance()
        {
            return View();
        }


        public IActionResult ProductDetail()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
