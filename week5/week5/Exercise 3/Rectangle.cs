using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_3
{
    class Rectangle : Shape
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(string Color, double Width, double Height)
        {
            this.Color = Color;
            this.Width = Width;
            this.Height = Height;
        }

        public override double CalculateArea()
        {
            return Area = Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public string GetPerimeter(string unit)
        {
            return $"Perimeter: {GetPerimeter()} {unit}";
        }
    }
}
