using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_7
{
    abstract class Hotel : Stay, Available
    {
        private string clientFirstName;
        private string clientLastName;
        protected string ClientFirstName { get; set; }
        protected string ClientLastName { get; set; }
        public int ClientId { get; set; }
        public DateTime DateBookedIn { get; set; }
        public double DaysOfAccomodation { get; set; }

        public virtual string GetClientInfo()
        {
            return $"{ClientFirstName}, {ClientLastName}, {ClientId}";
        }

        public virtual double GetStayInfo()
        {
            return DaysOfAccomodation;
        }

        public string GetStayInfo(string message)
        {
            return message;
        }

        public DateTime GetDueDate()
        {
            return DateBookedIn.AddDays(DaysOfAccomodation);
        }

        public int AvailableRooms()
        {
           if ( Rooms.NrRooms > 0)
            {
                return Rooms.NrRooms;
            }
           else
            {
                throw new Exception("No available Rooms");
            }
        }
    }
}
