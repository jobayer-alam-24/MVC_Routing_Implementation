using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC_Routing_Implementation.Controllers
{
    public class Products : Controller
    {
        private readonly ILogger<Products> _logger;

        public Products(ILogger<Products> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateProducts()
        {
            return View("~/Views/Products/Create.cshtml");
        }
        public IActionResult EditProducts(int id)
        {
            ViewBag.ID = id;
            return View("~/Views/Products/Edit.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}