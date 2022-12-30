using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_4
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public abstract double CalculateBonus();

        public virtual string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public enum Department
        {
            HR,
            IT,
            Sales,
            Marketing
        }
    }
}
