using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System.Models
{
    public class Reservation
    {
        public FlightID FlightID { get; }
        public string Name { get; }
        public DateTime DepartureTime { get; }
        public DateTime ArrivalTime { get; }
        public TimeSpan FlightDuration => ArrivalTime.Subtract(DepartureTime);

        public Reservation(FlightID flightID, string name, DateTime departureTime, DateTime arrivalTime)
        {
            FlightID = flightID;
            Name = name;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if (reservation.FlightID != FlightID)
            {
                return false;
            }

            return reservation.DepartureTime < ArrivalTime && reservation.DepartureTime > DepartureTime;
        }
    }
}
