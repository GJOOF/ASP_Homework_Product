using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class CardsInMemoryRepository : ICardsRepository
    {
        private List<Card> Cards = new List<Card>();

        public Card TryGetByUserId(string userId)
        {
            return Cards.FirstOrDefault(x => x.UserId == userId);
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

                Cards.Add(newCard);
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

        public void DecreaseAmount(int productId, string userId)
        {
            var exisitingCard = TryGetByUserId(userId);
            var existingCardItem = exisitingCard?.Items?.FirstOrDefault(x => x.Product.Id == productId);
            if (existingCardItem == null)
            {
                return;
            }

            existingCardItem.Amount -= 1;

            if (existingCardItem.Amount == 0)
            {
                exisitingCard.Items.Remove(existingCardItem);
            }
        }

        public void Clear(string userId)
        {
            var exisitingCard = TryGetByUserId(userId);
            Cards.Remove(exisitingCard);
        }
    }
}
