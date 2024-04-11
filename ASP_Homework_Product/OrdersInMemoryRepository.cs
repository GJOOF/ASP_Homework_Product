using ASP_Homework_Product.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class OrdersInMemoryRepository : IOrdersRepository
    {
        private List<Card> orders = new List<Card>();

        public void Add(Card card)
        {
            orders.Add(card);
        }
    }
}