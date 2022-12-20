using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Faculty
    {
        public string firstName;
        public string lastName;
        public int employeeId;
        public List<string> subjectsTaught;

        public Faculty(string firstName, string lastName, int employeeId, List<string> subjectsTaught)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.subjectsTaught = new List<string>();
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public List<string> GetSubjectsTaught()
        {
            foreach(string subjects in subjectsTaught)
            {
                subjectsTaught.Add(subjects);
            }
            return this.subjectsTaught;
        }
    }
}
