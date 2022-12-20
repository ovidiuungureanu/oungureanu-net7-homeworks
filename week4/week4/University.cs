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
        public List<string> students;
        public List<string> faculties;
        public Faculty faculty;
        public Student student;

        public University(string name)
        {
            this.name = name;
        }

        public University(List<string> students, List<string> faculties)
        {
            this.students = new List<string>();
            this.faculties = new List<string>();
        }

        public University(Faculty faculty, Student student)
        {
            this.faculty = faculty;
            this.student = student;
        }

        public List<string> AddStudent(Student firstName)
        {
            foreach (string student in students)
            {
                students.Add(student);
            }
            return this.students;
        }

        public List<string> AddFaculty(Faculty firstName)
        {
            foreach (string faculty in faculties)
            {
                faculties.Add(faculty);
            }
            return this.faculties;
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
