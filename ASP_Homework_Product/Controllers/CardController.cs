using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ASP_Homework_Product.Controllers
{
    public class cardController : Controller
    {

        private readonly ProductRepository productRepository;
        public cardController()
        {
            productRepository = new ProductRepository();
        }

        public ActionResult Index()
        {
            var card = CardsRepository.TryGetByUserId(Constants.UserId);
            return View(card);
        }

        public IActionResult Add(int productId)
        {
            var product = productRepository.TryGetById(productId);
            CardsRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
