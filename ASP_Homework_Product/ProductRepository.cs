using GuitarShop.Models;
using System.Collections.Generic;

namespace GuitarShop
{
    public class ProductRepository
    {
        static List<Product> Products = new List<Product>()
        {
            new Product("Fender Stratocaster Black", 179000,
                "\r\nBody Style:Stratocaster\r\nBody Material:Alder\r\nBody Finish:Gloss Nitrocellulose Lacquer"),

            new Product("Gibson EDS-1275 Doubleneck Cherry Red", 727000,
                "\r\nBody Style:SG\r\nBody Shape:EDS-1275\r\nBody Material:Solid Mahogany\r\nBody Finish:Gloss Nitrocellulose Lacquer"),
            
            new Product("Gibson SG Standard Cherry", 218000,
                "\r\nBody Style:SG\r\nBody Material:Mahogany\r\nBinding:Single Ply Cream, Fretboard\r\nBody Finish:Satin Nitrocellulose Lacquer"),
            
            new Product("Gibson Les Paul Special TV Yellow", 164000,
                "\r\nBody Style:Les Paul\r\nBody Material:Mahogany\r\nBody Finish:Gloss Nitrocellulose Lacquer")
        };

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}

