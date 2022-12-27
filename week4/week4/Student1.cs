using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Student1
    {
        public string name;
        public DateTime startDate;
        public DateTime endDate;
        public College college;
        public DateTime birthDate;

        public Student1(string name, DateTime startDate, DateTime endDate, College college, DateTime birthDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.college = college;
            this.birthDate = birthDate;
        }

        public bool IsStillStudent()
        {
            if(endDate < DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.birthDate.Year;
        }

        public void Print()
        {
            Console.WriteLine($"Name is {this.name}, age is {this.GetAge()} and is going to {college.name}");
        }
    }
}
