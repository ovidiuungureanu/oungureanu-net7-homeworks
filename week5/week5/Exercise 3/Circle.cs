using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_3
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public static double PI { get; set; } = Math.PI;

        public Circle(string Color, double Radius)
        {
            this.Color = Color;
            this.Radius = Radius;
        }

        public override double CalculateArea()
        {
            return Area = PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * PI * Radius;
        }

        public string GetPerimeter(string unit)
        {
            return $"Circumference: {GetPerimeter()} {unit}";
        }
    }
}
