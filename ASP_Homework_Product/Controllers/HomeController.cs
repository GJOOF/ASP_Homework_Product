using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productRepository;
        public HomeController(ILogger<HomeController> logger)
        {
            productRepository = new ProductRepository();
        }

        public IActionResult Index()
        {
            List<Product> products = productRepository.GetProducts();


            return View(products);
        }
    }
}
