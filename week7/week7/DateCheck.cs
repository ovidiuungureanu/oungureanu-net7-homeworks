using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    public class DateCheck
    {
        public void CheckIfDateIsInThePast()
        {
            Console.WriteLine("Insert a date in the format DD/MM/YYYY ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            DateTime dateNow = DateTime.Today;

            if (DateTime.Compare(date, dateNow) < 0)
            {
                throw new InvalidDateException("The date is in the past");
            }
            else
            {
                Console.WriteLine("The date is in the future");
            }
        }
    }

    public class InvalidDateException : Exception
    {
      public InvalidDateException(string? message) : base(message)
      { }
    }
}

