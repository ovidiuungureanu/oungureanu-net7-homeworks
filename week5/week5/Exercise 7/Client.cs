using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_7
{
    class Client : Hotel
    {
        public string ClientFullName
        {
            get
            {
                return $"{ClientFirstName} {ClientLastName}";
            }
        }
        public NumberOfTheRoom NumberOfTheRoom { get; set; }

        public Client (string ClientFirstName, string ClientLastName, int ClientId, DateTime DateBookedIn, double DaysOfAccomodation, NumberOfTheRoom NumberOfTheRoom)
        {
            this.ClientFirstName = ClientFirstName;
            this.ClientLastName = ClientLastName;
            this.ClientId = ClientId;
            this.DateBookedIn = DateBookedIn;
            this.DaysOfAccomodation = DaysOfAccomodation;
            Rooms.NrRooms--;
            this.NumberOfTheRoom = NumberOfTheRoom;
        }

        public override string GetClientInfo()
        {
            return $"Client Name: {ClientFullName}, Id: {ClientId}, {NumberOfTheRoom}, {DateBookedIn}, {GetDueDate()}";
        }

        public override double GetStayInfo()
        {
            return DaysOfAccomodation;
        }
    }
}
