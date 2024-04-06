using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository IProductRepository;
        public ProductController(IProductRepository IProductRepository)
        {
            this.IProductRepository = IProductRepository;
        }
        public IActionResult Index(int id)
        {
            var product = IProductRepository.TryGetById(id);
            return View(product);
        }
    }
}
