using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_5
{
    static class Bank
    {
        static double interestRate = 0.01;
        static int numAccounts = 0;
        public static double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public static int NumAccounts
        {
            get { return numAccounts; }
            set { numAccounts = value; }
        }

        public static double CalculateInterest(double balance)
        {
            double interest;
            return interest = balance * InterestRate;
        }

        public static int GetNumAccounts()
        {
            return NumAccounts;
        }
    }
}
