using System.Collections.Generic;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product TryGetById(int id);
    }
}
