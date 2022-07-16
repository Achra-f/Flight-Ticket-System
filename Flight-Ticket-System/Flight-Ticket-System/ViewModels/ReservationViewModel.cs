using Flight_Ticket_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string FlightID => _reservation.FlightID?.ToString();
        public string Name => _reservation.Name;
        public DateTime DepartureTime => _reservation.DepartureTime;
        public DateTime ArrivalTime => _reservation.ArrivalTime;

        public ReservationViewModel(Reservation reservation)
        {
              _reservation = reservation;
        }
    }
}
