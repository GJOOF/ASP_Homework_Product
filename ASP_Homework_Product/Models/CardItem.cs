using System;

namespace ASP_Homework_Product.Models
{
    public class CardItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal Cost
        {
            get { return Product.Cost * Amount; }
        }
    }
}
