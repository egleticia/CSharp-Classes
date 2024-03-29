﻿using InterfaceEHerança.Model.Enums;

namespace InterfaceEHerança.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
