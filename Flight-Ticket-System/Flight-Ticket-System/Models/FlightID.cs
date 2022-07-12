using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System.Models
{
    public class FlightID
    {
        public int FlightNumber { get; }
        public string FlightName { get; }

        public FlightID(int flightNumber, string flightName)
        {
            FlightNumber = flightNumber;
            FlightName = flightName;
        }
        public override string ToString()
        {
            return $"{FlightName}{FlightNumber}";
        }
        public override bool Equals(object obj)
        {
            return obj is FlightID flightID && FlightNumber == flightID.FlightNumber && FlightName == flightID.FlightName;
        }

        public override int GetHashCode()
        {
            return FlightNumber.GetHashCode() ^ FlightName.GetHashCode();
        }


    }
}
