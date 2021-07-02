using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MİdsoftWebSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MİdsoftWebSite.Data;

namespace MİdsoftWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MidosftWebSiteDbContext _db = new MidosftWebSiteDbContext();

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
        public IActionResult HomePage()
        {
            var homepage = _db.HomePages.Where(x => x.Gcrecord == null).ToList();
            return View("homepage", homepage);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AboutUs()
        {
            List<AboutU> aboutUs = _db.AboutUs.Where(x => x.Gcrecord == null).ToList();
            return View("aboutUs", aboutUs);
        }
        public IActionResult Contact()
        {
            var contact = _db.Contacts.Where(x => x.Gcrecord == null).ToList();
            return View("contact", contact);
        }

        public IActionResult Product()
        {
            var product = _db.Products.Where(x => x.Gcrecord == null).ToList();
            return View("product", product);
        }

        public IActionResult ProductDetail(Guid Oid)
        {
            var productDetail = _db.ProductDetails.Where(x => x.Products1 == Oid && x.Gcrecord == null).ToList();
            return View("productDetail", productDetail);
        }

        public IActionResult Reference()
        {
            var reference = _db.Referances.Where(x => x.Gcrecord == null).ToList();
            return View("reference", reference);
        }
    }
}
