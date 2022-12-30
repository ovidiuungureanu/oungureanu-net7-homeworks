using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_6
{
    public class Rectangle1 : IShape, IColor
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public string Color { get; set; }

        public Rectangle1(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
            this.Color = "Black";
        }
        public Rectangle1(double Width, double Height, string Color)
        {
            this.Width = Width;
            this.Height = Height;
            this.Color = Color;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public string CalculateArea(string unit)
        {
            return $"Area: {CalculateArea()} {unit}";
        }
    }
}
