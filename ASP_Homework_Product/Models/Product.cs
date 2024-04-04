namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int IdCreator = 0;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }
        public string ImagePath { get; }

        public Product(string name, int сost, string description, string imagePath)
        {
            Id = IdCreator++;
            Name = name;
            Cost = сost;
            Description = description;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"Product: {this.Name}\n{this.Cost} p.\n{this.Description}";
        }
    }
}