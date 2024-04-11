using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel;
namespace ASP_Homework_Product.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICardsRepository cardsRepository;
        private readonly IOrdersRepository ordersRepository;

        public OrderController(ICardsRepository cartsRepository, IOrdersRepository ordersRepository)
        {
            this.cardsRepository = cartsRepository;
            this.ordersRepository = ordersRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Buy()
        {
            var existingCard = cardsRepository.TryGetByUserId(Constants.UserId);
            ordersRepository.Add(existingCard);
            cardsRepository.Clear(Constants.UserId);
            return View(existingCard);
        }
    }
}