using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System.Models
{
    public class Airport
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Airport(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string name)
        {
            return _reservationBook.GetReservationsForUser(name);
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservations(reservation);
        }
    }
}
