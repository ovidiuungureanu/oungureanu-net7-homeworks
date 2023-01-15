using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    public class Nums
    {
        public void ReadAndCheckNumbers()
        {
            List<string> numbers = new List<string>();
            Console.WriteLine("Enter Names, separated by a space:");
            string input = Console.ReadLine();
            string[] inputParsed = input.Split(" ");
            numbers.AddRange(inputParsed);

            void Convert(List<string> numbers)
            {
                List<int> newNums = new List<int>();
                for (int i = 0; i < numbers.Count; i++)
                {
                    newNums.Add(int.Parse(numbers[i]));
                }
            }

            try
            {

            }
            catch
            {

            }

        }
        public int GetSum(List<string> numbers)
        {
            return numbers.Sum(str => Convert.ToInt32(str));
        }
    }

    public class FormatException : Exception
    {
        public FormatException(string? message) : base(message)
        { }
    }

    public class OverflowException : Exception
    {
        public OverflowException(string? message) : base(message)
        { }
    }

    public class DivideByZeroException : Exception
    {
        public DivideByZeroException(string? message) : base(message)
        { }
    }
}
