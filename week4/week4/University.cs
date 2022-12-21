using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class University
    {
        public string name;
        public List<Student> students { get; set; }
        public List<Faculty> faculties { get; set; }


        public University(string name)
        {
            this.name = name;
            this.students = new List<Student>();
            this.faculties = new List<Faculty>();
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void AddFaculty(Faculty faculty)
        {
            this.faculties.Add(faculty);
        }

        public int GetStudentCount()
        {
            return students.Count();
        }

        public int GetFacultyCount()
        {
            return faculties.Count();
        }
    }
}
