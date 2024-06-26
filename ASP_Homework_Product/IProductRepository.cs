﻿using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product TryGetById(int id);
    }
}
