using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_3
{
    abstract class Shape
    {
        public string color;
        public double area;
        public string Color { get; set; }
        public double Area { get; set; } = 0;

        public abstract double CalculateArea();

        public virtual double GetPerimeter()
        {
           return Math.Sqrt(area) * 4;
        }
    }
}
