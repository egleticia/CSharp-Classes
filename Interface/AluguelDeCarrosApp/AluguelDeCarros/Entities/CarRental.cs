using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Entities
{
    public class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public CarRental() { }

        public CarRental(DateTime start, DateTime finish)
        {
            Start = start;
            Finish = finish;

        }
    }
}
