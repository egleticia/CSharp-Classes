﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarros.Entities
{
    public class Vehicle
    {
        public string CarModel { get; set; }

        public Vehicle() { }

        public Vehicle(string carModel)
        {
            CarModel = carModel;
        }
    }
}
