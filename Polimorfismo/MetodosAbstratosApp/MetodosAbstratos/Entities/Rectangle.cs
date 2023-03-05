using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        // Atributos
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width= width;
            Height= height;
        }

        // sobrescrita do método abstrato área
        public override double Area()
        {
            return Width * Height;
        }
    }
}
