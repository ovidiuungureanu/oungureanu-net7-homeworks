using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_4
{
    class Manager : Employee
    {
        private Department Department { get; set; }

        public Manager(string Name, int Age, double Salary, Department Department)
        {
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.Department = Department;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Department: {Department}, Email: {Email}, Phone: {Phone}";
        }
    }
}
