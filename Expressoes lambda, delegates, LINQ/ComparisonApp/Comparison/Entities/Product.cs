using System.Globalization;

namespace Comparison.Entities
{
    class Product
    {
        public string Produto { get; set; }

        public double Price { get; set; }

        public Product(string name, double price) 
        {
            Produto = name;
            Price = price;
        }

        public override string ToString()
        {
            return Produto + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
