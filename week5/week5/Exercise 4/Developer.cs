using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_4
{
    class Developer : Employee
    {
        private List<string> Skills { get; set; }
        private bool IsJunior { get; set; }

        public Developer(string Name, int Age, double Salary, List<string> Skills, bool IsJunior)
        {
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.Skills = Skills;
            this.IsJunior = IsJunior;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }

        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Skills: {Skills}, Email: {Email}, Phone: {Phone}";
        }
    }
}
