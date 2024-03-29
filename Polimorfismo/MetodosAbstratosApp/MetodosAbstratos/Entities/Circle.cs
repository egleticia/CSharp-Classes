﻿using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

         // : base(color) - chama o constrtutor da classe Shape
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;

        }
    }
}
