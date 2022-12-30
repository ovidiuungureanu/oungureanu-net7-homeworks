using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_6
{
    interface IShape
    {
        double CalculateArea();

        public string CalculateArea(string unit);
    }

    interface IColor
    {
        string Color { get; set; }
    }

    public class Circle1 : IShape, IColor
    {
        private double Radius { get; set; }
        public string Color { get; set; }

        public Circle1(double Radius)
        {
            this.Radius = Radius;
            this.Color = "Black";
        }

        public Circle1(double Radius, string Color)
        {
            this.Radius = Radius;
            this.Color = Color;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public string CalculateArea(string unit)
        {
            return $"Area: {CalculateArea()} {unit}";
        }
    }
}
