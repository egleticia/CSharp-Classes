using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Fixacao.Entities
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }


        public Product()
        {

        }
        public Product (string name, double price, int quantity)
        {

        }

    }
}
