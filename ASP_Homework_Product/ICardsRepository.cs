using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public interface ICardsRepository
    {
        void Add(Product product, string userId);
        Card TryGetByUserId(string userId);
        void Clear(string userId);
        void DecreaseAmount(int productId, string userId);
    }
}
