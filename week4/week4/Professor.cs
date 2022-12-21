using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Professor
    {
        // Before Update Class Professor

        public string name;
        public string faculity;
        public string specialization;
        public List<Student1> studentsWhoGiveTheirDegree { get; set; }

        public Professor(string name, string faculity, string specialization)
        {
            this.name = name;
            this.faculity = faculity;
            this.specialization = specialization;
        }
        public Professor(string name, string faculity, string specialization, List<Student1> studentsWhoGiveTheirDegree)
        {
            this.name = name;
            this.faculity = faculity;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }

        public void AddStudent(Student1 name)
        {
            this.studentsWhoGiveTheirDegree.Add(name);
        }


        // Exercise 7   - After Update Class Professor

        //public string name;
        //public College college;
        //public string specialization;
        //public List<Student1> studentsWhoGiveTheirDegree;

        //public Professor(string name, College college, Student1 student)
        //{
        //    this.college = college;

        //    if (this.college.name == student.college.name)
        //    {
        //        Console.WriteLine("Same College");
        //    }
        //    else
        //    {
        //        throw new Exception("The name of the college is not the same for the professor and the student");
        //    }
        //}
    }
}
