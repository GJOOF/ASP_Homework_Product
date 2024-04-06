using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ASP_Homework_Product.Controllers
{
    public class CardController : Controller
    {
        private readonly ProductRepository productRepository;
        private readonly CardsRepository cardsRepository;

        public CardController(ProductRepository productRepository, CardsRepository cardsRepository)
        {
            this.productRepository = productRepository;
            this.cardsRepository = cardsRepository;
        }

        public ActionResult Index()
        {
            var card = cardsRepository.TryGetByUserId(Constants.UserId);
            return View(card);
        }
        
        public IActionResult Add(int productId)
        {
            var product = productRepository.TryGetById(productId);
            cardsRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
