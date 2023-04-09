using System.Globalization;

namespace Restricoes_generics.Entities
{
    class Produtos : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Produtos(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Produtos))
                throw new ArgumentException("Comparing error: argument is not a Product!");

            Produtos other = obj as Produtos;
            return Price.CompareTo(other.Price);
        }
    }
}
