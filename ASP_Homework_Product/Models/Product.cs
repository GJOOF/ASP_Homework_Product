namespace GuitarShop.Models
{
    public class Product
    {
        private static int IdCreator = 0;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public Product(string name, int сost, string description)
        {
            Id = IdCreator++;
            Name = name;
            Cost = сost;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\n{this.Name}\n{this.Cost} p.\n{this.Description}";
        }
    }
}