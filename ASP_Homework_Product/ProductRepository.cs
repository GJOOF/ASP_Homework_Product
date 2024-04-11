using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Gibson EDS-1275 Doubleneck Cherry Red", 727000,
                "\r\nBody Style:SG\r\nBody Shape:EDS-1275\r\nBody Material:Solid Mahogany\r\nBody Finish:Gloss Nitrocellulose Lacquer","/images/gibson_doubleneck_cherry_red.jpg"),
            
            new Product("Gibson SG Standard Cherry", 218000,
                "\r\nBody Style:SG\r\nBody Material:Mahogany\r\nBinding:Single Ply Cream, Fretboard\r\nBody Finish:Satin Nitrocellulose Lacquer","/images/gibson_sg_standard_cherry.jpg"),
            
            new Product("Gibson Les Paul Special TV Yellow", 164000,
                "\r\nBody Style:Les Paul\r\nBody Material:Mahogany\r\nBody Finish:Gloss Nitrocellulose Lacquer","/images/gibson_les_paul_special_tv_yellow.jpg")
        };

        public List<Product> GetProducts() { return products; }
        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }
    }
}

