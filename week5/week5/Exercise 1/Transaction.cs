using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_1
{
    public class Transaction
    {
        public DateTime timestamp;
        public string type;
        public decimal amount;


        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
