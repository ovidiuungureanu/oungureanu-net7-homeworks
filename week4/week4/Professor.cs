using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Professor
    {
        public string name;
        public string faculity;
        public string specialization;
        public List<string> studentsWhoGiveTheirDegree;

        public Professor(string name, string faculity, string specialization)
        {
            this.name = name;
            this.faculity = faculity;
            this.specialization = specialization;
        }
        public Professor(string name, string faculity, string specialization, List<string> studentsWhoGiveTheirDegree)
        {
            this.name = name;
            this.faculity = faculity;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = new List<string>();
        }



        // Exercise 7

        public Professor(Professor professor)
        {
            this.name = professor.name;

            
        }
    }
}
