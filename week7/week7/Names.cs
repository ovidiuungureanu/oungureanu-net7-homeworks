using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    public class Names
    {
        public void ReadAndCheckNames()
        {
            List<string> names = new List<string>();

            Console.WriteLine("Enter Names, separated by a space:");

            string input = Console.ReadLine();

            string[] inputParsed = input.Split(" ");

            names.AddRange(inputParsed);

            try
            {
                CheckAllNames(names);
                Console.WriteLine("All names are ok.");
            }
            catch(BlankNameException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private void CheckAllNames(List<string> names)
        {
            foreach(string name in names)
            {
                if (!IsValidName(name))
                {
                    throw new BlankNameException("The blank can't be a valid name");
                }
            }
        }
        private bool IsValidName(string name)
        {
            if (!name.Contains(""))
            {
                return false;
            }
            return true;
        }
    }

    public class BlankNameException : Exception
    {
        public BlankNameException(string? message) : base(message)
        { }
    }
}
