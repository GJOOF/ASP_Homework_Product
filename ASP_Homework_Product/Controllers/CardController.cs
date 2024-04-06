using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel;
namespace ASP_Homework_Product.Controllers
{
    public class CardController : Controller
    {
        private readonly IProductRepository IProductRepository;
        private readonly ICardsRepository cardsRepository;
        public CardController(IProductRepository IProductRepository, ICardsRepository cardsRepository)
        {
            this.IProductRepository = IProductRepository;
            this.cardsRepository = cardsRepository;
        }
        public ActionResult Index()
        {
            var card = cardsRepository.TryGetByUserId(Constants.UserId);
            return View(card);
        }

        public IActionResult Add(int productId)
        {
            var product = IProductRepository.TryGetById(productId);
            cardsRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public ActionResult DecreaseAmount(int productId)
        {
            cardsRepository.DecreaseAmount(productId, Constants.UserId);
            return RedirectToAction("Index");
        }

        public ActionResult Clear()
        {
            cardsRepository.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}