using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class CardsRepository
    {
        private List<Card> cards = new List<Card>();

        internal Card TryGetByUserId(string userId)
        {
            return cards.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var exisitingCard = TryGetByUserId(userId);
            if (exisitingCard == null)
            {
                var newCard = new Card
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Items = new List<CardItem>
                    {
                        new CardItem
                        {
                            Id = Guid.NewGuid(),
                            Amount = 1,
                            Product = product,
                        }
                    }
                };

                cards.Add(newCard);
            }
            else
            {
                var existingCardItem = exisitingCard.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCardItem != null)
                {
                    existingCardItem.Amount += 1;
                }
                else
                {
                    exisitingCard.Items.Add(new CardItem
                    {
                        Id = Guid.NewGuid(),
                        Amount = 1,
                        Product = product,
                    });
                }
            }
        }

    }
}
