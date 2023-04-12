
namespace Igualdade.Entities
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;   
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            // Implementando a programção defensiva
            if(!(obj is Product))
                return false;

            //realizando um downcasting
            Product other = (Product)obj;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }

}
