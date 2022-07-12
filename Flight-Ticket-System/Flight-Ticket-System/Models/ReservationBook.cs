using Flight_Ticket_System.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_System.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string name)
        {
            return _reservations.Where(r => r.Name == name);
        }

        public void AddReservations(Reservation reservation)
        {
            foreach (Reservation exisitingReservation in _reservations)
            {
                if (exisitingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(exisitingReservation, reservation);

                }
            }
            _reservations.Add(reservation);
        }
    }
}
